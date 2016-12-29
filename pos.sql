-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 29, 2016 at 12:00 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 7.0.9

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

CREATE TABLE `barang` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(20) DEFAULT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `JumlahAwal` int(10) DEFAULT NULL,
  `HargaHPP` decimal(16,2) DEFAULT NULL,
  `HargaJual` decimal(16,2) DEFAULT NULL,
  `Created_at` datetime DEFAULT NULL,
  `Updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`ID`, `Kode`, `Nama`, `JumlahAwal`, `HargaHPP`, `HargaJual`, `Created_at`, `Updated_at`) VALUES
(1, 'N1', 'Nokia', 400, '550000.00', '550000.00', '2016-12-04 21:57:48', '2016-12-04 21:57:48'),
(2, 'K4', 'Kingston', 20, '550001.00', '550000.00', '2016-12-04 22:07:27', '2016-12-29 11:34:08'),
(3, 'QQ', 'Quaker', 20, '40000.00', '40000.00', '2016-12-04 22:12:02', '2016-12-04 22:12:02'),
(4, 'Sams01', 'Samsung Galaxy Ace 3', 10, '2000000.00', '2000000.00', '2016-12-11 13:18:32', '2016-12-11 20:49:55');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `ID` int(10) DEFAULT NULL,
  `Nama` varchar(20) DEFAULT NULL,
  `Alamat` varchar(50) DEFAULT NULL,
  `NoHp` varchar(12) DEFAULT NULL,
  `Gender` varchar(12) DEFAULT NULL,
  `Created_at` datetime DEFAULT NULL,
  `Edited_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`StaffID`, `Staffname`, `DateJoin`, `Level`, `Status`, `Name`, `Phone`, `Address`, `Email`, `NIK`, `Password`) VALUES
(0, 'ADMIN', '2016-12-11', 1, 1, 'Admin', '081265105761', 'Aincrad', 'calvinwangxz@gmail.com', '141112028', '$2a$10$HCvNkYs01HBISoi2Cd.KR.67gdMJgZKn.t/gjju5iEw5nlRd0dHVi');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
