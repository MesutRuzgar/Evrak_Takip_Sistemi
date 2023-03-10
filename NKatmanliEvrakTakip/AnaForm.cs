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
            GetList();
        }

        private void GetList()
        {
            dataGridView1.DataSource = customerManager.GetCustomerDto();
        }
        private void Clear()
        {
            tbxId.Text = string.Empty;
            mskVkn.Text = string.Empty;
            tbxAd.Text = string.Empty;
            tbxVergiYili.Text = string.Empty;
            tbxFaaliyetBelgesiTarih.Text = string.Empty;
            tbxImzaSirkusuTarih.Text = string.Empty;
            rtbxFirmaYetkili.Text = string.Empty;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clear();
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
