using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LiteDB;
//using HtmlAgilityPack;


namespace AvonDataAcquisition
{
    public partial class Form1 : Form
    {
        //
        ClientEditor clientEditorWin;
        ProductEditor prodEditorWin;
        OrderEditor orderEditorWin;
        ContextMenu ctxMenuMain, ctxMenu;

        LiteCollection<OverallOrder> colMain;
        OverallOrder mainOrder;
        
        //used in data2 fetch
        List<OrderItem> orderItems;

        int orderSum = 0;
        float discOrderSum = 0;

        #region Init
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if !DEBUG
            MainDataGridView.Columns[0].Visible = false;
            dataGridView1.Columns[0].Visible = false;
#endif
            ctxMenuMain = new ContextMenu();
            ctxMenu = new ContextMenu();
            orderItems = new List<OrderItem>();

            ctxMenuMain.MenuItems.Add("Delete", OnOverOrder_Delete);

            ctxMenu.MenuItems.Add("Edit", (object s, EventArgs ev) => OrderEditor_ModeSelect(OrderEditorMode.EditOrder, dataGridView1.SelectedRows[0].Index) );
            ctxMenu.MenuItems.Add("Delete", OnClientOrder_DeleteClick);
            comboBox1.SelectedIndex = 0;
        }
#endregion

#region Windows
        //+
        public void ClientsWindow_Open(object s, EventArgs e)
        {
            if (mainOrder != null)
            {
                if (clientEditorWin == null || clientEditorWin.IsDisposed)
                {
                    clientEditorWin = new ClientEditor(Data_Fetch);
                    clientEditorWin.Show();
                }
                else clientEditorWin.Focus();
            }
            else ShowLoginWarning();
        }
        //+
        private void CatalogEditor_Open(object sender, EventArgs e)
        {
            if (mainOrder != null) new CatalogEditor(Form_Update).ShowDialog();
            else ShowLoginWarning();
        }
        //+
        private void OrderEditor_Open(object sender, EventArgs e)
        {
            OrderEditor_ModeSelect(OrderEditorMode.AddOrder);
        }
        //+
        private void OrderEditor_ModeSelect(OrderEditorMode mode, int orderId = -1)
        {
            if (mainOrder != null)
            {
                if (orderEditorWin == null || orderEditorWin.IsDisposed)
                {
                    if (mode == OrderEditorMode.EditOrder)
                    {
                        orderEditorWin = new OrderEditor(mainOrder, mainOrder.ClientOrders[orderId], mode, Data_Fetch);
                    }
                    else orderEditorWin = new OrderEditor(mainOrder, null, mode, Data_Fetch);

                    orderEditorWin.Show();
                }
                else
                {
                    orderEditorWin.Focus();
                }
            }
            else ShowLoginWarning();
        }
        //+
        private void ProductEditor_Open(object sender, EventArgs e)
        {
            if (mainOrder != null)
            {
                if (prodEditorWin == null || prodEditorWin.IsDisposed)
                {
                    prodEditorWin = new ProductEditor(Data_Fetch);
                    prodEditorWin.Show();
                }
                else prodEditorWin.Focus();
            }
            else ShowLoginWarning();
        }
#endregion

#region Functions
        //+/?
        private void Form_Update()
        {
            OnDataBase_Login(null, null);
        }
        //+/?
        private void Data_Fetch()
        {
            dataGridView1.Rows.Clear();
            orderItems.Clear();
            int priceSum = 0;
            float discSum = 0;
            orderSum = 0;
            discOrderSum = 0;
            var font = new Font(dataGridView2.Font, FontStyle.Bold);

            foreach (var order in mainOrder.ClientOrders)
            {
                priceSum = 0;
                foreach (var item in order.OrderItems)
                {
                    int j = orderItems.FindIndex(x => x.Product.ProductCode.Equals(item.Product.ProductCode));

                    if (j == -1)
                        orderItems.Add(item);
                    else
                        orderItems[j].Quantity++;

                    priceSum += item.Product.Price * item.Quantity;
                }

                discSum = priceSum * (1 - order.Client.ClientDiscount / 100f);
                dataGridView1.Rows.Add(order.ClientOrderId, order.Client.ClientName, order.Client.ClientDiscount, order.OrderItems.Count, priceSum, discSum);

                orderSum += priceSum;
                discOrderSum += discSum;
            }
            dataGridView1.Rows.Add("", "", "", "ИТОГО:", orderSum, discOrderSum);
            dataGridView1.Rows[dataGridView1.RowCount - 1].DefaultCellStyle.Font = font;

            priceSum = 0;
            int count = 0;

            dataGridView2.Rows.Clear();
            foreach (var item in orderItems)
            {
                count += item.Quantity;
                priceSum += item.Product.Price * item.Quantity;
                dataGridView2.Rows.Add(item.Product.ProductCode, item.Product.Page, item.Product.Price, item.Quantity);
            }

            dataGridView2.Rows.Add("", "ИТОГО:", priceSum, count);
            dataGridView2.Rows[dataGridView2.Rows.Count - 1].DefaultCellStyle.Font = font;

            label3.Text = priceSum.ToString() + "/" + Prefs.MaxOrderSum.ToString();
            if (priceSum > Prefs.MaxOrderSum) label3.ForeColor = Color.Red;
            else label3.ForeColor = Color.Black;
        }
        //+
        private void ShowLoginWarning()
        {
            MessageBox.Show("Сначала войдите в систему!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FileToolStripMenuItem.ShowDropDown();
            FileToolStripMenuItem.DropDownItems[0].Select();
        }
#endregion

#region Events
        //TEST
        /*private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://my.avon.ru/poisk/rezultaty/?q=46164";

            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);
            var node = htmlDoc.DocumentNode.SelectSingleNode(xPathTextBox.Text);

            try
            {
                Console.WriteLine(htmlDoc.Text);
                Console.WriteLine("--------------------");
                Console.WriteLine("Node Name: " + node.Name + "\n" + HtmlEntity.DeEntitize(node.OuterHtml));
            }
            catch { }

            //using (var webClient = new WebClient())
            //{
            //    // Выполняем запрос по адресу и получаем ответ в виде строки
            //    //var response = webClient.DownloadString(url);
            //    //Console.WriteLine(response);
            //}
        }*/
        //+
        private void OnClientOrder_DeleteClick(object s, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить элемент?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow data = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                var col = Prefs.DB.GetCollection<ClientOrder>(Prefs.ColClientOrders);
                var mainCol = Prefs.DB.GetCollection<OverallOrder>(Prefs.ColOverallOrders);

                col.Delete((int)dataGridView1.SelectedRows[0].Cells[0].Value);
                mainOrder.ClientOrders.RemoveAt(dataGridView1.SelectedRows[0].Index);
                mainCol.Update(mainOrder);

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                Data_Fetch();
                //Debug
                //Console.WriteLine("Deleting item: " + data.Cells[0].Value + ";" + data.Cells[1].Value + ";");
            }
        }
        //+
        private void OnComboBox_IndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            saveAsCsvButton.Hide();

