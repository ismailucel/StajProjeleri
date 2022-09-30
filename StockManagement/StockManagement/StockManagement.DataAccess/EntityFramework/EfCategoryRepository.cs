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
    
    public class EfCategoryRepository:GenericRepository<Category>, ICategoryDal
    {
        public bool AddcategoryDAL(string CategoryName, string Description)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cmd = new SqlCommand("AddCategory @CategoryName,@Description", con);
            cmd.Parameters.Add(new SqlParameter("@CategoryName", CategoryName));
            cmd.Parameters.Add(new SqlParameter("@Description", Description));


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
        public void loadcategory(DataGridView dgvCategory)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            int i = 0;
            dgvCategory.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Categories", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(),dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void deletecategory(DataGridView dvgCategory, DataGridViewCellEventArgs e)
        {

            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            con.Open();
            cm = new SqlCommand("DELETE FROM Categories WHERE Id LIKE '" + dvgCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted");
        }
        public bool UpdatecategoryDAL(int Id,string CategoryName, string Description)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cmd = new SqlCommand("UpdateCategory @Id, @CategoryName,@Description", con);
            cmd.Parameters.Add(new SqlParameter("@Id", Id));
            cmd.Parameters.Add(new SqlParameter("@CategoryName", CategoryName));
            cmd.Parameters.Add(new SqlParameter("@Description", Description));


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

    }
}
