using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.DAL;
using LibraryManagement.Model;

namespace LibraryManagement.Forms
{
    public partial class UserPage : Form
    {
        private readonly LibraryContext _context;

        private User _selecteduser;




        public UserPage()
        {
            InitializeComponent();

            _context = new LibraryContext();

            FillUserData();
        }


        private void FillUserData()
        {
            dgvUsersList.Rows.Clear();

            foreach (var item in _context.Users.ToList())
            {
                dgvUsersList.Rows.Add(item.Id,
                    item.UserName,
                                 item.FirstName,
                                 item.LastName,
                                 item.Email,
                                 item.Password);
            }
        }



        private bool Validation()
        {
            if (string.IsNullOrEmpty(TxtFirstName.Text))
            {
                LblFirstName.ForeColor = Color.Red;
                LblLastName.ForeColor = SystemColors.ControlText;
                LblPassword.ForeColor = SystemColors.ControlText;
                LblUserName.ForeColor = SystemColors.ControlText;
                LblEmail.ForeColor = SystemColors.ControlText;

                return false;
            }
            if (string.IsNullOrEmpty(TxtLastName.Text))
            {
                LblFirstName.ForeColor = Color.Red;
                LblLastName.ForeColor = SystemColors.ControlText;
                LblPassword.ForeColor = SystemColors.ControlText;
                LblUserName.ForeColor = SystemColors.ControlText;
                LblEmail.ForeColor = SystemColors.ControlText;

                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                LblFirstName.ForeColor = SystemColors.ControlText;
                LblLastName.ForeColor = SystemColors.ControlText;
                LblPassword.ForeColor = Color.Red;
                LblUserName.ForeColor = SystemColors.ControlText;
                LblEmail.ForeColor = SystemColors.ControlText;

                return false;
            }
            if (string.IsNullOrEmpty(TxtUserName.Text))
            {
                LblFirstName.ForeColor = SystemColors.ControlText;
                LblLastName.ForeColor = SystemColors.ControlText;
                LblPassword.ForeColor = SystemColors.ControlText;
                LblUserName.ForeColor = Color.Red;
                LblEmail.ForeColor = SystemColors.ControlText;

                return false;
            }
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                LblFirstName.ForeColor = SystemColors.ControlText;
                LblLastName.ForeColor = SystemColors.ControlText;
                LblPassword.ForeColor = SystemColors.ControlText;
                LblUserName.ForeColor = SystemColors.ControlText;
                LblEmail.ForeColor = Color.Red;

                return false;
            }

            return true;

        }


        private void ResetUserForm()
        {
            TxtEmail.Text = string.Empty;
            TxtFirstName.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtPassword.Text = string.Empty;
            TxtUserName.Text = string.Empty;


            LblFirstName.ForeColor = SystemColors.ControlText;
            LblLastName.ForeColor = SystemColors.ControlText;
            LblPassword.ForeColor = SystemColors.ControlText;
            LblUserName.ForeColor = SystemColors.ControlText;
            LblEmail.ForeColor = SystemColors.ControlText;
        }

        private void ButtonUserReset()
        {
            BtnAddUser.Visible = true;
            BtnUserUpdate.Visible = false;
            BtnUserDelete.Visible = false;
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {

            if (!Validation())
            {
                return;
            }

            User user = new User();

            user.FirstName = TxtFirstName.Text;
            user.LastName = TxtLastName.Text;
            user.UserName = TxtUserName.Text;
            user.Email = TxtEmail.Text;
            user.Password = TxtPassword.Text;


            List<User> user1 = _context.Users.Where(u => u.UserName.Contains(TxtUserName.Text)).ToList();

            foreach (var item in user1)
            {
                if (item.UserName == user.UserName)
                {
                    LblUserName.ForeColor = Color.Red;
                    MessageBox.Show("Eyni Adlı İstifadəçi Olduğu Üçün Şəxs Əlavə Olunmadı","Diqqət!");
                    ResetUserForm();
                    return;
                }
            }
            _context.Users.Add(user);
            _context.SaveChanges();

            FillUserData();
            ResetUserForm();

            MessageBox.Show("Yeni İstifadəçi Əlavə Olundu!");

        }
    }
}
