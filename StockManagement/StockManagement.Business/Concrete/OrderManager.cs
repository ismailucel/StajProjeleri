using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.DataAccess.AdoNET;
using StockManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderdal;
        public OrderManager(IOrderDal orderdal)
        {
            _orderdal = orderdal;
        }
        public OrderManager()
        {

        }
        public void TAdd(Order entity)
        {
            _orderdal.Add(entity);
        }

        public void TDelete(Order entity)
        {
            _orderdal.Delete(entity);
        }

        public List<Order> TGetAll()
        {
            return _orderdal.GetAll().ToList();
        }

        public Order TGetById(int id)
        {
            return _orderdal.GetById(id);
        }

        public void TUpdate(Order entity)
        {
            _orderdal.Update(entity);
        }
       /* public string AddOrderBL(DateTime OrderDate, double Quantity, int ProductId, int ProductPrice,int CustomerId, DateTimePicker lblDateTimePicker, NumericUpDown numericQuantity, TextBox textBoxProductId, TextBox textBoxProductPrice, TextBox textBoxCustomerID)
        {
            string isOrderValid = "true";
            if (isOrderValid == "true")
            {
                AdoOrderRepository orderDAL = new AdoOrderRepository();
                bool isDone = orderDAL.AddorderDAL(OrderDate, Quantity, ProductId, ProductPrice, CustomerId, lblDateTimePicker, numericQuantity, textBoxProductId, textBoxProductPrice, textBoxCustomerID);
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
                return isOrderValid;
            }

        }*/
    }
}
