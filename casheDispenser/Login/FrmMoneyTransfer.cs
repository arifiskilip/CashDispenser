using DataAccess.Concrete;
using Entities.Concrete;
using Login.Concrete;
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
    public partial class FrmMoneyTransfer : Form
    {
        public FrmMoneyTransfer()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            FrmMainScreen mainScreen = new FrmMainScreen();
            LogDal logDal = new LogDal();
            using (CashDispenserContext context = new CashDispenserContext())
            {
                if (MessageBox.Show(txtMoney.Text + " TL gönderim işlemini onaylıyormusunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Transection transection = new Transection();
                    FrmLogin.person.Money -= decimal.Parse(txtMoney.Text);
                    int id = Convert.ToInt32(txtCustomerId.Text);
                    var person2 = context.Customers.FirstOrDefault(p => p.Id == id);
                    person2.Money+= decimal.Parse(txtMoney.Text);
                    if (person2.NationalIdentityNumber == person2.NationalIdentityNumber)
                    {
                        transection.MoneyTransfer(FrmLogin.person, person2);
                        mainScreen.Show();
                        logDal.Add(new Log { CustomerId = FrmLogin.person.Id, LogType = "Para Transferi", Description = (-1 * int.Parse(txtMoney.Text)).ToString(), Date = DateTime.Now });
                        logDal.Add(new Log { CustomerId = int.Parse(txtCustomerId.Text), LogType = "Para Transferi", Description = (+1 * int.Parse(txtMoney.Text)).ToString(), Date = DateTime.Now });
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen göndericinin bilgilerini kontrol ediniz.");
                    }
                    
                }
                else
                {
                    {
                        MessageBox.Show("TL gönderim işlemi tarafınızca iptal edilmiştir.", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainScreen.Show();
                    }
                }
            }
        }
    }
}
