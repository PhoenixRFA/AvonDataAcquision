using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LiteDB;

namespace AvonDataAcquisition
{
    public partial class ClientEditor : Form
    {
        //client deleting
        //3>delete only clients without orders

        ContextMenu ctx;
        Action parent_update;

        List<Client> clients;
        LiteCollection<Client> colClients;

        #region Init
        public ClientEditor()
        {
            InitializeComponent();
        }

        public ClientEditor(Action close_callback) : this()
        {
            parent_update = close_callback;
        }
        //+
        private void ClientEditor_Load(object sender, EventArgs e)
        {
#if !DEBUG
            dataGridView1.Columns[0].Visible = false;
#endif
            ctx = new ContextMenu();
            ctx.MenuItems.Add("Delete", OnClient_Delete);
            colClients = Prefs.DB.GetCollection<Client>(Prefs.ColClients);
            clients = new List<Client>();

            foreach (Client c in colClients.FindAll())
            {
                clients.Add(c);
                dataGridView1.Rows.Add(c.ClientId, c.ClientName, c.ClientDiscount);
            }
        }
        #endregion

        #region Events
        //+
        private void OnForm_Closed(object sender, FormClosedEventArgs e)
        {
            parent_update();
        }
        //+
        private void OnDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                ctx.Show(dataGridView1, dataGridView1.PointToClient(new Point(MousePosition.X, MousePosition.Y)));
            }
        }
        //+
        private void OnData_Changed(object s, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;

            if (e.ColumnIndex == 1) clients[e.RowIndex].ClientName = dataGridView1["name", e.RowIndex].Value.ToString();
            else
            {
                int oldVar = clients[e.RowIndex].ClientDiscount;

                if (int.TryParse(dataGridView1["discount", e.RowIndex].Value.ToString(), out int val))
                    clients[e.RowIndex].ClientDiscount = val;
                else
                {
                    MessageBox.Show("Ошибка ввода скидки, доступны только числа!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1["discount", e.RowIndex].Value = oldVar;
                    return;
                }
            }

            colClients.Update(clients[e.RowIndex]);
        }
        //+
        private void OnClient_Delete(object sender, EventArgs e)
        {
            List<OverallOrder> orders = new List<OverallOrder>();
            int i = dataGridView1.SelectedRows[0].Index;
            
            var colMain = Prefs.DB.GetCollection<OverallOrder>(Prefs.ColOverallOrders)
                .Include(x => x.ClientOrders).Include(x => x.ClientOrders[0].Client);

            foreach (var order in colMain.FindAll())
                foreach (var item in order.ClientOrders)
                    if (item.Client.ClientId == clients[i].ClientId) orders.Add(order);

            if (orders.Count == 0)
            {
                colClients.Delete((int)dataGridView1[0, i].Value);
                clients.RemoveAt(i);
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

                MessageBox.Show("Клиент есть в базе.\n" + str + "\nНевозможно удалить. Сначала удалите все заказы клиента!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
