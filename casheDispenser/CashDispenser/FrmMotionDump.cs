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
    public partial class FrmMotionDump : Form
    {
        public FrmMotionDump()
        {
            InitializeComponent();
        }


        private void FrmMotionDump_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            LogDal logDal = new LogDal();
            for (int i = 0; i < logDal.GetAll(FrmLogin.person.Id).Count(); i++)
            {
                dataGridView1.Rows.Add(logDal.GetAll(FrmLogin.person.Id)[i].CustomerId,FrmLogin.person.FirstName+" "+ FrmLogin.person.LastName,
                    logDal.GetAll(FrmLogin.person.Id)[i].Description, logDal.GetAll(FrmLogin.person.Id)[i].LogType, logDal.GetAll(FrmLogin.person.Id)[i].Date);
            }
        }
    }
}
