using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBizPos.Models
{
    internal class Transaction
    {
        public int transaction_id { get; set; }
        public int? customer_id { get; set; }
        public string customer_name { get; set; }
        public decimal total { get; set; }
        public DateTime date { get; set; }
    }
}
