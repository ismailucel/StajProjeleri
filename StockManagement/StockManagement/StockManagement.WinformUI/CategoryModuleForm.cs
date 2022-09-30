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
using StockManagement.Business.Concrete;
using StockManagement.DataAccess;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entities.Concrete;

namespace StockManagement.WinformUI
{
    public partial class CategoryModuleForm : Form
    {
        

        CategoryManager _categorymanager = new CategoryManager();

        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        

        public void Clear()
        {
            textBoxName.Clear();
            textBoxDescription.Clear();

        }

       

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string isDone = _categorymanager.AddCategoryBL(textBoxName.Text, textBoxDescription.Text);
                if (isDone == "true")
                {
                    MessageBox.Show("Category added successfuly..");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string isDone = _categorymanager.UpdateCategoryBL(int.Parse(textBoxId.Text), textBoxName.Text, textBoxDescription.Text);
                if (isDone == "true")
                {
                    MessageBox.Show("Category updated successfuly..");
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
    }
}
