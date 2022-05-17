-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Erstellungszeit: 11. Mai 2022 um 15:17
-- Server-Version: 10.4.22-MariaDB
-- PHP-Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `emadb`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `customerdata`
--

CREATE TABLE `customerdata` (
  `ID` int(11) NOT NULL,
  `CompanyName` varchar(255) NOT NULL,
  `ContactPerson` varchar(255) NOT NULL,
  `Street` varchar(255) DEFAULT NULL,
  `HouseNumber` varchar(255) DEFAULT NULL,
  `ZipCode` varchar(255) DEFAULT NULL,
  `City` varchar(255) DEFAULT NULL,
  `Country` varchar(255) DEFAULT NULL,
  `PhoneNumber` varchar(255) NOT NULL,
  `EMailAddress` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `customerdata`
--

INSERT INTO `customerdata` (`ID`, `CompanyName`, `ContactPerson`, `Street`, `HouseNumber`, `ZipCode`, `City`, `Country`, `PhoneNumber`, `EMailAddress`) VALUES
(1, 'Salon Velly', 'Frau Schönhof', 'Haarweg ', '13b', '51864', 'Schönhausen', 'DE', '07694 519475', 'salonvelly@info.de');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `customerlogindata`
--

CREATE TABLE `customerlogindata` (
  `ID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `customerlogindata`
--

INSERT INTO `customerlogindata` (`ID`, `CustomerID`, `Username`, `Password`) VALUES
(1, 1, 'salon.velly', 'YteCO#TL');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `dealer`
--

CREATE TABLE `dealer` (
  `ID` int(11) NOT NULL,
  `CompanyName` varchar(255) DEFAULT NULL,
  `ContactPerson` varchar(255) DEFAULT NULL,
  `Street` varchar(255) DEFAULT NULL,
  `HouseNumber` varchar(255) DEFAULT NULL,
  `ZipCode` varchar(255) DEFAULT NULL,
  `City` varchar(255) DEFAULT NULL,
  `Country` varchar(255) DEFAULT NULL,
  `PhoneNumber` varchar(255) DEFAULT NULL,
  `EMailAddress` varchar(255) DEFAULT NULL,
  `Website` varchar(255) DEFAULT NULL,
  `MinimumOrderValueEUR` int(11) DEFAULT NULL,
  `FreeDeliveryFromEUR` int(11) DEFAULT NULL,
  `StandardDeliveryDeEUR` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `dealer`
--

INSERT INTO `dealer` (`ID`, `CompanyName`, `ContactPerson`, `Street`, `HouseNumber`, `ZipCode`, `City`, `Country`, `PhoneNumber`, `EMailAddress`, `Website`, `MinimumOrderValueEUR`, `FreeDeliveryFromEUR`, `StandardDeliveryDeEUR`) VALUES
(1, 'Schwarzkopf', 'Ralf Biermann', 'Hans-Grade-Allee ', '58', '24830', 'Schleswig', 'DE', '04621 435681', 'RalfBiermann@schwarzkopf.info', 'schwarzkopf.de', 5000, 12000, 399),
(2, 'Friseurbedarf Hägele', 'Janina Hahn', 'Feldstrasse', '16', '39532', 'Havelberg', 'DE', '03938 77933', 'JaninaHahn@hagel.info', 'friseurbedarf-haegele.com', 3500, 10000, 399),
(3, 'Vertriebshaus Friseurhandwerk Mayer', 'Petra Probst', 'Fontenay', '51', '91287', 'Plech', 'DE', '09244 125217', 'PetraProbst@mayer.de', 'wasfriseurebrauchen.de', 4500, 8500, 399),
(4, 'Amazon', 'Tim Holzman', 'Bleibtreustrasse', '4', '95287', 'Detmold', 'DE', '05231 880664', 'TimHolzman@amazon.de', 'amazon.de', 5000, 6000, 399);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `items`
--

CREATE TABLE `items` (
  `ID` int(11) AUTO_INCREMENT PRIMARY KEY NOT NULL,
  `Picture` varchar(355) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `VolumePack` int(11) DEFAULT NULL,
  `VolumeUnitPack` varchar(255) DEFAULT NULL,
  `SelledAmount` int(11) DEFAULT NULL,
  `SelledUnit` varchar(255) DEFAULT NULL,
  `PriceSelledUnitEUR` int(11) DEFAULT NULL,
  `DealerID` int(11) NOT NULL,
  `DealerItemNumber` int(11) DEFAULT NULL,
  `Availability` varchar(255) DEFAULT NULL,
  `DeliveryTime` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `items`
--

INSERT INTO `items` (`ID`, `Picture`, `Name`, `Description`, `VolumePack`, `VolumeUnitPack`, `SelledAmount`, `SelledUnit`, `PriceSelledUnitEUR`, `DealerID`, `DealerItemNumber`, `Availability`, `DeliveryTime`) VALUES
(1, 'revital_shampoo.png', 'GLYNT REVITAL Shampoo', 'Regenerierendes Shampoo mit Phyto-Keratin', 250, 'ml', 10, 'Stk', 4460, 1, 12077448, 'Auf Lager', '1-2 Werktage'),
(2, 'silver_shampoo.png', 'L\'Oréal Silver Shampoo', 'Silber Shampoo - Neutralisiert Gelbstich', 500, 'ml', 8, 'Stk', 6890, 1, 12027139, 'Auf Lager', '2-3 Werktage'),
(3, 'kérastase_sirum.png', 'Kérastase Elixir Ultime Original', 'Pflegeöl mit sofortigem Glanz-Effekt', 100, 'ml', 6, 'Stk', 3675, 2, 12027140, 'Auf Lager', '1-2 Werktage'),
(4, 'color_mixer.png', 'Efalock Color Mixer', 'Zum Anrühren von Haarfarbe und Blondierung', 1, 'Stk', 3, 'Stk', 1225, 4, 3040264, 'Nicht verfügbar', '2-3 Werktage'),
(5, 'comair-cape-hair.png', 'ComairCape Hair', 'Friseurumhang, Nylonfaser, wasserabweisend, Größe: Erwachsene, Farbe: schwarz', 1, 'Stk', 5, 'Stk', 1925, 4, 910408355, 'Auf Lager', '5-7 Werktage'),
(6, 'comair-cape-hair.png', 'ComairCape Hair Junior', 'Friseurumhang, Nylonfaser, wasserabweisend, Größe: Kinder, Farbe: schwarz', 1, 'Stk', 5, 'Stk', 1725, 4, 910408359, 'Auf Lager', '5-7 Werktage'),
(7, 'comair-vinyl-gloves.png', 'Vinyl Gloves S', 'Puderfreie Vinyl Handschuhe, Größe S', 100, 'Stk', 10, 'Pack', 2890, 4, 25556755, 'Auf Lager', '2-3 Werktage'),
(8, 'comair-vinyl-gloves.png', 'Vinyl Gloves M', 'Puderfreie Vinyl Handschuhe, Größe M', 100, 'Stk', 10, 'Pack', 2890, 4, 25556756, 'Nicht verfügbar', '2-3 Werktage'),
(9, 'comair-vinyl-gloves.png', 'Vinyl Gloves L', 'Puderfreie Vinyl Handschuhe, Größe L', 100, 'Stk', 10, 'Pack', 2890, 4, 25556757, 'Auf Lager', '2-3 Werktage'),
(10, 'comair-vinyl-gloves.png', 'Vinyl Gloves XL', 'Puderfreie Vinyl Handschuhe, Größe XL', 100, 'Stk', 10, 'Pack', 2890, 4, 25556758, 'Auf Lager', '2-3 Werktage'),
(11, 'hair_clips_pack_of_12.png', 'Hair Clips', 'Haar Clips zum Fixieren der Haare, Black, Plastic', 12, 'Stk', 3, 'Pack', 1799, 4, 11450819, 'Auf Lager', '1-2 Werktage'),
(12, 'hair_dryer.png', 'Remington Ionic Hair Dryer', 'Haartrockner/Fön', 1, 'Stk', 2, 'Stk', 4699, 3, 23340099, 'Auf Lager', '2-3 Werktage'),
(13, 'hair_mask.png', 'K18 Leave-In Molecular', 'Reperatur-Haarmaske für stark geschädigtes Haar ', 15, 'ml', 15, 'Stk', 4569, 3, 68980000, 'Auf Lager', '1-2 Werktage'),
(14, 'schwarzkopf_blondierung.png', 'Selective ColorEvo Cream hair dye ', 'Extra starke Blondierung für intensives Blond ', 100, 'ml', 4, 'Stk', 1495, 1, 1370525, 'Auf Lager', '2-3 Werktage'),
(15, 'loréal_paris_préférence.png', 'L\'Oréal Paris Préférence No. 3.12', 'Haarfarbe - Intensives kühles Dunkelbraun', 60, 'ml', 6, 'Stk', 2699, 1, 5507321, 'Auf Lager', '1-2 Werktage'),
(16, 'loréal_paris_préférence_blond.png', 'L\'Oréal Paris Préférence No. 11.11', 'Ultra-helles kühles Kristall-Blond', 60, 'ml', 8, 'Stk', 3366, 1, 81850, 'Nicht verfügbar', '2-3 Werktage'),
(17, 'mixing_bowl.png', 'Farbmisch-Schale', 'Plastikschale schwarz zum Anrühren von Haarfarbe und Blondierung', 1, 'Stk', 3, 'Stk', 349, 4, 10001828, 'Auf Lager', '1-2 Werktage'),
(18, 'pinsel_kamm.png', 'Kombo-Pinsel', 'Kombinationstool - Kamm und Färbepinsel 2 in 1', 1, 'Stk', 4, 'Stk', 1150, 2, 1081951, 'Auf Lager', '2-3 Werktage'),
(19, 'hair_trimmer.png', 'Hatteker - Haarschneider', 'Präzisions-Haar- und Bartschneider', 1, 'Stk', 1, 'Stk', 4099, 4, 9988122, 'Auf Lager', '5-7 Werktage'),
(20, 'styling-brush-round.png', 'Styling-Bürste rund', 'Größe Rundbürste für Haarstyling', 1, 'Stk', 2, 'Stk', 1665, 2, 3132639, 'Auf Lager', '2-3 Werktage'),
(21, 'thining_scissors.png', 'Effilierschere Edelstahl', 'Premium Effilierschere zum Ausdünnen der Haare', 1, 'Stk', 2, 'Stk', 2499, 4, 454551, 'Auf Lager', '1-2 Werktage'),
(22, 'schwarzkopf_red_hair_colour.png', 'Schwarzkopf Brillance T868', 'Glanz-Tönungs-Gel Dunkelrot/Granat', 60, 'ml', 5, 'Stk', 2749, 1, 5968957, 'Auf Lager', '2-3 Werktage'),
(23, 'luminance_ultraviolett.png', 'Schwarzkopf Brillance Luminance 860', 'Haarfarbe - Ultraviolett, auch für dunkles Haar', 60, 'ml', 5, 'Stk', 3399, 1, 5985957, 'Auf Lager', '2-3 Werktage'),
(24, 'schwarzkopf-repair-rescue-serum.png', 'Schwarzkopf Professionals Paptide Repair Rescue', 'Reperatur-Spitzen-Pflege für sensibles Haar', 75, 'ml', 5, 'Stk', 2949, 1, 5368957, 'Auf Lager', '2-3 Werktage'),
(25, 'haarfarbe_schwarz.png', 'Schwarzkopf Brillance 890', 'Haarfarbe schwarz', 60, 'ml', 5, 'Stk', 2899, 1, 5961157, 'Auf Lager', '2-3 Werktage'),
(26, 'spülung_fruchtvitamin.png', 'Schwarzkopf Schauma Frucht und Vitamin Spülung', 'Bis zu 3x bessere Kämmbarkeit - für normales Haar', 250, 'ml', 5, 'Stk', 2789, 1, 5428957, 'Auf Lager', '2-3 Werktage'),
(27, 'pinsel_set5.png', '5er-Set Friseurpinsel', 'Friseurpinsel zum Haare färben und Stylen - 5er Set', 1, 'Pack', 1, 'Stk', 499, 2, 12027188, 'Auf Lager', '1-2 Werktage'),
(28, 'set5_kamm.png', '5er-Set Friseurkämme', '5 verschiedene Friseurkämme im Set', 1, 'Pack', 1, 'Stk', 1975, 2, 12487140, 'Auf Lager', '2 Werktage'),
(29, 'BaByliss-power-pro-2000w.png', 'BaByliss Power Pro 2000', 'Haartrockner/Fön', 1, 'Stk', 1, 'Stk', 2519, 2, 11127140, 'Auf Lager', '1-2 Werktage'),
(30, 'hair_trimmer_remington.png', 'Remington Haarschneider PG 6030', 'Haarschneider für Haupthaar und Bart', 1, 'Stk', 1, 'Stk', 3999, 2, 1258440, 'Auf Lager', '2-3 Werktage'),
(31, 'set_scheren.png', 'Scheren-Set 3-teilig', 'Effilierschere, Haarschneideschere und Effiliermesser', 1, 'Pack', 1, 'Stk', 2999, 2, 12058140, 'Auf Lager', '2 Werktage'),
(32, 'lockenwickler.png', 'Lockenwickler 3 S,M und L', 'Lockenwickler in 3 Größen', 1, 'Pack', 2, 'Stk', 1798, 2, 18689140, 'Auf Lager', '3 Werktage'),
(33, 'remington-glaetteisen.png', 'Remington Glätteisen S8590', 'Glätteisen für Haarstyling', 1, 'Stk', 1, 'Stk', 4499, 2, 10107140, 'Auf Lager', '3-4 Werktage'),
(34, 'friseurbesen.png', 'Spezial-Haar-Besen', 'Spezial-Besen zum einfachen Entsorgen von Haarresten', 1, 'Stk', 1, 'Stk', 1899, 3, 23114599, 'Auf Lager', '2-3 Werktage'),
(35, 'stuhl.png', 'Friseurstuhl 205197', 'Höhenverstellbarer Friseurstuhl mir verstellbarer Rückenlehne und Kopfstütze', 1, 'Stk', 1, 'Stk', 25995, 3, 21140099, 'Auf Lager', '3-5 Werktage'),
(36, 'friseurwagen.png', 'Friseurwagen Salon CO', 'Friseurwagen mit 5 Schubladen und zahlreichen Sortierfächern', 1, 'Stk', 1, 'Stk', 12949, 3, 15340099, 'Auf Lager', '3-4 Werktage'),
(37, 'seifenspender.png', 'Seifen-/Flüssigkeitsspender', 'Spender für Seife, Shampoo, Spülung, etc.', 1, 'Stk', 3, 'Stk', 2719, 3, 18540099, 'Auf Lager', '2-3 Werktage'),
(38, 'friseurhaarsauger.png', 'Sibel Hair Vacuum 1200 Watt', 'Automatischer Haarstaubsauger für Friseure', 1, 'Stk', 1, 'Stk', 19990, 3, 21910099, 'Auf Lager', '2-3 Werktage'),
(39, 'handtücher_grün.png', '6er Set Handtücher dunkelgrün/grün', '4 Handtücher 50x100, 2 Handtücher 80x100', 1, 'Pack', 1, 'Stk', 2699, 3, 23586099, 'Auf Lager', '2-3 Werktage'),
(40, 'handtücher_schwarz.png', '8er Set Handtücher schwarz', '8 Handtücher 50x100', 1, 'Stk', 1, 'Stk', 3490, 3, 21010099, 'Auf Lager', '2-3 Werktage'),
(41, 'handtücher_weiß_grau.png', '6er Set Handtücher weiß/grau', '4 Handtücher 50x100, 2 Handtücher 80x100', 1, 'Stk', 1, 'Stk', 2599, 3, 20662399, 'Auf Lager', '2-3 Werktage');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ordereditems`
--

CREATE TABLE `ordereditems` (
  `OrdersID` int(11) NOT NULL,
  `ItemsID` int(11) NOT NULL,
  `VolumePack` int(11) DEFAULT NULL,
  `VolumeUnitPack` varchar(255) DEFAULT NULL,
  `SelledAmount` int(11) DEFAULT NULL,
  `SelledUnit` varchar(255) DEFAULT NULL,
  `PriceUnitEUR` int(11) DEFAULT NULL,
  `SelledAmountItem` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `orders`
--

CREATE TABLE `orders` (
  `ID` int(11) AUTO_INCREMENT PRIMARY KEY NOT NULL,
  `CustomerDataID` int(11) NOT NULL,
  `OrderDate` date DEFAULT NULL,
  `TotalPriceEUR` int(11) DEFAULT NULL,
  `BillViaAddress` BOOLEAN,
  `BillViaEMail` BOOLEAN
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `customerdata`
--
ALTER TABLE `customerdata`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `customerlogindata`
--
ALTER TABLE `customerlogindata`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_CustomerLoginData_CustomerData` (`CustomerID`);

--
-- Indizes für die Tabelle `dealer`
--
ALTER TABLE `dealer`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `items`
--
ALTER TABLE `items`
  ADD KEY `FK_Items_Dealer` (`DealerID`);

--
-- Indizes für die Tabelle `ordereditems`
--
ALTER TABLE `ordereditems`
  ADD KEY `FK_OrderedItems_Orders` (`OrdersID`),
  ADD KEY `FK_OrderedItems_Items` (`ItemsID`);

--
-- Indizes für die Tabelle `orders`
--
ALTER TABLE `orders`
  ADD KEY `FK_Orders_CustomerData` (`CustomerDataID`);

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `customerlogindata`
--
ALTER TABLE `customerlogindata`
  ADD CONSTRAINT `FK_CustomerLoginData_CustomerData` FOREIGN KEY (`CustomerID`) REFERENCES `customerdata` (`ID`);

--
-- Constraints der Tabelle `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `FK_Items_Dealer` FOREIGN KEY (`DealerID`) REFERENCES `dealer` (`ID`);

--
-- Constraints der Tabelle `ordereditems`
--
ALTER TABLE `ordereditems`
  ADD CONSTRAINT `FK_OrderedItems_Items` FOREIGN KEY (`ItemsID`) REFERENCES `items` (`ID`),
  ADD CONSTRAINT `FK_OrderedItems_Orders` FOREIGN KEY (`OrdersID`) REFERENCES `orders` (`ID`);

--
-- Constraints der Tabelle `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `FK_Orders_CustomerData` FOREIGN KEY (`CustomerDataID`) REFERENCES `customerdata` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
