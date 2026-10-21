-- FIGYELEM: a script torli a konyvtar_gyakorlat adatbazist, ha mar letezik!
DROP DATABASE IF EXISTS konyvtar_gyakorlat;
CREATE DATABASE konyvtar_gyakorlat CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE konyvtar_gyakorlat;

CREATE TABLE Szerzok (Id INT AUTO_INCREMENT PRIMARY KEY, Nev VARCHAR(100) NOT NULL);
CREATE TABLE Kategoriak (Id INT AUTO_INCREMENT PRIMARY KEY, Nev VARCHAR(100) NOT NULL UNIQUE);
CREATE TABLE Konyvek (
 Id INT AUTO_INCREMENT PRIMARY KEY, Cim VARCHAR(150) NOT NULL,
 SzerzoId INT NOT NULL, KategoriaId INT NOT NULL, KiadasEve INT NOT NULL,
 FOREIGN KEY (SzerzoId) REFERENCES Szerzok(Id),
 FOREIGN KEY (KategoriaId) REFERENCES Kategoriak(Id)
);
CREATE TABLE Olvasok (
 Id INT AUTO_INCREMENT PRIMARY KEY, Nev VARCHAR(100) NOT NULL,
 Email VARCHAR(150) NOT NULL UNIQUE, Aktiv BOOLEAN NOT NULL DEFAULT TRUE
);
CREATE TABLE Kolcsonzesek (
 Id INT AUTO_INCREMENT PRIMARY KEY, KonyvId INT NOT NULL, OlvasoId INT NOT NULL,
 Kezdete DATE NOT NULL, Hatarido DATE NOT NULL, Visszahozva DATE NULL,
 FOREIGN KEY (KonyvId) REFERENCES Konyvek(Id),
 FOREIGN KEY (OlvasoId) REFERENCES Olvasok(Id)
);
INSERT INTO Szerzok VALUES
(1,'Molnár Ferenc'),(2,'Gárdonyi Géza'),(3,'Szabó Magda'),(4,'Jókai Mór'),
(5,'Fekete István'),(6,'George Orwell'),(7,'Antoine de Saint-Exupéry'),(8,'Móricz Zsigmond');
INSERT INTO Kategoriak VALUES
(1,'Ifjúsági regény'),(2,'Történelmi regény'),(3,'Szépirodalom'),(4,'Disztópia'),(5,'Kalandregény');
INSERT INTO Konyvek VALUES
(1,'A Pál utcai fiúk',1,1,1906),(2,'Egri csillagok',2,2,1899),
(3,'Abigél',3,1,1970),(4,'Az arany ember',4,3,1872),
(5,'Tüskevár',5,5,1957),(6,'1984',6,4,1949),
(7,'A kis herceg',7,1,1943),(8,'Légy jó mindhalálig',8,3,1920);
INSERT INTO Olvasok VALUES
(1,'Kiss Anna','kiss.anna@example.com',TRUE),
(2,'Nagy Péter','nagy.peter@example.com',TRUE),
(3,'Tóth Luca','toth.luca@example.com',TRUE),
(4,'Varga Bence','varga.bence@example.com',TRUE),
(5,'Kovács Réka','kovacs.reka@example.com',FALSE),
(6,'Szabó Dániel','szabo.daniel@example.com',TRUE);
-- Egy konyvhoz legfeljebb egy aktiv kolcsonzes tartozik.
INSERT INTO Kolcsonzesek VALUES
(1,1,2,'2026-09-10','2026-09-24',NULL),
(2,2,1,'2026-09-20','2026-10-04',NULL),
(3,3,4,'2026-09-12','2026-09-26','2026-09-25'),
(4,4,3,'2026-09-21','2026-10-05',NULL),
(5,3,1,'2026-10-05','2026-10-19',NULL),
(6,6,4,'2026-09-15','2026-09-29','2026-09-28'),
(7,7,2,'2026-09-25','2026-10-09',NULL),
(8,6,3,'2026-10-04','2026-10-18',NULL),
(9,5,1,'2026-10-08','2026-10-22',NULL),
(10,1,1,'2026-08-01','2026-08-15','2026-08-14'),
(11,2,2,'2026-08-10','2026-08-24','2026-08-28'),
(12,4,3,'2026-09-01','2026-09-15','2026-09-15'),
(13,5,4,'2026-09-03','2026-09-17','2026-09-16'),
(14,7,2,'2026-09-05','2026-09-19','2026-09-21'),
(15,8,3,'2026-09-10','2026-09-24','2026-09-23'),
(16,3,4,'2026-08-01','2026-08-15','2026-08-16');
-- Ellenorzes
SELECT COUNT(*) AS Konyvek FROM Konyvek;
SELECT COUNT(*) AS AktivKolcsonzesek FROM Kolcsonzesek WHERE Visszahozva IS NULL;
