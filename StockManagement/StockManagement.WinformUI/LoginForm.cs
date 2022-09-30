using StockManagement.DataAccess.AdoNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.WinformUI
{
    public partial class LoginForm : Form
    {
        AdoUserRepository efuser = new AdoUserRepository();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == false)
            {
                txtboxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtboxPassword.UseSystemPasswordChar = false;

            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtboxUsername.Clear();
            txtboxPassword.Clear();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit App","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                efuser.login(txtboxUsername, txtboxPassword,new MainForm());

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
