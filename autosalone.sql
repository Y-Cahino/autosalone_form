CREATE DATABASE IF NOT EXISTS 'autosaloni';
USE 'autosaloni';
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
--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `autosalone`
CREATE TABLE 'autosalone'(
  'bunghID' INT(11) NOT NULL AUTO_INCREMENT,
  'modello_id' INT(11) NOT NULL,
  'anno_produzione' INT(4) NOT NULL,
  'prezzo_id' INT(11) NOT NULL,
  'marca_id' INT(11) NOT NULL,
  'n_u' TINYINT(1) NOT NULL, --0=usata, 1=nuova
  'test_drive' TINYINT(1) NOT NULL, --0 =no, 1=si
  'promo' INT(3) DEFAULT 0,
  PRIMARY KEY (`bunghID`),
  FOREIGN KEY (`modello_id`) REFERENCES `modelli`(`id`),
  FOREIGN KEY (`anno_produzione`) REFERENCES `anni`(`anno`),
  FOREIGN KEY (`prezzo_id`) REFERENCES `prezzi`(`id`),
  FOREIGN KEY (`marca_id`) REFERENCES `marche`(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;