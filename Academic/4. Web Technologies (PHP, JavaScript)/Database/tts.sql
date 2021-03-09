-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 07, 2020 at 03:28 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tts`
--

-- --------------------------------------------------------

--
-- Table structure for table `complain`
--

CREATE TABLE `complain` (
  `complainid` int(11) NOT NULL,
  `passengerid` int(11) NOT NULL,
  `issuedate` datetime NOT NULL,
  `details` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `complain`
--

INSERT INTO `complain` (`complainid`, `passengerid`, `issuedate`, `details`) VALUES
(1, 1, '2019-12-21 03:00:00', 'Your Customer Manager, Mr Tanvir is not sincere at his job, please change him');

-- --------------------------------------------------------

--
-- Table structure for table `employeeinfo`
--

CREATE TABLE `employeeinfo` (
  `employeeid` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `mobileno` varchar(14) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(20) NOT NULL,
  `address` varchar(200) DEFAULT NULL,
  `designation` varchar(25) NOT NULL,
  `salary` int(5) NOT NULL,
  `hiredate` date NOT NULL,
  `commission` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employeeinfo`
--

INSERT INTO `employeeinfo` (`employeeid`, `name`, `mobileno`, `email`, `password`, `address`, `designation`, `salary`, `hiredate`, `commission`) VALUES
(1, 'Rejwan Ahmed', '01711085769', 'rejwan@live.com', 'ahmed', 'Dhaka 1216, Bangladesh', 'Admin', 25000, '2019-12-20', 0),
(3, 'Tanvir Azad', '01711085768', 'tanvir@live.com', 'azadi', 'Dhanmondi-15,Dhaka', 'Customere Manager', 35000, '2019-12-20', 5),
(4, 'Rejwan Ahmed ', '01711085757', 'rejwan.ahmed@live.com', 'redwan', 'Badda, Dhaka', 'Customer Manager', 15000, '2019-12-24', 5);

-- --------------------------------------------------------

--
-- Table structure for table `journeytimeinfo`
--

