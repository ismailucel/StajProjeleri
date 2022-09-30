using StockManagement.DataAccess.EntityFramework;
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
    public partial class UserForm : Form
    {
        EfUserRepository efUser = new EfUserRepository();
        public UserForm()
        {
            InitializeComponent();
            efUser.loaduser(dgvUser);
        }


        
        private void uCUser_Click(object sender, EventArgs e)
        {
            UserModuleForm _usermoduleform = new UserModuleForm();

            _usermoduleform.btnSave.Enabled = true;
            _usermoduleform.btnUpdate.Enabled = false;
            _usermoduleform.ShowDialog();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if(colName=="Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.textBoxId.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.textBoxUserName.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.textBoxFullName.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.textBoxPassword.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.textBoxAddress.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                userModule.textBoxCity.Text = dgvUser.Rows[e.RowIndex].Cells[6].Value.ToString();

                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.ShowDialog();

            }
            else if(colName =="Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this user?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    efUser.deleteuser(dgvUser, e);
                }
            }
            efUser.loaduser(dgvUser);
        }
    }
}
