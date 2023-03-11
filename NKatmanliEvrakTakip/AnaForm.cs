using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using Business.Validation;
using Business.ValidationRules;

namespace EvrakTakipSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {

            InitializeComponent();

        }
        public static string? tel;
        public static string? email;
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        dbAngunContext db = new dbAngunContext();
        CustomerValidator validator = new CustomerValidator();


        private void AnaForm_Load(object sender, EventArgs e)
        {
            FillCustomerTable();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbxId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                mskVkn.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxAd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxVergiYili.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                tbxFaaliyetBelgesiTarih.Text = DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString(), out DateTime dateFaaliyet) ? dateFaaliyet.ToShortDateString() : "";
                tbxImzaSirkusuTarih.Text = DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString(), out DateTime dateImza) ? dateImza.ToShortDateString() : "";

                rtbxFirmaYetkili.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value?.ToString();
            }
            catch
            {

                MessageBox.Show("Geçersiz işlem!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbxId.Text))
                {
                    int id = int.Parse(tbxId.Text);
                    var customer = db.Customers.Find(id);
                    if (customer != null)
                    {
                        customer.TaxIdentificationNumber = mskVkn.Text;
                        customer.CompanyName = tbxAd.Text;
                        customer.TaxPlateYear = tbxVergiYili.Text;
                        customer.ActivityCertificateDate = string.IsNullOrEmpty(tbxFaaliyetBelgesiTarih.Text) ? null : DateTime.Parse(tbxFaaliyetBelgesiTarih.Text);
                        customer.SignatureCircularDate = string.IsNullOrEmpty(tbxImzaSirkusuTarih.Text) ? null : DateTime.Parse(tbxImzaSirkusuTarih.Text);
                        customer.CompanyOfficials = rtbxFirmaYetkili.Text;
                        var validationResult = validator.Validate(customer);

                        // FluentValidation kullanarak verilerin doğruluğunu kontrol ediyoruz.
                        if (validationResult.IsValid)
                        {
                            customerManager.Update(customer);
                            MessageBox.Show("Güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillCustomerTable();
                            ClearForm();
                        }
                        else
                        {
                            // Hata mesajlarını gösteriyoruz.
                            string errorMessage = string.Join("\n", validationResult.Errors.Select(error => error.ErrorMessage));
                            MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir müşteri seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(tbxId.Text))
                {
                    int id = int.Parse(tbxId.Text);
                    var customer = db.Customers.Find(id);
                    if (customer != null)
                    {
                        customerManager.Delete(customer);
                        MessageBox.Show("Silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillCustomerTable();
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir müşteri seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

                MessageBox.Show("Silme işlemi sırasında bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.TaxIdentificationNumber = mskVkn.Text;
                customer.CompanyName = tbxAd.Text;
                customer.TaxPlateYear = tbxVergiYili.Text;
                customer.ActivityCertificateDate = string.IsNullOrEmpty(tbxFaaliyetBelgesiTarih.Text) ? null : DateTime.Parse(tbxFaaliyetBelgesiTarih.Text);
                customer.SignatureCircularDate = string.IsNullOrEmpty(tbxImzaSirkusuTarih.Text) ? null : DateTime.Parse(tbxImzaSirkusuTarih.Text);
                customer.CompanyOfficials = rtbxFirmaYetkili.Text;


                // FluentValidation kullanarak verilerin doğruluğunu kontrol ediyoruz.

                var validationResult = validator.Validate(customer);

                if (validationResult.IsValid)
                {
                    if (MessageBox.Show("İletişim bilgileri eklemek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IletısımKayıt fr = new IletısımKayıt();
                        DialogResult result2 = fr.ShowDialog();

                        if (result2 == DialogResult.OK)
                        {
                            customer.Phone = tel;
                            customer.Email = email;
                        }
                        else
                        {
                            customer.Phone = null;
                            customer.Email = null;
                        }
                    }

                    customerManager.Add(customer);
                    MessageBox.Show("Ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillCustomerTable();
                    ClearForm();
                }
                else
                {
                    // Hata mesajlarını gösteriyoruz.
                    string errorMessage = string.Join("\n", validationResult.Errors.Select(error => error.ErrorMessage));
                    MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ekleme işlemi sırasında bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxId.Text))
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IletisimFormu frm = new IletisimFormu();
                frm.id = tbxId.Text;
                frm.Show();
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource= customerManager.GetCustomerDto(tbxSearch.Text);
            Gecerlimi();
        }

        //METHODS
        private void ClearForm()
        {
            tbxId.Text = string.Empty;
            mskVkn.Text = string.Empty;
            tbxAd.Text = string.Empty;
            tbxVergiYili.Text = string.Empty;
            tbxFaaliyetBelgesiTarih.Text = string.Empty;
            tbxImzaSirkusuTarih.Text = string.Empty;
            rtbxFirmaYetkili.Text = string.Empty;
        }
        private void FillCustomerTable()
        {
            dataGridView1.DataSource = customerManager.GetCustomerDto();
            Gecerlimi();
        }
        private void Gecerlimi()
        {
            DataGridViewCellStyle renk = new DataGridViewCellStyle();
            DateTime bugun = DateTime.Today;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (!string.IsNullOrEmpty(row.Cells[5].Value?.ToString()))
                    {
                        DateTime dtDbImzaYili;
                        if (DateTime.TryParse(row.Cells[5].Value.ToString(), out dtDbImzaYili))
                        {
                            renk.BackColor = (dtDbImzaYili >= bugun) ? Color.YellowGreen : Color.Firebrick;
                            row.Cells[5].Style.BackColor = renk.BackColor;
                        }
                    }

                    if (!string.IsNullOrEmpty(row.Cells[4].Value?.ToString()))
                    {
                        DateTime dtDbFaaliyet;
                        if (DateTime.TryParse(row.Cells[4].Value.ToString(), out dtDbFaaliyet))
                        {
                            DateTime gecerliTarih = dtDbFaaliyet.AddDays(60);
                            renk.BackColor = (gecerliTarih >= bugun) ? Color.YellowGreen : Color.Firebrick;
                            row.Cells[4].Style.BackColor = renk.BackColor;
                        }
                    }

                    if (!string.IsNullOrEmpty(row.Cells[3].Value?.ToString()))
                    {
                        int buYil = bugun.Year;
                        int vergiYili = buYil - 1;
                        renk.BackColor = (row.Cells[3].Value.ToString() == Convert.ToString(vergiYili)) ? Color.YellowGreen : Color.Firebrick;
                        row.Cells[3].Style.BackColor = renk.BackColor;
                    }


                    if (string.IsNullOrEmpty(row.Cells[5].Value?.ToString()) &&
                        string.IsNullOrEmpty(row.Cells[4].Value?.ToString()) &&
                        string.IsNullOrEmpty(row.Cells[3].Value?.ToString()))
                    {
                        renk.BackColor = Color.White;
                    }
                }
            }
        }

       
    }

}


