-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 05, 2019 at 06:34 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `snowflake`
--

-- --------------------------------------------------------

--
-- Table structure for table `customerinfo`
--

CREATE TABLE `customerinfo` (
  `customerID` int(3) NOT NULL,
  `customerName` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `mobileNumber` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customerinfo`
--

INSERT INTO `customerinfo` (`customerID`, `customerName`, `email`, `mobileNumber`) VALUES
(1, 'Anonymous', 'Anonymous', 'Anonymous'),
(113, 'Rudro Ahsan', 'rudro@live.com', '01684264978'),
(114, 'Riju', 'riju@live.com', '01971085769'),
(115, 'Rafi', 'rafi@gmail.com', '01711085769'),
(116, 'Firoz Ahmed', 'firoz@gmail.com', '01711085769');

-- --------------------------------------------------------

--
-- Table structure for table `employeeinfo`
--

CREATE TABLE `employeeinfo` (
  `employeeID` int(3) NOT NULL,
  `employeeName` varchar(30) NOT NULL,
  `designation` varchar(25) NOT NULL,
  `salary` int(6) NOT NULL,
  `mobileNumber` varchar(11) NOT NULL,
  `email` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employeeinfo`
--

INSERT INTO `employeeinfo` (`employeeID`, `employeeName`, `designation`, `salary`, `mobileNumber`, `email`) VALUES
(111, 'REJWAN AHMED', 'Manager', 30000, '01711085769', 'rejwan.ahmed@live.com'),
(112, 'KAISAR AHMED SOUMIK', 'Customer Manager', 15000, '01689975474', 'soumik@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `hallinfo`
--

CREATE TABLE `hallinfo` (
  `hallID` int(3) NOT NULL,
  `hallName` varchar(30) NOT NULL,
  `capacity` int(3) NOT NULL,
  `hallType` varchar(20) NOT NULL,
  `pricePerSeat` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hallinfo`
--

INSERT INTO `hallinfo` (`hallID`, `hallName`, `capacity`, `hallType`, `pricePerSeat`) VALUES
(951, 'Olympus', 300, '2D', 300),
(952, 'Black Diamond', 300, '3D', 400),
(953, 'Apollo', 300, '3D', 400);

-- --------------------------------------------------------

--
-- Table structure for table `logininfo`
--

CREATE TABLE `logininfo` (
  `userID` int(3) NOT NULL,
  `password` varchar(20) NOT NULL,
  `userType` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `logininfo`
--

INSERT INTO `logininfo` (`userID`, `password`, `userType`) VALUES
(111, 'r111', 'Manager'),
(112, 's112', 'Customer Manager'),
(113, 'r113', 'Customer'),
(114, 'r114', 'Customer'),
(115, 'r115', 'Customer'),
(116, 'f116', 'Customer'),
(117, '117', 'Customer Manager');

-- --------------------------------------------------------

--
-- Table structure for table `movieinfo`
--

CREATE TABLE `movieinfo` (
  `movieID` int(3) NOT NULL,
  `movieName` varchar(50) NOT NULL,
  `genre` varchar(50) NOT NULL,
  `releaseDate` varchar(50) NOT NULL,
  `runningTime` varchar(50) NOT NULL,
  `rating` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `movieinfo`
--

INSERT INTO `movieinfo` (`movieID`, `movieName`, `genre`, `releaseDate`, `runningTime`, `rating`) VALUES
(555, 'Avengers: Infinity War', 'Action, Adventure, Sci-Fi ', 'April 27, 2018 (United States)', '149 Minutes', '8.5/10 (IMDb)'),
(556, 'Incredibles 2', 'Animation, Action, Adventure ', 'June 15, 2018 (United States)', '118 Minutes', '7.7/10 (IMDb)'),
(557, 'Aquaman', 'Action, Adventure, Fantasy ', 'December 21, 2018 (United States)', '143 minutes', '7.2/10 (IMDb)');

-- --------------------------------------------------------

--
-- Table structure for table `showtimeinfo`
--

CREATE TABLE `showtimeinfo` (
  `showTimeID` int(3) NOT NULL,
  `movieID` int(3) NOT NULL,
  `hallID` int(3) NOT NULL,
  `showDate` varchar(15) NOT NULL,
  `showTime` varchar(15) NOT NULL,
  `availableSeat` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `showtimeinfo`
--

INSERT INTO `showtimeinfo` (`showTimeID`, `movieID`, `hallID`, `showDate`, `showTime`, `availableSeat`) VALUES
(850, 555, 952, '25-04-2019', '11:00 AM', 0),
(851, 556, 953, '25-04-2019', '15:00 PM', 290),
(852, 555, 952, '25-04-2019', '15:00 PM', 289),
(853, 555, 952, '25-04-2019', '18:30 PM', 300),
(854, 555, 952, '26-04-2019', '11:00 AM', 300),
(855, 555, 952, '26-04-2019', '15:00 PM', 300),
(856, 555, 952, '27-04-2019', '15:00 PM', 300),
(857, 555, 952, '27-04-2019', '18:30 PM', 300),
(858, 556, 953, '25-04-2019', '11:00 AM', 295),
(859, 556, 953, '25-04-2019', '18:30 PM', 300),
(860, 556, 953, '26-04-2019', '18:30 PM', 300),
(861, 556, 953, '26-04-2019', '11:00 AM', 300),
(862, 556, 953, '27-04-2019', '11:00 AM', 300),
(863, 556, 953, '27-04-2019', '18:30 PM', 300),
(864, 557, 951, '25-04-2019', '11:00 AM', 292),
(865, 557, 951, '25-04-2019', '15:00 PM', 300),
(866, 557, 951, '26-04-2019', '15:00 PM', 300),
(867, 557, 951, '26-04-2019', '18:30 PM', 300),
(868, 557, 951, '27-04-2019', '18:30 PM', 300),
(869, 557, 951, '27-04-2019', '11:00 AM', 300);

-- --------------------------------------------------------

--
-- Table structure for table `soldticket`
--

CREATE TABLE `soldticket` (
  `soldTicketID` int(3) NOT NULL,
  `movieID` int(3) NOT NULL,
  `showTimeID` int(3) NOT NULL,
  `customerID` int(3) NOT NULL,
  `employeeID` int(3) NOT NULL,
  `seat` int(3) NOT NULL,
  `revenue` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `soldticket`
--

INSERT INTO `soldticket` (`soldTicketID`, `movieID`, `showTimeID`, `customerID`, `employeeID`, `seat`, `revenue`) VALUES
(201, 555, 850, 113, 112, 285, 114000),
(202, 556, 851, 114, 112, 10, 4000),
(203, 557, 864, 114, 112, 3, 900),
(204, 555, 850, 115, 111, 3, 1200),
(205, 555, 850, 116, 112, 3, 1200),
(206, 555, 850, 113, 111, 5, 2000),
(207, 556, 858, 116, 111, 5, 2000),
(208, 555, 852, 113, 111, 10, 4000),
(211, 555, 850, 1, 111, 4, 1600),
(212, 555, 852, 1, 111, 1, 400),
(213, 557, 864, 114, 111, 5, 1500);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customerinfo`
--
ALTER TABLE `customerinfo`
  ADD PRIMARY KEY (`customerID`);

--
-- Indexes for table `employeeinfo`
--
ALTER TABLE `employeeinfo`
  ADD PRIMARY KEY (`employeeID`);

--
-- Indexes for table `hallinfo`
--
ALTER TABLE `hallinfo`
  ADD PRIMARY KEY (`hallID`);

--
-- Indexes for table `logininfo`
--
ALTER TABLE `logininfo`
  ADD PRIMARY KEY (`userID`);

--
-- Indexes for table `movieinfo`
--
ALTER TABLE `movieinfo`
  ADD PRIMARY KEY (`movieID`);

--
-- Indexes for table `showtimeinfo`
--
ALTER TABLE `showtimeinfo`
  ADD PRIMARY KEY (`showTimeID`),
  ADD KEY `movieID` (`movieID`),
  ADD KEY `hallID` (`hallID`);

--
-- Indexes for table `soldticket`
--
ALTER TABLE `soldticket`
  ADD PRIMARY KEY (`soldTicketID`),
  ADD KEY `movieID` (`movieID`),
  ADD KEY `showTimeID` (`showTimeID`),
  ADD KEY `customerID` (`customerID`),
  ADD KEY `employeeID` (`employeeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customerinfo`
--
ALTER TABLE `customerinfo`
  MODIFY `customerID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=118;

--
-- AUTO_INCREMENT for table `employeeinfo`
--
ALTER TABLE `employeeinfo`
  MODIFY `employeeID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=118;

--
-- AUTO_INCREMENT for table `hallinfo`
--
ALTER TABLE `hallinfo`
  MODIFY `hallID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=954;

--
-- AUTO_INCREMENT for table `logininfo`
--
ALTER TABLE `logininfo`
  MODIFY `userID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=118;

--
-- AUTO_INCREMENT for table `movieinfo`
--
ALTER TABLE `movieinfo`
  MODIFY `movieID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=558;

--
-- AUTO_INCREMENT for table `showtimeinfo`
--
ALTER TABLE `showtimeinfo`
  MODIFY `showTimeID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=870;

--
-- AUTO_INCREMENT for table `soldticket`
--
ALTER TABLE `soldticket`
  MODIFY `soldTicketID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=214;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `showtimeinfo`
--
ALTER TABLE `showtimeinfo`
  ADD CONSTRAINT `showtimeinfo_ibfk_1` FOREIGN KEY (`movieID`) REFERENCES `movieinfo` (`MovieID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `showtimeinfo_ibfk_2` FOREIGN KEY (`hallID`) REFERENCES `hallinfo` (`hallID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `soldticket`
--
ALTER TABLE `soldticket`
  ADD CONSTRAINT `soldticket_ibfk_1` FOREIGN KEY (`movieID`) REFERENCES `movieinfo` (`MovieID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `soldticket_ibfk_2` FOREIGN KEY (`showTimeID`) REFERENCES `showtimeinfo` (`ShowTimeID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `soldticket_ibfk_3` FOREIGN KEY (`customerID`) REFERENCES `customerinfo` (`customerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `soldticket_ibfk_4` FOREIGN KEY (`employeeID`) REFERENCES `employeeinfo` (`employeeID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
