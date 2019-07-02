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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBook.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBook.Location = new System.Drawing.Point(0, 165);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(715, 124);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBook_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qiyməti";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sayı";
            this.Column4.Name = "Column4";
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Location = new System.Drawing.Point(28, 46);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(57, 13);
            this.LblBookName.TabIndex = 1;
            this.LblBookName.Text = "Kitabın Adı";
            // 
            // TxtBookName
            // 
            this.TxtBookName.Location = new System.Drawing.Point(31, 71);
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(100, 20);
            this.TxtBookName.TabIndex = 2;
            // 
            // TxtBookPrice
            // 
            this.TxtBookPrice.Location = new System.Drawing.Point(152, 71);
            this.TxtBookPrice.Name = "TxtBookPrice";
            this.TxtBookPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtBookPrice.TabIndex = 4;
            // 
            // LblBookPrice
            // 
            this.LblBookPrice.AutoSize = true;
            this.LblBookPrice.Location = new System.Drawing.Point(149, 46);
            this.LblBookPrice.Name = "LblBookPrice";
            this.LblBookPrice.Size = new System.Drawing.Size(41, 13);
            this.LblBookPrice.TabIndex = 3;
            this.LblBookPrice.Text = "Qiyməti";
            // 
            // LblBookCount
            // 
            this.LblBookCount.AutoSize = true;
            this.LblBookCount.Location = new System.Drawing.Point(282, 46);
            this.LblBookCount.Name = "LblBookCount";
            this.LblBookCount.Size = new System.Drawing.Size(27, 13);
            this.LblBookCount.TabIndex = 5;
            this.LblBookCount.Text = "Sayı";
            // 
            // NmrCount
            // 
            this.NmrCount.Location = new System.Drawing.Point(285, 71);
            this.NmrCount.Name = "NmrCount";
            this.NmrCount.Size = new System.Drawing.Size(120, 20);
            this.NmrCount.TabIndex = 6;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.Color.Turquoise;
            this.BtnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddBook.Location = new System.Drawing.Point(428, 69);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(75, 23);
            this.BtnAddBook.TabIndex = 7;
            this.BtnAddBook.Text = "Əlavə et";
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // BtnBookUpdate
            // 
            this.BtnBookUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.BtnBookUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBookUpdate.Location = new System.Drawing.Point(428, 36);
            this.BtnBookUpdate.Name = "BtnBookUpdate";
            this.BtnBookUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnBookUpdate.TabIndex = 8;
            this.BtnBookUpdate.Text = "Yenilə";
            this.BtnBookUpdate.UseVisualStyleBackColor = false;
            this.BtnBookUpdate.Visible = false;
            this.BtnBookUpdate.Click += new System.EventHandler(this.BtnBookUpdate_Click);
            // 
            // BtnBookDelete
            // 
            this.BtnBookDelete.BackColor = System.Drawing.Color.Maroon;
            this.BtnBookDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBookDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBookDelete.Location = new System.Drawing.Point(428, 100);
            this.BtnBookDelete.Name = "BtnBookDelete";
            this.BtnBookDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnBookDelete.TabIndex = 9;
            this.BtnBookDelete.Text = "Sil";
            this.BtnBookDelete.UseVisualStyleBackColor = false;
            this.BtnBookDelete.Visible = false;
            this.BtnBookDelete.Click += new System.EventHandler(this.BtnBookDelete_Click);
            // 
            // TxtSerachBox
            // 
            this.TxtSerachBox.Location = new System.Drawing.Point(550, 69);
            this.TxtSerachBox.Name = "TxtSerachBox";
            this.TxtSerachBox.Size = new System.Drawing.Size(100, 20);
            this.TxtSerachBox.TabIndex = 10;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(550, 100);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(100, 23);
            this.btnSearchBook.TabIndex = 11;
            this.btnSearchBook.Text = "Axtar";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // BookPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 289);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.TxtSerachBox);
            this.Controls.Add(this.BtnBookDelete);
            this.Controls.Add(this.BtnBookUpdate);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.NmrCount);
            this.Controls.Add(this.LblBookCount);
            this.Controls.Add(this.TxtBookPrice);
            this.Controls.Add(this.LblBookPrice);
            this.Controls.Add(this.TxtBookName);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.dgvBook);
            this.Name = "BookPg";
            this.Text = "BookPg";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrCount)).EndInit();
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
    }
}