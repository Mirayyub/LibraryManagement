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
            this.BtnBooksAbout = new System.Windows.Forms.Button();
            this.BtnCostumersAbout = new System.Windows.Forms.Button();
            this.BtnUsersAbout = new System.Windows.Forms.Button();
            this.DgvDashBoard = new System.Windows.Forms.DataGridView();
            this.BtnCreateOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDashBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBooksAbout
            // 
            this.BtnBooksAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnBooksAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBooksAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnBooksAbout.Location = new System.Drawing.Point(186, 355);
            this.BtnBooksAbout.Name = "BtnBooksAbout";
            this.BtnBooksAbout.Size = new System.Drawing.Size(170, 42);
            this.BtnBooksAbout.TabIndex = 0;
            this.BtnBooksAbout.Text = "Kitablar";
            this.BtnBooksAbout.UseVisualStyleBackColor = false;
            this.BtnBooksAbout.Click += new System.EventHandler(this.BtnBooksAbout_Click);
            // 
            // BtnCostumersAbout
            // 
            this.BtnCostumersAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnCostumersAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCostumersAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCostumersAbout.Location = new System.Drawing.Point(394, 355);
            this.BtnCostumersAbout.Name = "BtnCostumersAbout";
            this.BtnCostumersAbout.Size = new System.Drawing.Size(170, 42);
            this.BtnCostumersAbout.TabIndex = 1;
            this.BtnCostumersAbout.Text = "Müştərilər";
            this.BtnCostumersAbout.UseVisualStyleBackColor = false;
            this.BtnCostumersAbout.Click += new System.EventHandler(this.BtnCostumersAbout_Click);
            // 
            // BtnUsersAbout
            // 
            this.BtnUsersAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnUsersAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsersAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnUsersAbout.Location = new System.Drawing.Point(597, 355);
            this.BtnUsersAbout.Name = "BtnUsersAbout";
            this.BtnUsersAbout.Size = new System.Drawing.Size(170, 42);
            this.BtnUsersAbout.TabIndex = 2;
            this.BtnUsersAbout.Text = "İstifadəçilər";
            this.BtnUsersAbout.UseVisualStyleBackColor = false;
            this.BtnUsersAbout.Click += new System.EventHandler(this.BtnUsersAbout_Click);
            // 
            // DgvDashBoard
            // 
            this.DgvDashBoard.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDashBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDashBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvDashBoard.Location = new System.Drawing.Point(186, 161);
            this.DgvDashBoard.Name = "DgvDashBoard";
            this.DgvDashBoard.Size = new System.Drawing.Size(581, 172);
            this.DgvDashBoard.TabIndex = 3;
            // 
            // BtnCreateOrder
            // 
            this.BtnCreateOrder.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCreateOrder.Location = new System.Drawing.Point(25, 95);
            this.BtnCreateOrder.Name = "BtnCreateOrder";
            this.BtnCreateOrder.Size = new System.Drawing.Size(110, 42);
            this.BtnCreateOrder.TabIndex = 4;
            this.BtnCreateOrder.Text = "Sifariş Yarat";
            this.BtnCreateOrder.UseVisualStyleBackColor = false;
            this.BtnCreateOrder.Click += new System.EventHandler(this.BtnCreateOrder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(25, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(25, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 42);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.Location = new System.Drawing.Point(25, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 42);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button4.Location = new System.Drawing.Point(25, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 42);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon Nömrəsi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Elektron Ünvan";
            this.Column5.Name = "Column5";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCreateOrder);
            this.Controls.Add(this.DgvDashBoard);
            this.Controls.Add(this.BtnUsersAbout);
            this.Controls.Add(this.BtnCostumersAbout);
            this.Controls.Add(this.BtnBooksAbout);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDashBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBooksAbout;
        private System.Windows.Forms.Button BtnCostumersAbout;
        private System.Windows.Forms.Button BtnUsersAbout;
        private System.Windows.Forms.DataGridView DgvDashBoard;
        private System.Windows.Forms.Button BtnCreateOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}