using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace NKatmanliEvrakTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerManager customerManager =new CustomerManager(new EfCustomerDal());
            dataGridView1.DataSource=customerManager.GetAll();
        }
    }
}