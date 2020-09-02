-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Sep 02, 2020 at 12:41 PM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `erpid`
--

-- --------------------------------------------------------

--
-- Table structure for table `issues`
--

CREATE TABLE IF NOT EXISTS `issues` (
  `issueid` int(11) NOT NULL AUTO_INCREMENT,
  `itemcode` int(11) NOT NULL,
  `voucherno` int(20) NOT NULL,
  `snofrom` int(10) NOT NULL,
  `snoto` int(10) NOT NULL,
  `reqby` varchar(255) NOT NULL,
  `issueto` varchar(255) NOT NULL,
  `scounty` varchar(255) NOT NULL,
  `quantity` int(11) NOT NULL,
  `issuedate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`issueid`),
  KEY `itemcode` (`itemcode`,`issueto`,`scounty`,`quantity`,`issuedate`),
  KEY `reqby` (`reqby`),
  KEY `voucherno` (`voucherno`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=49 ;

--
-- Dumping data for table `issues`
--

INSERT INTO `issues` (`issueid`, `itemcode`, `voucherno`, `snofrom`, `snoto`, `reqby`, `issueto`, `scounty`, `quantity`, `issuedate`) VALUES
(1, 103, 2343534, 0, 0, '20089230', '1203023', 'SUBUKIA', 1000, '2017-12-07 15:24:12'),
(2, 104, 4567754, 2345768, 2346000, '20439943', '2395845', 'NAKURU', 1000, '2017-12-07 15:28:01'),
(3, 121, 3456789, 2345768, 2346000, '8954043', '8679454', 'LAIKIPIA', 50, '2017-12-07 15:28:50'),
(4, 103, 1234567, 102001, 102201, '098737', '56784393', 'BARINGO', 200, '2017-12-07 15:31:09'),
(5, 121, 4567890, 0, 0, '5647', '23456', 'KERICHO', 20, '2017-12-07 15:31:46'),
(6, 121, 345969, 0, 0, '20748', '13576', 'SUBUKIA', 10, '2017-12-08 07:30:04'),
(7, 124, 8009, 0, 0, '2008', '88788', 'SUBUKIA', 5, '2017-12-08 07:43:59'),
(8, 108, 345768, 0, 0, '20075', '4578857', 'SUBUKIA', 10, '2017-12-08 07:54:44'),
(9, 108, 342839, 0, 0, '2009043', '2000323', 'LAIKIPIA', 20, '2017-12-08 07:56:01'),
(10, 111, 23823, 0, 0, '120102', '23940', 'NAKURU', 10, '2017-12-08 09:49:59'),
(11, 108, 2323, 0, 0, '2020', '2039', 'NAKURU', 10, '2017-12-08 12:04:01'),
(12, 107, 10987, 0, 0, '12345', '4567', 'NAKURU', 10, '2017-12-08 12:06:52'),
(13, 100, 23456, 0, 0, '2039', '2130', 'NAKURU', 20, '2017-12-08 12:08:34'),
(14, 108, 234567, 0, 0, '210', '311', 'NAKURU', 10, '2017-12-08 12:17:38'),
(15, 108, 12345, 0, 0, '1234', '2345', 'NAKURU', 10, '2017-12-08 12:32:27'),
(16, 108, 2345, 0, 0, '1230', '5670', 'NAKURU', 20, '2017-12-08 12:41:03'),
(17, 108, 1000, 0, 0, '200', '300', 'NAKURU', 10, '2017-12-08 12:48:35'),
(18, 108, 800, 0, 0, '300', '200', 'NAKURU', 30, '2017-12-08 12:52:14'),
(19, 111, 12010, 0, 0, '1201', '1301', 'NAKURU', 40, '2017-12-08 15:41:55'),
(20, 108, 23203, 0, 0, '201', '300', 'NAKURU', 10, '2017-12-15 10:16:48'),
(21, 121, 23023, 0, 0, '201', '234', 'NAKURU', 20, '2017-12-15 10:27:16'),
(22, 111, 239403, 0, 0, '120', '122', 'NAKURU', 20, '2017-12-15 10:28:25'),
(23, 111, 230403, 0, 0, '200', '400', 'NAKURU', 20, '2017-12-15 10:30:46'),
(24, 111, 232034, 0, 0, '120', '400', 'NAKURU', 100, '2017-12-15 10:36:50'),
(25, 108, 12021, 0, 0, '434', '567', 'NAKURU', 20, '2017-12-15 11:00:33'),
(26, 103, 230495, 234001, 235000, '214', '234', 'NAKURU', 1000, '2017-12-15 11:13:31'),
(27, 103, 2345968, 234001, 235000, '2345', '24567', 'KERICHO', 1000, '2017-12-15 11:23:18'),
(28, 108, 23839, 0, 0, '1234567', '230392', 'NAKURU', 30, '2017-12-28 10:18:34'),
(29, 108, 23230, 0, 0, '2323', '23', 'DAS', 30, '2017-12-28 10:19:02'),
(30, 112, 121, 0, 0, '193430', '123', 'NAKURU', 23, '2018-01-01 14:43:17'),
(31, 108, 12, 0, 0, '123', '123', 'NAK', 12, '2018-01-01 15:19:56'),
(32, 108, 12, 0, 0, '123', '34', 'NAK', 12, '2018-01-01 15:24:09'),
(33, 108, 131, 0, 0, '567', '67', 'NAK', 5, '2018-01-01 15:25:40'),
(34, 119, 0, 0, 0, '', '', '', 0, '2018-01-02 07:38:30'),
(35, 108, 0, 0, 0, '', '', '', 0, '2018-01-02 07:57:58'),
(36, 108, 0, 0, 0, '', '', '', 0, '2018-01-02 07:58:15'),
(37, 119, 123, 0, 0, '385', '908', 'NAKURU', 20, '2018-01-02 08:00:33'),
(38, 119, 84934, 0, 0, '8675', '756', 'NAKURU', 23, '2018-01-02 08:01:52'),
(39, 108, 37232, 0, 0, '2323', '234', 'NAK', 2, '2018-01-02 08:12:44'),
(40, 112, 37232, 0, 0, '230', '6758', 'NAK', 20, '2018-01-02 08:15:23'),
(41, 121, 12102, 0, 0, '393', '12', 'NAKURU', 20, '2018-01-03 08:15:03'),
(42, 121, 73473, 0, 0, '234', '343', 'NAKURU', 20, '2018-01-03 08:22:57'),
(43, 121, 2323, 0, 0, '23233', '122', 'NAKURU', 5, '2018-01-03 08:29:29'),
(44, 121, 239320, 0, 0, '2324', '364', 'NAKURU', 4, '2018-01-03 08:30:00'),
(45, 121, 38348, 0, 0, '34', '12', 'SUBUKIA', 2, '2018-01-03 09:02:49'),
(46, 121, 2323, 0, 0, '2323', '234', 'NAKURU', 12, '2018-01-03 09:10:40'),
(47, 121, 343434, 0, 0, '32232', '34434', 'NAKURU', 20, '2018-01-09 08:38:24'),
(48, 112, 3434, 0, 0, '232', '2343', 'NAKURU', 2, '2018-01-12 14:17:22');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE IF NOT EXISTS `items` (
  `itemcode` int(11) NOT NULL,
  `description` varchar(255) NOT NULL,
  `typ` varchar(255) NOT NULL,
  `balance` double NOT NULL,
  PRIMARY KEY (`itemcode`),
  UNIQUE KEY `description_2` (`description`),
  KEY `description` (`description`),
  KEY `typ` (`typ`),
  KEY `balance` (`balance`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`itemcode`, `description`, `typ`, `balance`) VALUES
(100, 'LAPTOP', 'DESERIALIZED', 0),
(101, 'RULER', 'DESERIALIZED', 0),
(102, 'PRINTER', 'DESERIALIZED', 0),
(103, 'REG 136C', 'SERIALIZED', 1000),
(104, 'REG 136A', 'SERIALIZED', 0),
(105, 'REG 101', 'DESERIALIZED', 0),
(106, 'COUNTER BOOK 3Q', 'DESERIALIZED', 0),
(107, 'COUNTER BOOK 2Q', 'DESERIALIZED', 0),
(108, 'BOX FILE', 'DESERIALIZED', 83),
(109, 'FINGERPRINT INK', 'DESERIALIZED', 0),
(110, 'PRITT GLUE', 'DESERIALIZED', 0),
(111, 'DUST COAT', 'DESERIALIZED', 11),
(112, 'MANILLA', 'DESERIALIZED', 38),
(113, 'TURPENTINE', 'DESERIALIZED', 0),
(114, 'INK CLEANING TOWEL', 'DESERIALIZED', 0),
(115, 'PAPER PUNCH', 'DESERIALIZED', 0),
(116, 'STAPLER', 'DESERIALIZED', 0),
(117, 'TYPRES LANDROVER', 'DESERIALIZED', 0),
(118, 'OFFICE PINS', 'DESERIALIZED', 0),
(119, 'CHAIRS', 'DESERIALIZED', 0),
(120, 'HP PRINTER TONNER 80A', 'DESERIALIZED', 0),
(121, 'BIRO PEN BLUE', 'DESERIALIZED', 18),
(122, 'STAPLES', 'DESERIALIZED', 0),
(123, 'TOWELLETES', 'DESERIALIZED', 0),
(124, 'MOUSE', 'DESERIALIZED', 0),
(125, 'ORANGE MODEM', 'DESERIALIZED', 0),
(126, 'CAPTURE SHEET', 'DESERIALIZED', 0);

-- --------------------------------------------------------

--
-- Table structure for table `loggers`
--

CREATE TABLE IF NOT EXISTS `loggers` (
  `no` int(11) NOT NULL AUTO_INCREMENT,
  `logid` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`no`),
  KEY `logid` (`logid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `loggers`
--

INSERT INTO `loggers` (`no`, `logid`, `password`) VALUES
(1, 'alex', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `receivables`
--

CREATE TABLE IF NOT EXISTS `receivables` (
  `transid` int(11) NOT NULL AUTO_INCREMENT,
  `itemcode` int(11) NOT NULL,
  `voucherno` varchar(255) NOT NULL,
  `supplier` varchar(255) NOT NULL,
  `station_assigned` varchar(255) NOT NULL,
  `snofrom` int(10) NOT NULL,
  `snoto` int(10) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unit` varchar(255) NOT NULL,
  `datereceived` datetime NOT NULL,
  `udptime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `remarks` varchar(255) NOT NULL,
  PRIMARY KEY (`transid`),
  KEY `udptime` (`udptime`),
  KEY `itemcode` (`itemcode`),
  KEY `voucherno` (`voucherno`),
  KEY `snofrom` (`snofrom`),
  KEY `station_assigned` (`station_assigned`),
  KEY `remarks` (`remarks`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=29 ;

--
-- Dumping data for table `receivables`
--

INSERT INTO `receivables` (`transid`, `itemcode`, `voucherno`, `supplier`, `station_assigned`, `snofrom`, `snoto`, `quantity`, `unit`, `datereceived`, `udptime`, `remarks`) VALUES
(1, 103, '78694', 'HQS', '', 12001, 13001, 1000, 'NO', '2017-12-07 00:00:00', '2017-12-07 15:41:34', ''),
(2, 108, '10920', 'HQS', '', 0, 0, 20, 'NO', '2017-12-07 00:00:00', '2017-12-07 15:43:10', ''),
(3, 119, '978569', 'HQS', '', 0, 0, 20, 'NO', '0000-00-00 00:00:00', '2017-12-07 15:46:35', ''),
(4, 120, '345768', 'HQS', '', 0, 0, 3, 'NO', '0000-00-00 00:00:00', '2017-12-08 07:14:44', ''),
(5, 105, '34896', 'HQS', '', 0, 0, 1000, 'NO', '0000-00-00 00:00:00', '2017-12-08 07:16:17', ''),
(6, 101, '87969', 'HQS', '', 0, 0, 20, 'PIECE', '0000-00-00 00:00:00', '2017-12-08 07:18:12', ''),
(7, 107, '029324', 'HQS', '', 0, 0, 50, 'NO', '0000-00-00 00:00:00', '2017-12-08 07:21:19', ''),
(8, 115, '56789', 'HQS', '', 0, 0, 34, 'NO', '0000-00-00 00:00:00', '2017-12-08 07:22:17', ''),
(9, 124, '78908', 'HQS', '', 0, 0, 10, 'NO', '0000-00-00 00:00:00', '2017-12-08 07:42:43', ''),
(10, 108, '23959', 'HQS', '', 0, 0, 20, 'NO', '2017-12-08 00:00:00', '2017-12-08 09:40:49', ''),
(11, 121, '23943434', 'HQS', '', 0, 0, 20, 'NO', '0000-00-00 00:00:00', '2017-12-08 09:56:28', ''),
(12, 119, '1230', 'HQS', '', 0, 0, 40, 'NO', '0000-00-00 00:00:00', '2017-12-08 13:41:16', ''),
(13, 121, '230', 'HQS', '', 0, 0, 20, 'NO', '0000-00-00 00:00:00', '2017-12-08 13:43:35', ''),
(14, 100, '8700', 'HQS', '', 0, 0, 5, 'NO', '0000-00-00 00:00:00', '2017-12-08 13:45:26', ''),
(15, 121, '340', 'HQS', '', 0, 0, 20, 'NO', '0000-00-00 00:00:00', '2017-12-08 13:49:19', ''),
(16, 111, '1070', 'HQS', '', 0, 0, 10, 'NO', '0000-00-00 00:00:00', '2017-12-08 13:58:16', ''),
(17, 103, '23405', 'HQS', '', 2300, 3300, 1000, 'NO', '0000-00-00 00:00:00', '2017-12-08 15:15:51', ''),
(18, 121, '7890', 'HQS', '', 0, 0, 20, 'NO', '0000-00-00 00:00:00', '2017-12-08 15:27:58', ''),
(19, 121, '6789', 'HQS', '', 0, 0, 20, 'NO', '0000-00-00 00:00:00', '2017-12-08 15:29:33', ''),
(20, 121, '7008', 'HQS', '', 0, 0, 10, 'NO', '0000-00-00 00:00:00', '2017-12-08 15:35:03', ''),
(21, 121, '120', 'HQS', '', 0, 0, 10, 'NO', '0000-00-00 00:00:00', '2017-12-08 15:37:39', ''),
(22, 121, '34567', 'HQS', '', 0, 0, 20, 'NO', '0000-00-00 00:00:00', '2017-12-08 15:38:52', ''),
(23, 111, '56789', 'HQS', '', 0, 0, 50, 'NO', '0000-00-00 00:00:00', '2017-12-08 15:40:26', ''),
(24, 112, '345678', 'HQS', '', 0, 0, 60, 'NO', '0000-00-00 00:00:00', '2017-12-14 02:52:26', ''),
(25, 103, '230232', 'HQS', '', 234001, 235000, 1000, 'NO', '0000-00-00 00:00:00', '2017-12-15 11:12:07', ''),
(26, 103, '678678', 'HQS', '', 235001, 236000, 1000, 'NO', '0000-00-00 00:00:00', '2017-12-15 11:21:00', ''),
(27, 108, '3435343', 'EMAD SUPPLIERS', 'NA', 0, 0, 20, 'NO', '2020-09-02 00:00:00', '2020-09-02 12:38:30', 'N'),
(28, 103, '3435343', 'EMAD SUPPLIERS', 'NJORO', 234560001, 234570000, 1000, 'NO', '2020-09-02 00:00:00', '2020-09-02 12:40:12', 'N');

-- --------------------------------------------------------

--
-- Table structure for table `stunits`
--

CREATE TABLE IF NOT EXISTS `stunits` (
  `no` int(11) NOT NULL AUTO_INCREMENT,
  `udesc` varchar(255) NOT NULL,
  PRIMARY KEY (`no`),
  UNIQUE KEY `udesc` (`udesc`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `stunits`
--

INSERT INTO `stunits` (`no`, `udesc`) VALUES
(4, 'BOX'),
(3, 'BUNDLE'),
(1, 'KG'),
(2, 'LITRE'),
(5, 'NO');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `receivables`
--
ALTER TABLE `receivables`
  ADD CONSTRAINT `receivables_ibfk_1` FOREIGN KEY (`itemcode`) REFERENCES `items` (`itemcode`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
