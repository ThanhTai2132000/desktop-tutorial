

--
-- Dumping data for table dienthoai
--

INSERT INTO  DongDienThoai VALUES
( 'VV1', 'Vivo V5s'),
( 'OPPO1', 'Oppo F3 Plus'),
( 'OPP02', 'Oppo F1s 2017 (64GB)'),
( 'OPP03', 'Oppo F1 Plus'),
('OP04', 'Oppo F3 Lite (A57)'),
( 'HTC1', 'HTC U Play'),
( 'HTC2', 'HTC U11 Red'),
( 'HTC3', 'HTC U11'),
( 'NOK1', 'Nokia 6'),
( 'NOK2', 'Nokia 8'),
( 'NOK3', 'Nokia 5'),
( 'SON1', 'Sony Xperia XZ1'),
( 'SON2', 'Sony Xperia XA1 Ultra'),
( 'SON3', 'Sony Xperia XZ Premium'),
( 'SAM1', 'Samsung Galaxy S8'),
( 'SAM2', 'Samsung Galaxy J7 Pro'),
( 'IP1', 'iPhone 8 Plus 256GB'),
( 'SAM3', 'Samsung Galaxy Note 8'),
( 'SAM4', 'Samsung Galaxy S8 Plus'),
( 'SAM5', 'Samsung Galaxy A5 (2017)'),
( 'IP2', 'iPhone 5s 16GB'),
( 'IP3', 'iPhone 8 256GB'),
( 'IP4', 'iPhone 8 Plus 256GB'),
( 'IP5', 'iPhone 6s Plus 32GB'),
( 'NOK', 'Nokia N150'),
( 'HTC', 'HTC U Play');

-- --------------------------------------------------------

--
-- Table structure for table dongdienthoai
--

CREATE TABLE DienThoai (
  MaDongDT varchar(10) NOT NULL,
  MaLoai varchar(10) NOT NULL,
  MaHangSX varchar(10) NOT NULL,
  MaNCC varchar(10) NOT NULL,
  TenDongDT varchar(50) NOT NULL,
  Hinh varchar(255) NOT NULL,
  DonGia float NOT NULL,
  GiaKM float NOT NULL DEFAULT '0'
)

--
-- Dumping data for table dongdienthoai
--
INSERT INTO DienThoai (MaDongDT, MaLoai, TenDongDT, Hinh, DonGia, GiaKM) VALUES
('HT01', 'TM', 'HTC U Play', 'htcuplay.jpg', 8990000, 0),
('HT02', 'TM', 'HTC U11 Red', 'htcu11red.jpg', 16990000, 0),
('HT03', 'TM', 'HTC U11', 'htcu11.jpg', 16990000, 0),
('IP01', 'TM', 'iPhone 8 Plus 256GB', 'iphone8plus.png', 28790000, 0),
('IP02', 'TM', 'iPhone 5s 16GB', 'iphone5s.png', 5999000, 0),
('IP03', 'TM', 'iPhone 8 256GB', 'iphone8plus.png', 25790000, 0),
('IP04', 'TM', 'iPhone 6s Plus 32GB', 'ip_6s_32.png', 14490000, 0),
('IP05', 'TM', 'iPhone 8 Plus 64GB', 'iphone8plus.png', 23990000, 0),
('NO01', 'TM', 'Nokia 5', 'nokia5.png', 5259000, 4259000),
('NO02', 'TM', 'Nokia 6', 'nokia6.png', 5590000, 0),
('NO03', 'TM', 'Nokia 8', 'nokia8.png', 12990000, 0),
('NO04', 'BP', 'Nokia N150', 'n150.png', 649000, 0),
('OP01', 'TM', 'Oppo F3 Plus', 'oppof3+.jpg', 10690000, 0),
('OP02', 'TM', 'Oppo F1s 2017 (64GB)', 'oppof1s2017.jpg', 5990000, 0),
('OP03', 'TM', 'Oppo F1 Plus', 'oppof1+.jpg', 6490000, 0),
('OP04', 'TM', 'Oppo F3 Lite (A57)', 'oppof3lite.jpg', 5490000, 0),
('SA01', 'TM', 'Samsung Galaxy S8', 'samsunggalaxys8.png', 18490000, 0),
('SA02', 'TM', 'Samsung Galaxy J7 Pro', 'samgalaJ7-pro.png', 6990000, 0),
('SA03', 'TM', 'Samsung Galaxy Note 8', 'samnote8.png', 22490000, 0),
('SA04', 'TM', 'Samsung Galaxy S8 Plus', 'samsunggalaxys8.png', 20490000, 0),
('SA05', 'TM', 'Samsung Galaxy A5 (2017)', 'dt_1.png', 7990000, 0),
('SO01', 'TM', 'Sony Xperia XZ1', 'sonyxperiaxz1.png', 15990000, 0),
('SO02', 'TM', 'Sony Xperia XA1 Ultra', 'sonyxperiaxa1ultra.png', 8490000, 0),
('SO03', 'TM', 'Sony Xperia XZ Premium', 'sonyxperiaxzpremium.png', 17990000, 0),
('VI02', 'TM', 'Vivo V5s', 'vivov5s.png', 6690000, 0);

-- --------------------------------------------------------

--
-- Table structure for table donhang
--



--



-- --------------------------------------------------------

--
-- Table structure for table loaidienthoai
--





--
-- Table structure for table nhanvien
--


--
-- Indexes for dumped tables
--

--


-- Indexes for table dienthoai
--
ALTER TABLE DongDienThoai
  ADD PRIMARY KEY (IMEI),
  ADD UNIQUE KEY IMEI (IMEI),
  ADD KEY MaDongDT (MaDongDT);

--
-- Indexes for table dongdienthoai
--
ALTER TABLE DienThoai
  ADD PRIMARY KEY (MaDongDT),
  ADD UNIQUE KEY MaDongDT (MaDongDT),
  ADD KEY MaLoai (MaLoai),
  ADD KEY MaHangSX (MaHangSX),
  ADD KEY MaNCC (MaNCC);
--
-- Constraints for table dienthoai
--
ALTER TABLE dienthoai
  ADD CONSTRAINT dienthoai_ibfk_1 FOREIGN KEY (MaDongDT) REFERENCES dongdienthoai (MaDongDT) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table dongdienthoai
--
ALTER TABLE dongdienthoai
  ADD CONSTRAINT dongdienthoai_ibfk_1 FOREIGN KEY (MaNCC) REFERENCES nhacungcap (MaNCC) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT dongdienthoai_ibfk_2 FOREIGN KEY (MaLoai) REFERENCES loaidienthoai (MaLoai) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT dongdienthoai_ibfk_3 FOREIGN KEY (MaHangSX) REFERENCES hangsanxuat (MaHangSX) ON DELETE CASCADE ON UPDATE CASCADE;

