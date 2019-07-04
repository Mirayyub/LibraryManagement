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
using LibraryManagement.DAL;
using LibraryManagement.Model;

namespace LibraryManagement.Forms
{
    public partial class Login : Form
    {
        private readonly LibraryContext _context;
        public Login()
        {
            InitializeComponent();
            _context = new LibraryContext();
            TxtPassWord.PasswordChar = '*';
            TxtPassWord.MaxLength = 15;
        }

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
                    panel1.BackColor=Color.Red;
                    return;
                }
                else if (TxtPassWord.Text == "")
                {
                    panel2.BackColor = Color.Red;
                    return;
                }
                MessageBox.Show("İstifadəçi və ya Şifrəni Düzgün Qeyd Edin.");

                return;
            }


            this.Hide();
            DashBoard ss = new DashBoard();

            ss.Show();
           
        }
    }
}
