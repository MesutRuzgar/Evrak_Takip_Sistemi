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

namespace EvrakTakipSistemi
{
    public partial class IletisimFormu : Form
    {
       
        public IletisimFormu()
        {
         
            InitializeComponent();
        }
        public string id;
        
        private void IletisimFormu_Load(object sender, EventArgs e)
        {
            tbxId.Text = id;
            


        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
