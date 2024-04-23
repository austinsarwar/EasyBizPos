using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBizPos.Models
{
    public class CartItem
    {
        public int ProductId { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public CartItem()
        {
        }

        public CartItem(int productId, string name, decimal price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }

        public CartItem(int productId, string name, decimal price, int quantity)
            : this(productId, name, price) // Calls the base constructor
        {
            Quantity = quantity;
        }

        public void setQuantity(int quantity)
        {
            this.Quantity = quantity;
        }

        public int getQuantity()
        {
            return this.Quantity;
        }
    }
}
