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
        private int cartItemCount = 0;
        private Cart()
        {

        }
        public static Cart Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Cart();
                }
                return instance;
            }


        }
        public void Add(CartItem item)
        {
            int id = item.ProductId;
            cartTotalPrice += item.Price;
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
            cartItemCount = 0;
        }
    }
}