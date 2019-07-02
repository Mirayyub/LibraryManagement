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
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.BtnUserUpdate = new System.Windows.Forms.Button();
            this.BtnUserDelete = new System.Windows.Forms.Button();
            this.TxtSearchUser = new System.Windows.Forms.TextBox();
            this.BtnSearchUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
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
            this.dgvUsersList.Location = new System.Drawing.Point(12, 220);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.Size = new System.Drawing.Size(676, 178);
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
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(37, 45);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(24, 13);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "Ad*";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(40, 61);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.TxtFirstName.TabIndex = 2;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(40, 135);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 4;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(37, 119);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(41, 13);
            this.LblLastName.TabIndex = 3;
            this.LblLastName.Text = "Soyad*";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(191, 61);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(188, 45);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(85, 13);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "Elektron Ünvan*";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(191, 135);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(100, 20);
            this.TxtUserName.TabIndex = 8;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(188, 119);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(71, 13);
            this.LblUserName.TabIndex = 7;
            this.LblUserName.Text = "İstifadəçi Adı*";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(345, 135);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 10;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(342, 119);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(32, 13);
            this.LblPassword.TabIndex = 9;
            this.LblPassword.Text = "Şifrə*";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddUser.Location = new System.Drawing.Point(345, 59);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(100, 23);
            this.BtnAddUser.TabIndex = 11;
            this.BtnAddUser.Text = "Əlavə et";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnUserUpdate
            // 
            this.BtnUserUpdate.BackColor = System.Drawing.Color.Lime;
            this.BtnUserUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserUpdate.Location = new System.Drawing.Point(345, 61);
            this.BtnUserUpdate.Name = "BtnUserUpdate";
            this.BtnUserUpdate.Size = new System.Drawing.Size(100, 23);
            this.BtnUserUpdate.TabIndex = 12;
            this.BtnUserUpdate.Text = "Yenilə";
            this.BtnUserUpdate.UseVisualStyleBackColor = false;
            this.BtnUserUpdate.Visible = false;
            this.BtnUserUpdate.Click += new System.EventHandler(this.BtnUserUpdate_Click);
            // 
            // BtnUserDelete
            // 
            this.BtnUserDelete.BackColor = System.Drawing.Color.Crimson;
            this.BtnUserDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUserDelete.Location = new System.Drawing.Point(345, 88);
            this.BtnUserDelete.Name = "BtnUserDelete";
            this.BtnUserDelete.Size = new System.Drawing.Size(100, 23);
            this.BtnUserDelete.TabIndex = 13;
            this.BtnUserDelete.Text = "Sil";
            this.BtnUserDelete.UseVisualStyleBackColor = false;
            this.BtnUserDelete.Visible = false;
            this.BtnUserDelete.Click += new System.EventHandler(this.BtnUserDelete_Click);
            // 
            // TxtSearchUser
            // 
            this.TxtSearchUser.Location = new System.Drawing.Point(492, 73);
            this.TxtSearchUser.Name = "TxtSearchUser";
            this.TxtSearchUser.Size = new System.Drawing.Size(100, 20);
            this.TxtSearchUser.TabIndex = 14;
            // 
            // BtnSearchUser
            // 
            this.BtnSearchUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearchUser.Location = new System.Drawing.Point(492, 99);
            this.BtnSearchUser.Name = "BtnSearchUser";
            this.BtnSearchUser.Size = new System.Drawing.Size(100, 40);
            this.BtnSearchUser.TabIndex = 15;
            this.BtnSearchUser.Text = "Axtar";
            this.BtnSearchUser.UseVisualStyleBackColor = false;
            this.BtnSearchUser.Click += new System.EventHandler(this.BtnSearchUser_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 410);
            this.Controls.Add(this.BtnSearchUser);
            this.Controls.Add(this.TxtSearchUser);
            this.Controls.Add(this.BtnUserDelete);
            this.Controls.Add(this.BtnUserUpdate);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.dgvUsersList);
            this.Name = "UserPage";
            this.Text = "UserPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
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
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button BtnUserUpdate;
        private System.Windows.Forms.Button BtnUserDelete;
        private System.Windows.Forms.TextBox TxtSearchUser;
        private System.Windows.Forms.Button BtnSearchUser;
    }
}