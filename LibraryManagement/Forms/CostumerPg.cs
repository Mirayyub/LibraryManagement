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
    public partial class CostumerPg : Form
    {
        private readonly LibraryContext _context;

        private Costumer _selectedcostumer;
        public CostumerPg()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillCostumerData();
        }

        private void FillCostumerData()
        {
            dgvCostumerlist.Rows.Clear();

            foreach (var item in _context.Costumers.ToList())
            {
                dgvCostumerlist.Rows.Add(item.Id,
                                 item.FirstName,
                                 item.LastName,
                                 item.Email,
                                 item.PhoneNo);
            }
        }
        private bool Validation()
        {
            if (string.IsNullOrEmpty(TxtFirstName.Text))
            {
                LblFirstName.ForeColor = Color.Red;
                LblLastName.ForeColor = SystemColors.ControlText;
                LblPhoneNumber.ForeColor = SystemColors.ControlText;
                LblEmail.ForeColor = SystemColors.ControlText;
                

                return false;
            }
            if (string.IsNullOrEmpty(TxtLastName.Text))
            {
                LblLastName.ForeColor = Color.Red;
                LblFirstName.ForeColor = SystemColors.ControlText;
                LblEmail.ForeColor = SystemColors.ControlText;
                LblPhoneNumber.ForeColor = SystemColors.ControlText;

                return false;
            }
            if (string.IsNullOrEmpty(TxtPhoneNumber.Text))
            {
                LblFirstName.ForeColor = SystemColors.ControlText;
                LblLastName.ForeColor = SystemColors.ControlText;
                LblPhoneNumber.ForeColor = Color.Red;
                LblEmail.ForeColor = SystemColors.ControlText;

                return false;
            }
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                LblFirstName.ForeColor = SystemColors.ControlText;
                LblLastName.ForeColor = SystemColors.ControlText;
                LblPhoneNumber.ForeColor = SystemColors.ControlText;
                LblEmail.ForeColor = Color.Red;

                return false;
            }
            

            return true;

        }
        private void ResetCostumerForm()
        {
            TxtEmail.Text = string.Empty;
            TxtFirstName.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtPhoneNumber.Text = string.Empty;
            


            LblFirstName.ForeColor = SystemColors.ControlText;
            LblLastName.ForeColor = SystemColors.ControlText;
            LblEmail.ForeColor = SystemColors.ControlText;
            LblPhoneNumber.ForeColor = SystemColors.ControlText;
        }

        private void ButtonCostumerReset()
        {
            BtnCostumerAdd.Visible = true;
            BtnCostumerUpdate.Visible = false;
            BtnCostumerDelete.Visible = false;
        }

        private void BtnCostumerAdd_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            Costumer cost = new Costumer();

            cost.FirstName = TxtFirstName.Text;
            cost.LastName = TxtLastName.Text;
            cost.Email = TxtEmail.Text;
            cost.PhoneNo= TxtPhoneNumber.Text;


            List<Costumer> cost1 = _context.Costumers.Where(c => c.FirstName.Contains(TxtFirstName.Text)).ToList();

            foreach (var item in cost1)
            {
                if (item.FirstName == cost.FirstName)
                {
                    LblFirstName.ForeColor = Color.Red;
                    MessageBox.Show("Eyni Adlı Müştəri Olduğu Üçün Şəxs Əlavə Olunmadı", "Diqqət!");
                    ResetCostumerForm();
                    return;
                }
            }
            _context.Costumers.Add(cost);
            _context.SaveChanges();

            MessageBox.Show("Yeni Müştəri Əlavə Olundu!");

            FillCostumerData();
            ResetCostumerForm();

            
        }

        private void BtnSearchCostumer_Click(object sender, EventArgs e)
        {
            ButtonCostumerReset();
            dgvCostumerlist.Rows.Clear();


            List<Costumer> costs = _context.Costumers.Where(c => c.FirstName.Contains(TxtSearchCostumer.Text)).ToList();

            foreach (var item in costs)
            {
                dgvCostumerlist.Rows.Add(item.Id,                                     
                                     item.FirstName,
                                     item.LastName,
                                     item.PhoneNo,
                                     item.Email);
            }

        }

        private void BtnCostumerDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Müştəri Haqqında Məlumatlar Silinsin?", "Müştəri Silinsin", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                _context.Costumers.Remove(_selectedcostumer);

                _context.SaveChanges();


                FillCostumerData();
                ResetCostumerForm();
                ButtonCostumerReset();

                MessageBox.Show("Müştəri Haqqında Məlumatlar silindi.", "Silindi");
            }
        }

        private void BtnCostumerUpdate_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            _selectedcostumer.FirstName = TxtFirstName.Text;
            _selectedcostumer.LastName = TxtLastName.Text;
            _selectedcostumer.PhoneNo = TxtPhoneNumber.Text;
            _selectedcostumer.Email = TxtEmail.Text;

            _context.SaveChanges();


            MessageBox.Show("Müştəri Haqqında Məlumatlar Yenilənsin?", "Məlumatlar Yenilənsin", MessageBoxButtons.YesNo);

            FillCostumerData();
            ResetCostumerForm();
            ButtonCostumerReset();
            MessageBox.Show("Seçilmiş Müştəri Haqqında Məlumatlar Yeniləndi", "Yeniləndi");


        }

        private void DgvCostumerlist_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnCostumerAdd.Visible = false;
            BtnCostumerDelete.Visible = true;
            BtnCostumerUpdate.Visible = true;

            ResetCostumerForm();

            foreach (var item in _context.Costumers.ToList())
            {

                int Id = Convert.ToInt32(dgvCostumerlist.Rows[e.RowIndex].Cells[0].Value.ToString());

                _selectedcostumer = _context.Costumers.Find(Id);

                TxtFirstName.Text = _selectedcostumer.FirstName;
                TxtLastName.Text = _selectedcostumer.LastName;
                TxtEmail.Text = _selectedcostumer.Email;
                TxtPhoneNumber.Text = _selectedcostumer.PhoneNo;
            }
        }
    }
}
