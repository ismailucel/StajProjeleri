using StockManagement.DataAccess.EntityFramework;
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
    public partial class OrderForm : Form
    {
        EfOrderRepository orderRepository = new EfOrderRepository();

        public OrderForm()
        {
            InitializeComponent();
            orderRepository.loadqtyTotal(dgvOrder,lblQtyBottom,lblTotalBottom);
        }

        private void uCOrder_Click(object sender, EventArgs e)
        {
            OrderModuleForm orderModule = new OrderModuleForm();
            orderModule.btnSave.Enabled = true;
            orderModule.ShowDialog();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvOrder.Columns[e.ColumnIndex].Name;
         
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    orderRepository.deleteorder(dgvOrder, e);
                }
            }
            orderRepository.loadorder(dgvOrder);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            orderRepository.loadorder(dgvOrder,textBoxSearch);
            
        }

        
    }
}
