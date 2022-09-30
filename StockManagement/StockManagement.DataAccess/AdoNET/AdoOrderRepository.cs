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
    public class AdoOrderRepository:GenericRepository<Order>,IOrderDal
    {
        public void deleteorder(DataGridView dgvOrder, DataGridViewCellEventArgs e)
        {

            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            con.Open();
            cm = new SqlCommand("DELETE FROM Orders WHERE Id LIKE '" + dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
            cm.ExecuteNonQuery();
            con.Close();

            cm = new SqlCommand("UPDATE Products SET Quantity=(Quantity+@Quantity) Where Id LIKE '" + dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString() + "' ", con);
            cm.Parameters.AddWithValue("@Quantity", Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString()));

            con.Open();
            cm.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("deleted");
        }


       
        public void loadorder(DataGridView dgvOrder)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm;
            SqlDataReader dr;
            int i = 0;
            dgvOrder.Rows.Clear();
            cm = new SqlCommand("SELECT O.Id, OrderDate,O.Quantity,O.ProductId,P.ProductName,ProductPrice,CustomerId,C.FullName FROM Orders AS O JOIN Customers AS C ON O.CustomerId = C.Id JOIN Products AS P ON O.ProductId=P.Id", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvOrder.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
           
            
        }

        public void loadqtyTotal(DataGridView dgvOrder,Label lblQtyBottom,Label lblTotalBottom)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm;
            SqlDataReader dr;
            int i = 0;
            double total = 0;
            dgvOrder.Rows.Clear();
            cm = new SqlCommand("SELECT O.Id, OrderDate,O.Quantity,O.ProductId,P.ProductName,ProductPrice,CustomerId,C.FullName FROM Orders AS O JOIN Customers AS C ON O.CustomerId = C.Id JOIN Products AS P ON O.ProductId=P.Id", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvOrder.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                total += Convert.ToInt32(dr[5].ToString());
            }
            dr.Close();
            con.Close();

            lblQtyBottom.Text = i.ToString();
            lblTotalBottom.Text = total.ToString();

        }

        public void loadorder(DataGridView dgvOrder,TextBox txtSearch)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm;
            SqlDataReader dr;
            int i = 0;
            dgvOrder.Rows.Clear();
            cm = new SqlCommand("SELECT O.Id, OrderDate,O.Quantity,O.ProductId,P.ProductName,ProductPrice,CustomerId,C.FullName FROM Orders AS O JOIN Customers AS C ON O.CustomerId = C.Id JOIN Products AS P ON O.ProductId=P.Id WHERE CONCAT(O.Id, OrderDate,O.Quantity,O.ProductId,P.ProductName,ProductPrice,CustomerId,C.FullName) LIKE '%"+txtSearch.Text +"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvOrder.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
