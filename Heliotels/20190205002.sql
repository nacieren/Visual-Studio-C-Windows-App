CREATE DATABASE Heliotels;

CREATE TABLE oteller (
  otelID INT NOT NULL PRIMARY KEY,
  otelisim VARCHAR(45) NOT NULL,
  otelkonum VARCHAR(45) NOT NULL,
  kişiSayısı VARCHAR(45) NOT NULL,
  puan VARCHAR(45) NOT NULL,
  fiyat VARCHAR(45) NOT NULL
);

INSERT INTO oteller (otelID, otelisim, otelkonum, kişiSayısı, puan, fiyat)
VALUES
  (1,'Hilton Dalaman', 'Dalaman', '10000', '4.8', '9500'),
  (2,'Aqua Fantasy', 'Antalya', '5500', '4.2', '8500'),
  (3,'Orka Lotus', 'İçmeler', '2000', '4.7', '7000'),
  (4,'Richmond', 'Pamucak', '12000', '4.1', '5000'),
  (5,'SunCity', 'Ölüdeniz', '7000', '4.4', '5500'),
  (6,'Jiva', 'Fethiye', '6000', '4.5', '6000'),
  (7,'Club Med', 'Bodrum', '4000', '4.2', '8000'),
  (8,'Ilıca', 'Çeşme', '2500', '4', '5700'),
  (9,'Ibis Styles', 'Bornova', '3500', '3.7', '3000'),
  (10,'Majura', 'Dalaman', '6250', '4', '4200'),
  (11,'DoubleTree', 'Datça', '2100', '4', '8000'),
  (12,'Swissotel', 'Bodrum', '11000', '4', '6600'),
  (13,'Four Points', 'Kula', '250', '4.8', '10000'),
  (14,'Gulumser Hatun', 'Manisa', '1500', '3.3', '2000'),
  (15,'Royal Asarlik', 'Bodrum', '700', '3.9', '3500'),
  (16,'My Marin', 'Fethiye', '2000', '4', '7000'),
  (17,'Elite World', 'Marmaris', '4000', '4.2', '6500'),
  (18,'Grand Hotel', 'Antalya', '8200', '4.1', '5700'),
  (19,'Green Nature', 'Kuşadası', '4600', '3.4', '2500'),
  (20,'Birgi Rukim', 'Ödemiş', '1000', '3.2', '1500'),
  (21,'Faros', 'Alaçatı', '500', '3.5', '3000'),
  (22,'Svalinn', 'Turgutreis', '1500', '4.7', '5700'),
  (23,'D Maris', 'Dalaman', '8250', '3.9', '2000'),
  (24,'Dove', 'Marmaris', '7200', '4.2', '5700'),
  (25,'Yacht Classic', 'Fethiye', '3400', '3.1', '1000');



CREATE TABLE kullanıcıbilgileri (
  kullanıcıID INT NOT NULL PRIMARY KEY,
  TC VARCHAR(11) NOT NULL,
  isim VARCHAR(45) NOT NULL,
  soyisim VARCHAR(45) NOT NULL,
  cinsiyet VARCHAR(10) NOT NULL,
  doğumYılı VARCHAR(15) NOT NULL,
  şehir VARCHAR(45) NOT NULL,
  şifre VARCHAR(45) NOT NULL
);

INSERT INTO kullanıcıbilgileri (kullanıcıID,TC, isim, soyisim, cinsiyet, doğumYılı, şehir, şifre)
VALUES 
(1,'13455434688', 'Zeynep Sena', 'Telli', 'Kadın', 2004, 'İstanbul', '123'),
(2,'65635435353', 'Halil', 'Telli', 'Erkek', 1999, 'İstanbul', '111'),
(3,'12314423323', 'Ali', 'Topal', 'Erkek', 1998, 'İstanbul', '123'),
(4,'97875673545', 'Irmak', 'Hızlı', 'Kadın', 1989, 'İstanbul', '123'),
(5,'45542432445', 'Beril', 'Kaya', 'Kadın', 1976, 'İstanbul', '123'),
(6,'91214778768', 'Eren', 'Keser', 'Erkek', 1995, 'İstanbul', '123'),
(7,'12096533221', 'Erva', 'Kılıç', 'Kadın', 1978, 'İstanbul', '111');

CREATE TABLE kredikartları (
  kartNumarası VARCHAR(45) NOT NULL PRIMARY KEY,
  kullanıcıID VARCHAR(45) NOT NULL,
  isimSoyisim VARCHAR(45) NOT NULL,
  sonKullanma VARCHAR(45) NOT NULL,
  CVV VARCHAR(45) NOT NULL
);

INSERT INTO kredikartları (kartNumarası, kullanıcıID, isimSoyisim, sonKullanma, CVV)
VALUES 
('1231244321', '13455434688', 'Zeynep Sena Telli', '11/25', '262'),
('3242131233', '65635435353', 'Halil Telli', '12/26', '379');

CREATE TABLE kullanıcıOtelleri (
  kullanıcıID VARCHAR(45) NOT NULL PRIMARY KEY,
  otelID VARCHAR(45) NOT NULL
);

INSERT INTO kullanıcıOtelleri (kullanıcıID, otelID)
VALUES 
('1', '8'),
('2', '4'),
('3', '12'),
('4', '19'),
('5', '11'),
('6', '13'),
('7', '22');


SELECT * FROM oteller;
SELECT * FROM kullanıcıbilgileri;
SELECT * FROM kredikartları;
SELECT * FROM kullanıcıOtelleri;

-- General queries

--1st Query
SELECT * FROM kullanıcıbilgileri 
WHERE TC = 13455434688 AND şifre = 123

--2nd Query
SELECT kullanıcıbilgileri.*, oteller.* FROM kullanıcıbilgileri
JOIN kullanıcıOtelleri ON kullanıcıbilgileri.kullanıcıID = kullanıcıOtelleri.kullanıcıID
JOIN oteller ON kullanıcıOtelleri.otelID = oteller.otelID
ORDER BY kullanıcıbilgileri.kullanıcıID;

--3rd Query
SELECT * FROM oteller
ORDER BY fiyat
LIMIT 5 OFFSET 3;

-- Advanced queries

--1st Query
SELECT otelkonum, COUNT(*) as otelSayisi
FROM oteller
GROUP BY otelkonum;

--2nd Query
SELECT otelkonum, COUNT(*) as otelSayisi
FROM oteller
GROUP BY otelkonum
HAVING COUNT(*) > 2;

--3rd Query
SELECT * FROM oteller
WHERE otelkonum = 'Fethiye'
GROUP BY otelID
ORDER BY fiyat ASC;

