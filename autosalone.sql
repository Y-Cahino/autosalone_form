-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Dic 19, 2024 alle 09:08
-- Versione del server: 10.4.28-MariaDB
-- Versione PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `autosaloni`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `autosalone`
--

CREATE TABLE `autosalone` (
  `bunghID` int(11) NOT NULL,
  `Modello` varchar(20) NOT NULL,
  `Anno di Produzione` int(4) NOT NULL,
  `Prezzo` int(11) NOT NULL,
  `Marca` varchar(20) NOT NULL,
  `Nuova o Usata` tinyint(1) NOT NULL,
  `Test Drive` tinyint(1) NOT NULL,
  `Promo` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `autosalone`
--

INSERT INTO `autosalone` (`bunghID`, `Modello`, `Anno di Produzione`, `Prezzo`, `Marca`, `Nuova o Usata`, `Test Drive`, `Promo`) VALUES
(1, 'Panda', 2015, 9999, 'Fiat', 0, 0, 0),
(2, 'C3', 2017, 12450, 'Citroén', 0, 0, 0),
(3, 'Yaris GR', 2020, 17000, 'Toyota', 0, 0, 0);

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `autosalone`
--
ALTER TABLE `autosalone`
  ADD PRIMARY KEY (`bunghID`),
  ADD KEY `auto-marche` (`Marca`),
  ADD KEY `auto-model` (`Modello`),
  ADD KEY `auto-ap` (`Anno di Produzione`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `autosalone`
--
ALTER TABLE `autosalone`
  MODIFY `bunghID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `autosalone`
--
ALTER TABLE `autosalone`
  ADD CONSTRAINT `auto-ap` FOREIGN KEY (`Anno di Produzione`) REFERENCES `ap` (`Anno di Produzione`),
  ADD CONSTRAINT `auto-marche` FOREIGN KEY (`Marca`) REFERENCES `marche` (`Marca`),
  ADD CONSTRAINT `auto-model` FOREIGN KEY (`Modello`) REFERENCES `modelli` (`modello_nome`),
  ADD CONSTRAINT `auto-pr` FOREIGN KEY (`Prezzo`) REFERENCES `prezzi` (`Prezzo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
