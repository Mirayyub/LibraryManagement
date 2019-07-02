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
        private readonly LibraryContext _context;

        private LibraryManagement.Model.Book _selectedBook;
        public BookPg()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillBookData();
        }

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

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            LibraryManagement.Model.Book book = new LibraryManagement.Model.Book();

            book.Name = TxtBookName.Text;
            book.Price = Convert.ToInt32(TxtBookPrice.Text);
            book.Count = Convert.ToInt32(NmrCount.Text);



            List<LibraryManagement.Model.Book> boook = _context.Books.Where(b => b.Name.Contains(TxtBookName.Text)).ToList();

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

            _selectedBook.Name = TxtBookName.Text;
            _selectedBook.Price = Convert.ToDecimal(TxtBookPrice.Text);
            _selectedBook.Count = Convert.ToInt32(NmrCount.Text);

            _context.SaveChanges();

            FillBookData();
            ResetBookForm();
            ButtonReset();

            MessageBox.Show("Seçilmiş Kitab Haqqında Məlumatlar Yeniləndi","Yeniləndi");


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

                _selectedBook = _context.Books.Find(Id);

                TxtBookName.Text = _selectedBook.Name;
                TxtBookPrice.Text = _selectedBook.Price.ToString();
                NmrCount.Value = _selectedBook.Count;

            }

            
        }

        private void BtnBookDelete_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Kitab və Kitab Haqqında Məlumatlar Silinsin?", "Kitab Silinsin", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                _context.Books.Remove(_selectedBook);

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


            List<LibraryManagement.Model.Book> books = _context.Books.Where(b => b.Name.Contains(TxtSerachBox.Text)).ToList();

            foreach (var item in books)
            {
               dgvBook.Rows.Add(item.Id,
                                    item.Name,
                                    item.Count,
                                    item.Price);
            }


        }
    }
}
