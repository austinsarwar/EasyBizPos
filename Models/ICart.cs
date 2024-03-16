using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBizPos.Models
{
    internal interface ICart
    {
        void AddToCart(CartItem cartItem);
        void ClearCart();

        decimal GetTotalPrice();

    }
}
