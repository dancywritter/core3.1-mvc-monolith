using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core3._1_mvc_monolith.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Pizza Pizza { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
