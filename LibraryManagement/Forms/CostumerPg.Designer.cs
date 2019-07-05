namespace LibraryManagement.Forms
{
    partial class CostumerPg
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
            this.BtnSearchCostumer = new System.Windows.Forms.Button();
            this.TxtSearchCostumer = new System.Windows.Forms.TextBox();
            this.BtnCostumerDelete = new System.Windows.Forms.Button();
            this.BtnCostumerUpdate = new System.Windows.Forms.Button();
            this.BtnCostumerAdd = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.dgvCostumerlist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblSearchName = new System.Windows.Forms.Label();
            this.grpboxCostumer = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumerlist)).BeginInit();
            this.grpboxCostumer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearchCostumer
            // 
            this.BtnSearchCostumer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnSearchCostumer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchCostumer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearchCostumer.Location = new System.Drawing.Point(549, 58);
            this.BtnSearchCostumer.Name = "BtnSearchCostumer";
            this.BtnSearchCostumer.Size = new System.Drawing.Size(100, 40);
            this.BtnSearchCostumer.TabIndex = 31;
            this.BtnSearchCostumer.Text = "Axtar";
            this.BtnSearchCostumer.UseVisualStyleBackColor = false;
            this.BtnSearchCostumer.Click += new System.EventHandler(this.BtnSearchCostumer_Click);
            // 
            // TxtSearchCostumer
            // 
            this.TxtSearchCostumer.Location = new System.Drawing.Point(549, 25);
            this.TxtSearchCostumer.Name = "TxtSearchCostumer";
            this.TxtSearchCostumer.Size = new System.Drawing.Size(100, 20);
            this.TxtSearchCostumer.TabIndex = 30;
            // 
            // BtnCostumerDelete
            // 
            this.BtnCostumerDelete.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCostumerDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCostumerDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCostumerDelete.Location = new System.Drawing.Point(139, 103);
            this.BtnCostumerDelete.Name = "BtnCostumerDelete";
            this.BtnCostumerDelete.Size = new System.Drawing.Size(100, 39);
            this.BtnCostumerDelete.TabIndex = 29;
            this.BtnCostumerDelete.Text = "Sil";
            this.BtnCostumerDelete.UseVisualStyleBackColor = false;
            this.BtnCostumerDelete.Visible = false;
            this.BtnCostumerDelete.Click += new System.EventHandler(this.BtnCostumerDelete_Click);
            // 
            // BtnCostumerUpdate
            // 
            this.BtnCostumerUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCostumerUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCostumerUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCostumerUpdate.Location = new System.Drawing.Point(139, 146);
            this.BtnCostumerUpdate.Name = "BtnCostumerUpdate";
            this.BtnCostumerUpdate.Size = new System.Drawing.Size(100, 40);
            this.BtnCostumerUpdate.TabIndex = 28;
            this.BtnCostumerUpdate.Text = "Yenilə";
            this.BtnCostumerUpdate.UseVisualStyleBackColor = false;
            this.BtnCostumerUpdate.Visible = false;
            this.BtnCostumerUpdate.Click += new System.EventHandler(this.BtnCostumerUpdate_Click);
            // 
            // BtnCostumerAdd
            // 
            this.BtnCostumerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnCostumerAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCostumerAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCostumerAdd.Location = new System.Drawing.Point(139, 146);
            this.BtnCostumerAdd.Name = "BtnCostumerAdd";
            this.BtnCostumerAdd.Size = new System.Drawing.Size(100, 41);
            this.BtnCostumerAdd.TabIndex = 27;
            this.BtnCostumerAdd.Text = "Əlavə et";
            this.BtnCostumerAdd.UseVisualStyleBackColor = false;
            this.BtnCostumerAdd.Click += new System.EventHandler(this.BtnCostumerAdd_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(142, 50);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 24;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(139, 34);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(85, 13);
            this.LblEmail.TabIndex = 23;
            this.LblEmail.Text = "Elektron Ünvan*";
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(6, 162);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.TxtPhoneNumber.TabIndex = 22;
            this.TxtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneNumber_KeyPress);
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Location = new System.Drawing.Point(3, 146);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.LblPhoneNumber.TabIndex = 21;
            this.LblPhoneNumber.Text = "Telefon Nömrəsi";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(6, 103);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 20;
            this.TxtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLastName_KeyPress);
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(3, 87);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(41, 13);
            this.LblLastName.TabIndex = 19;
            this.LblLastName.Text = "Soyad*";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(6, 50);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.TxtFirstName.TabIndex = 18;
            this.TxtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirstName_KeyPress);
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(3, 34);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(24, 13);
            this.LblFirstName.TabIndex = 17;
            this.LblFirstName.Text = "Ad*";
            // 
            // dgvCostumerlist
            // 
            this.dgvCostumerlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCostumerlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCostumerlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCostumerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCostumerlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgvCostumerlist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCostumerlist.Location = new System.Drawing.Point(0, 226);
            this.dgvCostumerlist.Name = "dgvCostumerlist";
            this.dgvCostumerlist.Size = new System.Drawing.Size(679, 178);
            this.dgvCostumerlist.TabIndex = 16;
            this.dgvCostumerlist.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCostumerlist_RowHeaderMouseDoubleClick);
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
            // Column5
            // 
            this.Column5.HeaderText = "Elektron Ünvan";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon Nömrəsi";
            this.Column4.Name = "Column4";
            // 
            // LblSearchName
            // 
            this.LblSearchName.AutoSize = true;
            this.LblSearchName.Location = new System.Drawing.Point(485, 27);
            this.LblSearchName.Name = "LblSearchName";
            this.LblSearchName.Size = new System.Drawing.Size(58, 13);
            this.LblSearchName.TabIndex = 32;
            this.LblSearchName.Text = "Müştəri adı";
            // 
            // grpboxCostumer
            // 
            this.grpboxCostumer.Controls.Add(this.TxtFirstName);
            this.grpboxCostumer.Controls.Add(this.LblFirstName);
            this.grpboxCostumer.Controls.Add(this.LblLastName);
            this.grpboxCostumer.Controls.Add(this.TxtLastName);
            this.grpboxCostumer.Controls.Add(this.BtnCostumerDelete);
            this.grpboxCostumer.Controls.Add(this.LblPhoneNumber);
            this.grpboxCostumer.Controls.Add(this.TxtPhoneNumber);
            this.grpboxCostumer.Controls.Add(this.BtnCostumerUpdate);
            this.grpboxCostumer.Controls.Add(this.BtnCostumerAdd);
            this.grpboxCostumer.Controls.Add(this.LblEmail);
            this.grpboxCostumer.Controls.Add(this.TxtEmail);
            this.grpboxCostumer.Location = new System.Drawing.Point(12, 12);
            this.grpboxCostumer.Name = "grpboxCostumer";
            this.grpboxCostumer.Size = new System.Drawing.Size(245, 208);
            this.grpboxCostumer.TabIndex = 33;
            this.grpboxCostumer.TabStop = false;
            this.grpboxCostumer.Text = "İdarəetmə Paneli";
            // 
            // CostumerPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(679, 404);
            this.Controls.Add(this.grpboxCostumer);
            this.Controls.Add(this.LblSearchName);
            this.Controls.Add(this.BtnSearchCostumer);
            this.Controls.Add(this.TxtSearchCostumer);
            this.Controls.Add(this.dgvCostumerlist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CostumerPg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CostumerPg";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumerlist)).EndInit();
            this.grpboxCostumer.ResumeLayout(false);
            this.grpboxCostumer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearchCostumer;
        private System.Windows.Forms.TextBox TxtSearchCostumer;
        private System.Windows.Forms.Button BtnCostumerDelete;
        private System.Windows.Forms.Button BtnCostumerUpdate;
        private System.Windows.Forms.Button BtnCostumerAdd;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.DataGridView dgvCostumerlist;
        private System.Windows.Forms.Label LblSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grpboxCostumer;
    }
}