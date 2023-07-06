CREATE DATABASE Heliotelss;

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
  (8,'Ilıca', 'Çeşme', '2500', '4', '5700');



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
('1231244321', '1', 'Zeynep Sena Telli', '11/25', '262'),
('3242131233', '2', 'Halil Telli', '12/26', '379');



