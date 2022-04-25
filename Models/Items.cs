using System;
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
        public string CompanyName { get; set; }
        public int DealerItemNumber { get; set; }
        public string Availability { get; set; }
        public string DeliveryTime { get; set; }

        public string PicturePath => $@"C:\Users\nsiebrands\Documents\Projekt Schule\Bilder\Datenbank bsp\{Picture}";
    }
}
