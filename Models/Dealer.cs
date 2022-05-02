namespace EMA.Models
{
    public class Dealer
    {
        public int DealerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
        public string EMailAddress { get; set; }
        public string Website { get; set; }
        public int MinimumOrderValueEUR { get; set; }
        public int FreeDeliveryFromEUR { get; set; }
        public int StandardDeliveryDeEUR { get; set; }
        public int ExpressDeliveryDeEUR { get; set; }
    }
}
