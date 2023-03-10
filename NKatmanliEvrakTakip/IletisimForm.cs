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
using DataAccess.Concrete.EntityFramework;
using Business.Concrete;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace EvrakTakipSistemi
{
    public partial class IletisimFormu : Form
    {

        public IletisimFormu()
        {

            InitializeComponent();
        }
        public string id;
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());



        private void IletisimFormu_Load(object sender, EventArgs e)
        {
            int ID = int.Parse(tbxId.Text = id);
            var customer = customerManager.GetAll(ID);
            if (customer != null)
            {
                foreach (var customers in customer)
                {
                     tbxVKN.Text =customers.TaxIdentificationNumber ;
                    tbxAd.Text = customers.CompanyName ;
                    mskTel.Text = customers.Phone ;
                    tbxEmail.Text = customers.Email ;
                }

            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


        }
    }
}
