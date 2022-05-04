namespace EMA.Models
{
    public class CartItem
    {
        public Items Item { get; set; }
        public int Count 
        { 
            get; 
            set; 
        }

        public CartItem(Items item)
        {
            Item = item;
            Count = 1;
        }

        public void IncreaseCount()
        {
            Count++;
        }

        public double Sum()
        {
            return Item.Price * Count;
        }
    }
}
