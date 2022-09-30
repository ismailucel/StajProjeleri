using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Concrete
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public double Quantity { get; set; }

        public int? CustomerId { get; set; }


        public int? ProductId { get; set; }


        public int ProductPrice { get; set; }


        [NotMapped]
        public double TotalAmount
        {
            get
            {
                return ProductPrice * Quantity;
            }
        }







    }
}
