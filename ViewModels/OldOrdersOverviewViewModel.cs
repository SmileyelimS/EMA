using EMA.Models;
using System;
using System.Collections.Generic;

namespace EMA.ViewModels
{
    public class OldOrdersOverviewViewModel : ViewModelBase
    {
        public OldOrdersOverviewViewModel()
        {
            InitDemoData();
        }

        public List<Orders> OldOrders { get; set; }

        private void InitDemoData()
        {
            var customer = new CustomerData
            {
                CompanyName = "Friseursalon Velly",
                ContactPerson = "Max Mustermann"
            };

            OldOrders = new List<Orders>();
            OldOrders.Add(new Orders()
            {
                OrdersID = 1,
                CustomerDataID = 1,
                OrderDate = new DateTime(2022,04,21),
                TotalPriceEUR = 177566,
                BillViaAddress = true,
                BillViaEMail = true,
                CustomerData = customer
            });
            OldOrders.Add(new Orders()
            {
                OrdersID = 2,
                CustomerDataID = 1,
                OrderDate = new DateTime(2022, 03, 30),
                TotalPriceEUR = 108077,
                BillViaAddress = false,
                BillViaEMail = true,
                CustomerData= customer
            });
            OldOrders.Add(new Orders()
            {
                OrdersID = 3,
                CustomerDataID = 1,
                OrderDate = new DateTime(2022, 05, 02),
                TotalPriceEUR = 66666,
                BillViaAddress = true,
                BillViaEMail = false,
                CustomerData = customer 
            });
        }
    }
}
