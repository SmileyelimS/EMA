namespace EMA.Models
{
    public class CartItem
    {
        public Item Item { get; set; }
        public string FreeDeliveryFrom
        {
            get { return FreeDeliveryFromText(); }
        }

        public int Count 
        { 
            get; 
            set; 
        }

        public CartItem(Item item)
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

        public string FreeDeliveryFromText()
        {
            string value = (Item.Dealer.FreeDeliveryFromEUR / 100d).ToString("0.00 €");
            string text = "Kostenlose Lieferung ab: ";
            return text + value;
        }
    }
}