            switch (comboBox1.SelectedIndex)
            { 
                case 0:
                    dataGridView1.Show();
                    break;
                case 1:
                    dataGridView2.Show();
                    saveAsCsvButton.Show();
                    break;
            }
        }
        //+
        private void OnData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                ctxMenu.Show(dataGridView1, dataGridView1.PointToClient(new Point(MousePosition.X, MousePosition.Y)));
            }
            //DEBUG
            //Console.WriteLine("Button: " + e.Button.ToString() + " Cell[" + e.ColumnIndex + ";" + e.RowIndex + "]");
        }
        //+/- Cache data? LogIn
        public void OnDataBase_Login(object sender, EventArgs e)
        {
            colMain = Prefs.DB.GetCollection<OverallOrder>(Prefs.ColOverallOrders);

            MainDataGridView.Rows.Clear();

            foreach (OverallOrder order in colMain.FindAll())
                MainDataGridView.Rows.Add(order.OverallOrderId, order.CatalogNum, order.Date.ToShortDateString());
        }
        //+show context menu
        private void OnMainData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MainDataGridView.ClearSelection();
                MainDataGridView.Rows[e.RowIndex].Selected = true;
                ctxMenuMain.Show(dataGridView1, dataGridView1.PointToClient(new Point(MousePosition.X, MousePosition.Y)));
            }
        }
        //+
        private void OnMainData_SelectionChanged(object sender, EventArgs e)
        {
            if (MainDataGridView.SelectedRows.Count == 0) return;

            mainOrder = colMain
                .Include(x=>x.ClientOrders).Include(x=>x.ClientOrders[0].Client).Include(x=>x.ClientOrders[0].OrderItems[0].Product)
                .FindById((int)MainDataGridView.SelectedRows[0].Cells[0].Value);

            //Fetch data
            Data_Fetch();

            //TEsT
            //orderItems.Sort((x,y) => {
            //    if (x.Quantity > y.Quantity) return 1;
            //    else if (x.Quantity < y.Quantity) return -1;
            //    else return 0;
            //});
        }
        //+
        private void OnSaveAsCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Файл таблицы (*.csv)|*.csv|Текстовый файл (*.txt)|*.txt|Все файлы|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                var csv = new StringBuilder();
                csv.AppendLine("Код;Страница;Цена;Количество");

                foreach (DataGridViewRow r in dataGridView2.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                        csv.Append(c.Value + ";");

                    csv.AppendLine();
                }

                File.WriteAllText(save.FileName, csv.ToString(), Encoding.UTF8);
            }
        }
        //+
        private void OnExit_Click(object sender, EventArgs e)
        {
            Prefs.DB.Shrink();
            Close();
        }
        //DEBUG!!
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*infoDataGrid.Rows.Clear();

            foreach (var o in mainOrder.ClientOrders[e.RowIndex].OrderItems)
                infoDataGrid.Rows.Add(o.Product.ProductCode, o.Product.Page, o.Product.Price, o.Quantity);

            infoDataGrid.Location = dataGridView1.GetCellDisplayRectangle(0, e.RowIndex, false).Location;
            infoDataGrid.Show();*/
        }
        //DEBUG
        private void infoDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right) infoDataGrid.Hide();
        }

        //+
        private void OnOverOrder_Delete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить позицию?\nПосле удаления данные будет невозможно восстановить!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var colClients = Prefs.DB.GetCollection<ClientOrder>(Prefs.ColClientOrders);

                foreach (var item in mainOrder.ClientOrders)
                {
                    colClients.Delete(item.ClientOrderId);
                }

                colMain.Delete(mainOrder.OverallOrderId);
                
                Form_Update();
            }
        }
#endregion
    }
}
