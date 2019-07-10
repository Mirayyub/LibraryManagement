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
    public partial class BookPg : Form
    {
        #region Connections Database
        private readonly LibraryContext _context;
        #endregion

        #region Models 
        private Book _selectedbook;
        #endregion


        public BookPg()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillBookData();
        }


        #region Buttons
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            Book book = new Book();
            book.Name = TxtBookName.Text;
            book.Price = Convert.ToInt32(TxtBookPrice.Text);
            book.Count = Convert.ToInt32(NmrCount.Text);


            List<Book> boook = _context.Books.Where(b => b.Name.Contains(TxtBookName.Text)).ToList();

            foreach (var item in boook)
            {
                if (item.Name == book.Name)
                {
                    LblBookName.ForeColor = Color.Red;
                    MessageBox.Show("Kitabxanada eyni kitab olduğu üçün əlavə olunmadı.");
                    ResetBookForm();
                    return;
                }
            }
            _context.Books.Add(book);
            _context.SaveChanges();

            FillBookData();
            ResetBookForm();

            MessageBox.Show("Yeni Kitab Əlavə Olundu!");
        }
        private void BtnBookUpdate_Click(object sender, EventArgs e)
        {

            if (!Validation())
            {
                return;
            }

            _selectedbook.Name = TxtBookName.Text;
            _selectedbook.Price = Convert.ToDecimal(TxtBookPrice.Text);
            _selectedbook.Count = Convert.ToInt32(NmrCount.Text);

            _context.SaveChanges();

            FillBookData();
            ResetBookForm();
            ButtonReset();

            MessageBox.Show("Seçilmiş Kitab Haqqında Məlumatlar Yeniləndi", "Yeniləndi");


        }
        private void DgvBook_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            BtnAddBook.Visible = false;
            BtnBookDelete.Visible = true;
            BtnBookUpdate.Visible = true;

            ResetBookForm();

            foreach (var item in _context.Books.ToList())
            {

                int Id = Convert.ToInt32(dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString());

                _selectedbook = _context.Books.Find(Id);

                TxtBookName.Text = _selectedbook.Name;
                TxtBookPrice.Text = _selectedbook.Price.ToString();
                NmrCount.Value = _selectedbook.Count;

            }


        }

        private void BtnBookDelete_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Kitab və Kitab Haqqında Məlumatlar Silinsin?", "Kitab Silinsin", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                _context.Books.Remove(_selectedbook);

                _context.SaveChanges();


                FillBookData();
                ResetBookForm();
                ButtonReset();

                MessageBox.Show("Kitab və Kitab haqqında Məlumatlar silindi.", "Silindi");
            }

        }

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {

            ButtonReset();
            dgvBook.Rows.Clear();


            List<Book> books = _context.Books.Where(b => b.Name.Contains(TxtSerachBox.Text)).ToList();

            foreach (var item in books)
            {
                dgvBook.Rows.Add(item.Id,
                                     item.Name,
                                     item.Count,
                                     item.Price);
            }


        }
        #endregion


        #region KeyPress

        private void TxtBookPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion


        #region Functions

        private void FillBookData()
        {
            dgvBook.Rows.Clear();
            foreach (var item in _context.Books.ToList())
            {
                dgvBook.Rows.Add(item.Id,
                                 item.Name,
                                 item.Price,
                                 item.Count);
            }


        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(TxtBookName.Text))
            {
                LblBookName.ForeColor = Color.Red;
                LblBookPrice.ForeColor = SystemColors.ControlText;
                LblBookCount.ForeColor = SystemColors.ControlText;

                return false;
            }
            if (string.IsNullOrEmpty(TxtBookPrice.Text))
            {
                LblBookName.ForeColor = SystemColors.ControlText;
                LblBookPrice.ForeColor = Color.Red;
                LblBookCount.ForeColor = SystemColors.ControlText;

                return false;
            }
            if (NmrCount.Text == "0")
            {
                LblBookName.ForeColor = SystemColors.ControlText;
                LblBookPrice.ForeColor = SystemColors.ControlText;
                LblBookCount.ForeColor = Color.Red;

                return false;
            }

            return true;

        }

        private void ResetBookForm()
        {
            TxtBookName.Text = string.Empty;
            TxtBookPrice.Text = string.Empty;
            NmrCount.Text = "0";

            LblBookName.ForeColor = SystemColors.ControlText;
            LblBookPrice.ForeColor = SystemColors.ControlText;
            LblBookCount.ForeColor = SystemColors.ControlText;
        }
        private void ButtonReset()
        {
            BtnAddBook.Visible = true;
            BtnBookUpdate.Visible = false;
            BtnBookDelete.Visible = false;
        }
        #endregion









    }
}
