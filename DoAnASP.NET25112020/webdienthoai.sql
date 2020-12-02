

--
-- Dumping data for table dienthoai
--

INSERT INTO  DongDienThoai VALUES
('VIV', 'Vivo'),
('OPP', 'Oppo'),
('HTC', 'HTC'),
('NOK', 'Nokia'),
('SON', 'Sony'),
('SAM', 'Samsung'),
('IPH', 'iPhone');

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
INSERT INTO DienThoai (TenDT, MaDongDT, Hinh, DonGia, GiaKM) VALUES
('HTC U Play', 'HTC', 'htcuplay.jpg', 8990000, 0),
('HTC U11 Red', 'HTC', 'htcu11red.jpg', 16990000, 0),
('HTC U11', 'HTC', 'htcu11.jpg', 16990000, 0),
('iPhone 8 Plus 256GB', 'IPH', 'iphone8plus.png', 28790000, 0),
('iPhone 5s 16GB', 'IPH', 'iphone5s.png', 5999000, 0),
('iPhone 8 256GB', 'IPH', 'iphone8plus.png', 25790000, 0),
('iPhone 6s Plus 32GB', 'IPH', 'ip_6s_32.png', 14490000, 0),
('iPhone 8 Plus 64GB', 'IPH', 'iphone8plus.png', 23990000, 0),
('Nokia 5', 'NOK', 'nokia5.png', 5259000, 4259000),
('Nokia 6', 'NOK', 'nokia6.png', 5590000, 0),
('Nokia 8', 'NOK', 'nokia8.png', 12990000, 0),
('Nokia N150', 'NOK', 'n150.png', 649000, 0),
('Oppo F3 Plus', 'OPP', 'oppof3+.jpg', 10690000, 0),
('Oppo F1s 2017 (64GB)', 'OPP', 'oppof1s2017.jpg', 5990000, 0),
('Oppo F1 Plus', 'OPP', 'oppof1+.jpg', 6490000, 0),
('Oppo F3 Lite (A57)', 'OPP', 'oppof3lite.jpg', 5490000, 0),
('Samsung Galaxy S8', 'SAM', 'samsunggalaxys8.png', 18490000, 0),
('Samsung Galaxy J7 Pro', 'SAM', 'samgalaJ7-pro.png', 6990000, 0),
('Samsung Galaxy Note 8', 'SAM', 'samnote8.png', 22490000, 0),
('Samsung Galaxy S8 Plus', 'SAM', 'samsunggalaxys8.png', 20490000, 0),
('Samsung Galaxy A5 (2017)', 'SAM', 'dt_1.png', 7990000, 0),
('Sony Xperia XZ1', 'SON', 'sonyxperiaxz1.png', 15990000, 0),
('Sony Xperia XA1 Ultra', 'SON', 'sonyxperiaxa1ultra.png', 8490000, 0),
('Sony Xperia XZ Premium', 'SON', 'sonyxperiaxzpremium.png', 17990000, 0),
('Vivo V5s', 'VIV', 'vivov5s.png', 6690000, 0);

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

