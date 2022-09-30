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
    public partial class ProductForm : Form
    {
        EfProductRepository efproduct = new EfProductRepository();

        public ProductForm()
        {
            InitializeComponent();
            efproduct.loadproduct(dgvProduct,textBoxSearch);

        }


        private void uCProducts_Click(object sender, EventArgs e)
        {
            ProductModuleForm _productModuleForm = new ProductModuleForm();

            _productModuleForm.btnSave.Enabled = true;
            _productModuleForm.btnUpdate.Enabled = false;
            _productModuleForm.ShowDialog();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModuleForm productModule = new ProductModuleForm();
                productModule.textBoxId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.textBoxProductName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.textBoxPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.textBoxQuantity.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.textBoxDescription.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.comboBoxCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModule.btnSave.Enabled = false;
                productModule.btnUpdate.Enabled = true;
                productModule.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    efproduct.deleteProduct(dgvProduct, e);
                }
            }
            efproduct.loadproduct(dgvProduct,textBoxSearch);
        }
        

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            efproduct.loadproduct(dgvProduct,textBoxSearch);
        }
    }
}
