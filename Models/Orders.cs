using System;

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
    }
}
