using Business.ValidationRules;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvrakTakipSistemi
{
    public partial class IletısımKayıt : Form
    {
        public IletısımKayıt()
        {
            InitializeComponent();
        }


        CommunicationValidator validator = new CommunicationValidator();


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string tel, email;
                tel = mskTelefon.Text;
                email = tbxEmail.Text;
                var customer = new Customer { Phone = tel, Email = email };
                var result = validator.Validate(customer);
                if (result.IsValid)
                {
                    AnaForm.tel = tel;
                    AnaForm.email = email;
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("İletişim bilgileri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    string errorMessage = string.Join("\n", result.Errors.Select(error => error.ErrorMessage));
                    MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {

                MessageBox.Show("İletişim bilgileri kaydedilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
