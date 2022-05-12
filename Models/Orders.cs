﻿using System;

namespace EMA.Models
{
    public class Orders
    {
        public int OrdersID { get; set; }
        public int CustomerDataID { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalPriceEUR { get; set; }
        public bool BillViaAddress { get; set; }
        public bool BillViaEMail { get; set; }
        public CustomerData CustomerData { get; set; }

        public double Price => TotalPriceEUR / 100d;
        public string PriceText => $"{Price:0.00}" + " " + $"€";
        public string DateTimeText => $"{OrderDate:dd.MM.yyyy}";
        public string BillSendToAddressText => BillViaAddress ? "Ja" : "Nein";
        public string BillSendToEMailText => BillViaEMail ? "Ja" : "Nein";
    }
}
