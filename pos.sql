-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 30, 2016 at 05:32 PM
-- Server version: 5.6.26
-- PHP Version: 5.5.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE IF NOT EXISTS `barang` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(20) DEFAULT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `JumlahAwal` int(10) DEFAULT NULL,
  `HargaHPP` decimal(16,2) DEFAULT NULL,
  `HargaJual` decimal(16,2) DEFAULT NULL,
  `Created_at` datetime DEFAULT NULL,
  `Updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`ID`, `Kode`, `Nama`, `JumlahAwal`, `HargaHPP`, `HargaJual`, `Created_at`, `Updated_at`) VALUES
(1, 'N1', 'Nokia', 400, '550000.00', '550000.00', '2016-12-04 21:57:48', '2016-12-04 21:57:48'),
(2, 'K4', 'Kingston', 20, '550000.00', '550000.00', '2016-12-04 22:07:27', '2016-12-04 22:07:27'),
(3, 'QQ', 'Quaker', 20, '40000.00', '40000.00', '2016-12-04 22:12:02', '2016-12-04 22:12:02'),
(4, 'Sams01', 'Samsung Galaxy Ace 3', 10, '2000000.00', '2000000.00', '2016-12-11 13:18:32', '2016-12-11 20:49:55');

-- --------------------------------------------------------

--
-- Table structure for table `buy`
--

CREATE TABLE IF NOT EXISTS `buy` (
  `id_pembelian` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `tanggal` datetime NOT NULL,
  `total_price` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `buy`
--

INSERT INTO `buy` (`id_pembelian`, `supplier_id`, `tanggal`, `total_price`) VALUES
(3, 1, '2016-12-30 23:03:35', 8250000);

-- --------------------------------------------------------

--
-- Table structure for table `buy_item`
--

CREATE TABLE IF NOT EXISTS `buy_item` (
  `buy_item_id` int(11) NOT NULL,
  `id_buy` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `buy_item`
--

INSERT INTO `buy_item` (`buy_item_id`, `id_buy`, `id_barang`, `qty`) VALUES
(3, 3, 1, 6),
(4, 3, 2, 9);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `ID` int(10) NOT NULL,
  `Nama` varchar(20) DEFAULT NULL,
  `Alamat` varchar(50) DEFAULT NULL,
  `NoHp` varchar(12) DEFAULT NULL,
  `Gender` varchar(12) DEFAULT NULL,
  `Created_at` datetime DEFAULT NULL,
  `Updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`ID`, `Nama`, `Alamat`, `NoHp`, `Gender`, `Created_at`, `Updated_at`) VALUES
(1, 'Calvin', 'Angin', '081265105761', 'Laki-Laki', '2016-12-29 21:38:12', '2016-12-29 21:42:16');

-- --------------------------------------------------------

--
-- Table structure for table `sell`
--

CREATE TABLE IF NOT EXISTS `sell` (
  `id_penjualan` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `tanggal` datetime NOT NULL,
  `total_price` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sell`
--

INSERT INTO `sell` (`id_penjualan`, `customer_id`, `tanggal`, `total_price`) VALUES
(1, 1, '2016-12-30 23:29:03', 8800000);

-- --------------------------------------------------------

--
-- Table structure for table `sell_item`
--

CREATE TABLE IF NOT EXISTS `sell_item` (
  `sell_item_id` int(11) NOT NULL,
  `id_sell` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sell_item`
--

INSERT INTO `sell_item` (`sell_item_id`, `id_sell`, `id_barang`, `qty`) VALUES
(1, 1, 1, 12),
(2, 1, 2, 4);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE IF NOT EXISTS `staff` (
  `StaffID` int(11) NOT NULL,
  `Staffname` varchar(50) NOT NULL,
  `DateJoin` date NOT NULL,
  `Level` int(11) NOT NULL,
  `Status` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Phone` varchar(50) NOT NULL,
  `Address` tinytext NOT NULL,
  `Email` varchar(75) NOT NULL,
  `NIK` varchar(75) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`StaffID`, `Staffname`, `DateJoin`, `Level`, `Status`, `Name`, `Phone`, `Address`, `Email`, `NIK`, `Password`) VALUES
(1, 'ADMIN', '2016-12-11', 1, 1, 'Admin', '081265105761', 'Aincrad', 'calvinwangxz@gmail.com', '141112028', '$2a$10$HCvNkYs01HBISoi2Cd.KR.67gdMJgZKn.t/gjju5iEw5nlRd0dHVi');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(30) DEFAULT NULL,
  `Alamat` varchar(50) DEFAULT NULL,
  `NoHP` varchar(12) DEFAULT NULL,
  `Gender` varchar(15) DEFAULT NULL,
  `Created_at` datetime DEFAULT NULL,
  `Updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`ID`, `Nama`, `Alamat`, `NoHP`, `Gender`, `Created_at`, `Updated_at`) VALUES
(1, 'Lyner Barsett', 'Platina', '08124242424', 'Laki-Laki', '2016-12-29 23:20:48', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `buy`
--
ALTER TABLE `buy`
  ADD PRIMARY KEY (`id_pembelian`);

--
-- Indexes for table `buy_item`
--
ALTER TABLE `buy_item`
  ADD PRIMARY KEY (`buy_item_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `sell`
--
ALTER TABLE `sell`
  ADD PRIMARY KEY (`id_penjualan`);

--
-- Indexes for table `sell_item`
--
ALTER TABLE `sell_item`
  ADD PRIMARY KEY (`sell_item_id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `buy`
--
ALTER TABLE `buy`
  MODIFY `id_pembelian` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `buy_item`
--
ALTER TABLE `buy_item`
  MODIFY `buy_item_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `sell`
--
ALTER TABLE `sell`
  MODIFY `id_penjualan` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `sell_item`
--
ALTER TABLE `sell_item`
  MODIFY `sell_item_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
