namespace LibraryManagement.Forms
{
    partial class DashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBooksAbout = new System.Windows.Forms.Button();
            this.BtnCostumersAbout = new System.Windows.Forms.Button();
            this.BtnUsersAbout = new System.Windows.Forms.Button();
            this.BtnCreateOrder = new System.Windows.Forms.Button();
            this.BtnReturnBook = new System.Windows.Forms.Button();
            this.BtnTrackingAllOrders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAccount = new System.Windows.Forms.Button();
            this.PnlNewOrders = new System.Windows.Forms.Panel();
            this.LblPriceAllbooks = new System.Windows.Forms.Label();
            this.BtnSubmitOrders = new System.Windows.Forms.Button();
            this.BtnRemoveList = new System.Windows.Forms.Button();
            this.LblPriceOrder = new System.Windows.Forms.Label();
            this.LblDateTimeOrder = new System.Windows.Forms.Label();
            this.LblBookCount = new System.Windows.Forms.Label();
            this.LblBookOrder = new System.Windows.Forms.Label();
            this.BtnAddNewOrder = new System.Windows.Forms.Button();
            this.TxtPriceOrder = new System.Windows.Forms.TextBox();
            this.DateReturnDay = new System.Windows.Forms.DateTimePicker();
            this.NmrBookCount = new System.Windows.Forms.NumericUpDown();
            this.CmbBookOrder = new System.Windows.Forms.ComboBox();
            this.LblCostumer = new System.Windows.Forms.Label();
            this.CmbCostumerOrder = new System.Windows.Forms.ComboBox();
            this.DgvBookDashboard = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvOrderItems = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlNewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrBookCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBooksAbout
            // 
            this.BtnBooksAbout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnBooksAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBooksAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnBooksAbout.Location = new System.Drawing.Point(172, 47);
            this.BtnBooksAbout.Name = "BtnBooksAbout";
            this.BtnBooksAbout.Size = new System.Drawing.Size(107, 42);
            this.BtnBooksAbout.TabIndex = 0;
            this.BtnBooksAbout.Text = "Kitablar";
            this.BtnBooksAbout.UseVisualStyleBackColor = false;
            this.BtnBooksAbout.Click += new System.EventHandler(this.BtnBooksAbout_Click);
            this.BtnBooksAbout.MouseEnter += new System.EventHandler(this.BtnBooksAbout_MouseEnter);
            this.BtnBooksAbout.MouseLeave += new System.EventHandler(this.BtnBooksAbout_MouseLeave);
            // 
            // BtnCostumersAbout
            // 
            this.BtnCostumersAbout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCostumersAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCostumersAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCostumersAbout.Location = new System.Drawing.Point(336, 47);
            this.BtnCostumersAbout.Name = "BtnCostumersAbout";
            this.BtnCostumersAbout.Size = new System.Drawing.Size(106, 42);
            this.BtnCostumersAbout.TabIndex = 1;
            this.BtnCostumersAbout.Text = "Müştərilər";
            this.BtnCostumersAbout.UseVisualStyleBackColor = false;
            this.BtnCostumersAbout.Click += new System.EventHandler(this.BtnCostumersAbout_Click);
            this.BtnCostumersAbout.MouseEnter += new System.EventHandler(this.BtnCostumersAbout_MouseEnter);
            this.BtnCostumersAbout.MouseLeave += new System.EventHandler(this.BtnCostumersAbout_MouseLeave);
            // 
            // BtnUsersAbout
            // 
            this.BtnUsersAbout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUsersAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsersAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnUsersAbout.Location = new System.Drawing.Point(648, 47);
            this.BtnUsersAbout.Name = "BtnUsersAbout";
            this.BtnUsersAbout.Size = new System.Drawing.Size(105, 42);
            this.BtnUsersAbout.TabIndex = 2;
            this.BtnUsersAbout.Text = "İstifadəçilər";
            this.BtnUsersAbout.UseVisualStyleBackColor = false;
            this.BtnUsersAbout.Click += new System.EventHandler(this.BtnUsersAbout_Click);
            this.BtnUsersAbout.MouseEnter += new System.EventHandler(this.BtnUsersAbout_MouseEnter);
            this.BtnUsersAbout.MouseLeave += new System.EventHandler(this.BtnUsersAbout_MouseLeave);
            // 
            // BtnCreateOrder
            // 
            this.BtnCreateOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCreateOrder.Location = new System.Drawing.Point(21, 95);
            this.BtnCreateOrder.Name = "BtnCreateOrder";
            this.BtnCreateOrder.Size = new System.Drawing.Size(110, 42);
            this.BtnCreateOrder.TabIndex = 4;
            this.BtnCreateOrder.Text = "Sifariş Yarat";
            this.BtnCreateOrder.UseVisualStyleBackColor = false;
            this.BtnCreateOrder.Click += new System.EventHandler(this.BtnCreateOrder_Click);
            this.BtnCreateOrder.MouseEnter += new System.EventHandler(this.BtnCreateOrder_MouseEnter);
            this.BtnCreateOrder.MouseLeave += new System.EventHandler(this.BtnCreateOrder_MouseLeave);
            // 
            // BtnReturnBook
            // 
            this.BtnReturnBook.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnReturnBook.Location = new System.Drawing.Point(21, 161);
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Size = new System.Drawing.Size(110, 42);
            this.BtnReturnBook.TabIndex = 5;
            this.BtnReturnBook.Text = "Kitab Qaytar";
            this.BtnReturnBook.UseVisualStyleBackColor = false;
            this.BtnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            this.BtnReturnBook.MouseEnter += new System.EventHandler(this.BtnReturnBook_MouseEnter);
            this.BtnReturnBook.MouseLeave += new System.EventHandler(this.BtnReturnBook_MouseLeave);
            // 
            // BtnTrackingAllOrders
            // 
            this.BtnTrackingAllOrders.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnTrackingAllOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTrackingAllOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnTrackingAllOrders.Location = new System.Drawing.Point(21, 225);
            this.BtnTrackingAllOrders.Name = "BtnTrackingAllOrders";
            this.BtnTrackingAllOrders.Size = new System.Drawing.Size(110, 42);
            this.BtnTrackingAllOrders.TabIndex = 6;
            this.BtnTrackingAllOrders.Text = "Izleme";
            this.BtnTrackingAllOrders.UseVisualStyleBackColor = false;
            this.BtnTrackingAllOrders.Click += new System.EventHandler(this.BtnTrackingAllOrders_Click);
            this.BtnTrackingAllOrders.MouseEnter += new System.EventHandler(this.BtnTrackingAllOrders_MouseEnter);
            this.BtnTrackingAllOrders.MouseLeave += new System.EventHandler(this.BtnTrackingAllOrders_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(777, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAccount
            // 
            this.BtnAccount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnAccount.Location = new System.Drawing.Point(500, 47);
            this.BtnAccount.Name = "BtnAccount";
            this.BtnAccount.Size = new System.Drawing.Size(105, 42);
            this.BtnAccount.TabIndex = 22;
            this.BtnAccount.Text = "Account";
            this.BtnAccount.UseVisualStyleBackColor = false;
            this.BtnAccount.MouseEnter += new System.EventHandler(this.BtnAccount_MouseEnter);
            this.BtnAccount.MouseLeave += new System.EventHandler(this.BtnAccount_MouseLeave);
            // 
            // PnlNewOrders
            // 
            this.PnlNewOrders.Controls.Add(this.LblPriceAllbooks);
            this.PnlNewOrders.Controls.Add(this.BtnSubmitOrders);
            this.PnlNewOrders.Controls.Add(this.BtnRemoveList);
            this.PnlNewOrders.Controls.Add(this.LblPriceOrder);
            this.PnlNewOrders.Controls.Add(this.LblDateTimeOrder);
            this.PnlNewOrders.Controls.Add(this.LblBookCount);
            this.PnlNewOrders.Controls.Add(this.LblBookOrder);
            this.PnlNewOrders.Controls.Add(this.BtnAddNewOrder);
            this.PnlNewOrders.Controls.Add(this.TxtPriceOrder);
            this.PnlNewOrders.Controls.Add(this.DateReturnDay);
            this.PnlNewOrders.Controls.Add(this.NmrBookCount);
            this.PnlNewOrders.Controls.Add(this.CmbBookOrder);
            this.PnlNewOrders.Controls.Add(this.LblCostumer);
            this.PnlNewOrders.Controls.Add(this.CmbCostumerOrder);
            this.PnlNewOrders.Controls.Add(this.DgvBookDashboard);
            this.PnlNewOrders.Location = new System.Drawing.Point(172, 95);
            this.PnlNewOrders.Name = "PnlNewOrders";
            this.PnlNewOrders.Size = new System.Drawing.Size(626, 408);
            this.PnlNewOrders.TabIndex = 23;
            this.PnlNewOrders.Visible = false;
            // 
            // LblPriceAllbooks
            // 
            this.LblPriceAllbooks.AutoSize = true;
            this.LblPriceAllbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPriceAllbooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPriceAllbooks.Location = new System.Drawing.Point(568, 56);
            this.LblPriceAllbooks.Name = "LblPriceAllbooks";
            this.LblPriceAllbooks.Size = new System.Drawing.Size(25, 25);
            this.LblPriceAllbooks.TabIndex = 36;
            this.LblPriceAllbooks.Text = "0";
            // 
            // BtnSubmitOrders
            // 
            this.BtnSubmitOrders.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnSubmitOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmitOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnSubmitOrders.Location = new System.Drawing.Point(548, 3);
            this.BtnSubmitOrders.Name = "BtnSubmitOrders";
            this.BtnSubmitOrders.Size = new System.Drawing.Size(75, 31);
            this.BtnSubmitOrders.TabIndex = 35;
            this.BtnSubmitOrders.Text = "Qəbul et";
            this.BtnSubmitOrders.UseVisualStyleBackColor = false;
            // 
            // BtnRemoveList
            // 
            this.BtnRemoveList.BackColor = System.Drawing.Color.Firebrick;
            this.BtnRemoveList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnRemoveList.Location = new System.Drawing.Point(392, 64);
            this.BtnRemoveList.Name = "BtnRemoveList";
            this.BtnRemoveList.Size = new System.Drawing.Size(71, 31);
            this.BtnRemoveList.TabIndex = 34;
            this.BtnRemoveList.Text = "Sil";
            this.BtnRemoveList.UseVisualStyleBackColor = false;
            this.BtnRemoveList.Visible = false;
            this.BtnRemoveList.Click += new System.EventHandler(this.BtnRemoveList_Click);
            // 
            // LblPriceOrder
            // 
            this.LblPriceOrder.AutoSize = true;
            this.LblPriceOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPriceOrder.Location = new System.Drawing.Point(312, 7);
            this.LblPriceOrder.Name = "LblPriceOrder";
            this.LblPriceOrder.Size = new System.Drawing.Size(39, 13);
            this.LblPriceOrder.TabIndex = 32;
            this.LblPriceOrder.Text = "Qiymət";
            // 
            // LblDateTimeOrder
            // 
            this.LblDateTimeOrder.AutoSize = true;
            this.LblDateTimeOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDateTimeOrder.Location = new System.Drawing.Point(169, 7);
            this.LblDateTimeOrder.Name = "LblDateTimeOrder";
            this.LblDateTimeOrder.Size = new System.Drawing.Size(30, 13);
            this.LblDateTimeOrder.TabIndex = 31;
            this.LblDateTimeOrder.Text = "Tarix";
            // 
            // LblBookCount
            // 
            this.LblBookCount.AutoSize = true;
            this.LblBookCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblBookCount.Location = new System.Drawing.Point(169, 56);
            this.LblBookCount.Name = "LblBookCount";
            this.LblBookCount.Size = new System.Drawing.Size(25, 13);
            this.LblBookCount.TabIndex = 30;
            this.LblBookCount.Text = "Say";
            // 
            // LblBookOrder
            // 
            this.LblBookOrder.AutoSize = true;
            this.LblBookOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblBookOrder.Location = new System.Drawing.Point(22, 56);
            this.LblBookOrder.Name = "LblBookOrder";
            this.LblBookOrder.Size = new System.Drawing.Size(31, 13);
            this.LblBookOrder.TabIndex = 29;
            this.LblBookOrder.Text = "Kitab";
            // 
            // BtnAddNewOrder
            // 
            this.BtnAddNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnAddNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnAddNewOrder.Location = new System.Drawing.Point(315, 64);
            this.BtnAddNewOrder.Name = "BtnAddNewOrder";
            this.BtnAddNewOrder.Size = new System.Drawing.Size(71, 31);
            this.BtnAddNewOrder.TabIndex = 28;
            this.BtnAddNewOrder.Text = "Əlavə et";
            this.BtnAddNewOrder.UseVisualStyleBackColor = false;
            this.BtnAddNewOrder.Click += new System.EventHandler(this.BtnAddNewOrder_Click);
            // 
            // TxtPriceOrder
            // 
            this.TxtPriceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtPriceOrder.Enabled = false;
            this.TxtPriceOrder.Location = new System.Drawing.Point(315, 26);
            this.TxtPriceOrder.Name = "TxtPriceOrder";
            this.TxtPriceOrder.Size = new System.Drawing.Size(100, 20);
            this.TxtPriceOrder.TabIndex = 27;
            // 
            // DateReturnDay
            // 
            this.DateReturnDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateReturnDay.Enabled = false;
            this.DateReturnDay.Location = new System.Drawing.Point(171, 26);
            this.DateReturnDay.Name = "DateReturnDay";
            this.DateReturnDay.Size = new System.Drawing.Size(106, 20);
            this.DateReturnDay.TabIndex = 26;
            this.DateReturnDay.ValueChanged += new System.EventHandler(this.DateReturnDay_ValueChanged);
            // 
            // NmrBookCount
            // 
            this.NmrBookCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NmrBookCount.Enabled = false;
            this.NmrBookCount.Location = new System.Drawing.Point(172, 75);
            this.NmrBookCount.Name = "NmrBookCount";
            this.NmrBookCount.Size = new System.Drawing.Size(105, 20);
            this.NmrBookCount.TabIndex = 25;
            this.NmrBookCount.ValueChanged += new System.EventHandler(this.NmrBookCount_ValueChanged);
            // 
            // CmbBookOrder
            // 
            this.CmbBookOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBookOrder.Enabled = false;
            this.CmbBookOrder.FormattingEnabled = true;
            this.CmbBookOrder.Location = new System.Drawing.Point(22, 75);
            this.CmbBookOrder.Name = "CmbBookOrder";
            this.CmbBookOrder.Size = new System.Drawing.Size(121, 21);
            this.CmbBookOrder.TabIndex = 24;
            this.CmbBookOrder.SelectedIndexChanged += new System.EventHandler(this.CmbBookOrder_SelectedIndexChanged);
            // 
            // LblCostumer
            // 
            this.LblCostumer.AutoSize = true;
            this.LblCostumer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCostumer.Location = new System.Drawing.Point(22, 7);
            this.LblCostumer.Name = "LblCostumer";
            this.LblCostumer.Size = new System.Drawing.Size(41, 13);
            this.LblCostumer.TabIndex = 23;
            this.LblCostumer.Text = "Müştəri";
            // 
            // CmbCostumerOrder
            // 
            this.CmbCostumerOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbCostumerOrder.FormattingEnabled = true;
            this.CmbCostumerOrder.Location = new System.Drawing.Point(22, 26);
            this.CmbCostumerOrder.Name = "CmbCostumerOrder";
            this.CmbCostumerOrder.Size = new System.Drawing.Size(121, 21);
            this.CmbCostumerOrder.TabIndex = 22;
            this.CmbCostumerOrder.SelectedIndexChanged += new System.EventHandler(this.CmbCostumerOrder_SelectedIndexChanged);
            // 
            // DgvBookDashboard
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.DgvBookDashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvBookDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookDashboard.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvBookDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvBookDashboard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvBookDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvBookDashboard.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvBookDashboard.Location = new System.Drawing.Point(0, 108);
            this.DgvBookDashboard.Name = "DgvBookDashboard";
            this.DgvBookDashboard.Size = new System.Drawing.Size(626, 140);
            this.DgvBookDashboard.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitablar";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sayı";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qaytarma Tarixi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qiyməti";
            this.Column5.Name = "Column5";
            // 
            // DgvOrderItems
            // 
            this.DgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrderItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column13,
            this.Column7,
            this.Column14,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.DgvOrderItems.Location = new System.Drawing.Point(21, 400);
            this.DgvOrderItems.Name = "DgvOrderItems";
            this.DgvOrderItems.Size = new System.Drawing.Size(34, 43);
            this.DgvOrderItems.TabIndex = 33;
            this.DgvOrderItems.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "CostumerId";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Müştəri";
            this.Column7.Name = "Column7";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "BookId";
            this.Column14.Name = "Column14";
            this.Column14.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Kitab";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Say";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Sifariş Vaxtı";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Qaytarma Vaxtı";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Qiymət";
            this.Column12.Name = "Column12";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(837, 536);
            this.Controls.Add(this.PnlNewOrders);
            this.Controls.Add(this.BtnAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DgvOrderItems);
            this.Controls.Add(this.BtnTrackingAllOrders);
            this.Controls.Add(this.BtnReturnBook);
            this.Controls.Add(this.BtnCreateOrder);
            this.Controls.Add(this.BtnUsersAbout);
            this.Controls.Add(this.BtnCostumersAbout);
            this.Controls.Add(this.BtnBooksAbout);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlNewOrders.ResumeLayout(false);
            this.PnlNewOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrBookCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBooksAbout;
        private System.Windows.Forms.Button BtnCostumersAbout;
        private System.Windows.Forms.Button BtnUsersAbout;
        private System.Windows.Forms.Button BtnCreateOrder;
        private System.Windows.Forms.Button BtnReturnBook;
        private System.Windows.Forms.Button BtnTrackingAllOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAccount;
        private System.Windows.Forms.Panel PnlNewOrders;
        private System.Windows.Forms.Label LblPriceOrder;
        private System.Windows.Forms.Label LblDateTimeOrder;
        private System.Windows.Forms.Label LblBookCount;
        private System.Windows.Forms.Label LblBookOrder;
        private System.Windows.Forms.Button BtnAddNewOrder;
        private System.Windows.Forms.TextBox TxtPriceOrder;
        private System.Windows.Forms.DateTimePicker DateReturnDay;
        private System.Windows.Forms.NumericUpDown NmrBookCount;
        private System.Windows.Forms.ComboBox CmbBookOrder;
        private System.Windows.Forms.Label LblCostumer;
        private System.Windows.Forms.ComboBox CmbCostumerOrder;
        private System.Windows.Forms.DataGridView DgvBookDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button BtnRemoveList;
        private System.Windows.Forms.DataGridView DgvOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button BtnSubmitOrders;
        private System.Windows.Forms.Label LblPriceAllbooks;
    }
}