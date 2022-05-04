using EMA.Models;
using System.Collections.Generic;

namespace EMA.ViewModels
{
    public class CartViewModel :ViewModelBase
    {
        public CartViewModel(List<CartItem> cartItems, string sum)
        {
            Sum = sum;
            CartItems = cartItems;
        }

        public string Sum { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
