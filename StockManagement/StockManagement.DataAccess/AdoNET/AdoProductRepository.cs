using StockManagement.DataAccess.Abstract;
using StockManagement.DataAccess.Repositories;
using StockManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.DataAccess.AdoNET
{
    public class AdoProductRepository:GenericRepository<Product>,IProductDal
    {
        public bool AddproductDAL(string ProductName, double Price, double Quantity, string Description,int CategoryId)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cmd = new SqlCommand("AddProduct @ProductName,@Price,@Quantity,@Description,@CategoryId", con);
            cmd.Parameters.Add(new SqlParameter("@ProductName", ProductName));
            cmd.Parameters.Add(new SqlParameter("@Price", Price));
            cmd.Parameters.Add(new SqlParameter("@Quantity", Quantity));
            cmd.Parameters.Add(new SqlParameter("@Description", Description));
            cmd.Parameters.Add(new SqlParameter("@CategoryId", CategoryId));
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool UpdateproductDAL(int Id, string ProductName, double Price, double Quantity, string Description, int CategoryId)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cmd = new SqlCommand("UpdateProduct @Id, @ProductName,@Price,@Quantity,@Description,@CategoryId", con);
            cmd.Parameters.Add(new SqlParameter("@Id", Id));
            cmd.Parameters.Add(new SqlParameter("@ProductName", ProductName));
            cmd.Parameters.Add(new SqlParameter("@Price", Price));
            cmd.Parameters.Add(new SqlParameter("@Quantity", Quantity));
            cmd.Parameters.Add(new SqlParameter("@Description", Description));
            cmd.Parameters.Add(new SqlParameter("@CategoryId", CategoryId));






            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


       /* public void loadproduct(DataGridView dgvProduct)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Products ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }*/
        public void loadproduct(DataGridView dgvProduct,TextBox txt)
        {   
            int i = 0;
            dgvProduct.Rows.Clear();
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            
            
            cm = new SqlCommand("SELECT * FROM Products WHERE CONCAT(ProductName, Price, Quantity, Description, CategoryId) LIKE '%"+ txt.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void loadCategory(ComboBox comboboxCategory)
        {
            comboboxCategory.Items.Clear();
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand("SELECT CategoryName from Categories", con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboboxCategory.Items.Add(dr[0].ToString());
            }

            dr.Close();
            con.Close();
        }
        public void deleteProduct(DataGridView dgvProduct, DataGridViewCellEventArgs e)
        {

            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            con.Open();
            cm = new SqlCommand("DELETE FROM Users WHERE Id LIKE '" + dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted");
        }
    }
}
