using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneNumber
{
    public partial class frmLogin : Form
    {
        public PhoneNumberDBEntities DB;
        public frmLogin()
        {
            DB = new PhoneNumberDBEntities();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty )
            {
                MessageBox.Show("please fill the boxes");
            }
            else
            {
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                var list = DB.LoginInfoes.Where(x => x.UserName == username && x.Password == password);
                if (list.Count() > 0)
                {
                    frmMain mainForm = new frmMain();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("username or password is not correct!");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
