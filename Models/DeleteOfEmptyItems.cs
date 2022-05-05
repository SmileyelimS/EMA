using System.Collections.Generic;
using System.Linq;

namespace EMA.Models
{
    public static class DeleteOfEmptyItems
    {
        public static List<CartItem> DeleteEmptyItem(List<CartItem> ItemsToUpdate)
        {
            var updatedItems = ItemsToUpdate.ToList();

            foreach (var item in updatedItems)
            {
                if (item.Count == 0)
                {
                    ItemsToUpdate.Remove(item);
                }
            }

            return ItemsToUpdate;
        }
    }
}
