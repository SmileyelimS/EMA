using EMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMA.ViewModels
{
    public class OldOrderViewModel
    {
        public OldOrderViewModel(Orders oldOrder)
        {
            OldOrder = oldOrder;

            InitDemoData();
        }

        public Orders OldOrder { get; set; }
        public List<OrderedItems> OrderedItems { get; set; }

        public void InitDemoData()
        {
            var dealer = new Dealer
            {
                CompanyName = "Schwarzkopf",
                MinimumOrderValueEUR = 5000,
                FreeDeliveryFromEUR = 8000,
                StandardDeliveryDeEUR = 399,
                DealerID = 1
            };
            var dealer2 = new Dealer
            {
                CompanyName = "Mach Irgendwas",
                MinimumOrderValueEUR = 5000,
                FreeDeliveryFromEUR = 20000,
                StandardDeliveryDeEUR = 399,
                DealerID = 2
            };

            var items = new List<Items>();
            for (int i = 0; i < 8; i++)
            {
                items.Add(new Items
                {
                    ItemID = 1,
                    Picture = "Haarfarbe.png",
                    Name = "Schwarzkopf Brilliance 890",
                    Description = "Haarfarbe Schwarz",
                    Dealer = dealer2,
                    DealerItemNumber = 12077448,
                });
                items.Add(new Items
                {
                    ItemID = 2,
                    Picture = "Shampoo.png",
                    Name = "Schwarzkopf Shampoo Repair&Care",
                    Description = "Pflegeshampoo für trockenes und geschädigtes Haar",
                    Dealer = dealer,
                    DealerItemNumber = 12077666,
                });
                items.Add(new Items
                {
                    ItemID = 3,
                    Picture = "Spülung.png",
                    Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                    Description = "Pflegespülung für normales Haar",
                    Dealer = dealer,
                    DealerItemNumber = 12077556,
                });
            }

            OrderedItems = new List<OrderedItems>();
            OrderedItems.Add(new OrderedItems
            {
                OrdersID = 1,
                ItemFromOrder = items.First(),
                VolumePack = 100,
                VolumeUnitPack = "ml",
                SelledAmount = 12,
                SelledUnit = "Stk",
                PriceUnitEUR = 4999,
                SelledAmountItem = 3
            });
            OrderedItems.Add(new OrderedItems
            {
                OrdersID = 2,
                ItemFromOrder = items.Last(),
                VolumePack = 250,
                VolumeUnitPack = "ml",
                SelledAmount = 10,
                SelledUnit = "Stk",
                PriceUnitEUR = 5599,
                SelledAmountItem = 5
            });
            OrderedItems.Add(new OrderedItems
            {
                OrdersID = 3,
                ItemFromOrder = items[1],
                VolumePack = 1000,
                VolumeUnitPack = "ml",
                SelledAmount = 6,
                SelledUnit = "Stk",
                PriceUnitEUR = 6699,
                SelledAmountItem = 10
            });
        }
    }
}
