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

        private decimal _rbtotalmoney;

        private decimal _totalmoney = 0;

        private OrderItem _selectedorderitem;


        public DashBoard()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillCustomerList();
            FillBookList();

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
            CmbCostumerOrder.Text = string.Empty;
            CmbBookOrder.Text = string.Empty;
            PnlNewOrders.Visible = true;
            LblPriceAllbooks.Text = "0";
            BtnCreateOrder.BackColor = Color.RoyalBlue;
            BtnTrackingAllOrders.BackColor = Color.CornflowerBlue;
            BtnReturnBook.BackColor = Color.CornflowerBlue;
            BtnCreateOrder.BackColor = Color.RoyalBlue;
            PnlReturnBook.Visible = false;
            PnlTrackingOrders.Visible = false;
            PnlAccount.Visible = false;
            BtnAccount.BackColor = Color.CornflowerBlue;
            PnlLibraryApp.Visible = false;
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
            PnlTrackingOrders.Visible = false;
            PnlReturnBook.Visible = true;
            PnlAccount.Visible = false;
            BtnTrackingAllOrders.BackColor = Color.CornflowerBlue;
            BtnCreateOrder.BackColor = Color.CornflowerBlue;
            BtnReturnBook.BackColor = Color.RoyalBlue;
            BtnAccount.BackColor = Color.CornflowerBlue;
            PnlLibraryApp.Visible = false;




        }

        private void BtnTrackingAllOrders_Click(object sender, EventArgs e)
        {
            PnlReturnBook.Visible = false;
            PnlTrackingOrders.Visible = true;
            PnlNewOrders.Visible = false;
            PnlAccount.Visible = false;
            BtnTrackingAllOrders.BackColor = Color.RoyalBlue;
            BtnCreateOrder.BackColor = Color.CornflowerBlue;
            BtnReturnBook.BackColor = Color.CornflowerBlue;
            BtnAccount.BackColor = Color.CornflowerBlue;
            PnlLibraryApp.Visible = false;
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
            BtnAddNewOrderNew.Enabled = false;
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
            BtnAddNewOrderNew.Enabled = true;
        }




        private void CalcMoneyFalseReturnDay()
        {

            if (DateReturnDay.Value <= DateTime.Now.AddDays(5))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddDays(5) && DateReturnDay.Value <= DateTime.Now.AddDays(10))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 2 * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddDays(10) && DateReturnDay.Value <= DateTime.Now.AddDays(20))
            {
                LblPriceOrderLbl.Text = (_selectedbook.Price * 3 * NmrBookCount.Value).ToString();
            }
            if (DateReturnDay.Value > DateTime.Now.AddDays(20) && DateReturnDay.Value <= DateTime.Now.AddMonths(1))
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
                MessageBox.Show("Müştərini Düzgün Qeyd Edin", "Diqqət!");

                return false;
            }

            if (string.IsNullOrEmpty(CmbBookOrder.Text))
            {
                LblCostumer.ForeColor = SystemColors.ControlText;
                LblBookOrder.ForeColor = Color.Red;
                LblBookCount.ForeColor = SystemColors.ControlText;
                LblDateTimeOrder.ForeColor = SystemColors.ControlText;
                MessageBox.Show("Düzgün Qeyd Edin.", "Diqqət!");
                return false;
            }

            if (DateReturnDay.Value < DateTime.Now)
            {
                LblCostumer.ForeColor = SystemColors.ControlText;
                LblBookOrder.ForeColor = SystemColors.ControlText;
                LblBookCount.ForeColor = SystemColors.ControlText;
                LblDateTimeOrder.ForeColor = Color.Red;

                MessageBox.Show("Qaytarma Vaxtını Keçmişə Qeyd Etmək Mümkün Deyil", "Diqqət!");

                return false;
            }

            if (NmrBookCount.Value == 0)
            {
                LblCostumer.ForeColor = Color.Red;
                LblBookOrder.ForeColor = SystemColors.ControlText;
                LblBookCount.ForeColor = Color.Red;
                LblDateTimeOrder.ForeColor = SystemColors.ControlText;

                MessageBox.Show("Bu Kitabdan Kitabxanada Qalmayıbç Zəhmət Olmasa Sonra Müraciət edin.", "Diqqət!");
                return false;
            }


            return true;
        }

        private void CmbCostumerOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

            CmbBookOrder.Enabled = true;
        }
        #region MOUSE HOVER ARE DISABLED
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
        #endregion
        private void BtnSubmitOrders_Click(object sender, EventArgs e)
        {
            int id = _context.Costumers.FirstOrDefault(c => c.FirstName + " " + c.LastName == CmbCostumerOrder.Text).Id;

            var selectedcostumer = _context.Costumers.Find(id);

            Order neworder = new Order
            {
                CostumerId = selectedcostumer.Id,

                CreatedDate = DateTime.Now,

            };

            _context.Orders.Add(neworder);
            _context.SaveChanges();


            for (int i = 0; i < DgvBookDashboard.Rows.Count - 1; i++)
            {

                OrderItem orderitem = new OrderItem
                {
                    BookId = Convert.ToInt32(DgvBookDashboard.Rows[i].Cells[0].Value),
                    Count = Convert.ToInt32(DgvBookDashboard.Rows[i].Cells[2].Value),
                    PayPrice = Convert.ToInt32(DgvBookDashboard.Rows[i].Cells[4].Value),
                    ReturnDate = Convert.ToDateTime(DgvBookDashboard.Rows[i].Cells[3].Value),
                    OrderId = neworder.Id

                };

                _context.OrderItems.Add(orderitem);
                _context.SaveChanges();

                this._totalmoney = 0;
                LblPriceAllbooks.Text = (this._totalmoney).ToString();

            }



            MessageBox.Show("Satış Müvəffəqiyyətlə yaddaşa yazıldı", "Diqqət!");


            BtnPnlResetForm();
            ResetForm();
            BtnAddNewOrderNew.Enabled = false;



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
            List<OrderItem> orders = _context.OrderItems.Include("Book").Include("Order").Include("Order.Costumer").Where(o => o.Order.Costumer.FirstName.Contains(TxtRBCostumerName.Text)).ToList();

            foreach (var item in orders)
            {
                if (item.IsHave == false)
                {
                    DgvOrderReturn.Rows.Add(item.Id,
                                        item.Order.Costumer.FirstName + " " + item.Order.Costumer.LastName,
                                        item.Order.Costumer.PhoneNo,
                                        item.Order.CreatedDate,
                                        item.Book.Name,
                                        item.Count,
                                        item.ReturnDate,
                                        item.PayPrice);
                }

            }
        }

        private void BtnRBSubmit_Click(object sender, EventArgs e)
        {


            if (nmrRBCouunt.Text == "" || nmrRBCouunt.Text == "0")
            {
                if (nmrRBCouunt.Text == "0")
                {
                    MessageBox.Show("Kitab Sayını Düzgün Qeyd Edin");
                    return;
                }

                MessageBox.Show("Kitab Sayını Düzgün Qeyd Edin");

                return;
            }

            _selectedorderitem.IsHave = true;
            _selectedorderitem.Book.Count += Convert.ToInt32(nmrRBCouunt.Value);
            _selectedorderitem.PayPrice = _rbtotalmoney;

            MessageBox.Show("Əməliyyat Uğurla Yerinə Yetirildi");
            ResetRBForms();
            _context.SaveChanges();
            this._rbtotalmoney = 0;
            lblRbTotal.Text = (this._rbtotalmoney).ToString();


        }

        private void ResetRBForms()
        {

            TxtRBCostumerName.Text = string.Empty;
            nmrRBCouunt.Value = 0;
            dateTimePickerRB.Value = DateTime.Now;
            lblRbTotal.Text = "0";
            DgvOrderReturn.Rows.Clear();

        }



        private void DgvOrderReturn_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            int Id = Convert.ToInt32(DgvOrderReturn.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedorderitem = _context.OrderItems.Find(Id);
            lblRbTotal.Text = (_totalmoney).ToString();
            _totalmoney = _selectedorderitem.PayPrice;
            dateTimePickerRB.Value = _selectedorderitem.ReturnDate;
            nmrRBCouunt.Value = _selectedorderitem.Count;



        }

        private void FillTodayOrders()
        {
            DgvTracking.Rows.Clear();


            var today = DateTime.Now.Date;
            var tomor = today.AddHours(24);

            List<OrderItem> orderitems = _context.OrderItems.Include("Book").Include("Order").Include("Order.Costumer").Where(o => o.ReturnDate > today && o.ReturnDate < tomor && o.IsHave == false).ToList();

            foreach (var item in orderitems)
            {
                DgvTracking.Rows.Add(item.Id,
                                    item.Order.Costumer.FirstName + " " + item.Order.Costumer.LastName,
                                    item.Book.Name,
                                    item.Count,
                                    item.Order.CreatedDate,
                                    item.ReturnDate,
                                    item.PayPrice);

            }



        }

        private void BtnTrackingTomorrow_Click(object sender, EventArgs e)
        {




            DgvTracking.Rows.Clear();

            var today = DateTime.Now.Date;
            var StartDate = today.AddHours(24);
            var EndDate = today.AddHours(48);

            List<OrderItem> orderitems = _context.OrderItems.Include("Book").Include("Order").Include("Order.Costumer").Where(o => o.ReturnDate > StartDate && o.ReturnDate < EndDate && o.IsHave == false).ToList();

            foreach (var item in orderitems)
            {
                DgvTracking.Rows.Add(item.Id,
                                    item.Order.Costumer.FirstName + " " + item.Order.Costumer.LastName,
                                    item.Book.Name,
                                    item.Count,
                                    item.Order.CreatedDate,
                                    item.ReturnDate,
                                    item.PayPrice);

            }
        }

        private void BtnTrackingToday_Click(object sender, EventArgs e)
        {
            FillTodayOrders();
        }

        private void BtnAllfalseOrders_Click(object sender, EventArgs e)
        {
            DgvTracking.Rows.Clear();


            var baselineDate = DateTime.Now.AddHours(-24);

            List<OrderItem> orderitems = _context.OrderItems.Include("Book").Include("Order").Include("Order.Costumer").Where(o => o.ReturnDate < baselineDate && o.IsHave == false).ToList();

            foreach (var item in orderitems)
            {
                DgvTracking.Rows.Add(item.Id,
                                    item.Order.Costumer.FirstName + " " + item.Order.Costumer.LastName,
                                    item.Book.Name,
                                    item.Count,
                                    item.Order.CreatedDate,
                                    item.ReturnDate,
                                    item.PayPrice);

            }
        }

        private void ResetAllPanlesTextsDashInclude()
        {

        }


        private void BtnAccount_Click(object sender, EventArgs e)
        {
            PnlAccount.Visible = true;
            PnlReturnBook.Visible = false;
            PnlTrackingOrders.Visible = false;
            PnlNewOrders.Visible = false;
            PnlLibraryApp.Visible = false;
            BtnTrackingAllOrders.BackColor = Color.CornflowerBlue;
            BtnCreateOrder.BackColor = Color.CornflowerBlue;
            BtnReturnBook.BackColor = Color.CornflowerBlue;
            BtnAccount.BackColor = Color.RoyalBlue;
        }

        private void BtnSelectDate_Click(object sender, EventArgs e)
        {
            DgvTrackingAccount.Rows.Clear();

            List<OrderItem> orders = _context.OrderItems.Include("Book").Include("Order").Include("Order.Costumer").Where(o => o.ReturnDate <= dateTimePickerAccount1.Value && o.Order.CreatedDate <= dateTimePickerAccount2.Value).ToList();

            foreach (var item in orders)
            {
                DgvTrackingAccount.Rows.Add(item.Id,
                                        item.Order.Costumer.FirstName,
                                        item.Order.Costumer.LastName,
                                        item.Book.Name,
                                        item.Count,
                                        item.Order.CreatedDate,
                                        item.ReturnDate,
                                        item.PayPrice);

            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Hesabatlar";

            for (int i=1; i<DgvTrackingAccount.Columns.Count+1; i++)
            {
                worksheet.Cells[1,i] = DgvTrackingAccount.Columns[i - 1].HeaderText;
            }
            for (int i=0; i<DgvTrackingAccount.Rows.Count; i++)
            {
                for (int j=0; j <DgvTrackingAccount.Columns.Count; j++)
                {
                    if (DgvTrackingAccount.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = DgvTrackingAccount.Rows[i].Cells[j].Value.ToString();
                    }
                        
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Hesabat";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void LblLibraryManager_Click(object sender, EventArgs e)
        {
            PnlLibraryApp.Visible = true;
            PnlAccount.Visible = false;
            PnlNewOrders.Visible = false;
            PnlReturnBook.Visible = false;
            PnlTrackingOrders.Visible = false;

            BtnTrackingAllOrders.BackColor = Color.CornflowerBlue;
            BtnCreateOrder.BackColor = Color.CornflowerBlue;
            BtnReturnBook.BackColor = Color.CornflowerBlue;
            BtnAccount.BackColor = Color.CornflowerBlue;
        }

        private void BtnExport_MouseEnter(object sender, EventArgs e)
        {
            BtnExport.BackColor = Color.RoyalBlue;
        }

        private void BtnExport_MouseLeave(object sender, EventArgs e)
        {
            BtnExport.BackColor = Color.RoyalBlue;
        }

        

        private void BtnSubmitOrders_MouseEnter(object sender, EventArgs e)
        {
            BtnSubmitOrders.BackColor = Color.DarkGreen;
        }

        private void BtnSubmitOrders_MouseLeave(object sender, EventArgs e)
        {
            BtnSubmitOrders.BackColor = Color.ForestGreen;
        }

        private void BtnRSearch_MouseEnter(object sender, EventArgs e)
        {
            BtnRSearch.BackColor = Color.DodgerBlue;
        }

        private void BtnRSearch_MouseLeave(object sender, EventArgs e)
        {
            BtnRSearch.BackColor = Color.DeepSkyBlue;
        }

        private void BtnRBSubmit_MouseEnter(object sender, EventArgs e)
        {
            BtnRBSubmit.BackColor = Color.DodgerBlue;
        }

        private void BtnRBSubmit_MouseLeave(object sender, EventArgs e)
        {
            BtnRBSubmit.BackColor = Color.DeepSkyBlue;
        }

        private void BtnTrackingToday_MouseEnter(object sender, EventArgs e)
        {
            BtnTrackingToday.BackColor = Color.DodgerBlue;
        }

        private void BtnTrackingToday_MouseLeave(object sender, EventArgs e)
        {
            BtnTrackingToday.BackColor = Color.DeepSkyBlue;
        }

        private void BtnTrackingTomorrow_MouseEnter(object sender, EventArgs e)
        {
            BtnTrackingTomorrow.BackColor = Color.DodgerBlue;
        }

        private void BtnTrackingTomorrow_MouseLeave(object sender, EventArgs e)
        {
            BtnTrackingTomorrow.BackColor = Color.DeepSkyBlue;
        }

        private void BtnAllfalseOrders_MouseEnter(object sender, EventArgs e)
        {
            BtnAllfalseOrders.BackColor = Color.DodgerBlue;
        }

        private void BtnAllfalseOrders_MouseLeave(object sender, EventArgs e)
        {
            BtnAllfalseOrders.BackColor = Color.DeepSkyBlue;
        }

        private void BtnAddNewOrderNew_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            if (!ValidateBookCountOnStock())
            {

                return;
            }

            var money = Convert.ToDecimal(LblPriceOrderLbl.Text);

            DgvBookDashboard.Rows.Add(_selectedbook.Id, _selectedbook.Name, NmrBookCount.Value, DateReturnDay.Value, money);

            _selectedbook.Count += Convert.ToInt32(NmrBookCount.Value);

            CmbCostumerOrder.Enabled = false;
            CmbBookOrder.Text = string.Empty;
            NmrBookCount.Value = 0;
            LblPriceOrderLbl.Text = " ";
            BtnRemoveList.Visible = false;
            BtnSubmitOrders.Visible = true;
            BtnAddNewOrderNew.Enabled = false;
            _totalmoney += money;

            LblPriceAllbooks.Text = _totalmoney.ToString();

            BtnPnlResetForm();
            DateReturnDay.Enabled = false;
            NmrBookCount.Enabled = false;
            LblPriceOrderLbl.Enabled = false;
            PctEmptyBasket.Visible = false;
            PctFullBasket.Visible = true;
        }

        private void BtnAddNewOrderNew_MouseEnter(object sender, EventArgs e)
        {
            BtnAddNewOrderNew.BackColor = Color.DodgerBlue;
        }

        private void BtnAddNewOrderNew_MouseLeave(object sender, EventArgs e)
        {
            BtnAddNewOrderNew.BackColor = Color.DeepSkyBlue;
        }

        private void NmrBookCount_ValueChanged_1(object sender, EventArgs e)
        {
            BtnAddNewOrderNew.Enabled = true;
            CalcMoneyCountAllBook();
            CalcMoneyFalseReturnDay();
        }

        private void DateReturnDay_ValueChanged_1(object sender, EventArgs e)
        {
            CalcMoneyFalseReturnDay();
            
            BtnAddNewOrderNew.Enabled = true;

        }
    }
}



//Umumi Panel ucun tracikng uun lazim olacaq
//    _context.OrderItems.Where(r => r.ReturnDate <= DateTime.Now).Select(r => new
//    {

//        r.Order.Costumer.FirstName,
//        r.Order.Costumer.LastName
//    }).ToList();
//}