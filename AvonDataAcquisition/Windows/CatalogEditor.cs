using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiteDB;

namespace AvonDataAcquisition
{
    public partial class CatalogEditor : Form
    {
        Action parent_update;
        LiteCollection<OverallOrder> colOverOrder;
        List<OverallOrder> overallOrders;

        #region Init
        public CatalogEditor()
        {
            InitializeComponent();
        }

        public CatalogEditor(Action action) : this()
        {
            parent_update = action;
        }
        //+
        private void CatalogEditor_Load(object sender, EventArgs e)
        {
            overallOrders = new List<OverallOrder>();
            dateTimePicker1.Value = DateTime.Now;

            colOverOrder = Prefs.DB.GetCollection<OverallOrder>(Prefs.ColOverallOrders).Include(x=>x.ClientOrders);

            foreach(var o in colOverOrder.FindAll())
            {
                dataGridView1.Rows.Add(o.OverallOrderId, o.CatalogNum, o.Date.ToShortDateString());
                overallOrders.Add(o);
            }
        }
        #endregion

        #region Event
        //+
        private void OnDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                monthCalendar1.SetDate(overallOrders[e.RowIndex].Date);
                monthCalendar1.Visible = true;
                monthCalendar1.Focus();
            }
        }
        //+
        private void OnDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;

            int oldVar = overallOrders[e.RowIndex].CatalogNum;

            if (e.ColumnIndex == 1 & !int.TryParse(dataGridView1[1, e.RowIndex].Value.ToString(), out int num))
            {
                MessageBox.Show("Ошибка ввода номера каталога, доступны только числа!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = oldVar;
                return;
            }
            else overallOrders[e.RowIndex].CatalogNum = num;

            colOverOrder.Update(overallOrders[e.RowIndex]);
        }
        //+
        private void OnDate_Selected(object sender, DateRangeEventArgs e)
        {
            overallOrders[dataGridView1.SelectedRows[0].Index].Date = monthCalendar1.SelectionStart;
            dataGridView1[2, dataGridView1.SelectedRows[0].Index].Value = monthCalendar1.SelectionStart.ToShortDateString();
            dataGridView1.Update();
            monthCalendar1.Visible = false;
        }
        //+
        private void OnForm_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }
        //+
        private void OnForm_Closed(object sender, FormClosedEventArgs e)
        {
            parent_update();
        }
        //+
        private void OnSubmit_Click(object sender, EventArgs e)
        { 
            OverallOrder order = new OverallOrder { CatalogNum = (int)catNumberNumeric.Value, Date = dateTimePicker1.Value };

            colOverOrder.Insert(order);
            overallOrders.Add(order);
            dataGridView1.Rows.Add(order.OverallOrderId, order.CatalogNum, order.Date.ToShortDateString());
        }
        #endregion
    }
}
