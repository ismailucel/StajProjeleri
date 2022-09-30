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

namespace StockManagement.DataAccess.EntityFramework
{
    public class EfCustomerRepository:GenericRepository<Customer>,ICustomerDal
    {
        public bool AddcustomerDAL(string Address, string City,string PhoneNumber,string FullName)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cmd = new SqlCommand("AddCustomer @Address,@City,@PhoneNumber,@FullName", con);
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@City", City));
            cmd.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
            cmd.Parameters.Add(new SqlParameter("@FullName", FullName));



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
        public bool UpdatecustomerDAL(int Id, string Address, string City, string PhoneNumber, string FullName)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cmd = new SqlCommand("UpdateCustomer @Id, @Address,@City,@PhoneNumber,@FullName", con);
            cmd.Parameters.Add(new SqlParameter("@Id", Id));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@City", City));
            cmd.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
            cmd.Parameters.Add(new SqlParameter("@FullName", FullName));


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
        public void loadcustomer(DataGridView dgvCustomer)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Customers", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void loadCustomerInOrders(DataGridView dgvCustomer, TextBox txtSearch)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Customers WHERE CONCAT(Address, City, PhoneNumber, FullName) LIKE '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }


        public void deletecustomer(DataGridView dgvCustomer, DataGridViewCellEventArgs e)
        {

            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            con.Open();
            cm = new SqlCommand("DELETE FROM Customers WHERE Id LIKE '" + dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted");
        }

    }
}
