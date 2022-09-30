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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;
        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }
        public CustomerManager()
        {

        }
        public void TAdd(Customer entity)
        {
            _customerdal.Add(entity);
        }

        public void TDelete(Customer entity)
        {
            _customerdal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerdal.GetAll().ToList();
        }

        public Customer TGetById(int id)
        {
            return _customerdal.GetById(id);
        }

        public void TUpdate(Customer entity)
        {
            _customerdal.Update(entity);
        }
        public string AddCustomerBL(string Address, string City, string PhoneNumber, string FullName)
        {
            string isCustomerValid = "true";
            if (isCustomerValid == "true")
            {
                EfCustomerRepository customerDAL = new EfCustomerRepository();
                bool isDone = customerDAL.AddcustomerDAL(Address, City, PhoneNumber, FullName);
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
                return isCustomerValid;
            }

        }
        public string UpdateCustomerBL(int Id, string Address, string City, string PhoneNumber, string FullName)
        {
            string isCustomerValid = "true";
            if (isCustomerValid == "true")
            {
                EfCustomerRepository customerDAL = new EfCustomerRepository();
                bool isDone = customerDAL.UpdatecustomerDAL(Id, Address, City, PhoneNumber, FullName);
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
                return isCustomerValid;
            }

        }
    }
}
