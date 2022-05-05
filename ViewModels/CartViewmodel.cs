using EMA.Models;
using System.Collections.Generic;
using System.Linq;

namespace EMA.ViewModels
{
    public class CartViewModel :ViewModelBase
    {
        public CartViewModel(List<CartItem> cartItems, string sum)
        {
            Sum = sum;
            CartItems = cartItems;
        }

        private string _sum;
        public string Sum 
        {
            get => _sum;
            set
            {
                _sum = value;
                OnPropertyChange();
            }
        }

        private List<CartItem> _cartItems;

        public List<CartItem> CartItems
        {
            get => _cartItems;
            set 
            { 
                _cartItems = value;
                OnPropertyChange();
            }
        }

        public void CalculateSum()
        {
            Sum = SumCalculator.CalculateSumCart(CartItems);
        }

        public void DeleteEmptyCartItem()
        {
            CartItems = DeleteOfEmptyItems.DeleteEmptyItem(CartItems);
        }
    }
}
