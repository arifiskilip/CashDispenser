using DataAccess.Concrete;
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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string OldPas, NewPas, NewPas2;
            OldPas = txtOldPas.Text;
            NewPas = txtNewPas.Text;
            NewPas2 = txtNewPasRetry.Text;
            FrmMainScreen frmMainScreen = new FrmMainScreen();

            CustomerDal customerDal = new CustomerDal();

            if (OldPas == FrmLogin.person.Password && NewPas == NewPas2)
            {
                FrmLogin.person.Password = NewPas;
                customerDal.Update(FrmLogin.person);
                MessageBox.Show("Şifre Başarıyla Değiştirildi.");
                frmMainScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı şifre girdiniz.");
                frmMainScreen.Show();
                this.Hide();

            }
        }
    }
}
