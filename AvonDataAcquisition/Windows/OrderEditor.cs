using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LiteDB;

namespace AvonDataAcquisition
{
    public enum OrderEditorMode { AddOrder, EditOrder }

    public partial class OrderEditor : Form
    {
        //
        bool newClient = false;
        bool newProduct = false;
        bool productUpdate = false;
        bool inputError = false;

        int sum;

        OrderEditorMode editorMode;
        Action parent_update;
        
        AutoCompleteStringCollection clientNamesSource;
        List<Client> clients;
        ContextMenu ctx;

        AutoCompleteStringCollection productCodesSource;
        LiteCollection<Product> productCol;
        List<Product> products;
        Product selectedProduct;

        OverallOrder mainOrder;
        ClientOrder selectedOrder;

        #region Init
        public OrderEditor()
        {
            InitializeComponent();

            clients = new List<Client>();
            products = new List<Product>();
            clientNamesSource = new AutoCompleteStringCollection();
            productCodesSource = new AutoCompleteStringCollection();
            Summary.Rows.Add("Итого: ", 0, "Итого (со скидкой):", 0);
        }

        public OrderEditor(OverallOrder mainOrder, ClientOrder selectedOrder, OrderEditorMode editorMode, Action action) : this()
        {
            this.mainOrder = mainOrder;
            this.selectedOrder = selectedOrder;
            this.editorMode = editorMode;
            parent_update = action;
        }
        //+
        private void OrderEditor_Load(object sender, EventArgs e)
        {
            ctx = new ContextMenu();
            ctx.MenuItems.Add("Delete", ItemDelete);

            LiteCollection<Client>  clientCol = Prefs.DB.GetCollection<Client>(Prefs.ColClients);
            foreach (Client c in clientCol.FindAll())
            {
                clients.Add(c);
                clientNamesSource.Add(c.ClientName);
            }
            clientNameTextBox.AutoCompleteCustomSource = clientNamesSource;

            productCol = Prefs.DB.GetCollection<Product>(Prefs.ColProducts);
            foreach (var p in productCol.FindAll())
            {
                products.Add(p);
                productCodesSource.Add(p.ProductCode);
            }
            productCodeTextBox.AutoCompleteCustomSource = productCodesSource;
            
            if(editorMode == OrderEditorMode.AddOrder)
            {
                selectedOrder = new ClientOrder();
                discountNumeric.ReadOnly = false;
                discountNumeric.Increment = 1;
                FinishButton.Text = "Сохранить заказ";
            }
            else
            {
                clientNameTextBox.ReadOnly = true;
                discountNumeric.ReadOnly = true;
                discountNumeric.Increment = 0;

                clientNameTextBox.Text = selectedOrder.Client.ClientName;
                discountNumeric.Value = selectedOrder.Client.ClientDiscount;

                sum = 0;
                foreach (var order in selectedOrder.OrderItems)
                {
                    dataGridView1.Rows.Add(order.OrderItemId, order.Product.ProductCode, order.Product.Page, order.Product.Price, order.Quantity);
                    sum += order.Product.Price * order.Quantity;
                }

                Summ();
            }
        }
        #endregion

        #region Functions
        //+
        private void clearInputs()
        {
            productCodeTextBox.Text = "";
            productStatusLabel.Text = "";
            pageNumeric.Value = 1;
            priceNumeric.Value = 0;
            countNumeric.Value = 1;
            newProduct = productUpdate = false;
        }

