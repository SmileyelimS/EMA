using EMA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMA.ViewModels
{
    public class OldOrderViewModel
    {
        public OldOrderViewModel(Order oldOrder)
        {
            OldOrder = oldOrder;

            InitOrderedItems();
        }

        public Order OldOrder { get; set; }
        public List<OrderedItem> OrderedItems { get; set; }

        private void InitOrderedItems()
        {
            var context = new EmaContext();
            OrderedItems = context.OrderedItems
                .Include(x => x.Items)
                .ThenInclude(x => x.Dealer)
                .Where(x => x.OrdersID == OldOrder.OrdersID)
                .ToList();
        }

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

            var items = new List<Item>();
            for (int i = 0; i < 8; i++)
            {
                items.Add(new Item
                {
                    ItemID = 1,
                    Picture = "Haarfarbe.png",
                    Name = "Schwarzkopf Brilliance 890",
                    Description = "Haarfarbe Schwarz",
                    Dealer = dealer2,
                    DealerItemNumber = 12077448,
                });
                items.Add(new Item
                {
                    ItemID = 2,
                    Picture = "Shampoo.png",
                    Name = "Schwarzkopf Shampoo Repair&Care",
                    Description = "Pflegeshampoo für trockenes und geschädigtes Haar",
                    Dealer = dealer,
                    DealerItemNumber = 12077666,
                });
                items.Add(new Item
                {
                    ItemID = 3,
                    Picture = "Spülung.png",
                    Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                    Description = "Pflegespülung für normales Haar",
                    Dealer = dealer,
                    DealerItemNumber = 12077556,
                });
            }

            OrderedItems = new List<OrderedItem>();
            OrderedItems.Add(new OrderedItem
            {
                OrdersID = 1,
                Items = items.First(),
                VolumePack = 100,
                VolumeUnitPack = "ml",
                SelledAmount = 12,
                SelledUnit = "Stk",
                PriceUnitEUR = 4999,
                SelledAmountItem = 3
            });
            OrderedItems.Add(new OrderedItem
            {
                OrdersID = 2,
                Items = items.Last(),
                VolumePack = 250,
                VolumeUnitPack = "ml",
                SelledAmount = 10,
                SelledUnit = "Stk",
                PriceUnitEUR = 5599,
                SelledAmountItem = 5
            });
            OrderedItems.Add(new OrderedItem
            {
                OrdersID = 3,
                Items = items[1],
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
