using EMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EMA.ViewModels
{
    public class UserInformationsViewModel : ViewModelBase
    {
        public UserInformationsViewModel(string sum, List<CartItem> cartItems)
        {
            InitDemoData();

            SumCartFromOtherView = sum;
            CartItemsFromOtherView = cartItems;
        }

        #region Properties

        public List<CartItem> CartItemsFromOtherView { get; set; }
        public string SumCartFromOtherView { get; set; }

        private string _newContactPerson;
        public string NewContactPerson
        {
            get { return _newContactPerson; }
            set 
            { 
                _newContactPerson = value; 
                OnPropertyChange();
            }
        }

        private string _newCompanyName;
        public string NewCompanyName
        {
            get { return _newCompanyName; }
            set
            {
                _newCompanyName = value;
                OnPropertyChange();
            }
        }

        private string _newPhoneNumber;
        public string NewPhoneNumber
        {
            get { return _newPhoneNumber; }
            set
            {
                _newPhoneNumber = value;
                OnPropertyChange();
            }
        }

        private string _newEMailAddress;
        public string NewEMailAddress
        {
            get { return _newEMailAddress; }
            set
            {
                _newEMailAddress = value;
                OnPropertyChange();
            }
        }

        private string _newStreet;
        public string NewStreet
        {
            get { return _newStreet; }
            set
            {
                _newStreet = value;
                OnPropertyChange();
            }
        }

        private string _newHouseNumber;
        public string NewHouseNumber
        {
            get { return _newHouseNumber; }
            set
            {
                _newHouseNumber = value;
                OnPropertyChange();
            }
        }

        private int _newZipCode;
        public int NewZipCode
        {
            get { return _newZipCode; }
            set
            {
                _newZipCode = value;
                OnPropertyChange();
            }
        }

        private string _newCity;
        public string NewCity
        {
            get { return _newCity; }
            set
            {
                _newCity = value;
                OnPropertyChange();
            }
        }

        private bool _areTextBoxesEnabled;

        public bool AreTextBoxesEnabled
        {
            get { return _areTextBoxesEnabled; }
            set 
            { 
                _areTextBoxesEnabled = value;
                OnPropertyChange ();
            }
        }

        private List<CustomerData> _customerData;
        public List<CustomerData> CustomerData
        {
            get { return _customerData; }
            set { _customerData = value; }
        }

        private List<Dealer> dealers;
        public List<Dealer> Dealers
        {
            get { return dealers; }
            set { dealers = value; }
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

            SetDefaultCustomerData();

            Dealers = new List<Dealer>();
            Dealers.Add(new Dealer
            {
                DealerID = 1,
                CompanyName = "Schwarzkopf",
                ContactPerson = "Schwarz Kopf",
                Street = "Hasenweide",
                HouseNumber = "2",
                ZipCode = 77893,
                City = "Schwarzköpfingen",
                Country = "Deutschland",
                PhoneNumber = "09344 8734190",
                EMailAddress = "schwarzkopf@kontakt.de",
                Website = "schwarzkopf-international.com",
                FreeDeliveryFromEUR = 150
            });
            Dealers.Add(new Dealer
            {
                DealerID = 2,
                CompanyName = "Friseurbedarf Hägele",
                ContactPerson = "Anneliese Hägele",
                Street = "Wiesenweg",
                HouseNumber = "22",
                ZipCode = 77113,
                City = "Hagel",
                Country = "Deutschland",
                PhoneNumber = "01144 776339",
                EMailAddress = "haegele-friseurbedarf@info.com",
                Website = "haegele-friseurbedarf.de",
                FreeDeliveryFromEUR = 100
            });
            Dealers.Add(new Dealer
            {
                DealerID = 3,
                CompanyName = "Vertriebshaus Friseurhandwerk Mayer",
                ContactPerson = "Roland V. Mayer",
                Street = "Kleisterstraße",
                HouseNumber = "14",
                ZipCode = 70922,
                City = "Handau",
                Country = "Deutschland",
                PhoneNumber = "08966 6598431",
                EMailAddress = "friseurmayer-handau@info.de",
                Website = "friseurvertrieb-mayer-handau.de",
                FreeDeliveryFromEUR = 180
            });
        }

        public void SetCustomerDataWhenCancelled()
        {
            SetDefaultCustomerData();
        }

        private void SetDefaultCustomerData()
        {
            var customer = CustomerData.First();
            NewContactPerson = customer.ContactPerson;
            NewCompanyName = customer.CompanyName;
            NewPhoneNumber = customer.PhoneNumber;
            NewEMailAddress = customer.EMailAddress;
            NewStreet = customer.Street;
            NewHouseNumber = customer.HouseNumber;
            NewZipCode = customer.ZipCode;
            NewCity = customer.City;
        }

        public void SetNewCustomerData()
        {
            var newCustomerData = new List<CustomerData>();
            newCustomerData.Add(new CustomerData
            {
                ContactPerson = NewContactPerson,
                CompanyName = NewCompanyName,
                PhoneNumber = NewPhoneNumber,
                EMailAddress = NewEMailAddress,
                Street = NewStreet,
                HouseNumber = NewHouseNumber,
                ZipCode = NewZipCode,
                City = NewCity,
            });

            CustomerData = newCustomerData;
        }

        public void EnableTextBoxes()
        {
            AreTextBoxesEnabled = true;
        }

        public void DisableTextBoxes()
        {
            AreTextBoxesEnabled = false;
        }

        #endregion
    }
}
