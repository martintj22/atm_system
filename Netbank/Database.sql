-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1:3306
-- Genereringstid: 21. 12 2017 kl. 13:37:30
-- Serverversion: 5.7.19
-- PHP-version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test2`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `konto`
--

DROP TABLE IF EXISTS `konto`;
CREATE TABLE IF NOT EXISTS `konto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `saldo` int(5) NOT NULL,
  `login_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_products_1` (`login_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `konto`
--

INSERT INTO `konto` (`id`, `saldo`, `login_id`) VALUES
(1, 55500, 1),
(2, 80000, 2);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `id` int(9) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `login`
--

INSERT INTO `login` (`id`, `name`, `email`, `username`, `password`) VALUES
(1, 'Martin', 'satoz.game@gmail.com', 'martintj22', '3e728f11f3c11b005f7ad9cb652119d1'),
(2, 'lol', 'kk@gmail.xom', '5170-20172017', '2312'),
(3, 'test', 'satoz.game@gmail.com', '5170-20182018', '69dafe8b58066478aea48f3d0f384820');

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `konto`
--
ALTER TABLE `konto`
  ADD CONSTRAINT `FK_products_1` FOREIGN KEY (`login_id`) REFERENCES `login` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
