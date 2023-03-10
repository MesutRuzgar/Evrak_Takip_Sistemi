using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace NKatmanliEvrakTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Customer c = new Customer();
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        private void Form1_Load(object sender, EventArgs e)
        {

          

            dataGridView1.DataSource = customerManager.GetCustomerDto();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            c.CompanyName = textBox2.Text;
            c.CompanyOfficials = null;
            c.Phone = null;
            c.Email = null;
            c.SignatureCircularDate = null;
            c.TaxIdentificationNumber = "12312312312";
            c.ActivityCertificateDate = null;
            c.ActivityCertificateDate = null;


            customerManager.Add(c);
        }
    }
}