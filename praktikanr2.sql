-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: 2020 m. Grd 09 d. 07:44
-- Server version: 10.4.13-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `praktikanr2`
--

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `groups`
--

DROP TABLE IF EXISTS `groups`;
CREATE TABLE IF NOT EXISTS `groups` (
  `PKGroupID` int(11) NOT NULL AUTO_INCREMENT,
  `GroupName` varchar(100) NOT NULL,
  PRIMARY KEY (`PKGroupID`),
  UNIQUE KEY `groups_un` (`GroupName`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `groups`
--

INSERT INTO `groups` (`PKGroupID`, `GroupName`) VALUES
(18, 'DAVS'),
(3, 'DEVLAB PI19A'),
(4, 'DEVLAB PI20A'),
(12, 'DEVLAB PI22A');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `lecturesettable`
--

DROP TABLE IF EXISTS `lecturesettable`;
CREATE TABLE IF NOT EXISTS `lecturesettable` (
  `LectureSetID` int(11) NOT NULL AUTO_INCREMENT,
  `FKLectureID` varchar(100) DEFAULT NULL,
  `FKGroupID` int(11) DEFAULT NULL,
  `FKUserID` int(11) DEFAULT NULL,
  PRIMARY KEY (`LectureSetID`),
  KEY `LecturesetTable_FK_1` (`FKUserID`),
  KEY `lecturesettable_FK` (`FKLectureID`),
  KEY `lecturesettable_FK_3` (`FKGroupID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `lecturesettable`
--

INSERT INTO `lecturesettable` (`LectureSetID`, `FKLectureID`, `FKGroupID`, `FKUserID`) VALUES
(8, 'Informacines Sistemos', 12, 17),
(9, 'Duomenu Baziu projektavimas', 3, 15),
(10, 'Duomenu Baziu projektavimas', 4, 15);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `lecturetable`
--

DROP TABLE IF EXISTS `lecturetable`;
CREATE TABLE IF NOT EXISTS `lecturetable` (
  `Lecture_Name` varchar(100) NOT NULL,
  PRIMARY KEY (`Lecture_Name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `lecturetable`
--

INSERT INTO `lecturetable` (`Lecture_Name`) VALUES
('adasdasddsa'),
('asdsadsadsda'),
('Duomenu Baziu projektavimas'),
('Informacines Sistemos');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `marks`
--

DROP TABLE IF EXISTS `marks`;
CREATE TABLE IF NOT EXISTS `marks` (
  `PKMarkID` int(11) NOT NULL AUTO_INCREMENT,
  `Mark` int(2) UNSIGNED NOT NULL,
  `FKUserID` int(11) DEFAULT NULL,
  `FKLecture` int(11) DEFAULT NULL,
  PRIMARY KEY (`PKMarkID`),
  KEY `marks_FK` (`FKUserID`),
  KEY `marks_FK_1` (`FKLecture`)
) ;

--
-- Sukurta duomenų kopija lentelei `marks`
--

INSERT INTO `marks` (`PKMarkID`, `Mark`, `FKUserID`, `FKLecture`) VALUES
(11, 10, 16, 9),
(12, 10, 16, 8),
(13, 4, 21, 8),
(14, 6, 22, 9);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `usertable`
--

DROP TABLE IF EXISTS `usertable`;
CREATE TABLE IF NOT EXISTS `usertable` (
  `PKUserID` int(11) NOT NULL AUTO_INCREMENT,
  `Vardas` varchar(100) NOT NULL,
  `Pavarde` varchar(100) NOT NULL,
  `Type` varchar(11) DEFAULT NULL,
  `el_pastas` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `Slaptazodis` varchar(100) NOT NULL,
  `FKGroupID` int(11) DEFAULT NULL,
  PRIMARY KEY (`PKUserID`),
  UNIQUE KEY `usertable_un_el_pastas` (`el_pastas`),
  UNIQUE KEY `usertable_un_pavarde` (`Vardas`,`Pavarde`),
  KEY `usertable_FK` (`FKGroupID`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `usertable`
--

INSERT INTO `usertable` (`PKUserID`, `Vardas`, `Pavarde`, `Type`, `el_pastas`, `username`, `Slaptazodis`, `FKGroupID`) VALUES
(15, 'Danielius', 'Fultinavcius', 'Admin', 'danielius.fultis@gmail.com', 'admin1 ', 'admin1', 3),
(16, 'Dan', 'Dan', 'Student', 'asdsadasd', 'das', 'das', 4),
(17, 'iwa', 'dawa', 'Lecturer', 'dandan', 'dandan', 'dandan', 12),
(21, 'komolejas', 'dasunas', 'Student', 'dassadasd', 'dasadsadsads', 'adsasdadsasdads', 4),
(22, 'dsaasdasd', 'sadasda', 'adsasdasd', 'asdasdasd', 'asdasd', 'asdasdasd', 4);

--
-- Apribojimai eksportuotom lentelėm
--

--
-- Apribojimai lentelei `lecturesettable`
--
ALTER TABLE `lecturesettable`
  ADD CONSTRAINT `LecturesetTable_FK_1` FOREIGN KEY (`FKUserID`) REFERENCES `usertable` (`PKUserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `lecturesettable_FK` FOREIGN KEY (`FKLectureID`) REFERENCES `lecturetable` (`Lecture_Name`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `lecturesettable_FK_3` FOREIGN KEY (`FKGroupID`) REFERENCES `groups` (`PKGroupID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Apribojimai lentelei `marks`
--
ALTER TABLE `marks`
  ADD CONSTRAINT `marks_FK` FOREIGN KEY (`FKUserID`) REFERENCES `usertable` (`PKUserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `marks_FK_1` FOREIGN KEY (`FKLecture`) REFERENCES `lecturesettable` (`LectureSetID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Apribojimai lentelei `usertable`
--
ALTER TABLE `usertable`
  ADD CONSTRAINT `usertable_FK` FOREIGN KEY (`FKGroupID`) REFERENCES `groups` (`PKGroupID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
