using StockManagement.Business.Concrete;
using StockManagement.DataAccess.AdoNET;
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
    public partial class ProductModuleForm : Form
    {
        ProductManager _productManager = new ProductManager();
        AdoProductRepository _efproduct = new AdoProductRepository();
        public ProductModuleForm()
        {
            InitializeComponent();
            _efproduct.loadCategory(comboBoxCategory);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string isDone = _productManager.AddProductBL(textBoxProductName.Text, int.Parse(textBoxPrice.Text), int.Parse(textBoxQuantity.Text), textBoxDescription.Text,int.Parse(comboBoxCategory.Text));
                if (isDone == "true")
                {
                    MessageBox.Show("Product added successfuly..");
                }
                else
                {
                    MessageBox.Show(isDone + "Try again..");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


       
        public void Clear()
        {
            textBoxDescription.Clear();
            textBoxPrice.Clear();
            textBoxQuantity.Clear();
            textBoxProductName.Clear();
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                string isDone = _productManager.UpdateProductBL(int.Parse(textBoxId.Text), textBoxProductName.Text, int.Parse(textBoxPrice.Text), int.Parse(textBoxQuantity.Text), textBoxDescription.Text, int.Parse(comboBoxCategory.Text));
                if (isDone == "true")
                {
                    MessageBox.Show("Product updated successfuly..");
                }
                else
                {
                    MessageBox.Show(isDone + "Try again..");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        /* private void btnClear_Click(object sender, EventArgs e)
         {
             Clear();
             btnSave.Enabled = true;
             btnUpdate.Enabled = true;
         }*/


    }
}

