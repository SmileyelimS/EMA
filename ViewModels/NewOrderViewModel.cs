using EMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMA.ViewModels
{
    public class NewOrderViewModel : ViewModelBase
    {
        public NewOrderViewModel()
        {
            InitDemoItems();
        }

        private List<Items> _items;

        public List<Items> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private void InitDemoItems()
        {
            var dealer = new Dealer();
            dealer.CompanyName = "Schwarzkopf";
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
                    //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
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
                    //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
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
                    //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                    Dealer = dealer,
                    DealerItemNumber = 12077556,
                    Availability = "Auf Lager",
                    DeliveryTime = "2-3  Werktage"
                });
            }
        }
    }
}
