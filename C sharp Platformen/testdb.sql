-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 21. 12 2017 kl. 14:11:10
-- Serverversion: 10.1.28-MariaDB
-- PHP-version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `testdb`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `testtable`
--

CREATE TABLE `testtable` (
  `Card_number` int(11) NOT NULL,
  `Pin_code` int(11) NOT NULL,
  `Balance` int(11) NOT NULL,
  `Name` text NOT NULL,
  `Surname` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `testtable`
--

INSERT INTO `testtable` (`Card_number`, `Pin_code`, `Balance`, `Name`, `Surname`) VALUES
(5555, 5555, 750000, 'Jennifer ', 'Aniston '),
(6666, 4444, 800000, 'Jennifer', 'Lawrence'),
(7777, 3333, 970000, 'Megan', 'Fox'),
(8888, 2222, 59000, 'Martin', 'Jorgensen'),
(9999, 1111, 43900, 'Michael ', 'Christensen');

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `testtable`
--
ALTER TABLE `testtable`
  ADD PRIMARY KEY (`Card_number`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `testtable`
--
ALTER TABLE `testtable`
  MODIFY `Card_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10000;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
