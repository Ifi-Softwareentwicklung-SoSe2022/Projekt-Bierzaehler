-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jul 20, 2022 at 06:38 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Chipkarte_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `Buchung`
--

CREATE TABLE `Buchung` (
  `buchungs_id` int(11) DEFAULT NULL,
  `chip_id` int(11) DEFAULT NULL,
  `drink_id` int(11) DEFAULT NULL,
  `datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Buchung`
--

INSERT INTO `Buchung` (`buchungs_id`, `chip_id`, `drink_id`, `datum`) VALUES
(1, 1, 1, '2022-07-20'),
(2, 1, 1, '2022-07-20'),
(3, 2, 1, '2022-07-20'),
(4, 2, 2, '2022-07-20');

-- --------------------------------------------------------

--
-- Table structure for table `Chipkarte`
--

CREATE TABLE `Chipkarte` (
  `chip_id` int(11) NOT NULL,
  `nachname` varchar(20) DEFAULT NULL,
  `vorname` varchar(20) DEFAULT NULL,
  `erstell_datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Chipkarte`
--

INSERT INTO `Chipkarte` (`chip_id`, `nachname`, `vorname`, `erstell_datum`) VALUES
(1, 'Rustum', 'Riad', '2022-07-20'),
(2, 'Nagel', 'Jouri', '2022-07-20');

-- --------------------------------------------------------

--
-- Table structure for table `Drink`
--

CREATE TABLE `Drink` (
  `drink_id` int(11) NOT NULL,
  `bez` varchar(20) DEFAULT NULL,
  `preis` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Drink`
--

INSERT INTO `Drink` (`drink_id`, `bez`, `preis`) VALUES
(1, 'Freiberger Pils', 0.5),
(2, 'Oeti', 0.25);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Buchung`
--
ALTER TABLE `Buchung`
  ADD KEY `chip_id` (`chip_id`),
  ADD KEY `drink_id` (`drink_id`);

--
-- Indexes for table `Chipkarte`
--
ALTER TABLE `Chipkarte`
  ADD PRIMARY KEY (`chip_id`);

--
-- Indexes for table `Drink`
--
ALTER TABLE `Drink`
  ADD PRIMARY KEY (`drink_id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Buchung`
--
ALTER TABLE `Buchung`
  ADD CONSTRAINT `buchung_ibfk_1` FOREIGN KEY (`chip_id`) REFERENCES `Chipkarte` (`chip_id`),
  ADD CONSTRAINT `buchung_ibfk_2` FOREIGN KEY (`drink_id`) REFERENCES `Drink` (`drink_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
