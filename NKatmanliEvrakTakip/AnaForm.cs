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
            dataGridView1.DataSource = customerManager.GetCustomerDto();
        }
    }

}
