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
  `ZipCode` int(11) DEFAULT NULL,
  `City` varchar(255) DEFAULT NULL,
  `Country` varchar(255) DEFAULT NULL,
  `PhoneNumber` varchar(255) NOT NULL,
  `EMailAddress` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `customerdata`
--

INSERT INTO `customerdata` (`ID`, `CompanyName`, `ContactPerson`, `Street`, `HouseNumber`, `ZipCode`, `City`, `Country`, `PhoneNumber`, `EMailAddress`) VALUES
(1, 'Salon Velly\r\n', 'Frau Schönhof\r\n', 'Haarweg \r\n', '13b', 51864, 'Schönhausen\r\n', 'DE', '07694 519475\r\n', 'salonvelly@info.de\r\n');

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
(1, 1, 'salon.velly\r\n', 'YteCO#TL\r\n');

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
  `ZipCode` int(11) DEFAULT NULL,
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
(1, 'Schwarzkopf\r\n', 'Ralf Biermann\r\n', 'Hans-Grade-Allee \r\n', '58\r\n', 24830, 'Schleswig\r\n', 'DE', '04621 435681', 'RalfBiermann@schwarzkopf.info\r\n', 'schwarzkopf.de\r\n', 50, 120, 399),
(2, 'Friseurbedarf Hägele\r\n', 'Janina Hahn\r\n', 'Feldstrasse\r\n', '16\r\n', 39532, 'Havelberg\r\n', 'DE', '03938 77933\r\n', 'JaninaHahn@hagel.info\r\n', 'friseurbedarf-haegele.com\r\n', 35, 100, 399),
(3, 'Vertriebshaus Friseurhandwerk Mayer\r\n', 'Petra Probst\r\n', 'Fontenay\r\n', '51\r\n', 91287, 'Plech\r\n', 'DE', '09244 125217\r\n', 'PetraProbst@mayer.de\r\n', 'wasfriseurebrauchen.de\r\n', 45, 85, 399),
(4, 'Amazon\r\n', 'Tim Holzman\r\n', 'Bleibtreustrasse\r\n', '4\r\n', NULL, 'Detmold\r\n', 'DE', '05231 880664\r\n', 'TimHolzman@amazon.de\r\n', 'amazon.de\r\n', 50, 60, 399);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `items`
--

