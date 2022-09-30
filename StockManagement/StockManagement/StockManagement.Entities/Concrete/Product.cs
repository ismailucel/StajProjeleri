using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Concrete
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }

        public string Description { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


    }
}
