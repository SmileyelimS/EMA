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
            InitDemoData();

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

        #endregion

        #region Methods

        private void InitDemoData()
        {
            CustomerData = new List<CustomerData>();
            CustomerData.Add(new CustomerData
            {
                CompanyName = "Friseursalon Velly",
                ContactPerson = "Max Mustermann",
                Street = "Lingusterweg",
                HouseNumber = "12",
                ZipCode = 74852,
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

            var totalPrice = totalPriceDouble.ToString("0.00 €");

            TotalPrice = totalPrice;
        }
        #endregion

    }
}
