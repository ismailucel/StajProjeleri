using StockManagement.Business.Concrete;
using StockManagement.DataAccess;
using StockManagement.DataAccess.AdoNET;
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
    public partial class CategoryForm : Form
    {
        AdoCategoryRepository efCategory = new AdoCategoryRepository();
        public CategoryForm()
        {
            InitializeComponent();
            efCategory.loadcategory(dgvCategory);
           
        }

       

        private void uCCategory_Click(object sender, EventArgs e)
        {
            CategoryModuleForm _categorymoduleform = new CategoryModuleForm();

            _categorymoduleform.btnSave.Enabled = true;
            _categorymoduleform.btnUpdate.Enabled = false;
            _categorymoduleform.ShowDialog();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryModuleForm categoryModule = new CategoryModuleForm();
                categoryModule.textBoxId.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryModule.textBoxName.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
                categoryModule.textBoxDescription.Text = dgvCategory.Rows[e.RowIndex].Cells[3].Value.ToString();


                categoryModule.btnSave.Enabled = false;
                categoryModule.btnUpdate.Enabled = true;
                categoryModule.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this caregory?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    efCategory.deletecategory(dgvCategory, e);
                }
            }
            efCategory.loadcategory(dgvCategory);
        }
    }
}
