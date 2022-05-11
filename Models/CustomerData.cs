namespace EMA.Models
{
    public class CustomerData
    {
        public int CustomerDataID { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string EMailAddress { get; set; }

        public string StreetText => $"{Street}" + " " + $"{HouseNumber}";
        public string CityText => $"{ZipCode}" + " " + $"{City}";
    }
}
