using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LiteDB;

namespace AvonDataAcquisition
{
    public partial class ProductEditor : Form
    {
        Action parent_update;

        LiteCollection<Product> colProducts;
        List<Product> products;
        ContextMenu ctx;

        #region Init
        public ProductEditor()
        {
            InitializeComponent();
        }

        public ProductEditor(Action action) : this()
        {
            parent_update = action;
        }
        //+
        private void ProductEditor_Load(object sender, EventArgs e)
        {
            ctx = new ContextMenu();
            ctx.MenuItems.Add("Delete", OnProductDelete);

            products = new List<Product>();
            colProducts = Prefs.DB.GetCollection<Product>(Prefs.ColProducts);

            foreach (var c in colProducts.FindAll())
            {
                dataGridView1.Rows.Add(c.ProductCode, c.Page, c.Price);
                products.Add(c);
            }
        }
        #endregion

        #region Events
        //+
        private void OnProductDelete(object sender, EventArgs e)
        {
            var orders = new List<OverallOrder>();
            int i = dataGridView1.SelectedRows[0].Index;
            
            var colMain = Prefs.DB.GetCollection<OverallOrder>(Prefs.ColOverallOrders)
                .Include(x => x.ClientOrders).Include(x => x.ClientOrders[0].OrderItems).Include(x => x.ClientOrders[0].OrderItems[0].Product);

            foreach (var order in colMain.FindAll())
                foreach (var item in order.ClientOrders)
                    foreach (var prod in item.OrderItems)
                    if (prod.Product.ProductCode == products[i].ProductCode) orders.Add(order);

            if (orders.Count == 0)
            {
                colProducts.Delete(products[i].ProductCode);
                products.RemoveAt(i);
                dataGridView1.Rows.RemoveAt(i);
            }
            else
            {
                string str;

                if (orders.Count == 1) str = "Каталог: № " + orders[0].CatalogNum;
                else
                {
                    str = "Каталоги: №";
                    foreach (var item in orders)
                        str += " " + item.CatalogNum.ToString() + ",";
                    str = str.TrimEnd(',');
                }

                MessageBox.Show("Товар есть в базе.\n" + str + "\nНевозможно удалить. Сначала удалите все заказы с этим товаром!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //+
        private void OnData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;

            if (!int.TryParse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString(), out int val))
            {
                MessageBox.Show("Ошибка при вводе данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (e.ColumnIndex == 1) products[e.RowIndex].Page = val;
                else products[e.RowIndex].Price = val;
            }

            colProducts.Update(products[e.RowIndex]);
        }
        //+
        private void OnData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0) MessageBox.Show("Нельзя поменять код товара. Удалите строку и добавьте новый товар.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //+
        private void OnData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                ctx.Show(dataGridView1, dataGridView1.PointToClient(new Point(MousePosition.X, MousePosition.Y)));
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
