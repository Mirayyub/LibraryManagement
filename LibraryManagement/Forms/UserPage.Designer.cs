namespace LibraryManagement.Forms
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.BtnUserUpdate = new System.Windows.Forms.Button();
            this.BtnUserDelete = new System.Windows.Forms.Button();
            this.TxtSearchUser = new System.Windows.Forms.TextBox();
            this.BtnSearchUser = new System.Windows.Forms.Button();
            this.grpboxUser = new System.Windows.Forms.GroupBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblSearchUserName = new System.Windows.Forms.Label();
            this.TxtEmailSearch = new System.Windows.Forms.TextBox();
            this.LblEmailSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.grpboxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvUsersList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsersList.Location = new System.Drawing.Point(0, 273);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.Size = new System.Drawing.Size(680, 178);
            this.dgvUsersList.TabIndex = 0;
            this.dgvUsersList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUsersList_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Istifadəçi Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adı";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Soyadı";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Elektron Ünvan";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Şifrə";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(9, 194);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 10;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(6, 178);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(32, 13);
            this.LblPassword.TabIndex = 9;
            this.LblPassword.Text = "Şifrə*";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddUser.Location = new System.Drawing.Point(129, 185);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(100, 36);
            this.BtnAddUser.TabIndex = 11;
            this.BtnAddUser.Text = "Əlavə et";
            this.BtnAddUser.UseVisualStyleBackColor = false;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnUserUpdate
            // 
            this.BtnUserUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnUserUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUserUpdate.Location = new System.Drawing.Point(129, 185);
            this.BtnUserUpdate.Name = "BtnUserUpdate";
            this.BtnUserUpdate.Size = new System.Drawing.Size(100, 36);
            this.BtnUserUpdate.TabIndex = 12;
            this.BtnUserUpdate.Text = "Yenilə";
            this.BtnUserUpdate.UseVisualStyleBackColor = false;
            this.BtnUserUpdate.Visible = false;
            this.BtnUserUpdate.Click += new System.EventHandler(this.BtnUserUpdate_Click);
            // 
            // BtnUserDelete
            // 
            this.BtnUserDelete.BackColor = System.Drawing.Color.Firebrick;
            this.BtnUserDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUserDelete.Location = new System.Drawing.Point(129, 143);
            this.BtnUserDelete.Name = "BtnUserDelete";
            this.BtnUserDelete.Size = new System.Drawing.Size(100, 36);
            this.BtnUserDelete.TabIndex = 13;
            this.BtnUserDelete.Text = "Sil";
            this.BtnUserDelete.UseVisualStyleBackColor = false;
            this.BtnUserDelete.Visible = false;
            this.BtnUserDelete.Click += new System.EventHandler(this.BtnUserDelete_Click);
            // 
            // TxtSearchUser
            // 
            this.TxtSearchUser.Location = new System.Drawing.Point(557, 37);
            this.TxtSearchUser.Name = "TxtSearchUser";
            this.TxtSearchUser.Size = new System.Drawing.Size(100, 20);
            this.TxtSearchUser.TabIndex = 14;
            // 
            // BtnSearchUser
            // 
            this.BtnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.BtnSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearchUser.Location = new System.Drawing.Point(557, 106);
            this.BtnSearchUser.Name = "BtnSearchUser";
            this.BtnSearchUser.Size = new System.Drawing.Size(100, 36);
            this.BtnSearchUser.TabIndex = 15;
            this.BtnSearchUser.Text = "Axtar";
            this.BtnSearchUser.UseVisualStyleBackColor = false;
            this.BtnSearchUser.Click += new System.EventHandler(this.BtnSearchUser_Click);
            // 
            // grpboxUser
            // 
            this.grpboxUser.Controls.Add(this.TxtUserName);
            this.grpboxUser.Controls.Add(this.LblUserName);
            this.grpboxUser.Controls.Add(this.TxtEmail);
            this.grpboxUser.Controls.Add(this.BtnUserUpdate);
            this.grpboxUser.Controls.Add(this.BtnUserDelete);
            this.grpboxUser.Controls.Add(this.TxtPassword);
            this.grpboxUser.Controls.Add(this.LblEmail);
            this.grpboxUser.Controls.Add(this.LblPassword);
            this.grpboxUser.Controls.Add(this.TxtLastName);
            this.grpboxUser.Controls.Add(this.BtnAddUser);
            this.grpboxUser.Controls.Add(this.LblLastName);
            this.grpboxUser.Controls.Add(this.TxtFirstName);
            this.grpboxUser.Controls.Add(this.LblFirstName);
            this.grpboxUser.Location = new System.Drawing.Point(12, 12);
            this.grpboxUser.Name = "grpboxUser";
            this.grpboxUser.Size = new System.Drawing.Size(240, 240);
            this.grpboxUser.TabIndex = 16;
            this.grpboxUser.TabStop = false;
            this.grpboxUser.Text = "İdarəetmə Paneli";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(9, 143);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(100, 20);
            this.TxtUserName.TabIndex = 16;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(6, 127);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(71, 13);
            this.LblUserName.TabIndex = 15;
            this.LblUserName.Text = "İstifadəçi Adı*";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(129, 44);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 14;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(126, 28);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(85, 13);
            this.LblEmail.TabIndex = 13;
            this.LblEmail.Text = "Elektron Ünvan*";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(9, 94);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 12;
            this.TxtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLastName_KeyPress);
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(6, 78);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(41, 13);
            this.LblLastName.TabIndex = 11;
            this.LblLastName.Text = "Soyad*";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(9, 44);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.TxtFirstName.TabIndex = 10;
            this.TxtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirstName_KeyPress);
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(6, 28);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(24, 13);
            this.LblFirstName.TabIndex = 9;
            this.LblFirstName.Text = "Ad*";
            // 
            // LblSearchUserName
            // 
            this.LblSearchUserName.AutoSize = true;
            this.LblSearchUserName.Location = new System.Drawing.Point(484, 40);
            this.LblSearchUserName.Name = "LblSearchUserName";
            this.LblSearchUserName.Size = new System.Drawing.Size(67, 13);
            this.LblSearchUserName.TabIndex = 17;
            this.LblSearchUserName.Text = "İstifadəçi Adı";
            // 
            // TxtEmailSearch
            // 
            this.TxtEmailSearch.Location = new System.Drawing.Point(557, 73);
            this.TxtEmailSearch.Name = "TxtEmailSearch";
            this.TxtEmailSearch.Size = new System.Drawing.Size(100, 20);
            this.TxtEmailSearch.TabIndex = 18;
            // 
            // LblEmailSearch
            // 
            this.LblEmailSearch.AutoSize = true;
            this.LblEmailSearch.Location = new System.Drawing.Point(470, 76);
            this.LblEmailSearch.Name = "LblEmailSearch";
            this.LblEmailSearch.Size = new System.Drawing.Size(81, 13);
            this.LblEmailSearch.TabIndex = 19;
            this.LblEmailSearch.Text = "Elektron Ünvan";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(680, 451);
            this.Controls.Add(this.LblEmailSearch);
            this.Controls.Add(this.TxtEmailSearch);
            this.Controls.Add(this.LblSearchUserName);
            this.Controls.Add(this.grpboxUser);
            this.Controls.Add(this.BtnSearchUser);
            this.Controls.Add(this.TxtSearchUser);
            this.Controls.Add(this.dgvUsersList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.grpboxUser.ResumeLayout(false);
            this.grpboxUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button BtnUserUpdate;
        private System.Windows.Forms.Button BtnUserDelete;
        private System.Windows.Forms.TextBox TxtSearchUser;
        private System.Windows.Forms.Button BtnSearchUser;
        private System.Windows.Forms.GroupBox grpboxUser;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblSearchUserName;
        private System.Windows.Forms.TextBox TxtEmailSearch;
        private System.Windows.Forms.Label LblEmailSearch;
    }
}