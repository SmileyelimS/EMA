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
        public List<CartItem> CartItems { get; set; }

        public void CalculateSum()
        {
            Sum = SumCalculator.CalculateSumCart(CartItems);
        }

        public void DeleteEmptyCartItem(List<CartItem> CartItemsToUpdate)
        {
            foreach (var item in CartItemsToUpdate)
            {
                if(item.Count == 0)
                {
                    CartItems.Remove(item);
                }
            }

            OnPropertyChange(nameof(CartItems));
        }
    }
}
