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
    public partial class FrmMainScreen : Form
    {
        public FrmMainScreen()
        {
            InitializeComponent();
        }

        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {

                lblFirstName.Text = FrmLogin.person.FirstName;
                lblLastName.Text = FrmLogin.person.LastName;
                lblMoney.Text = FrmLogin.person.Money.ToString();
                lblNationalIdentity.Text = FrmLogin.person.NationalIdentityNumber;
            }

        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            FrmWithdrawMoney frmWithdrawMoney = new FrmWithdrawMoney();
            frmWithdrawMoney.Show();
            this.Hide();
        }

        private void btnDepositFunds_Click(object sender, EventArgs e)
        {
            FrmDepositFunds frmDepositFunds = new FrmDepositFunds();
            frmDepositFunds.Show();
            this.Hide();
        }

        private void btnMoneyTransfer_Click(object sender, EventArgs e)
        {
            FrmMoneyTransfer frmMoneyTransfer = new FrmMoneyTransfer();
            frmMoneyTransfer.Show();
            this.Hide();
        }

        private void btnMotionDump_Click(object sender, EventArgs e)
        {
            FrmMotionDump frmMotionDump = new FrmMotionDump();
            frmMotionDump.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.Show();
            this.Hide();
        }
    }
}