CREATE TABLE `journeytimeinfo` (
  `journeytimeid` int(11) NOT NULL,
  `trainid` int(11) NOT NULL,
  `journeydate` date NOT NULL,
  `standardavailableseat` int(5) DEFAULT NULL,
  `economyavailableseat` int(5) DEFAULT NULL,
  `firstclassavailableseat` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `journeytimeinfo`
--

INSERT INTO `journeytimeinfo` (`journeytimeid`, `trainid`, `journeydate`, `standardavailableseat`, `economyavailableseat`, `firstclassavailableseat`) VALUES
(1, 1, '2019-12-23', 90, 350, 50),
(2, 2, '2019-12-23', 100, 350, 50),
(3, 3, '2019-12-23', 100, 350, 50),
(4, 4, '2019-12-23', 100, 350, 50),
(5, 5, '2019-12-23', 100, 350, 50),
(6, 6, '2019-12-23', 100, 350, 50),
(7, 7, '2019-12-23', 100, 350, 50),
(8, 8, '2019-12-23', 100, 350, 50),
(9, 9, '2019-12-23', 100, 350, 50),
(10, 10, '2019-12-23', 100, 350, 50),
(11, 11, '2019-12-23', 100, 350, 50),
(12, 12, '2019-12-23', 100, 350, 50),
(13, 1, '2019-12-24', 100, 350, 50),
(14, 2, '2019-12-24', 100, 350, 50),
(15, 3, '2019-12-24', 100, 350, 50),
(16, 4, '2019-12-24', 100, 350, 50),
(17, 5, '2019-12-24', 100, 350, 50),
(18, 6, '2019-12-24', 100, 350, 50),
(19, 7, '2019-12-24', 100, 350, 50),
(20, 8, '2019-12-24', 100, 350, 50),
(21, 9, '2019-12-24', 100, 350, 50),
(22, 10, '2019-12-24', 100, 350, 50),
(23, 11, '2019-12-24', 100, 350, 50),
(24, 12, '2019-12-24', 100, 350, 50),
(25, 1, '2019-12-25', 100, 350, 50),
(26, 2, '2019-12-25', 100, 350, 50),
(27, 3, '2019-12-25', 100, 350, 50),
(28, 4, '2019-12-25', 100, 350, 50),
(29, 5, '2019-12-25', 100, 350, 50),
(30, 6, '2019-12-25', 100, 350, 50),
(31, 7, '2019-12-25', 100, 350, 50),
(32, 8, '2019-12-25', 100, 350, 50),
(33, 9, '2019-12-25', 100, 350, 50),
(34, 10, '2019-12-25', 100, 350, 50),
(35, 11, '2019-12-25', 100, 350, 50),
(36, 12, '2019-12-25', 100, 350, 50);

-- --------------------------------------------------------

--
-- Table structure for table `logininfo`
--

CREATE TABLE `logininfo` (
  `loginid` int(11) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(20) NOT NULL,
  `usertype` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `logininfo`
--

INSERT INTO `logininfo` (`loginid`, `email`, `password`, `usertype`) VALUES
(1, 'rejwan@live.com', 'ahmed', 'Admin'),
(2, 'manwar@live.com', 'manwar', 'Passenger'),
(3, 'tanvir@live.com', 'tanvir', 'Customer Manager'),
(4, 'fahim@live.com', 'fahim', 'Passenger'),
(5, 'rejwan.ahmed@live.com', 'redwan', 'Customoer Manager');

-- --------------------------------------------------------

--
-- Table structure for table `passengerinfo`
--

CREATE TABLE `passengerinfo` (
  `passengerid` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `mobileno` varchar(14) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(20) NOT NULL,
  `address` varchar(200) DEFAULT NULL,
  `cardinfo` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `passengerinfo`
--

INSERT INTO `passengerinfo` (`passengerid`, `name`, `mobileno`, `email`, `password`, `address`, `cardinfo`) VALUES
(1, 'Manwar Hossain', '01711085770', 'manwar@live.com', 'manwar', 'Mirpur, Dhaka', '123456789'),
(2, 'Fahim Ashraf', '01711085771', 'fahim@live.com', 'fahim', 'Demra, Dhaka', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `soldticketinfo`
--

CREATE TABLE `soldticketinfo` (
  `soldticketid` int(11) NOT NULL,
  `passengerid` int(11) NOT NULL,
  `employeeid` int(11) NOT NULL,
  `trainid` int(11) NOT NULL,
  `journeytimeid` int(11) NOT NULL,
  `issuedate` datetime NOT NULL,
  `class` varchar(30) NOT NULL,
  `amountofticket` int(5) NOT NULL,
  `bill` float NOT NULL,
  `vat` float NOT NULL,
  `netbill` float NOT NULL,
  `paytype` varchar(30) NOT NULL,
  `card` double NOT NULL,
  `cardnumber` varchar(30) NOT NULL,
  `cash` float NOT NULL,
  `remaining` float NOT NULL,
  `couchno` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `soldticketinfo`
--

INSERT INTO `soldticketinfo` (`soldticketid`, `passengerid`, `employeeid`, `trainid`, `journeytimeid`, `issuedate`, `class`, `amountofticket`, `bill`, `vat`, `netbill`, `paytype`, `card`, `cardnumber`, `cash`, `remaining`, `couchno`) VALUES
(3, 1, 1, 1, 1, '2019-12-21 03:00:00', 'Standard (AC Couch)', 5, 3500, 5, 3675, 'Card', 3675, '123456789', 0, 0, '51, 52, 53, 54, 55'),
(4, 1, 1, 1, 1, '2019-12-23 03:00:00', 'Standard (AC Couch)', 5, 3500, 5, 3675, 'Card', 3675, '123456789', 0, 0, '56, 57, 58, 59, 60');

-- --------------------------------------------------------

--
-- Table structure for table `traininfo`
--

CREATE TABLE `traininfo` (
  `trainid` int(11) NOT NULL,
  `trainno` varchar(20) DEFAULT NULL,
  `name` varchar(200) NOT NULL,
  `offday` varchar(30) DEFAULT NULL,
  `departurestation` varchar(200) NOT NULL,
  `departuretime` time(6) NOT NULL,
  `arrivalstation` varchar(200) NOT NULL,
  `arrivaltime` time(6) DEFAULT NULL,
  `routetype` varchar(200) DEFAULT NULL,
  `capacity` int(5) DEFAULT NULL,
  `standard` int(5) DEFAULT NULL,
  `priceperstandard` int(5) DEFAULT NULL,
  `economy` int(5) DEFAULT NULL,
  `pricepereconomy` int(5) DEFAULT NULL,
  `firstclass` int(5) DEFAULT NULL,
  `priceperfirstclass` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `traininfo`
--

INSERT INTO `traininfo` (`trainid`, `trainno`, `name`, `offday`, `departurestation`, `departuretime`, `arrivalstation`, `arrivaltime`, `routetype`, `capacity`, `standard`, `priceperstandard`, `economy`, `pricepereconomy`, `firstclass`, `priceperfirstclass`) VALUES
(1, '701', 'Subarna Express', 'Monday', 'CHITTAGONG', '07:00:00.000000', 'DHAKA', '12:10:00.000000', 'Intercity Trains(Meter Gauge & Dual Gauge)', 500, 100, 700, 350, 450, 50, 900),
(2, '702', 'Subarna Express', 'Monday', 'DHAKA', '15:00:00.000000', 'CHITTAGONG', '20:10:00.000000', 'Intercity Trains(Meter Gauge & Dual Gauge)', 500, 100, 700, 350, 450, 50, 900),
(3, '709', 'Parabat Express', 'Tuesday', 'DHAKA', '06:35:00.000000', 'SYLHET', '13:20:00.000000', 'Intercity Trains(Meter Gauge & Dual Gauge)', 500, 100, 700, 350, 450, 50, 900),
(4, '710', 'Parabat Express', 'Tuesday', 'SYLHET', '15:00:00.000000', 'DHAKA', '21:55:00.000000', 'Intercity Trains(Meter Gauge & Dual Gauge)', 500, 100, 700, 350, 450, 50, 900),
(5, '715', 'Kapotaskh Express', 'Saturday', 'KHULNA', '06:30:00.000000', 'RAJSHAHI', '12:20:00.000000', 'Intercity Trains (Broad Gauge & Dual Gauge)			\r\n', 500, 100, 700, 350, 450, 50, 900),
(6, '716', 'Kapotaskh Express', 'Saturday', 'RAJSHAHI', '14:15:00.000000', 'KHULNA', '20:00:00.000000', 'Intercity Trains (Broad Gauge & Dual Gauge)			\r\n', 500, 100, 700, 350, 450, 50, 900),
(7, '725', 'Sundarban Express\r\n', 'Monday', 'KHULNA', '20:30:00.000000', 'DHAKA', '05:40:00.000000', 'Intercity Trains (Broad Gauge & Dual Gauge)			\r\n', 500, 100, 700, 350, 450, 50, 900),
(8, '726', 'Sundarban Express\r\n', 'Wednesday', 'DHAKA', '06:20:00.000000', 'KHULNA', '15:40:00.000000', 'Intercity Trains (Broad Gauge & Dual Gauge)			\r\n', 500, 100, 700, 350, 450, 50, 900),
(9, '12', 'Noakhali Express\r\n\r\n', NULL, 'DHAKA', '20:20:00.000000', 'NOAKHALI', '05:50:00.000000', 'Mail/Express Trains (Metre Gauge)', 500, 100, 700, 350, 450, 50, 900),
(10, '11', 'Dhaka Express\r\n\r\n', NULL, 'NOAKHALI', '20:40:00.000000', 'DHAKA', '06:40:00.000000', 'Mail/Express Trains (Metre Gauge)', 500, 100, 700, 350, 450, 50, 900),
(11, '53', 'Benapol Commute\r\n\r\n\r\n', NULL, 'KHULNA', '15:30:00.000000', 'BENAPOL', '18:10:00.000000', 'Mail/Express Trains (Metre Gauge)', 500, 100, 700, 350, 450, 50, 900),
(12, '54', 'Benapol Commute\r\n\r\n\r\n', NULL, 'BENAPOL', '06:00:00.000000', 'KHULNA', '08:30:00.000000', 'Mail/Express Trains (Metre Gauge)', 500, 100, 700, 350, 450, 50, 900),
(13, '54', 'Motin Express\r\n\r\n\r\n', NULL, 'BENAPOL', '06:00:00.000000', 'KHULNA', '08:30:00.000000', 'Mail/Express Trains (Metre Gauge)', 500, 100, 700, 350, 450, 50, 900),
(14, '56', 'Motin Express\r\n\r\n\r\n', NULL, 'Benapol', '08:30:00.000000', 'BENAPOL', '06:40:00.000000', 'Mail/Express Trains (Metre Gauge)', 500, 100, 700, 350, 450, 50, 900),
(15, 'Turag1/3', 'Turag Express', 'Friday', 'Dhaka', '17:20:00.000000', 'Joydebpur', '18:40:00.000000', 'Mail/Express Trains(Metre Gauge)', 500, 100, 200, 350, 100, 50, 350),
(16, '712', 'Faridpur Express', 'Tuesday', 'Dhaka', '10:00:00.000000', 'Faridpur', '16:00:00.000000', 'Mail/Express Trains (Metre Gauge)', 500, 100, 700, 350, 450, 50, 900),
(17, '21', 'chittagon', 'wednesday', 'dhaka', '01:06:00.000000', 'khulna', '16:03:00.000000', 'rail', 500, 100, 2, 1, 2, 11, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `complain`
--
ALTER TABLE `complain`
  ADD PRIMARY KEY (`complainid`),
  ADD KEY `passengerid` (`passengerid`);

--
-- Indexes for table `employeeinfo`
--
ALTER TABLE `employeeinfo`
  ADD PRIMARY KEY (`employeeid`);

--
-- Indexes for table `journeytimeinfo`
--
ALTER TABLE `journeytimeinfo`
  ADD PRIMARY KEY (`journeytimeid`),
  ADD KEY `trainid` (`trainid`);

--
-- Indexes for table `logininfo`
--
ALTER TABLE `logininfo`
  ADD PRIMARY KEY (`loginid`);

--
-- Indexes for table `passengerinfo`
--
ALTER TABLE `passengerinfo`
  ADD PRIMARY KEY (`passengerid`);

--
-- Indexes for table `soldticketinfo`
--
ALTER TABLE `soldticketinfo`
  ADD PRIMARY KEY (`soldticketid`),
  ADD KEY `passengerid` (`passengerid`),
  ADD KEY `employeeid` (`employeeid`),
  ADD KEY `trainid` (`trainid`),
  ADD KEY `journeytimeid` (`journeytimeid`);

--
-- Indexes for table `traininfo`
--
ALTER TABLE `traininfo`
  ADD PRIMARY KEY (`trainid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `complain`
--
ALTER TABLE `complain`
  MODIFY `complainid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employeeinfo`
--
ALTER TABLE `employeeinfo`
  MODIFY `employeeid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `journeytimeinfo`
--
ALTER TABLE `journeytimeinfo`
  MODIFY `journeytimeid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `logininfo`
--
ALTER TABLE `logininfo`
  MODIFY `loginid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `passengerinfo`
--
ALTER TABLE `passengerinfo`
  MODIFY `passengerid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `soldticketinfo`
--
ALTER TABLE `soldticketinfo`
  MODIFY `soldticketid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `traininfo`
--
ALTER TABLE `traininfo`
  MODIFY `trainid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `complain`
--
ALTER TABLE `complain`
  ADD CONSTRAINT `complain_ibfk_1` FOREIGN KEY (`passengerid`) REFERENCES `passengerinfo` (`passengerid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `journeytimeinfo`
--
ALTER TABLE `journeytimeinfo`
  ADD CONSTRAINT `journeytimeinfo_ibfk_1` FOREIGN KEY (`trainid`) REFERENCES `traininfo` (`trainid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `soldticketinfo`
--
ALTER TABLE `soldticketinfo`
  ADD CONSTRAINT `soldticketinfo_ibfk_1` FOREIGN KEY (`passengerid`) REFERENCES `passengerinfo` (`passengerid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `soldticketinfo_ibfk_2` FOREIGN KEY (`employeeid`) REFERENCES `employeeinfo` (`employeeid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `soldticketinfo_ibfk_3` FOREIGN KEY (`trainid`) REFERENCES `traininfo` (`trainid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `soldticketinfo_ibfk_4` FOREIGN KEY (`journeytimeid`) REFERENCES `journeytimeinfo` (`journeytimeid`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
