namespace EMA.Models
{
    public class Dealer
    {
        public int DealerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string EMailAddress { get; set; }
        public string Website { get; set; }
        public int MinimumOrderValueEUR { get; set; }
        public int FreeDeliveryFromEUR { get; set; }
        public int StandardDeliveryDeEUR { get; set; }

        public string ContactPersonText => "Ansprechpartner:" + " " + $"{ContactPerson}";
        public string StreetText => $"{Street}" + " " + $"{HouseNumber}";
        public string CityText => $"{ZipCode}" + " " + $"{City}";
    }
}
