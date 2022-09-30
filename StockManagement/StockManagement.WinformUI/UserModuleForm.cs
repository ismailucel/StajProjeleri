using StockManagement.Business.Concrete;
using StockManagement.DataAccess.AdoNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.WinformUI
{
    public partial class UserModuleForm : Form
    {
        MyUserManager _usermanager = new MyUserManager();
        
       

        public UserModuleForm()
        {
            InitializeComponent();
        }

     
        public void Clear()
        {
            textBoxId.Clear();
            textBoxUserName.Clear();
            textBoxFullName.Clear();
            textBoxAddress.Clear();
            textBoxPassword.Clear();
            textBoxCity.Clear();

        }
   
     

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string isDone = _usermanager.AddUserBL(textBoxUserName.Text, textBoxFullName.Text, textBoxPassword.Text, textBoxAddress.Text, textBoxCity.Text);
                if (isDone == "true")
                {
                    MessageBox.Show("User added successfuly..");
                }
                else
                {
                    MessageBox.Show(isDone + "Try again..");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string isDone = _usermanager.UpdateUserBL(int.Parse(textBoxId.Text), textBoxUserName.Text, textBoxFullName.Text, textBoxPassword.Text, textBoxAddress.Text, textBoxCity.Text);
                if (isDone == "true")
                {
                    MessageBox.Show("User updated successfuly..");
                }
                else
                {
                    MessageBox.Show(isDone + "Try again..");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
