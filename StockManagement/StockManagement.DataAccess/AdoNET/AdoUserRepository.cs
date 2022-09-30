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
    
    public class AdoUserRepository:GenericRepository<User>, IUserDal
    {
        public bool AdduserDAL(string UserName, string FullName, string Password,string Address,string City)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cmd = new SqlCommand("AddUser @UserName,@FullName,@Password,@Address,@City", con);
            cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
            cmd.Parameters.Add(new SqlParameter("@FullName", FullName));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@City", City));


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
         public bool UpdateuserDAL(int Id,string Address, string City, string Password, string FullName, string UserName)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cmd = new SqlCommand("UpdateUser @Id, @Address,@City,@Password,@FullName,@UserName", con);
            cmd.Parameters.Add(new SqlParameter("@Id", Id));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@City", City));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cmd.Parameters.Add(new SqlParameter("@FullName", FullName));
            cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
            
            
            
           


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



        public void loaduser(DataGridView dgvUser)
        {
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Users", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

       

        public void deleteuser(DataGridView dgvUser, DataGridViewCellEventArgs e)
        {
            
            SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
            SqlCommand cm = new SqlCommand();
            con.Open();
            cm = new SqlCommand("DELETE FROM Users WHERE Id LIKE '" + dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted");
        }

        public void login(TextBox txtUserName,TextBox txtPassword,Form main)
        {
            try
            {
                SqlConnection con = new SqlConnection("server =(localdb)\\MSSQLLocalDB; database=StockManagement; integrated security=true;");
                SqlCommand cm = new SqlCommand("SELECT * FROM Users WHERE UserName=@UserName AND Password=@Password",con);
                cm.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cm.Parameters.AddWithValue("@Password", txtPassword.Text);
                con.Open();
                SqlDataReader dr;
                dr = cm.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    MessageBox.Show("Welcome" + dr["FullName"].ToString() + " | ", "ACCESS SUCCESFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "ACCESS FAILS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }




    }
}
