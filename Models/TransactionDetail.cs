using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBizPos.Models
{
    internal class TransactionDetail
    {
        public int transactionDetailId { get; set; }
        public int transactionId { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        int quantity { get; set; }
        int price { get; set; }

    }
}
