using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBizPos.Models
{
    internal class TransactionClass
    {
        public int transaction_id { get; set; }
        public int customer_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public double total { get; set; }
        public DateTime date { get; set; }
    }
}
