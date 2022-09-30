using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.DataAccess.AdoNET;
using StockManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydall;

        public CategoryManager(ICategoryDal categorydall)
        {
            _categorydall = categorydall;
        }
        public CategoryManager()
        {
            
        }

        public void TAdd(Category entity)
        {
            _categorydall.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _categorydall.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categorydall.GetAll().ToList();
        }

        public Category TGetById(int id)
        {
            return _categorydall.GetById(id);
        }

        public void TUpdate(Category entity)
        {
            _categorydall.Update(entity);
        }
        public string AddCategoryBL(string CategoryName, string Description)
        {
            string isCategoryValid = "true";
            if (isCategoryValid == "true")
            {
                AdoCategoryRepository categoryDAL = new AdoCategoryRepository();
                bool isDone = categoryDAL.AddcategoryDAL(CategoryName, Description);
                if (isDone != true)
                {
                    return "Server error, ";
                }
                else
                {
                    return "true";
                }
            }
            else
            {
                return isCategoryValid;
            }

        }

        public string UpdateCategoryBL(int Id, string CategoryName, string Description)
        {
            string isCategoryValid = "true";
            if (isCategoryValid == "true")
            {
                AdoCategoryRepository categoryDAL = new AdoCategoryRepository();
                bool isDone = categoryDAL.UpdatecategoryDAL(Id, CategoryName, Description);
                if (isDone != true)
                {
                    return "Server error, ";
                }
                else
                {
                    return "true";
                }
            }
            else
            {
                return isCategoryValid;
            }

        }
    }
}