CREATE TABLE `items` (
  `ID` int(11) NOT NULL,
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
(1, 'shampoo.png\r\n', 'GLYNT REVITAL Shampoo\r\n', 'Regenerierend mit Phyto-Keratin\r\n', 250, 'ml', 10, 'Stk', 1360, 1, 12077448, 'Auf Lager\r\n', '1-2 Werktage\r\n'),
(2, 'silver_shampoo.png\r\n', 'L\'Oréal Silver Shampoo\r\n', 'Silber Shampoo neutralisiert Gelbstich\r\n', 500, 'ml', 10, 'Stk', 2190, 1, 12027139, 'Auf Lager\r\n', '2-3 Werktage\r\n'),
(3, 'kérastase_sirum.png\r\n', 'Kérastase Elixir Ultime Original\r\n', 'Pflegeöl mit sofortigem Glanz-Effekt\r\n', 100, 'ml', 6, 'Stk', 3675, 2, 12027140, 'Auf Lager\r\n', '1-2 Werktage\r\n'),
(4, 'color_mixer.png\r\n', 'Efalock Color Mixer\r\n', 'Zum Anrühren von Haarfarbe und Blondierung\r\n', 1, 'stk', 13, 'Stk', 225, 4, 3040264, 'Nicht verfügbar\r\n', '2-3 Werktage\r\n'),
(5, 'comair-cape-hair.png\r\n', 'ComairCape Hair\r\n', 'Nylon, velcro fastener, water-repellent, black\r\n', 1, 'stk', 50, 'Stk', 1925, 4, 910408355, 'Auf Lager\r\n', '5-7 Werktage\r\n'),
(6, 'comair-vinyl-gloves.png\r\n', 'Vinyl Gloves\r\n', 'Puderfreie Vinyl Gloves\r\n', 50, 'pack', 18, 'Stk', 2390, 4, 25556755, 'Auf Lager\r\n', '2-3 Werktage\r\n'),
(7, 'hair_clips_pack_of_12.png\r\n', 'Hair Clips\r\n', 'Anself Hair Sectioning Clips, Black, Plastic\r\n', 12, 'pack', 20, 'Stk', 999, 4, 11450819, 'Auf Lager\r\n', '1-2 Werktage\r\n'),
(8, 'hair_dryer.png\r\n', 'Hair Dryer\r\n', 'DryCare Pro BHD274\r\n', 1, 'stk', 22, 'Stk', 2499, 3, 23340099, 'Nicht verfügbar\r\n', '2-3 Werktage\r\n'),
(9, 'hair_mask.png\r\n', 'K18 Leave-In Molecular\r\n', 'Repair Hair Mask \r\n', 15, 'ml', 15, 'Stk', 3500, 3, 68980000, 'Auf Lager\r\n', '1-2 Werktage\r\n'),
(10, 'extra_light_blonde.png\r\n', 'Selective ColorEvo Cream hair dye \r\n', '10.0  Extra light blonde \r\n', 100, 'ml', 4, 'Stk', 1195, 1, 1370525, 'Auf Lager\r\n', '2-3 Werktage\r\n'),
(11, 'loréal_paris_préférence.png\r\n', 'L\'Oréal Paris Préférence\r\n', 'No. 3.12 Intense Cool Dark Brown\r\n', 60, 'ml', 6, 'Stk', 1992, 1, 5507321, 'Auf Lager\r\n', '1-2 Werktage\r\n'),
(12, 'loréal_paris_préférence_blond.png\r\n', 'L\'Oréal Paris Préférence\r\n', 'No. 11.11 - Ultra Light Cool Crystal Blonde\r\n', 60, 'ml', 12, 'Stk', 2266, 1, 81850, 'Nicht verfügbar\r\n', '2-3 Werktage\r\n'),
(13, 'mixing_bowl.png\r\n', 'Mixing bowl\r\n', 'Color mixing bowl\r\n', 1, 'stk', 20, 'Stk', 300, 4, 10001828, 'Auf Lager\r\n', '1-2 Werktage\r\n'),
(14, 'brush_comb.png\r\n', 'Brush comb\r\n', 'Color Brush & Comb\r\n', 1, 'stk', 50, 'Stk', 165, 2, 1081951, 'Auf Lager\r\n', '2-3 Werktage\r\n'),
(15, 'hair_trimmer.png\r\n', 'Hair Trimmer\r\n', 'Men\'s Precision Hair and Beard Trimmer\r\n', 1, 'stk', 20, 'Stk', 4099, 4, 9988122, 'Auf Lager\r\n', '5-7 Werktage\r\n'),
(16, 'styling-brush-round.png\r\n', 'Tangle Teezer\r\n', 'Blow Styling Brush Round Tool Large\r\n', 1, 'stk', 15, 'Stk', 2165, 2, 3132639, 'Auf Lager\r\n', '2-3 Werktage\r\n'),
(17, 'thining_scissors.png\r\n', 'Premium thinning scissors\r\n', 'Premium thinning scissors with single-sided or two-sided micro-teeth.\r\n', 1, 'stk', 4, 'Stk', 2499, 4, 454551, 'Auf Lager\r\n', '1-2 Werktage\r\n'),
(18, 'schwarzkopf_red_hair_colour.png\r\n', 'Schwarzkopf\r\n', 'Red Hair Color\r\n', 1, 'stk', 23, 'Stk', 743, 1, 5968957, 'Auf Lager\r\n', '2-3 Werktage\r\n');

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
  `ID` int(11) NOT NULL,
  `CustomerDataID` int(11) NOT NULL,
  `OrderDate` date DEFAULT NULL,
  `TotalPriceEUR` int(11) DEFAULT NULL,
  `BillViaAddress` BOOLEAN,
  `BillViaEMail` varchar(255) DEFAULT NULL
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
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_Items_Dealer` (`DealerID`);

--
-- Indizes für die Tabelle `ordereditems`
--
ALTER TABLE `ordereditems`
  ADD PRIMARY KEY (`OrdersID`),
  ADD KEY `FK_OrderedItems_Items` (`ItemsID`);

--
-- Indizes für die Tabelle `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`ID`),
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
