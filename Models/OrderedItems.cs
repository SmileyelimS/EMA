using System.Collections.Generic;

namespace EMA.Models
{
    public class OrderedItems
    {
        public int OrdersID { get; set; }
        public int ItemsID { get; set; }
        public Items ItemFromOrder { get; set; }
        public int VolumePack { get; set; }
        public string VolumeUnitPack { get; set; }
        public int SelledAmount { get; set; }
        public string SelledUnit { get; set; }
        public int PriceUnitEUR { get; set; }
        public int SelledAmountItem { get; set; }

        public double SumOfItem => PriceUnitEUR * SelledAmountItem / 100d;
        public string SumOfItemText => $"{SumOfItem.ToString("0.00")}" + " " + "€";
        public string PackageVolume => $"{VolumePack}" + " " + $"{VolumeUnitPack}";
        public string SelledAmountString => $"{SelledAmount}" + " " + $"{SelledUnit}";
        public double PriceUnit => PriceUnitEUR / 100d;
        public string PriceUnitText => $"{PriceUnit.ToString("0.00")}" + " " + $"€";
    }
}
