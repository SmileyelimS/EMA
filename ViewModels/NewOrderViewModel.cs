using EMA.Models;
using System.Collections.Generic;
using System.Linq;

namespace EMA.ViewModels
{
    public class NewOrderViewModel : ViewModelBase
    {
        public NewOrderViewModel(string sum, List<CartItem> cartItems)
        {
            ItemsInCart = cartItems;
            SumCart = sum;
            InitDemoItems();
        }

        #region Properties

        private List<Items> _items;
        public List<Items> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private List<CartItem> _itemsInCart = new List<CartItem>();
        public List<CartItem> ItemsInCart
        {
            get { return _itemsInCart; }
            set { _itemsInCart = value; }
        }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;

                OnPropertyChange();
                OnPropertyChange(nameof(MyFilteredItems));
            }
        }

        private string _sumCart = "0 €";
        public string SumCart
        {
            get { return _sumCart; }
            set
            {
                _sumCart = value;
                OnPropertyChange();
            }
        }

        #endregion

        #region Methods

        private void InitDemoItems()
        {
            var dealer = new Dealer
            {
                CompanyName = "Schwarzkopf"
            };
            Items = new List<Items>();

            for (int i = 0; i < 8; i++)
            {
                Items.Add(new Items
                {
                    ItemID = 1,
                    Picture = "Haarfarbe.png",
                    Name = "Schwarzkopf Brilliance 890",
                    Description = "Haarfarbe Schwarz",
                    VolumePack = 100,
                    VolumeUnitPack = "ml",
                    SelledAmount = 10,
                    SelledUnit = "Stk",
                    PriceSelledUnitEUR = 4999,
                    Dealer = dealer,
                    DealerItemNumber = 12077448,
                    Availability = "Auf Lager",
                    DeliveryTime = "1-2  Werktage"
                });
                Items.Add(new Items
                {
                    ItemID = 2,
                    Picture = "Shampoo.png",
                    Name = "Schwarzkopf Shampoo Repair&Care",
                    Description = "Pflegeshampoo für trockenes und geschädigtes Haar",
                    VolumePack = 500,
                    VolumeUnitPack = "ml",
                    SelledAmount = 10,
                    SelledUnit = "Stk",
                    Dealer = dealer,
                    PriceSelledUnitEUR = 5999,
                    DealerItemNumber = 12077666,
                    Availability = "Auf Lager",
                    DeliveryTime = "1-2  Werktage"
                });
                Items.Add(new Items
                {
                    ItemID = 3,
                    Picture = "Spülung.png",
                    Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                    Description = "Pflegespülung für normales Haar",
                    VolumePack = 400,
                    VolumeUnitPack = "ml",
                    SelledAmount = 10,
                    SelledUnit = "Stk",
                    PriceSelledUnitEUR = 5599,
                    Dealer = dealer,
                    DealerItemNumber = 12077556,
                    Availability = "Auf Lager",
                    DeliveryTime = "2-3  Werktage"
                });
            }
        }

        public List<Items> MyFilteredItems
        {
            get
            {
                if (string.IsNullOrWhiteSpace(SearchText)) return Items;

                return Items.Where(x => x.Name.Contains(SearchText, System.StringComparison.OrdinalIgnoreCase) ||
                                   x.Description.Contains(SearchText, System.StringComparison.OrdinalIgnoreCase) ||
                                   x.VolumePack.ToString().Contains(SearchText, System.StringComparison.OrdinalIgnoreCase) ||
                                   x.Price.ToString().Contains(SearchText, System.StringComparison.OrdinalIgnoreCase) ||
                                   x.CompanyName.Contains(SearchText, System.StringComparison.OrdinalIgnoreCase) ||
                                   x.DealerItemNumber.ToString().Contains(SearchText, System.StringComparison.OrdinalIgnoreCase)).ToList();
            }
        }

        public void AddToCart(Items item)
        {
            var itemInList = ItemsInCart.FirstOrDefault(x => x.Item == item);

            if (itemInList is null)
            {
                ItemsInCart.Add(new CartItem(item));
            }
            else
            {
                itemInList.IncreaseCount();
            }

            SumCart = SumCalculator.CalculateSumCart(ItemsInCart);
            OnPropertyChange(nameof(ItemsInCart));
        }
        #endregion
    }
}
