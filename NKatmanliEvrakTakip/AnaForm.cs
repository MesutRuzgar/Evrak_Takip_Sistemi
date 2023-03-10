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

namespace EvrakTakipSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {

            InitializeComponent();

        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        private void AnaForm_Load(object sender, EventArgs e)
        {
            FillCustomerTable();
        }

        private void FillCustomerTable()
        {
            dataGridView1.DataSource = customerManager.GetCustomerDto();
            Gecerlimi();
        }
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
    }

}
