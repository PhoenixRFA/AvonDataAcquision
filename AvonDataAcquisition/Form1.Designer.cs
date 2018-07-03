namespace AvonDataAcquisition
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.войтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каталогиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.infoDataGrid = new System.Windows.Forms.DataGridView();
            this.pCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveAsCsvButton = new System.Windows.Forms.Button();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.редакторыToolStripMenuItem,
            this.добавитьЗаказToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.войтиToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // войтиToolStripMenuItem1
            // 
            this.войтиToolStripMenuItem1.Name = "войтиToolStripMenuItem1";
            this.войтиToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.войтиToolStripMenuItem1.Text = "Войти";
            this.войтиToolStripMenuItem1.Click += new System.EventHandler(this.OnDataBase_Login);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.OnExit_Click);
            // 
            // редакторыToolStripMenuItem
            // 
            this.редакторыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каталогиToolStripMenuItem,
            this.клиентыToolStripMenuItem1,
            this.товарToolStripMenuItem1});
            this.редакторыToolStripMenuItem.Name = "редакторыToolStripMenuItem";
            this.редакторыToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.редакторыToolStripMenuItem.Text = "Редакторы";
            // 
            // каталогиToolStripMenuItem
            // 
            this.каталогиToolStripMenuItem.Name = "каталогиToolStripMenuItem";
            this.каталогиToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.каталогиToolStripMenuItem.Text = "Каталоги";
            this.каталогиToolStripMenuItem.Click += new System.EventHandler(this.CatalogEditor_Open);
            // 
            // клиентыToolStripMenuItem1
            // 
            this.клиентыToolStripMenuItem1.Name = "клиентыToolStripMenuItem1";
            this.клиентыToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.клиентыToolStripMenuItem1.Text = "Клиенты";
            this.клиентыToolStripMenuItem1.Click += new System.EventHandler(this.ClientsWindow_Open);
            // 
            // товарToolStripMenuItem1
            // 
            this.товарToolStripMenuItem1.Name = "товарToolStripMenuItem1";
            this.товарToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.товарToolStripMenuItem1.Text = "Товар";
            this.товарToolStripMenuItem1.Click += new System.EventHandler(this.ProductEditor_Open);
            // 
            // добавитьЗаказToolStripMenuItem
            // 
            this.добавитьЗаказToolStripMenuItem.Name = "добавитьЗаказToolStripMenuItem";
            this.добавитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.добавитьЗаказToolStripMenuItem.Text = "Добавить заказ";
            this.добавитьЗаказToolStripMenuItem.Click += new System.EventHandler(this.OrderEditor_Open);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.client_name,
            this.discount,
            this.order,
            this.sum,
            this.sumDisc});
            this.dataGridView1.Location = new System.Drawing.Point(9, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(614, 402);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnData_CellMouseClick);
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AllowUserToDeleteRows = false;
            this.MainDataGridView.AllowUserToResizeRows = false;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cat_num,
            this.date});
            this.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.RowHeadersVisible = false;
            this.MainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGridView.Size = new System.Drawing.Size(227, 432);
            this.MainDataGridView.TabIndex = 16;
            this.MainDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnMainData_CellMouseClick);
            this.MainDataGridView.SelectionChanged += new System.EventHandler(this.OnMainData_SelectionChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // cat_num
            // 
            this.cat_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cat_num.HeaderText = "№ каталога";
            this.cat_num.Name = "cat_num";
            this.cat_num.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Обзор",
            "Общий"});
            this.comboBox1.Location = new System.Drawing.Point(57, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.OnComboBox_IndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Режим:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.page,
            this.price,
            this.quantity});
            this.dataGridView2.Location = new System.Drawing.Point(9, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(614, 402);
            this.dataGridView2.TabIndex = 19;
            // 
            // code
            // 
            this.code.HeaderText = "Код";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // page
            // 
            this.page.HeaderText = "Страница";
            this.page.Name = "page";
            this.page.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Количество";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainDataGridView);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.saveAsCsvButton);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.infoDataGrid);
            this.splitContainer1.Panel2MinSize = 450;
            this.splitContainer1.Size = new System.Drawing.Size(857, 432);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 20;
            this.splitContainer1.TabStop = false;
            // 
            // infoDataGrid
            // 
            this.infoDataGrid.AllowUserToAddRows = false;
            this.infoDataGrid.AllowUserToDeleteRows = false;
            this.infoDataGrid.AllowUserToResizeRows = false;
            this.infoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pCode,
            this.pPage,
            this.pPrice,
            this.pCount});
            this.infoDataGrid.Location = new System.Drawing.Point(9, 30);
            this.infoDataGrid.Name = "infoDataGrid";
            this.infoDataGrid.ReadOnly = true;
            this.infoDataGrid.RowHeadersVisible = false;
            this.infoDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.infoDataGrid.Size = new System.Drawing.Size(404, 150);
            this.infoDataGrid.TabIndex = 24;
            this.infoDataGrid.Visible = false;
            this.infoDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.infoDataGrid_MouseClick);
            // 
            // pCode
            // 
            this.pCode.HeaderText = "Код товара";
            this.pCode.Name = "pCode";
            this.pCode.ReadOnly = true;
            // 
            // pPage
            // 
            this.pPage.HeaderText = "Страница";
            this.pPage.Name = "pPage";
            this.pPage.ReadOnly = true;
            // 
            // pPrice
            // 
            this.pPrice.HeaderText = "Цена";
            this.pPrice.Name = "pPrice";
            this.pPrice.ReadOnly = true;
            // 
            // pCount
            // 
            this.pCount.HeaderText = "Кол-во";
            this.pCount.Name = "pCount";
            this.pCount.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "0/0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Общий заказ:";
            // 
            // saveAsCsvButton
            // 
            this.saveAsCsvButton.Location = new System.Drawing.Point(548, 3);
            this.saveAsCsvButton.Name = "saveAsCsvButton";
            this.saveAsCsvButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsCsvButton.TabIndex = 20;
            this.saveAsCsvButton.Text = "Сохранить";
            this.saveAsCsvButton.UseVisualStyleBackColor = true;
            this.saveAsCsvButton.Click += new System.EventHandler(this.OnSaveAsCsv_Click);
            // 
            // orderId
            // 
            this.orderId.HeaderText = "id";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Width = 40;
            // 
            // client_name
            // 
            this.client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.client_name.HeaderText = "Клиент";
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discount.HeaderText = "Скидка";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // order
            // 
            this.order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order.HeaderText = "Наименований";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // sumDisc
            // 
            this.sumDisc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumDisc.HeaderText = "Сумма (скидка)";
            this.sumDisc.Name = "sumDisc";
            this.sumDisc.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 471);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Avon DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаказToolStripMenuItem;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn page;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button saveAsCsvButton;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem войтиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редакторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каталогиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView infoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDisc;
    }
}

