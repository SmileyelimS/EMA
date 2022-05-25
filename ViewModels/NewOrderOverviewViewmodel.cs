using EMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EMA.ViewModels
{
    public class NewOrderOverviewViewModel :ViewModelBase
    {
        public NewOrderOverviewViewModel(string sumOrderItems, List<CartItem> orderItems)
        {
            InitCustomerData();

            ItemsForOrder = orderItems;
            SumItemsForOrder = sumOrderItems;

            CalculateTotalShipping();
            GetTotalPrice();
        }

        #region Properties

        private List<CustomerData> _customerData;
        public List<CustomerData> CustomerData
        {
            get { return _customerData; }
            set { _customerData = value; }
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

        private string _sumShipping;
        public string SumShipping
        {
            get { return _sumShipping; }
            set 
            { 
                _sumShipping = value;
                OnPropertyChange();
            }
        }

        public int SumShippingInt { get; set; }

        private string _totalPrice;
        public string TotalPrice
        {
            get { return _totalPrice; }
            set 
            { 
                _totalPrice = value;
                OnPropertyChange();
            }
        }

        private bool _billViaAddress;
        public bool BillViaAddress
        {
            get { return _billViaAddress; }
            set 
            { 
                _billViaAddress = value;
                OnPropertyChange();
            }
        }

        private bool _billViaEMail;
        public bool BillViaEMail
        {
            get { return _billViaEMail; }
            set
            {
                _billViaEMail = value;
                OnPropertyChange();
            }
        }

        public int TotalPriceInt { get; set; }

        public Order NewOrder { get; set; }
        public List<OrderedItem> OrderedItems { get; set; } = new List<OrderedItem>();

        #endregion

        #region Methods

        private void InitCustomerData()
        {
            var context = new EmaContext();
            CustomerData = context.CustomerDatas.ToList();
        }

        private void InitDemoData()
        {
            CustomerData = new List<CustomerData>();
            CustomerData.Add(new CustomerData
            {
                CompanyName = "Friseursalon Velly",
                ContactPerson = "Max Mustermann",
                Street = "Lingusterweg",
                HouseNumber = "12",
                ZipCode = "74852",
                City = "Musterstadt-Veihingen",
                PhoneNumber = "07445 7365409",
                EMailAddress = "friseursalon-velly@info.de"
            });
        }

            public void DeleteEmptyOrderItem()
        {
            ItemsForOrder = DeleteOfEmptyItems.DeleteEmptyItem(ItemsForOrder);
        }

        public void CalculateOrderSum()
        {
            SumItemsForOrder = SumCalculator.CalculateSumCart(ItemsForOrder);
        }
        
        public void CalculateTotalShipping()
        {
            var dealers = ItemsForOrder.GroupBy(x => x.Item.Dealer.DealerID).ToList();
            var deliveryCost = 0d;
            for (int i = 0; i < dealers.Count; i++)
            {
                var dealer = ItemsForOrder.First(x => x.Item.Dealer.DealerID == dealers[i].Key).Item.Dealer;
                var hasFreeDelivery = IsFreeDeliveryReached(ItemsForOrder, dealer);
                if (!hasFreeDelivery)
                {
                    deliveryCost += dealer.StandardDeliveryDeEUR / 100d;
                }
            }

            SumShippingInt = (int)(deliveryCost * 100);
            SumShipping = deliveryCost.ToString("0.00 €");
        }

        public bool IsFreeDeliveryReached(List<CartItem> cardItemsForDealer, Dealer dealer)
        {
            var sum = cardItemsForDealer.Where(x => x.Item.Dealer == dealer).Sum(x => x.Count * x.Item.Price);
            var minValue = dealer.FreeDeliveryFromEUR / 100d;
            return sum >= minValue;
        }

        public void GetTotalPrice()
        {
            string[] splitSumItemsForOrder = SumItemsForOrder.Split(" ");
            var onlyNumbersFromSumItemsForOrder = splitSumItemsForOrder[0];

            string[] splitSumShipping = SumShipping.Split(" ");
            var onlyNumbersFromSumShipping = splitSumShipping[0];

            double totalPriceDouble = Convert.ToDouble(onlyNumbersFromSumItemsForOrder) + Convert.ToDouble(onlyNumbersFromSumShipping);
            TotalPriceInt = (int)(totalPriceDouble*100);

            var totalPrice = totalPriceDouble.ToString("0.00 €");

            TotalPrice = totalPrice;
        }

        public void SetNewOrder()
        {
            NewOrder = new Order()
            {
                CustomerDataID = CustomerData.First().CustomerDataID,
                OrderDate = DateTime.Now,
                TotalPriceEUR = TotalPriceInt,
                BillViaAddress = BillViaAddress,
                BillViaEMail = BillViaEMail,
                Shipping = SumShippingInt 
            };
        }

        private void SetOrderedItems()
        {
            var itemsInCart = new List<Item>();
            ItemsForOrder = DeleteOfEmptyItems.DeleteEmptyItem(ItemsForOrder);

            foreach(CartItem cartItem in ItemsForOrder)
            {
                itemsInCart.Add(cartItem.Item);
            }

            foreach(Item i in itemsInCart)
            {
                OrderedItems.Add(new OrderedItem()
                { 
                    Items = i,
                    Orders = NewOrder,
                    VolumePack = i.VolumePack,
                    VolumeUnitPack = i.VolumeUnitPack,
                    SelledAmount = i.SelledAmount,
                    SelledUnit = i.SelledUnit,
                    PriceUnitEUR = i.PriceSelledUnitEUR,
                    SelledAmountItem = ItemsForOrder.First(x => x.Item.ItemID == i.ItemID).Count,
                });
            }
        }

        public void CompletePurchase()
        {
            SetNewOrder();
            SetOrderedItems();
            var contextOrders = new EmaContext();
            contextOrders.Add(NewOrder);
            contextOrders.AttachRange(OrderedItems);

            contextOrders.SaveChanges();
        }

        #endregion

    }
}
