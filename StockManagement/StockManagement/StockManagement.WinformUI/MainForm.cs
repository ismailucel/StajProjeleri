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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childform);
            panelMain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit App", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void uCCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void uCProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void uCCustomers_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void uCUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void uCOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());

        }

        
    }
}
