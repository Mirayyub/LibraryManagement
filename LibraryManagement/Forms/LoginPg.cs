using LibraryManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Model;

namespace LibraryManagement.Forms
{
    public partial class Login : Form
    {
        #region Connections Database
        private readonly LibraryContext _context;
        #endregion


        public Login()
        {
            InitializeComponent();
            _context = new LibraryContext();
            TxtPassWord.PasswordChar = '*';
            TxtPassWord.MaxLength = 15;
        }

        

        #region Buttons
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            List<User> user = _context.Users.Where(u => u.UserName == TxtLogin.Text).ToList();

            if (TxtLogin.Text == "" || TxtPassWord.Text == "")
            {
                if (TxtLogin.Text == "")
                {
                    panel1.BackColor = Color.Red;
                    return;
                }
                else if (TxtPassWord.Text == "")
                {
                    panel2.BackColor = Color.Red;
                    return;
                }
                MessageBox.Show("İstifadəçi Adını və ya Şifrəni Düzgün Qeyd Edin.", "Diqqət");

                return;
            }


            UsersLoginCheck();

        }
       
        #endregion


        #region Functions 
        private void UsersLoginCheck()
        {

            if (!_context.Users.Any(u => u.UserName == TxtLogin.Text))
            {

                MessageBox.Show("İstifadəçi Adı Düzgün Daxil Edilməyib","Diqqət");
                return;

            }

            if (!_context.Users.Any(u => u.Password == TxtPassWord.Text))
            {

                MessageBox.Show("Şifrə Düzgün Daxil Edilməyib", "Diqqət");
                return;
            }

            else
            {
                DashBoard ss = new DashBoard();

                ss.Show();
                this.Hide();
            }

        }
        

        #endregion

       
    }
}
