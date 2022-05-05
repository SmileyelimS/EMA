using EMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMA.ViewModels
{
    public class NewOrderOverviewViewModel :ViewModelBase
    {
        public NewOrderOverviewViewModel(string sumOrderItems, List<CartItem> orderItems)
        {
            ItemsForOrder = orderItems;
            SumItemsForOrder = sumOrderItems;
        }

        private List<CartItem> _itemsForOrder = new List<CartItem>();
        public List<CartItem> ItemsForOrder
        {
            get { return _itemsForOrder; }
            set { _itemsForOrder = value; }
        }

        private string _sumItemsForOrder;
        public string SumItemsForOrder
        {
            get { return _sumItemsForOrder; }
            set
            {
                _sumItemsForOrder = value;
                OnPropertyChange();
            }
        }

        public void DeleteEmptyOrderItem()
        {
            ItemsForOrder = DeleteOfEmptyItems.DeleteEmptyItem(ItemsForOrder);
        }
    }

    
}
