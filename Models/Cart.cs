using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EasyBizPos.Models
{
    internal class Cart
    {
        // This class is used to create a cart object that will be used to
        // store the products that the customer wants to buy
        public int product_id { get; set; }
        public string product_name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public Customer customer { get; set; }  
        public Transaction transaction { get; set; }

    }
}
