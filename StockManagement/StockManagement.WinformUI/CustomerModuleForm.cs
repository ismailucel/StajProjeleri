using StockManagement.Business.Concrete;
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
    public partial class CustomerModuleForm : Form
    {
        CustomerManager _customerManager = new CustomerManager();

        public CustomerModuleForm()
        {
            InitializeComponent();
        }

       
        public void Clear()
        {
            textBoxCity.Clear();
            textBoxFullName.Clear();
            textBoxAddress.Clear();
            textBoxPhone.Clear();

        }



    

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string isDone = _customerManager.AddCustomerBL(textBoxAddress.Text, textBoxCity.Text, textBoxPhone.Text, textBoxFullName.Text);
                if (isDone == "true")
                {
                    MessageBox.Show("Customer added successfuly..");
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

                string isDone = _customerManager.UpdateCustomerBL(int.Parse(textBoxId.Text), textBoxAddress.Text, textBoxCity.Text, textBoxPhone.Text, textBoxFullName.Text);

                if (isDone == "true")
                {
                    MessageBox.Show("Customer updated successfuly..");
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
