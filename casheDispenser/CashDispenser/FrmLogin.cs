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

    public partial class FrmLogin : Form
    {
        public static Customer person;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Exit
        {
            this.Close();
        }



        private void button3_Click(object sender, EventArgs e) //Register
        {
            FrmRegister register = new FrmRegister();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {
                bool success = false;
                var result = context.Customers.ToList();
                foreach (var item in result)
                {
                    if (item.NationalIdentityNumber == textBox1.Text && item.Password == textBox2.Text)
                    {
                        person = context.Customers.FirstOrDefault(p => p.Id == item.Id);
                        success = true;
                        break;
                    }
                }
                if (success)
                {
                    FrmMainScreen mainScreen = new FrmMainScreen();
                    mainScreen.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı şifre hatalı");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}