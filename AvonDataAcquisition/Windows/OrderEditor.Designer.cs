namespace AvonDataAcquisition
{
    partial class OrderEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.discountNumeric = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.clientStatusLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.countNumeric = new System.Windows.Forms.NumericUpDown();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.pageNumeric = new System.Windows.Forms.NumericUpDown();
            this.productStatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.Summary = new System.Windows.Forms.DataGridView();
            this.title1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Summary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент:";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.clientNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clientNameTextBox.Location = new System.Drawing.Point(65, 10);
            this.clientNameTextBox.MaxLength = 100;
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(124, 20);
            this.clientNameTextBox.TabIndex = 1;
            this.clientNameTextBox.TextChanged += new System.EventHandler(this.OnClientName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Скидка:";
            // 
            // discountNumeric
            // 
            this.discountNumeric.Location = new System.Drawing.Point(254, 11);
            this.discountNumeric.Name = "discountNumeric";
            this.discountNumeric.Size = new System.Drawing.Size(58, 20);
            this.discountNumeric.TabIndex = 2;
            this.discountNumeric.Enter += new System.EventHandler(this.OnNumeric_Focus);
            this.discountNumeric.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnDiscount_Select);
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
            this.id,
            this.code,
            this.page,
            this.price,
            this.count});
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 326);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnData_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnData_CellMouseClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnData_CellValueChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 40;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 40;
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.code.FillWeight = 50F;
            this.code.HeaderText = "Код";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // page
            // 
            this.page.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.page.FillWeight = 30F;
            this.page.HeaderText = "Страница";
            this.page.Name = "page";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.FillWeight = 30F;
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count.FillWeight = 30F;
            this.count.HeaderText = "Количество";
            this.count.Name = "count";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productCodeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productCodeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productCodeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.productCodeTextBox.Location = new System.Drawing.Point(12, 405);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(86, 20);
            this.productCodeTextBox.TabIndex = 5;
            this.productCodeTextBox.TextChanged += new System.EventHandler(this.OnProductCode_TextChanged);
            // 
            // clientStatusLabel
            // 
            this.clientStatusLabel.AutoSize = true;
            this.clientStatusLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.clientStatusLabel.Location = new System.Drawing.Point(312, 13);
            this.clientStatusLabel.Name = "clientStatusLabel";
            this.clientStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.clientStatusLabel.TabIndex = 6;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubmitButton.Location = new System.Drawing.Point(380, 403);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Ввод";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.OnSubmit_Click);
            // 
            // countNumeric
            // 
            this.countNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countNumeric.Location = new System.Drawing.Point(284, 405);
            this.countNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumeric.Name = "countNumeric";
            this.countNumeric.Size = new System.Drawing.Size(90, 20);
            this.countNumeric.TabIndex = 8;
            this.countNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumeric.Enter += new System.EventHandler(this.OnNumeric_Focus);
            this.countNumeric.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnNumeric_MouseClick);
            // 
            // priceNumeric
            // 
            this.priceNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.priceNumeric.Location = new System.Drawing.Point(196, 405);
            this.priceNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(82, 20);
            this.priceNumeric.TabIndex = 7;
            this.priceNumeric.ValueChanged += new System.EventHandler(this.OnNumeric_ValueChanged);
            this.priceNumeric.Enter += new System.EventHandler(this.OnNumeric_Focus);
            this.priceNumeric.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnNumeric_MouseClick);
            // 
            // pageNumeric
            // 
            this.pageNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageNumeric.Location = new System.Drawing.Point(104, 405);
            this.pageNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pageNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNumeric.Name = "pageNumeric";
            this.pageNumeric.Size = new System.Drawing.Size(86, 20);
            this.pageNumeric.TabIndex = 6;
            this.pageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNumeric.ValueChanged += new System.EventHandler(this.OnNumeric_ValueChanged);
            this.pageNumeric.Enter += new System.EventHandler(this.OnNumeric_Focus);
            this.pageNumeric.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnNumeric_MouseClick);
            // 
            // productStatusLabel
            // 
            this.productStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productStatusLabel.AutoSize = true;
            this.productStatusLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.productStatusLabel.Location = new System.Drawing.Point(9, 428);
            this.productStatusLabel.Name = "productStatusLabel";
            this.productStatusLabel.Size = new System.Drawing.Size(89, 13);
            this.productStatusLabel.TabIndex = 11;
            this.productStatusLabel.Text = "Товар не в базе";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Код";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Страница";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Количество";
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(353, 7);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(101, 23);
            this.FinishButton.TabIndex = 16;
            this.FinishButton.Text = "Закрыть заказ";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.OnFinish_Click);
            // 
            // Summary
            // 
            this.Summary.AllowUserToAddRows = false;
            this.Summary.AllowUserToDeleteRows = false;
            this.Summary.AllowUserToResizeRows = false;
            this.Summary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Summary.ColumnHeadersVisible = false;
            this.Summary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title1,
            this.value1,
            this.title2,
            this.value2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Summary.DefaultCellStyle = dataGridViewCellStyle2;
            this.Summary.Location = new System.Drawing.Point(12, 361);
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            this.Summary.RowHeadersVisible = false;
            this.Summary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Summary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Summary.Size = new System.Drawing.Size(444, 25);
            this.Summary.TabIndex = 17;
            // 
            // title1
            // 
            this.title1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.title1.FillWeight = 40F;
            this.title1.HeaderText = "";
            this.title1.Name = "title1";
            this.title1.ReadOnly = true;
            this.title1.Width = 5;
            // 
            // value1
            // 
            this.value1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value1.FillWeight = 60F;
            this.value1.HeaderText = "";
            this.value1.Name = "value1";
            this.value1.ReadOnly = true;
            // 
            // title2
            // 
            this.title2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.title2.HeaderText = "";
            this.title2.Name = "title2";
            this.title2.ReadOnly = true;
            this.title2.Width = 5;
            // 
            // value2
            // 
            this.value2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value2.FillWeight = 60F;
            this.value2.HeaderText = "";
            this.value2.Name = "value2";
            this.value2.ReadOnly = true;
            // 
            // OrderEditor
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productStatusLabel);
            this.Controls.Add(this.pageNumeric);
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.countNumeric);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.clientStatusLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.discountNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderEditor";
            this.Text = "Редактор заказа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnForm_Closed);
            this.Load += new System.EventHandler(this.OrderEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.discountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Summary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown discountNumeric;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label clientStatusLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.NumericUpDown countNumeric;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.NumericUpDown pageNumeric;
        private System.Windows.Forms.Label productStatusLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn page;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridView Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn title1;
        private System.Windows.Forms.DataGridViewTextBoxColumn value1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title2;
        private System.Windows.Forms.DataGridViewTextBoxColumn value2;
    }
}