        private void Summ()
        {
            Summary[1, 0].Value = sum;
            Summary[3, 0].Value = sum * (1 - selectedOrder.Client.ClientDiscount / 100f);
        }
        //
        private void ItemDelete(object o, EventArgs e)
        {
            foreach(DataGridViewRow item in dataGridView1.SelectedRows)
            {
                selectedOrder.OrderItems.RemoveAt(item.Index);
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            var col = Prefs.DB.GetCollection<ClientOrder>(Prefs.ColClientOrders);
            col.Update(selectedOrder);

            sum = 0;
            foreach(var item in selectedOrder.OrderItems)
                sum += item.Product.Price * item.Quantity;

            Summ();
        }
        #endregion

        #region Events
        //+
        private void OnClientName_TextChanged(object sender, EventArgs e)
        {
            foreach(var i in clients)
            {
                if (clientNameTextBox.Text.Length == i.ClientName.Length && clientNameTextBox.Text == i.ClientName)
                {
                    discountNumeric.Value = i.ClientDiscount;
                    selectedOrder.Client = i;

                    clientStatusLabel.Text = "Ok";
                    clientStatusLabel.ForeColor = Color.Green;
                    discountNumeric.ReadOnly = true;
                    discountNumeric.Increment = 0;
                    newClient = false;
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(clientNameTextBox.Text))
            {
                clientStatusLabel.Text = "New";
                clientStatusLabel.ForeColor = Color.Goldenrod;
                discountNumeric.ReadOnly = false;
                discountNumeric.Increment = 1;
                newClient = true;
            }
            else clientStatusLabel.Text = "";
        }
        //+
        private void OnProductCode_TextChanged(object sender, EventArgs e)
        {
            inputError = false;

            if (productCodeTextBox.Text.Length != 5)
            {
                productStatusLabel.Text = "Код должен быть длиною в 5 символов";
                productStatusLabel.ForeColor = Color.Red;
                productCodeTextBox.ForeColor = Color.Red;
                inputError = true;
                return;
            }

            if (!string.IsNullOrEmpty(productCodeTextBox.Text))
            {
                productStatusLabel.Text = "Новый товар";
                productStatusLabel.ForeColor = Color.Goldenrod;
                productCodeTextBox.ForeColor = Color.Black;
                newProduct = true;
            }
            else productStatusLabel.Text = "";

            if (int.TryParse(productCodeTextBox.Text, out int a) == false)
            {
                productStatusLabel.Text = "Код должен состоять только из цифр";
                productStatusLabel.ForeColor = Color.Red;
                productCodeTextBox.ForeColor = Color.Red;
                inputError = true;
            }

            foreach (var i in products)
            {
                if (productCodeTextBox.Text == i.ProductCode)
                {
                    pageNumeric.Value = i.Page;
                    priceNumeric.Value = i.Price;
                    selectedProduct = i;

                    productStatusLabel.Text = "Товар в базе";
                    productStatusLabel.ForeColor = Color.Green;
                    productCodeTextBox.ForeColor = Color.Black;
                    newProduct = productUpdate = false;
                    return;
                }
            }
        }
        //+
        private void OnSubmit_Click(object sender, EventArgs e)
        {
            if (inputError)
            {
                MessageBox.Show("Ошибка ввода кода товара.\nПоддерживаются только коды из 5 цифр", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(productCodeTextBox.Text))
            {
                MessageBox.Show("Необходимо ввести код товара!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                productCodeTextBox.Focus();
                return;
            }

            if(newProduct || productUpdate)
            {
                if (productUpdate)
                {
                    selectedProduct.Page = (int)pageNumeric.Value;
                    selectedProduct.Price = (int)priceNumeric.Value;
                    productCol.Update(selectedProduct);
                }
                else
                {
                    Product prod = new Product { ProductCode = productCodeTextBox.Text, Page = (int)pageNumeric.Value, Price = (int)priceNumeric.Value };
                    productCol.Insert(prod);
                    selectedProduct = prod;
                }
                //////Debug
                //Console.WriteLine("newProduct:" + newProduct + " productUpdate:" + productUpdate);
            }

            OrderItem item = new OrderItem { Quantity = (int)countNumeric.Value, Product = selectedProduct};
            selectedOrder.OrderItems.Add(item);

            dataGridView1.Rows.Add(item.OrderItemId, item.Product.ProductCode, item.Product.Page, item.Product.Price, item.Quantity);
            clearInputs();

            sum = 0;
            foreach (var o in selectedOrder.OrderItems)
                sum += o.Product.Price * o.Quantity;

            Summ();
        }
        //+
        private void OnFinish_Click(object sender, EventArgs e)
        {
            if (editorMode == OrderEditorMode.AddOrder)
            {
                if (string.IsNullOrWhiteSpace(clientNameTextBox.Text))
                {
                    MessageBox.Show("Необходимо ввести имя клиента", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clientNameTextBox.Focus();
                    return;
                }

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Заказ пустой!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (newClient)
                {
                    var clientCol = Prefs.DB.GetCollection<Client>(Prefs.ColClients);

                    Client client = new Client { ClientName = clientNameTextBox.Text, ClientDiscount = (int)discountNumeric.Value };
                    clientCol.Insert(client);
                    selectedOrder.Client = client;
                }

                var mainCol = Prefs.DB.GetCollection<OverallOrder>(Prefs.ColOverallOrders);
                var col = Prefs.DB.GetCollection<ClientOrder>(Prefs.ColClientOrders);

                col.Insert(selectedOrder);
                mainOrder.ClientOrders.Add(selectedOrder);
                mainCol.Update(mainOrder);

                clientNameTextBox.Text = "";
                clearInputs();
                selectedOrder = new ClientOrder();
                dataGridView1.Rows.Clear();
                dataGridView1.Update();
                newClient = false;
            }
            else
            {
                var mainCol = Prefs.DB.GetCollection<OverallOrder>(Prefs.ColOverallOrders);
                var col = Prefs.DB.GetCollection<ClientOrder>(Prefs.ColClientOrders);

                col.Update(selectedOrder);
                Close();
            }
        }
        //+
        private void OnNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!newProduct) productUpdate = true;
        }
        //+
        private void OnNumeric_Focus(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, 10);
        }
        //+
        private void OnDiscount_Select(object sender, MouseEventArgs e)
        {
            if (editorMode == OrderEditorMode.EditOrder) MessageBox.Show("Скидка существующего клиента меняется в редакторе клиентов!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else (sender as NumericUpDown).Select(0, 10);
        }
        //+
        private void OnNumeric_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as NumericUpDown).Select(0, 10);
        }
        //+
        private void OnData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1) MessageBox.Show("Нельзя поменять код товара. Удалите строку и добавьте новый товар.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //
        private void OnData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if(dataGridView1.SelectedRows.Count == 0)
                    dataGridView1[e.ColumnIndex, e.RowIndex].Selected = true;

                ctx.Show(dataGridView1, dataGridView1.PointToClient(new Point(MousePosition.X, MousePosition.Y)));
            }
        }
        //+
        private void OnData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var prod = selectedOrder.OrderItems[e.RowIndex].Product;

            if (!int.TryParse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString(), out int val))
            {
                MessageBox.Show("Ошибка ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (e.ColumnIndex)
            {
                case 2:
                    prod.Page = val;
                    productCol.Update(prod);
                    break;
                case 3:
                    prod.Price = val;
                    productCol.Update(prod);
                    break;
                case 4:
                    var col = Prefs.DB.GetCollection<OrderItem>(Prefs.ColOrders);
                    var order = selectedOrder.OrderItems[e.RowIndex];
                    order.Quantity = val;
                    col.Update(order);
                    break;
            }
        }
        //+
        private void OnForm_Closed(object sender, FormClosedEventArgs e)
        {
            parent_update();
        }
        #endregion

    }
}
