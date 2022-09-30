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

    public partial class CustomerForm : Form
    {
        AdoCustomerRepository efCustomer = new AdoCustomerRepository();

        public CustomerForm()
        {
            InitializeComponent();
            efCustomer.loadcustomer(dgvCustomer);
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModuleForm customerModule = new CustomerModuleForm();

                customerModule.textBoxId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModule.textBoxAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerModule.textBoxCity.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                customerModule.textBoxPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                customerModule.textBoxFullName.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();

                customerModule.btnSave.Enabled = false;
                customerModule.btnUpdate.Enabled = true;
                customerModule.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    efCustomer.deletecustomer(dgvCustomer, e);
                }
            }
            efCustomer.loadcustomer(dgvCustomer);
        }

        private void uCCustomer_Click(object sender, EventArgs e)
        {
            CustomerModuleForm _customerModuleForm = new CustomerModuleForm();

            _customerModuleForm.btnSave.Enabled = true;
            _customerModuleForm.btnUpdate.Enabled = false;
            _customerModuleForm.ShowDialog();
        }
    }
}
