namespace LibraryManagement.Forms
{
    partial class BookPg
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
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblBookName = new System.Windows.Forms.Label();
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.TxtBookPrice = new System.Windows.Forms.TextBox();
            this.LblBookPrice = new System.Windows.Forms.Label();
            this.LblBookCount = new System.Windows.Forms.Label();
            this.NmrCount = new System.Windows.Forms.NumericUpDown();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.BtnBookUpdate = new System.Windows.Forms.Button();
            this.BtnBookDelete = new System.Windows.Forms.Button();
            this.TxtSerachBox = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.groupbookpage = new System.Windows.Forms.GroupBox();
            this.lblSearchBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrCount)).BeginInit();
            this.groupbookpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToResizeColumns = false;
            this.dgvBook.AllowUserToResizeRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBook.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBook.Location = new System.Drawing.Point(0, 285);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.Size = new System.Drawing.Size(672, 138);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBook_RowHeaderMouseDoubleClick);
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
            this.Column2.HeaderText = "Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qiyməti";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sayı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Location = new System.Drawing.Point(3, 38);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(53, 13);
            this.LblBookName.TabIndex = 1;
            this.LblBookName.Text = "Kitab Adı*";
            // 
            // TxtBookName
            // 
            this.TxtBookName.Location = new System.Drawing.Point(6, 54);
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(100, 20);
            this.TxtBookName.TabIndex = 2;
            // 
            // TxtBookPrice
            // 
            this.TxtBookPrice.Location = new System.Drawing.Point(6, 114);
            this.TxtBookPrice.Name = "TxtBookPrice";
            this.TxtBookPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtBookPrice.TabIndex = 4;
            // 
            // LblBookPrice
            // 
            this.LblBookPrice.AutoSize = true;
            this.LblBookPrice.Location = new System.Drawing.Point(6, 98);
            this.LblBookPrice.Name = "LblBookPrice";
            this.LblBookPrice.Size = new System.Drawing.Size(45, 13);
            this.LblBookPrice.TabIndex = 3;
            this.LblBookPrice.Text = "Qiyməti*";
            // 
            // LblBookCount
            // 
            this.LblBookCount.AutoSize = true;
            this.LblBookCount.Location = new System.Drawing.Point(6, 156);
            this.LblBookCount.Name = "LblBookCount";
            this.LblBookCount.Size = new System.Drawing.Size(31, 13);
            this.LblBookCount.TabIndex = 5;
            this.LblBookCount.Text = "Sayı*";
            // 
            // NmrCount
            // 
            this.NmrCount.Location = new System.Drawing.Point(6, 172);
            this.NmrCount.Name = "NmrCount";
            this.NmrCount.Size = new System.Drawing.Size(97, 20);
            this.NmrCount.TabIndex = 6;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddBook.Location = new System.Drawing.Point(127, 209);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(100, 40);
            this.BtnAddBook.TabIndex = 7;
            this.BtnAddBook.Text = "Əlavə et";
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // BtnBookUpdate
            // 
            this.BtnBookUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnBookUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBookUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBookUpdate.Location = new System.Drawing.Point(127, 209);
            this.BtnBookUpdate.Name = "BtnBookUpdate";
            this.BtnBookUpdate.Size = new System.Drawing.Size(100, 40);
            this.BtnBookUpdate.TabIndex = 8;
            this.BtnBookUpdate.Text = "Yenilə";
            this.BtnBookUpdate.UseVisualStyleBackColor = false;
            this.BtnBookUpdate.Visible = false;
            this.BtnBookUpdate.Click += new System.EventHandler(this.BtnBookUpdate_Click);
            // 
            // BtnBookDelete
            // 
            this.BtnBookDelete.BackColor = System.Drawing.Color.Firebrick;
            this.BtnBookDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBookDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBookDelete.Location = new System.Drawing.Point(6, 209);
            this.BtnBookDelete.Name = "BtnBookDelete";
            this.BtnBookDelete.Size = new System.Drawing.Size(100, 40);
            this.BtnBookDelete.TabIndex = 9;
            this.BtnBookDelete.Text = "Sil";
            this.BtnBookDelete.UseVisualStyleBackColor = false;
            this.BtnBookDelete.Visible = false;
            this.BtnBookDelete.Click += new System.EventHandler(this.BtnBookDelete_Click);
            // 
            // TxtSerachBox
            // 
            this.TxtSerachBox.Location = new System.Drawing.Point(550, 28);
            this.TxtSerachBox.Name = "TxtSerachBox";
            this.TxtSerachBox.Size = new System.Drawing.Size(100, 20);
            this.TxtSerachBox.TabIndex = 10;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchBook.Location = new System.Drawing.Point(550, 59);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(100, 40);
            this.btnSearchBook.TabIndex = 11;
            this.btnSearchBook.Text = "Axtar";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // groupbookpage
            // 
            this.groupbookpage.Controls.Add(this.LblBookName);
            this.groupbookpage.Controls.Add(this.TxtBookName);
            this.groupbookpage.Controls.Add(this.LblBookPrice);
            this.groupbookpage.Controls.Add(this.BtnBookDelete);
            this.groupbookpage.Controls.Add(this.TxtBookPrice);
            this.groupbookpage.Controls.Add(this.BtnBookUpdate);
            this.groupbookpage.Controls.Add(this.LblBookCount);
            this.groupbookpage.Controls.Add(this.BtnAddBook);
            this.groupbookpage.Controls.Add(this.NmrCount);
            this.groupbookpage.Location = new System.Drawing.Point(12, 12);
            this.groupbookpage.Name = "groupbookpage";
            this.groupbookpage.Size = new System.Drawing.Size(257, 267);
            this.groupbookpage.TabIndex = 12;
            this.groupbookpage.TabStop = false;
            this.groupbookpage.Text = "İdarəetmə Paneli";
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Location = new System.Drawing.Point(495, 31);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(49, 13);
            this.lblSearchBook.TabIndex = 13;
            this.lblSearchBook.Text = "Kitab Adı";
            // 
            // BookPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 423);
            this.Controls.Add(this.lblSearchBook);
            this.Controls.Add(this.groupbookpage);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.TxtSerachBox);
            this.Controls.Add(this.dgvBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookPg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookPg";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrCount)).EndInit();
            this.groupbookpage.ResumeLayout(false);
            this.groupbookpage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.TextBox TxtBookName;
        private System.Windows.Forms.TextBox TxtBookPrice;
        private System.Windows.Forms.Label LblBookPrice;
        private System.Windows.Forms.Label LblBookCount;
        private System.Windows.Forms.NumericUpDown NmrCount;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Button BtnBookUpdate;
        private System.Windows.Forms.Button BtnBookDelete;
        private System.Windows.Forms.TextBox TxtSerachBox;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.GroupBox groupbookpage;
        private System.Windows.Forms.Label lblSearchBook;
    }
}