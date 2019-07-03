using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            

        }
        
        private void BtnBooksAbout_Click(object sender, EventArgs e)
        {
            BookPg ss = new BookPg();

            ss.Show();
            

        }

        private void BtnCostumersAbout_Click(object sender, EventArgs e)
        {
            CostumerPg ss = new CostumerPg();

            ss.Show();
        }

        private void BtnUsersAbout_Click(object sender, EventArgs e)
        {
            UserPage ss = new UserPage();

            ss.Show();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            


        }
    }
}
