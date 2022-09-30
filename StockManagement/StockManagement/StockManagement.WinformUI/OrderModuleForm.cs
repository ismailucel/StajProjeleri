using StockManagement.Business.Concrete;
using StockManagement.DataAccess.EntityFramework;
using StockManagement.Entities.Concrete;
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
    public partial class OrderModuleForm : Form
    {
        EfCustomerRepository efcustomer = new EfCustomerRepository();
        EfProductRepository efproduct = new EfProductRepository();
        EfOrderRepository eforder = new EfOrderRepository();
        OrderManager _ordermanager = new OrderManager();
        int quantity = 0;
        public OrderModuleForm()
        {
            InitializeComponent();
            efcustomer.loadCustomerInOrders(dgvCustomer, textBoxCustomerSearch);
            efproduct.loadproduct(dgvProduct, textBoxProductSearch);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void textBoxCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            efcustomer.loadCustomerInOrders(dgvCustomer, textBoxCustomerSearch);
        }

        private void textBoxProductSearch_TextChanged(object sender, EventArgs e)
        {
            efproduct.loadproduct(dgvProduct, textBoxProductSearch);
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCustomerID.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();

         
        }
        

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
           
            if(Convert.ToInt16(numericQuantity.Value) > quantity)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericQuantity.Value = numericQuantity.Value - 1;
                return;
            }
            if(Convert.ToInt16(numericQuantity.Value) >0)
            {
                int total = Convert.ToInt16(textBoxProductPrice.Text) * Convert.ToInt16(numericQuantity.Value);
                textBoxTotal.Text = total.ToString();
            }
            
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCustomerID.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProductId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxProductName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxProductPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
          //  quantity = Convert.ToInt16(dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;

        }

        public void Clear()
        {
            textBoxCustomerID.Clear();
            textBoxCustomerName.Clear();
            textBoxCustomerSearch.Clear();
            textBoxProductId.Clear();
            textBoxProductName.Clear();
            textBoxProductPrice.Clear();
            textBoxProductSearch.Clear();
            textBoxTotal.Clear();


        }

        public void GetQty()
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm;
            SqlDataReader dr;

            cm = new SqlCommand("SELECT Quantity FROM Products WHERE Id ='"+textBoxProductId.Text +"'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                quantity = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cmd = new SqlCommand("INSERT INTO Orders(OrderDate,Quantity, ProductId, ProductPrice, CustomerId) VALUES (@OrderDate, @Quantity, @ProductId,@ProductPrice,@CustomerId)", con);

            cmd.Parameters.AddWithValue("@OrderDate", lblDateTimePicker.Value);
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(numericQuantity.Value));
            cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(textBoxProductId.Text));
            cmd.Parameters.AddWithValue("@ProductPrice", Convert.ToInt32(textBoxProductPrice.Text));
            cmd.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(textBoxCustomerID.Text));
            MessageBox.Show("Order added");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            cmd = new SqlCommand("UPDATE Products SET Quantity=(Quantity-@Quantity) Where Id LIKE '" + textBoxProductId.Text + "' ", con);
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(numericQuantity.Value));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Clear();
            efproduct.loadproduct(dgvProduct, textBoxProductSearch);

        }

      


        

       
    }
}
