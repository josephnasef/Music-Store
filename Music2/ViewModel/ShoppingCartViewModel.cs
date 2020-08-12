using Music2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music2.ViewModel
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}