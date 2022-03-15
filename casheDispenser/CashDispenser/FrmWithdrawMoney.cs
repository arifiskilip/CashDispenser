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
    public partial class FrmWithdrawMoney : Form
    {
        public FrmWithdrawMoney()
        {
            InitializeComponent();
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            FrmMainScreen mainScreen = new FrmMainScreen();
            LogDal logDal = new LogDal();
            using (CashDispenserContext context = new CashDispenserContext())
            {
                if (MessageBox.Show(txtMoney.Text + " TL çekim işlemini onaylıyormusunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Transection transection = new Transection();
                    FrmLogin.person.Money -= decimal.Parse(txtMoney.Text);
                    transection.WithdrawMoney(FrmLogin.person);    
                    mainScreen.Show();
                    logDal.Add(new Log { Date = DateTime.Now, Description = (-1 * decimal.Parse(txtMoney.Text)).ToString(), LogType = "Para Çekme",CustomerId=FrmLogin.person.Id });
                    this.Hide();
                }
                else
                {
                    {
                        MessageBox.Show("TL çekim işlemi tarafınızca iptal edilmiştir.", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainScreen.Show();
                    }
                }
            }
            
        }
    }
}
