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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBooksAbout = new System.Windows.Forms.Button();
            this.BtnCostumersAbout = new System.Windows.Forms.Button();
            this.BtnUsersAbout = new System.Windows.Forms.Button();
            this.BtnCreateOrder = new System.Windows.Forms.Button();
            this.BtnReturnBook = new System.Windows.Forms.Button();
            this.BtnTrackingAllOrders = new System.Windows.Forms.Button();
            this.BtnAccount = new System.Windows.Forms.Button();
            this.PnlNewOrders = new System.Windows.Forms.Panel();
            this.PctEmptyBasket = new System.Windows.Forms.PictureBox();
            this.PctFullBasket = new System.Windows.Forms.PictureBox();
            this.LblManat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPriceOrderLbl = new System.Windows.Forms.Label();
            this.DgvBookDashboard = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblPriceAllbooks = new System.Windows.Forms.Label();
            this.BtnSubmitOrders = new System.Windows.Forms.Button();
            this.BtnRemoveList = new System.Windows.Forms.Button();
            this.LblPriceOrder = new System.Windows.Forms.Label();
            this.LblDateTimeOrder = new System.Windows.Forms.Label();
            this.LblBookCount = new System.Windows.Forms.Label();
            this.LblBookOrder = new System.Windows.Forms.Label();
            this.BtnAddNewOrder = new System.Windows.Forms.Button();
            this.DateReturnDay = new System.Windows.Forms.DateTimePicker();
            this.NmrBookCount = new System.Windows.Forms.NumericUpDown();
            this.CmbBookOrder = new System.Windows.Forms.ComboBox();
            this.LblCostumer = new System.Windows.Forms.Label();
            this.CmbCostumerOrder = new System.Windows.Forms.ComboBox();
            this.DgvOrderReturn = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlReturnBook = new System.Windows.Forms.Panel();
            this.BtnRBSubmit = new System.Windows.Forms.Button();
            this.LblRBCount = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LblRBDay = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnRSearch = new System.Windows.Forms.Button();
            this.TxtRBCostumerPhoneNo = new System.Windows.Forms.TextBox();
            this.LblRCostumerPhone = new System.Windows.Forms.Label();
            this.LblRCostumerName = new System.Windows.Forms.Label();
            this.TxtRBCostumerName = new System.Windows.Forms.TextBox();
            this.PctExit = new System.Windows.Forms.PictureBox();
            this.PnlNewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctEmptyBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctFullBasket)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrBookCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderReturn)).BeginInit();
            this.PnlReturnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).BeginInit();
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
            // 
            // PnlNewOrders
            // 
            this.PnlNewOrders.Controls.Add(this.PctEmptyBasket);
            this.PnlNewOrders.Controls.Add(this.PnlReturnBook);
            this.PnlNewOrders.Controls.Add(this.PctFullBasket);
            this.PnlNewOrders.Controls.Add(this.LblManat);
            this.PnlNewOrders.Controls.Add(this.panel1);
            this.PnlNewOrders.Controls.Add(this.DgvBookDashboard);
            this.PnlNewOrders.Controls.Add(this.LblPriceAllbooks);
            this.PnlNewOrders.Controls.Add(this.BtnSubmitOrders);
            this.PnlNewOrders.Controls.Add(this.BtnRemoveList);
            this.PnlNewOrders.Controls.Add(this.LblPriceOrder);
            this.PnlNewOrders.Controls.Add(this.LblDateTimeOrder);
            this.PnlNewOrders.Controls.Add(this.LblBookCount);
            this.PnlNewOrders.Controls.Add(this.LblBookOrder);
            this.PnlNewOrders.Controls.Add(this.BtnAddNewOrder);
            this.PnlNewOrders.Controls.Add(this.DateReturnDay);
            this.PnlNewOrders.Controls.Add(this.NmrBookCount);
            this.PnlNewOrders.Controls.Add(this.CmbBookOrder);
            this.PnlNewOrders.Controls.Add(this.LblCostumer);
            this.PnlNewOrders.Controls.Add(this.CmbCostumerOrder);
            this.PnlNewOrders.Location = new System.Drawing.Point(172, 95);
            this.PnlNewOrders.Name = "PnlNewOrders";
            this.PnlNewOrders.Size = new System.Drawing.Size(761, 290);
            this.PnlNewOrders.TabIndex = 23;
            this.PnlNewOrders.Visible = false;
            // 
            // PctEmptyBasket
            // 
            this.PctEmptyBasket.Image = ((System.Drawing.Image)(resources.GetObject("PctEmptyBasket.Image")));
            this.PctEmptyBasket.Location = new System.Drawing.Point(495, 9);
            this.PctEmptyBasket.Name = "PctEmptyBasket";
            this.PctEmptyBasket.Size = new System.Drawing.Size(105, 97);
            this.PctEmptyBasket.TabIndex = 42;
            this.PctEmptyBasket.TabStop = false;
            // 
            // PctFullBasket
            // 
            this.PctFullBasket.Image = ((System.Drawing.Image)(resources.GetObject("PctFullBasket.Image")));
            this.PctFullBasket.Location = new System.Drawing.Point(495, 9);
            this.PctFullBasket.Name = "PctFullBasket";
            this.PctFullBasket.Size = new System.Drawing.Size(105, 97);
            this.PctFullBasket.TabIndex = 41;
            this.PctFullBasket.TabStop = false;
            this.PctFullBasket.Visible = false;
            // 
            // LblManat
            // 
            this.LblManat.AutoSize = true;
            this.LblManat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblManat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblManat.Location = new System.Drawing.Point(702, 47);
            this.LblManat.Name = "LblManat";
            this.LblManat.Size = new System.Drawing.Size(29, 25);
            this.LblManat.TabIndex = 40;
            this.LblManat.Text = "₼";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblPriceOrderLbl);
            this.panel1.Location = new System.Drawing.Point(305, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 27);
            this.panel1.TabIndex = 39;
            // 
            // LblPriceOrderLbl
            // 
            this.LblPriceOrderLbl.AutoSize = true;
            this.LblPriceOrderLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPriceOrderLbl.Location = new System.Drawing.Point(20, 6);
            this.LblPriceOrderLbl.Name = "LblPriceOrderLbl";
            this.LblPriceOrderLbl.Size = new System.Drawing.Size(13, 13);
            this.LblPriceOrderLbl.TabIndex = 38;
            this.LblPriceOrderLbl.Text = "0";
            // 
            // DgvBookDashboard
            // 
            this.DgvBookDashboard.AllowUserToResizeColumns = false;
            this.DgvBookDashboard.AllowUserToResizeRows = false;
            this.DgvBookDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookDashboard.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvBookDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvBookDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvBookDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvBookDashboard.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvBookDashboard.Location = new System.Drawing.Point(3, 112);
            this.DgvBookDashboard.Name = "DgvBookDashboard";
            this.DgvBookDashboard.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.DgvBookDashboard.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBookDashboard.Size = new System.Drawing.Size(728, 139);
            this.DgvBookDashboard.TabIndex = 37;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitablar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Say";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qaytarma Tarixi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qiyməti";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // LblPriceAllbooks
            // 
            this.LblPriceAllbooks.AutoSize = true;
            this.LblPriceAllbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPriceAllbooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPriceAllbooks.Location = new System.Drawing.Point(627, 47);
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
            this.BtnSubmitOrders.Location = new System.Drawing.Point(642, 11);
            this.BtnSubmitOrders.Name = "BtnSubmitOrders";
            this.BtnSubmitOrders.Size = new System.Drawing.Size(75, 31);
            this.BtnSubmitOrders.TabIndex = 35;
            this.BtnSubmitOrders.Text = "Təsdiqlə";
            this.BtnSubmitOrders.UseVisualStyleBackColor = false;
            this.BtnSubmitOrders.Visible = false;
            this.BtnSubmitOrders.Click += new System.EventHandler(this.BtnSubmitOrders_Click);
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
            this.BtnAddNewOrder.Enabled = false;
            this.BtnAddNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnAddNewOrder.Location = new System.Drawing.Point(305, 64);
            this.BtnAddNewOrder.Name = "BtnAddNewOrder";
            this.BtnAddNewOrder.Size = new System.Drawing.Size(71, 31);
            this.BtnAddNewOrder.TabIndex = 28;
            this.BtnAddNewOrder.Text = "Əlavə et";
            this.BtnAddNewOrder.UseVisualStyleBackColor = false;
            this.BtnAddNewOrder.Click += new System.EventHandler(this.BtnAddNewOrder_Click);
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
            // DgvOrderReturn
            // 
            this.DgvOrderReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrderReturn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvOrderReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column13,
            this.Column7,
            this.Column14,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.DgvOrderReturn.Location = new System.Drawing.Point(0, 172);
            this.DgvOrderReturn.Name = "DgvOrderReturn";
            this.DgvOrderReturn.Size = new System.Drawing.Size(758, 176);
            this.DgvOrderReturn.TabIndex = 33;
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
            // PnlReturnBook
            // 
            this.PnlReturnBook.Controls.Add(this.BtnRBSubmit);
            this.PnlReturnBook.Controls.Add(this.LblRBCount);
            this.PnlReturnBook.Controls.Add(this.numericUpDown1);
            this.PnlReturnBook.Controls.Add(this.LblRBDay);
            this.PnlReturnBook.Controls.Add(this.dateTimePicker1);
            this.PnlReturnBook.Controls.Add(this.BtnRSearch);
            this.PnlReturnBook.Controls.Add(this.TxtRBCostumerPhoneNo);
            this.PnlReturnBook.Controls.Add(this.LblRCostumerPhone);
            this.PnlReturnBook.Controls.Add(this.LblRCostumerName);
            this.PnlReturnBook.Controls.Add(this.TxtRBCostumerName);
            this.PnlReturnBook.Controls.Add(this.DgvOrderReturn);
            this.PnlReturnBook.Location = new System.Drawing.Point(34, 247);
            this.PnlReturnBook.Name = "PnlReturnBook";
            this.PnlReturnBook.Size = new System.Drawing.Size(761, 386);
            this.PnlReturnBook.TabIndex = 43;
            this.PnlReturnBook.Visible = false;
            // 
            // BtnRBSubmit
            // 
            this.BtnRBSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnRBSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRBSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnRBSubmit.Location = new System.Drawing.Point(607, 29);
            this.BtnRBSubmit.Name = "BtnRBSubmit";
            this.BtnRBSubmit.Size = new System.Drawing.Size(110, 42);
            this.BtnRBSubmit.TabIndex = 50;
            this.BtnRBSubmit.Text = "Qaytar";
            this.BtnRBSubmit.UseVisualStyleBackColor = false;
            // 
            // LblRBCount
            // 
            this.LblRBCount.AutoSize = true;
            this.LblRBCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRBCount.Location = new System.Drawing.Point(161, 73);
            this.LblRBCount.Name = "LblRBCount";
            this.LblRBCount.Size = new System.Drawing.Size(54, 13);
            this.LblRBCount.TabIndex = 49;
            this.LblRBCount.Text = "Kitab Sayı";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(160, 89);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 20);
            this.numericUpDown1.TabIndex = 48;
            // 
            // LblRBDay
            // 
            this.LblRBDay.AutoSize = true;
            this.LblRBDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRBDay.Location = new System.Drawing.Point(161, 21);
            this.LblRBDay.Name = "LblRBDay";
            this.LblRBDay.Size = new System.Drawing.Size(77, 13);
            this.LblRBDay.TabIndex = 47;
            this.LblRBDay.Text = "Qaytarılan Gün";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // BtnRSearch
            // 
            this.BtnRSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnRSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnRSearch.Location = new System.Drawing.Point(22, 124);
            this.BtnRSearch.Name = "BtnRSearch";
            this.BtnRSearch.Size = new System.Drawing.Size(110, 42);
            this.BtnRSearch.TabIndex = 45;
            this.BtnRSearch.Text = "Axtar";
            this.BtnRSearch.UseVisualStyleBackColor = false;
            this.BtnRSearch.Click += new System.EventHandler(this.BtnRSearch_Click);
            // 
            // TxtRBCostumerPhoneNo
            // 
            this.TxtRBCostumerPhoneNo.Location = new System.Drawing.Point(22, 89);
            this.TxtRBCostumerPhoneNo.Name = "TxtRBCostumerPhoneNo";
            this.TxtRBCostumerPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.TxtRBCostumerPhoneNo.TabIndex = 38;
            // 
            // LblRCostumerPhone
            // 
            this.LblRCostumerPhone.AutoSize = true;
            this.LblRCostumerPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRCostumerPhone.Location = new System.Drawing.Point(19, 73);
            this.LblRCostumerPhone.Name = "LblRCostumerPhone";
            this.LblRCostumerPhone.Size = new System.Drawing.Size(84, 13);
            this.LblRCostumerPhone.TabIndex = 36;
            this.LblRCostumerPhone.Text = "Telefon Nömrəsi";
            // 
            // LblRCostumerName
            // 
            this.LblRCostumerName.AutoSize = true;
            this.LblRCostumerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRCostumerName.Location = new System.Drawing.Point(22, 20);
            this.LblRCostumerName.Name = "LblRCostumerName";
            this.LblRCostumerName.Size = new System.Drawing.Size(41, 13);
            this.LblRCostumerName.TabIndex = 35;
            this.LblRCostumerName.Text = "Müştəri";
            // 
            // TxtRBCostumerName
            // 
            this.TxtRBCostumerName.Location = new System.Drawing.Point(22, 36);
            this.TxtRBCostumerName.Name = "TxtRBCostumerName";
            this.TxtRBCostumerName.Size = new System.Drawing.Size(100, 20);
            this.TxtRBCostumerName.TabIndex = 34;
            // 
            // PctExit
            // 
            this.PctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctExit.Image = ((System.Drawing.Image)(resources.GetObject("PctExit.Image")));
            this.PctExit.Location = new System.Drawing.Point(903, 12);
            this.PctExit.Name = "PctExit";
            this.PctExit.Size = new System.Drawing.Size(55, 54);
            this.PctExit.TabIndex = 44;
            this.PctExit.TabStop = false;
            this.PctExit.Click += new System.EventHandler(this.PctExit_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(970, 542);
            this.Controls.Add(this.PctExit);
            this.Controls.Add(this.PnlNewOrders);
            this.Controls.Add(this.BtnAccount);
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
            this.PnlNewOrders.ResumeLayout(false);
            this.PnlNewOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctEmptyBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctFullBasket)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrBookCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderReturn)).EndInit();
            this.PnlReturnBook.ResumeLayout(false);
            this.PnlReturnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBooksAbout;
        private System.Windows.Forms.Button BtnCostumersAbout;
        private System.Windows.Forms.Button BtnUsersAbout;
        private System.Windows.Forms.Button BtnCreateOrder;
        private System.Windows.Forms.Button BtnReturnBook;
        private System.Windows.Forms.Button BtnTrackingAllOrders;
        private System.Windows.Forms.Button BtnAccount;
        private System.Windows.Forms.Panel PnlNewOrders;
        private System.Windows.Forms.Label LblPriceOrder;
        private System.Windows.Forms.Label LblDateTimeOrder;
        private System.Windows.Forms.Label LblBookCount;
        private System.Windows.Forms.Label LblBookOrder;
        private System.Windows.Forms.Button BtnAddNewOrder;
        private System.Windows.Forms.DateTimePicker DateReturnDay;
        private System.Windows.Forms.NumericUpDown NmrBookCount;
        private System.Windows.Forms.ComboBox CmbBookOrder;
        private System.Windows.Forms.Label LblCostumer;
        private System.Windows.Forms.ComboBox CmbCostumerOrder;
        private System.Windows.Forms.Button BtnRemoveList;
        private System.Windows.Forms.DataGridView DgvOrderReturn;
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
        private System.Windows.Forms.DataGridView DgvBookDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label LblPriceOrderLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblManat;
        private System.Windows.Forms.PictureBox PctEmptyBasket;
        private System.Windows.Forms.PictureBox PctFullBasket;
        private System.Windows.Forms.Panel PnlReturnBook;
        private System.Windows.Forms.PictureBox PctExit;
        private System.Windows.Forms.TextBox TxtRBCostumerPhoneNo;
        private System.Windows.Forms.Label LblRCostumerPhone;
        private System.Windows.Forms.Label LblRCostumerName;
        private System.Windows.Forms.TextBox TxtRBCostumerName;
        private System.Windows.Forms.Button BtnRSearch;
        private System.Windows.Forms.Label LblRBCount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label LblRBDay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnRBSubmit;
    }
}