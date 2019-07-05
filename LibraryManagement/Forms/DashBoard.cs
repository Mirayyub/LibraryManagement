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

        private Book _selectedbook;

        private decimal _totalmoney = 0;
        
        

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
            LblPriceAllbooks.Text = "0";            
            BtnCreateOrder.BackColor = Color.RoyalBlue;
            BtnTrackingAllOrders.BackColor = Color.CornflowerBlue;            
            BtnReturnBook.BackColor = Color.CornflowerBlue;
            BtnCreateOrder.BackColor = Color.RoyalBlue;
            PnlReturnBook.Visible = false;
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
            PnlReturnBook.Visible = true;
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

        private void BtnPnlResetForm()
        {
            LblBookOrder.ForeColor = SystemColors.ControlText;
            LblBookCount.ForeColor = SystemColors.ControlText;
            LblDateTimeOrder.ForeColor = SystemColors.ControlText;

            CmbBookOrder.Text = string.Empty;
            DateReturnDay.Value = DateTime.Now;
            NmrBookCount.Text = "1";
            LblPriceOrderLbl.Text = " ";
            

        }

        private void BookMoneyScreen()
        {
            int Id = _context.Books.FirstOrDefault(b => b.Name == CmbBookOrder.Text).Id;
            _selectedbook = _context.Books.Find(Id);
            LblPriceOrderLbl.Text = _selectedbook.Price.ToString();

        }
        
        private void CmbBookOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookMoneyScreen();
            DateReturnDay.Enabled = true;
            LblPriceOrderLbl.Enabled = true;
            NmrBookCount.Enabled = true;
            
        }


        private void ResetForm()
        {

            CmbBookOrder.Enabled = false;
            NmrBookCount.Enabled = false;
            DateReturnDay.Enabled = false;
            LblPriceOrderLbl.Enabled = false;
            CmbCostumerOrder.Enabled = true;
            BtnSubmitOrders.Visible = false;
            BtnAddNewOrder.Enabled = false;
            PctEmptyBasket.Visible = true;
            PctFullBasket.Visible = false;
            DgvBookDashboard.Rows.Clear();
            LblPriceAllbooks.Text = "0";
            NmrBookCount.Text = "0";
            LblPriceOrderLbl.Text = " ";
            CmbCostumerOrder.Text = string.Empty;            
            CmbBookOrder.Text = string.Empty;
            DateReturnDay.Value = DateTime.Now;
            LblCostumer.ForeColor = SystemColors.ControlText;
            LblBookOrder.ForeColor = SystemColors.ControlText;
            LblBookCount.ForeColor = SystemColors.ControlText;
            LblDateTimeOrder.ForeColor = SystemColors.ControlText;
            

        }


        private void CalcMoneyCountAllBook()
        {

            LblPriceOrderLbl.Text = (_selectedbook.Price * Convert.ToDecimal(NmrBookCount.Value)).ToString();

        }

        

        private void NmrBookCount_ValueChanged(object sender, EventArgs e)
        {
            CalcMoneyCountAllBook();
            CalcMoneyFalseReturnDay();
            BtnAddNewOrder.Enabled = true;
        }




        private void CalcMoneyFalseReturnDay()
        {

            if (DateReturnDay.Value <= DateTime.Now.AddDays(7))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddDays(7) && DateReturnDay.Value <= DateTime.Now.AddDays(14))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 2 * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddDays(14) && DateReturnDay.Value <= DateTime.Now.AddDays(21))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 3 * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddDays(21) && DateReturnDay.Value <= DateTime.Now.AddMonths(1))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 4 * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddMonths(1) && DateReturnDay.Value <= DateTime.Now.AddMonths(3))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 5 * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddMonths(3) && DateReturnDay.Value <= DateTime.Now.AddMonths(4))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 6 * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddMonths(4) && DateReturnDay.Value <= DateTime.Now.AddMonths(5))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 7 * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddMonths(5) && DateReturnDay.Value <= DateTime.Now.AddMonths(6))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 8 * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddMonths(6) && DateReturnDay.Value <= DateTime.Now.AddMonths(7))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 10 * NmrBookCount.Value).ToString();
            }

        }


       

        private void DateReturnDay_ValueChanged(object sender, EventArgs e)
        {
            CalcMoneyFalseReturnDay();
        }

        

        private void BtnAddNewOrder_Click(object sender, EventArgs e)
        {

            if (!ValidateBookCountOnStock())
            {

                return;
            }
            
            var money = Convert.ToDecimal(LblPriceOrderLbl.Text);

            DgvBookDashboard.Rows.Add(_selectedbook.Id, _selectedbook.Name, NmrBookCount.Value, DateReturnDay.Value, money);

            _selectedbook.Count -= Convert.ToInt32(NmrBookCount.Value);

            CmbCostumerOrder.Enabled = false;
            CmbBookOrder.Text = string.Empty;
            NmrBookCount.Value = 0;
            LblPriceOrderLbl.Text = " ";
            BtnRemoveList.Visible = false;
            BtnSubmitOrders.Visible = true;
            BtnAddNewOrder.Enabled = false;
            _totalmoney += money;

            LblPriceAllbooks.Text = _totalmoney.ToString();

            BtnPnlResetForm();
            DateReturnDay.Enabled = false;
            NmrBookCount.Enabled = false;
            LblPriceOrderLbl.Enabled = false;
            PctEmptyBasket.Visible = false;
            PctFullBasket.Visible = true;


        }


        private bool ValidateBookCountOnStock()
        {

            if (NmrBookCount.Value > _selectedbook.Count)
            {
                LblBookCount.ForeColor = Color.Red;
                MessageBox.Show("Kitab Sayı Qeyd Olunandan Azdır.", "Diqqət!");
                return false;
            }

            return true;
        }

        



        private bool Validation()
        {
            if (string.IsNullOrEmpty(CmbCostumerOrder.Text))
            {
                LblCostumer.ForeColor = Color.Red;
                LblBookOrder.ForeColor = SystemColors.ControlText;
                LblBookCount.ForeColor = SystemColors.ControlText;
                LblDateTimeOrder.ForeColor = SystemColors.ControlText;

                return false;
            }

            if (string.IsNullOrEmpty(CmbBookOrder.Text))
            {
                LblCostumer.ForeColor = Color.Red;
                LblBookOrder.ForeColor = SystemColors.ControlText;
                LblBookCount.ForeColor = SystemColors.ControlText;
                LblDateTimeOrder.ForeColor = SystemColors.ControlText;

                return false;
            }

            if (DateReturnDay.Value < DateTime.Now)
            {
                LblCostumer.ForeColor = Color.Red;
                LblBookOrder.ForeColor = SystemColors.ControlText;
                LblBookCount.ForeColor = SystemColors.ControlText;
                LblDateTimeOrder.ForeColor = SystemColors.ControlText;

                MessageBox.Show("Qaytarma Vaxtını Keçmişə Qeyd Etmək Mümkün Deyil", "Diqqət!");

                return false;
            }

            if (NmrBookCount.Value == 0)
            {
                LblCostumer.ForeColor = Color.Red;
                LblBookOrder.ForeColor = SystemColors.ControlText;
                LblBookCount.ForeColor = SystemColors.ControlText;
                LblDateTimeOrder.ForeColor = SystemColors.ControlText;

                return false;
            }

            if (DateReturnDay.Value == DateTime.Now)
            {
                LblCostumer.ForeColor = Color.Red;
                LblBookOrder.ForeColor = SystemColors.ControlText;
                LblBookCount.ForeColor = SystemColors.ControlText;
                LblDateTimeOrder.ForeColor = SystemColors.ControlText;

                return false;

            }

            
            return true;
        }

        private void CmbCostumerOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

            CmbBookOrder.Enabled = true;
        }

        //private void BtnCreateOrder_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnCreateOrder.BackColor = Color.RoyalBlue;
        //}

        //private void BtnCreateOrder_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnCreateOrder.BackColor = Color.CornflowerBlue;
        //}

        //private void BtnReturnBook_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnReturnBook.BackColor = Color.RoyalBlue;
        //}

        //private void BtnReturnBook_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnReturnBook.BackColor = Color.CornflowerBlue;
        //}

        //private void BtnTrackingAllOrders_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnTrackingAllOrders.BackColor = Color.RoyalBlue;
        //}

        //private void BtnTrackingAllOrders_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnTrackingAllOrders.BackColor = Color.CornflowerBlue;
        //}

        //private void BtnBooksAbout_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnBooksAbout.BackColor = Color.RoyalBlue;
        //}

        //private void BtnBooksAbout_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnBooksAbout.BackColor = Color.CornflowerBlue;
        //}

        //private void BtnCostumersAbout_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnCostumersAbout.BackColor = Color.RoyalBlue;
        //}

        //private void BtnCostumersAbout_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnCostumersAbout.BackColor = Color.CornflowerBlue;
        //}

        //private void BtnAccount_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnAccount.BackColor = Color.RoyalBlue;
        //}

        //private void BtnAccount_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnAccount.BackColor = Color.CornflowerBlue;
        //}

        //private void BtnUsersAbout_MouseEnter(object sender, EventArgs e)
        //{
        //    BtnUsersAbout.BackColor = Color.RoyalBlue;
        //}

        //private void BtnUsersAbout_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnUsersAbout.BackColor = Color.CornflowerBlue;
        //}

        private void BtnSubmitOrders_Click(object sender, EventArgs e)
        {
            int id = _context.Costumers.FirstOrDefault(c => c.FirstName + " " + c.LastName == CmbCostumerOrder.Text).Id;

            var selectedCostumer = _context.Costumers.Find(id);

            Order newOrder = new Order
            {
                CustomerId=selectedCostumer.Id,

                CreatedDate=DateTime.Now,
            };

            _context.Orders.Add(newOrder);
            _context.SaveChanges();
            MessageBox.Show("Satış Müvəffəqiyyətlə yaddaşa yazıldı", "Diqqət!");


            BtnPnlResetForm();
            ResetForm();
            BtnAddNewOrder.Enabled = false;
            




        }

        private void PctExit_Click(object sender, EventArgs e)
        {
            Login ss = new Login();

            this.Hide();
            ss.Show();
        }

        private void BtnRSearch_Click(object sender, EventArgs e)
        {
            
            DgvOrderReturn.Rows.Clear();


            List<OrderItem> order = _context.OrderItems.Where(o => o.Costumer.FirstName.Contains(TxtRBCostumerName.Text)).ToList();

            foreach (var item in order)
            {
                DgvOrderReturn.Rows.Add(item.Id,
                                     item.CustomerId,
                                     item.Costumer.FirstName+ " " + item.Costumer.LastName,
                                     item.BookId,
                                     item.Book,
                                     item.Book.Count
                                     
                                     );
            }
        }
    }
    
}
