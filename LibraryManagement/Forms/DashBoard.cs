using LibraryManagement.DAL;
using LibraryManagement.Model;
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

        private readonly LibraryContext _context;
        

        

        public DashBoard()
        {
            InitializeComponent();
            _context = new LibraryContext();

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
            
            FillCustomerList();
            FillBookList();
            PnlNewOrders.Visible = true;
            LblPriceOrder.Text = "0";
            CmbBookOrder.DropDownHeight = CmbBookOrder.Font.Height * 5;
            CmbCostumerOrder.DropDownHeight = CmbCostumerOrder.Font.Height * 5;
            BtnCreateOrder.BackColor = Color.RoyalBlue;
            BtnTrackingAllOrders.BackColor = Color.CornflowerBlue;            
            BtnReturnBook.BackColor = Color.CornflowerBlue;


        }


        private void FillCustomerList()
        {
            foreach (var item in _context.Costumers.ToList())
            {
                CmbCostumerOrder.Items.Add(item.FirstName + " " + item.LastName);
            }

        }
        private void FillBookList()
        {
            foreach (var item in _context.Books.ToList())
            {
                CmbBookOrder.Items.Add(item.Name);
            }
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            PnlNewOrders.Visible = false;

            BtnTrackingAllOrders.BackColor = Color.CornflowerBlue;
            BtnCreateOrder.BackColor = Color.CornflowerBlue;
            BtnReturnBook.BackColor = Color.RoyalBlue;
            
        }

        private void BtnTrackingAllOrders_Click(object sender, EventArgs e)
        {

            PnlNewOrders.Visible = false;

            BtnTrackingAllOrders.BackColor = Color.RoyalBlue;
            BtnCreateOrder.BackColor = Color.CornflowerBlue;
            BtnReturnBook.BackColor = Color.CornflowerBlue;

        }

        









    }
}
