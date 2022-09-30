using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }

        public string Address { get; set; }

        public string Password { get; set; }

        public string City { get; set; }


        
    }
}