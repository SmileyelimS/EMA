using EMA.Models;
using System.Collections.Generic;

namespace EMA.ViewModels
{
    public class CartViewModel :ViewModelBase
    {
        public CartViewModel(Dictionary<Items, int> dictionaryCartItems, string sum)
        {
            Sum = sum;
            CartItems = dictionaryCartItems;
        }

        public string Sum { get; set; }
        public Dictionary<Items, int> CartItems { get; set; }
    }
}
