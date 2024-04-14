using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Controls.Primitives;

namespace EasyBizPos.Models
{
    internal class Cart
    {
        private static Cart instance;
        private Dictionary<int, int> idQuantityMap = new Dictionary<int, int>();
        private List<CartItem> cartList = new List<CartItem>();
        private decimal cartTotalPrice = 0;
        private decimal cartSubtotal = 0;
        private decimal cartTax = 0;
        private int cartItemCount = 0;
        private string customerName = null;
        private int? customerId = -1;
        private int transactionId = -1;
        private decimal changeDue = 0;

        private Cart()
        {

        }
        public static Cart Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Cart();
                }
                return instance;
            }


        }
        public void Add(CartItem item)
        {
            int id = item.ProductId;
            cartSubtotal = Math.Round(cartSubtotal + item.Price, 2);
            decimal taxRate = Convert.ToDecimal(ConfigManager.Instance.GetSalesTaxRate());
            cartTax = Math.Round(cartSubtotal * taxRate, 2);
            cartTotalPrice = cartSubtotal + cartTax;

            if (idQuantityMap.ContainsKey(id))
            {
                idQuantityMap[id] += 1;
            }
            else
            {
                idQuantityMap[id] = 1;
                cartList.Add(item);
            }
        }


        public void updateCartListQuantity()
        {
            foreach (var item in cartList)
            {
                item.setQuantity(idQuantityMap[item.ProductId]);
            }
        }

        public decimal GetCartSubtotal()
        {
            return cartSubtotal;
        }


        public decimal GetCartTotalPrice()
        {
            return cartTotalPrice;
        }

        public int GetQuantity(CartItem item)
        {
            int quantity = idQuantityMap[item.ProductId];
            return quantity;
        }

        public List<CartItem> getCart()
        {
            return this.cartList;
        }

        public void incrementCartItemCount()
        {
            cartItemCount++;
        }

        public int getCartItemCount()
        {
            return cartItemCount;
        }

        public void Clear()
        {
            idQuantityMap.Clear();
            cartList.Clear();
            cartTotalPrice = 0;
            cartSubtotal = 0;
            cartTax = 0;
            cartItemCount = 0;
            customerName = null;
            customerId = -1;
            transactionId = -1;
    }
        // Setter for customerName
        public void SetCustomerName(string name)
        {
            customerName = name;
        }

        // Getter for customerName
        public string GetCustomerName()
        {
            return customerName;
        }

        // Setter for customerId
        public void SetCustomerId(int? id)
        {
            customerId = id;
        }

        // Getter for customerId
        public int? GetCustomerId()
        {
            return customerId;
        }

        // Setter for transactionId
        public void SetTransactionId(int id)
        {
            transactionId = id;
        }

        // Getter for transactionId
        public int GetTransactionId()
        {
            return transactionId;
        }
        public void SetChange(decimal change)
        {
            changeDue = change;
        }
        public decimal GetChange() { return changeDue; }

    }
}
