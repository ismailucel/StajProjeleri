using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.DataAccess.EntityFramework;
using StockManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;
        public ProductManager()
        {

        }
        public string AddProductBL(string ProductName,double Price,double Quantity, string Description,int CategoryId)
        {
            string isProductValid = "true";
            if (isProductValid == "true")
            {
                EfProductRepository productDAL = new EfProductRepository();
                bool isDone = productDAL.AddproductDAL(ProductName,Price,Quantity, Description, CategoryId);
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
                return isProductValid;
            }

        }

        public string UpdateProductBL(int Id, string ProductName, double Price, double Quantity, string Description, int CategoryId)
        {
            string isProductValid = "true";
            if (isProductValid == "true")
            {
                EfProductRepository productDAL = new EfProductRepository();
                bool isDone = productDAL.UpdateproductDAL(Id, ProductName, Price, Quantity, Description, CategoryId);
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
                return isProductValid;
            }

        }
        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }
        public void TAdd(Product entity)
        {
            _productdal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productdal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _productdal.GetAll().ToList();
        }

        public Product TGetById(int id)
        {
            return _productdal.GetById(id);
        }

        public void TUpdate(Product entity)
        {
            _productdal.Update(entity);
        }
    }
}
