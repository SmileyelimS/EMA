using EMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMA.ViewModels
{
    public class NewOrderViewModel : ViewModelBase
    {
        public NewOrderViewModel()
        {
            InitDemoItems();
        }

        private List<Items> _items;

        public List<Items> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private void InitDemoItems()
        {
            Items = new List<Items>();
            Items.Add(new Items
            {
                ItemID = 1,
                Picture = "Haarfarbe.png",
                Name = "Schwarzkopf Brilliance 890",
                Description = "Haarfarbe Schwarz",
                VolumePack = 100,
                VolumeUnitPack = "ml",
                SelledAmount = 10,
                SelledUnit = "Stk",
                //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                PriceSelledUnitEUR = 4999,
                //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                CompanyName = "Schwarzkopf",
                DealerItemNumber = 12077448,
                Availability = "Auf Lager",
                DeliveryTime = "1-2  Werktage"
            });
            Items.Add(new Items
            {
                ItemID = 2,
                Picture = "Shampoo.png",
                Name = "Schwarzkopf Shampoo Repair&Care",
                Description = "Pflegeshampoo für trockenes und geschädigtes Haar",
                VolumePack = 500,
                VolumeUnitPack = "ml",
                SelledAmount = 10,
                SelledUnit = "Stk",
                //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                PriceSelledUnitEUR = 5999,
                //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                //Dann CompanyName + "Art.Nr.:" + DealerItemNumber
                CompanyName = "Schwarzkopf",
                DealerItemNumber = 12077666,
                Availability = "Auf Lager",
                DeliveryTime = "1-2  Werktage"
            });
            Items.Add(new Items
            {
                ItemID = 3,
                Picture = "Spülung.png",
                Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                Description = "Pflegespülung für normales Haar",
                VolumePack = 400,
                VolumeUnitPack = "ml",
                SelledAmount = 10,
                SelledUnit = "Stk",
                //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                PriceSelledUnitEUR = 5599,
                //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                CompanyName = "Schwarzkopf",
                DealerItemNumber = 12077556,
                Availability = "Auf Lager",
                DeliveryTime = "2-3  Werktage"
            });
            {
                Items.Add(new Items
                {
                    ItemID = 1,
                    Picture = "Haarfarbe.png",
                    Name = "Schwarzkopf Brilliance 890",
                    Description = "Haarfarbe Schwarz",
                    VolumePack = 100,
                    VolumeUnitPack = "ml",
                    SelledAmount = 10,
                    SelledUnit = "Stk",
                    //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                    PriceSelledUnitEUR = 4999,
                    //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                    CompanyName = "Schwarzkopf",
                    DealerItemNumber = 12077448,
                    Availability = "Auf Lager",
                    DeliveryTime = "1-2  Werktage"
                });
                Items.Add(new Items
                {
                    ItemID = 2,
                    Picture = "Shampoo.png",
                    Name = "Schwarzkopf Shampoo Repair&Care",
                    Description = "Pflegeshampoo für trockenes und geschädigtes Haar",
                    VolumePack = 500,
                    VolumeUnitPack = "ml",
                    SelledAmount = 10,
                    SelledUnit = "Stk",
                    //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                    PriceSelledUnitEUR = 5999,
                    //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                    //Dann CompanyName + "Art.Nr.:" + DealerItemNumber
                    CompanyName = "Schwarzkopf",
                    DealerItemNumber = 12077666,
                    Availability = "Auf Lager",
                    DeliveryTime = "1-2  Werktage"
                });
                Items.Add(new Items
                {
                    ItemID = 3,
                    Picture = "Spülung.png",
                    Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                    Description = "Pflegespülung für normales Haar",
                    VolumePack = 400,
                    VolumeUnitPack = "ml",
                    SelledAmount = 10,
                    SelledUnit = "Stk",
                    //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                    PriceSelledUnitEUR = 5599,
                    //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                    CompanyName = "Schwarzkopf",
                    DealerItemNumber = 12077556,
                    Availability = "Auf Lager",
                    DeliveryTime = "2-3  Werktage"
                });
                Items.Add(new Items
                {
                    ItemID = 3,
                    Picture = "Spülung.png",
                    Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                    Description = "Pflegespülung für normales Haar",
                    VolumePack = 400,
                    VolumeUnitPack = "ml",
                    SelledAmount = 10,
                    SelledUnit = "Stk",
                    //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                    PriceSelledUnitEUR = 5599,
                    //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                    CompanyName = "Schwarzkopf",
                    DealerItemNumber = 12077556,
                    Availability = "Auf Lager",
                    DeliveryTime = "2-3  Werktage"
                });
                Items.Add(new Items
                     {
                         ItemID = 1,
                         Picture = "Haarfarbe.png",
                         Name = "Schwarzkopf Brilliance 890",
                         Description = "Haarfarbe Schwarz",
                         VolumePack = 100,
                         VolumeUnitPack = "ml",
                         SelledAmount = 10,
                         SelledUnit = "Stk",
                         //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                         PriceSelledUnitEUR = 4999,
                         //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                         CompanyName = "Schwarzkopf",
                         DealerItemNumber = 12077448,
                         Availability = "Auf Lager",
                         DeliveryTime = "1-2  Werktage"
                     });
                Items.Add(new Items
                {
                    ItemID = 2,
                    Picture = "Shampoo.png",
                    Name = "Schwarzkopf Shampoo Repair&Care",
                    Description = "Pflegeshampoo für trockenes und geschädigtes Haar",
                    VolumePack = 500,
                    VolumeUnitPack = "ml",
                    SelledAmount = 10,
                    SelledUnit = "Stk",
                    //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                    PriceSelledUnitEUR = 5999,
                    //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                    //Dann CompanyName + "Art.Nr.:" + DealerItemNumber
                    CompanyName = "Schwarzkopf",
                    DealerItemNumber = 12077666,
                    Availability = "Auf Lager",
                    DeliveryTime = "1-2  Werktage"
                });
                Items.Add(new Items
                {
                    ItemID = 3,
                    Picture = "Spülung.png",
                    Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                    Description = "Pflegespülung für normales Haar",
                    VolumePack = 400,
                    VolumeUnitPack = "ml",
                    SelledAmount = 10,
                    SelledUnit = "Stk",
                    //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                    PriceSelledUnitEUR = 5599,
                    //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                    CompanyName = "Schwarzkopf",
                    DealerItemNumber = 12077556,
                    Availability = "Auf Lager",
                    DeliveryTime = "2-3  Werktage"
                });
                {
                    Items.Add(new Items
                    {
                        ItemID = 1,
                        Picture = "Haarfarbe.png",
                        Name = "Schwarzkopf Brilliance 890",
                        Description = "Haarfarbe Schwarz",
                        VolumePack = 100,
                        VolumeUnitPack = "ml",
                        SelledAmount = 10,
                        SelledUnit = "Stk",
                        //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                        PriceSelledUnitEUR = 4999,
                        //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                        CompanyName = "Schwarzkopf",
                        DealerItemNumber = 12077448,
                        Availability = "Auf Lager",
                        DeliveryTime = "1-2  Werktage"
                    });
                    Items.Add(new Items
                    {
                        ItemID = 2,
                        Picture = "Shampoo.png",
                        Name = "Schwarzkopf Shampoo Repair&Care",
                        Description = "Pflegeshampoo für trockenes und geschädigtes Haar",
                        VolumePack = 500,
                        VolumeUnitPack = "ml",
                        SelledAmount = 10,
                        SelledUnit = "Stk",
                        //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                        PriceSelledUnitEUR = 5999,
                        //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                        //Dann CompanyName + "Art.Nr.:" + DealerItemNumber
                        CompanyName = "Schwarzkopf",
                        DealerItemNumber = 12077666,
                        Availability = "Auf Lager",
                        DeliveryTime = "1-2  Werktage"
                    });
                    Items.Add(new Items
                    {
                        ItemID = 3,
                        Picture = "Spülung.png",
                        Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                        Description = "Pflegespülung für normales Haar",
                        VolumePack = 400,
                        VolumeUnitPack = "ml",
                        SelledAmount = 10,
                        SelledUnit = "Stk",
                        //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                        PriceSelledUnitEUR = 5599,
                        //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                        CompanyName = "Schwarzkopf",
                        DealerItemNumber = 12077556,
                        Availability = "Auf Lager",
                        DeliveryTime = "2-3  Werktage"
                    });
                    Items.Add(new Items
                    {
                        ItemID = 3,
                        Picture = "Spülung.png",
                        Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                        Description = "Pflegespülung für normales Haar",
                        VolumePack = 400,
                        VolumeUnitPack = "ml",
                        SelledAmount = 10,
                        SelledUnit = "Stk",
                        //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                        PriceSelledUnitEUR = 5599,
                        //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                        CompanyName = "Schwarzkopf",
                        DealerItemNumber = 12077556,
                        Availability = "Auf Lager",
                        DeliveryTime = "2-3  Werktage"
                    });
                    Items.Add(new Items
                    {
                        ItemID = 2,
                        Picture = "Shampoo.png",
                        Name = "Schwarzkopf Shampoo Repair&Care",
                        Description = "Pflegeshampoo für trockenes und geschädigtes Haar",
                        VolumePack = 500,
                        VolumeUnitPack = "ml",
                        SelledAmount = 10,
                        SelledUnit = "Stk",
                        //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                        PriceSelledUnitEUR = 5999,
                        //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                        //Dann CompanyName + "Art.Nr.:" + DealerItemNumber
                        CompanyName = "Schwarzkopf",
                        DealerItemNumber = 12077666,
                        Availability = "Auf Lager",
                        DeliveryTime = "1-2  Werktage"
                    });
                    Items.Add(new Items
                    {
                        ItemID = 3,
                        Picture = "Spülung.png",
                        Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                        Description = "Pflegespülung für normales Haar",
                        VolumePack = 400,
                        VolumeUnitPack = "ml",
                        SelledAmount = 10,
                        SelledUnit = "Stk",
                        //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                        PriceSelledUnitEUR = 5599,
                        //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                        CompanyName = "Schwarzkopf",
                        DealerItemNumber = 12077556,
                        Availability = "Auf Lager",
                        DeliveryTime = "2-3  Werktage"
                    });
                    {
                        Items.Add(new Items
                        {
                            ItemID = 1,
                            Picture = "Haarfarbe.png",
                            Name = "Schwarzkopf Brilliance 890",
                            Description = "Haarfarbe Schwarz",
                            VolumePack = 100,
                            VolumeUnitPack = "ml",
                            SelledAmount = 10,
                            SelledUnit = "Stk",
                            //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                            PriceSelledUnitEUR = 4999,
                            //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                            CompanyName = "Schwarzkopf",
                            DealerItemNumber = 12077448,
                            Availability = "Auf Lager",
                            DeliveryTime = "1-2  Werktage"
                        });
                        Items.Add(new Items
                        {
                            ItemID = 2,
                            Picture = "Shampoo.png",
                            Name = "Schwarzkopf Shampoo Repair&Care",
                            Description = "Pflegeshampoo für trockenes und geschädigtes Haar",
                            VolumePack = 500,
                            VolumeUnitPack = "ml",
                            SelledAmount = 10,
                            SelledUnit = "Stk",
                            //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                            PriceSelledUnitEUR = 5999,
                            //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                            //Dann CompanyName + "Art.Nr.:" + DealerItemNumber
                            CompanyName = "Schwarzkopf",
                            DealerItemNumber = 12077666,
                            Availability = "Auf Lager",
                            DeliveryTime = "1-2  Werktage"
                        });
                        Items.Add(new Items
                        {
                            ItemID = 3,
                            Picture = "Spülung.png",
                            Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                            Description = "Pflegespülung für normales Haar",
                            VolumePack = 400,
                            VolumeUnitPack = "ml",
                            SelledAmount = 10,
                            SelledUnit = "Stk",
                            //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                            PriceSelledUnitEUR = 5599,
                            //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                            CompanyName = "Schwarzkopf",
                            DealerItemNumber = 12077556,
                            Availability = "Auf Lager",
                            DeliveryTime = "2-3  Werktage"
                        });
                        Items.Add(new Items
                        {
                            ItemID = 3,
                            Picture = "Spülung.png",
                            Name = "Schwarzkopf Schauma Frucht&Vitamin Spülung",
                            Description = "Pflegespülung für normales Haar",
                            VolumePack = 400,
                            VolumeUnitPack = "ml",
                            SelledAmount = 10,
                            SelledUnit = "Stk",
                            //Der Preis muss durch hundert geteilt und ein "€" angehängt werden
                            PriceSelledUnitEUR = 5599,
                            //CompanyName soll via DealerID aus Tabelle Dealer ermittelt werden
                            CompanyName = "Schwarzkopf",
                            DealerItemNumber = 12077556,
                            Availability = "Auf Lager",
                            DeliveryTime = "2-3  Werktage"
                        });
                    }
                }
            }
        }
    }
}
