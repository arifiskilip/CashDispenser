using DataAccess.Concrete;
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

namespace Login
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender=cmbGender.Text,
                NationalIdentityNumber=txtNationalId.Text,
                Password=txtPassword.Text
            });

            MessageBox.Show("Kayıt Başarılı.!");
        }
    }
}
