﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMA.Models
{
    public class Items
    {
        public int ItemID { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int VolumePack { get; set; }
        public string VolumeUnitPack { get; set; }
        public int SelledAmount { get; set; }
        public string SelledUnit { get; set; }
        public int PriceSelledUnitEUR { get; set; }
        public Dealer Dealer{ get; set; }
        public int DealerItemNumber { get; set; }
        public string Availability { get; set; }
        public string DeliveryTime { get; set; }

        public string PicturePath => $@"C:\Users\nsiebrands\Documents\Projekt Schule\Bilder\Datenbank bsp\{Picture}";
        public string PackageVolume => $"{VolumePack}" + " " + $"{VolumeUnitPack}";
        public string SelledAmountString => $"{SelledAmount}" + " " + $"{SelledUnit}";
        public string ArticleNumber => $"Art.Nr.:" + " " + $"{DealerItemNumber}";
        public string CompanyName => $"{Dealer.CompanyName}";

        public double Price => PriceSelledUnitEUR / 100d;
        public string PriceText => $"{Price.ToString("0.00")}" + " " + $"€";
    }
}
