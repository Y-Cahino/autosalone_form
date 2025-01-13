CREATE DATABASE IF NOT EXISTS autosaloni;
USE autosaloni;
--
-- Dump dei dati per la tabella `autosalone`
--
--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `autosalone`
--
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

CREATE TABLE 'marche'(
  'id' INT(11) NOT NULL AUTO_INCREMENT,
  'marca_n' VARCHAR(20) NOT NULL,
  PRIMARY KEY ('id')
) NGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE 'anni'(
  'anno' INT(4) NOT NULL,
  PRIMARY KEY ('anno')
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
CREATE TABLE 'modelli'(
  'id' INT(11) NOT NULL AUTO_INCREMENT,
  'modello_n' VARCHAR(20) NOT NULL,
  PRIMARY KEY ('id')
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--Inserimento Dati
INSERT INTO 'modelli'('modello_n') VALUES
('Panda'), ('C3'), ('Yaris GR');
INSERT INTO 'marche'('marca_n') VALUES
('Fiat'), ('Citroén'), ('Toyota');
INSERT INTO 'anni'('anno') VALUES
(2015), (2017), (2020);
INSERT INTO 'prezzi'('prezzo') VALUES
(9999), (12450), (17000);
INSERT INTO 'autosalone'('modello_id', 'anno_produzione', 'prezzo_id', 'marca_id', 'n_u', 'promo') VALUES
(1, 2015, 1, 1, 0, 0, 0),
(2, 2017, 2, 2, 0, 0, 0),
(3, 2020, 3, 3, 0, 0, 0);
