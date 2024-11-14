use QLBG

create table loaiSP(
	maLoai int not null primary key,
	tenLoai nVarChar(20),
	tinhTrang bit,
);

create table kichCo(
	maKichCo int not null primary key,
	kichCo int,
	tinhTrang bit,
);

create table sanPham(
	maSP nVarChar(20) not null primary key,
	tenSP nVarChar(130),
	giaBan float,
	soLuong int,
	img image,
	giaNhap float,
	mau nVarChar(20),
	tinhTrang bit,
	maLoai int foreign key references loaiSP(maLoai)
);

create table sanPham_KichCo (
    maSP nVarChar(20) not null,
    maKichCo INT not null,
    soLuong INT,
    tinhTrang BIT,
    primary key (maSP, maKichCo),
    foreign key (maSP) references sanPham(maSP),
    foreign key (maKichCo) references kichCo(maKichCo)
);

create table khuyenMai(
	maKM int not null primary key,
	tenKM nVarChar(130),
	giaTriGiam int,
	ngayBD datetime,
	ngayKT datetime,
	tinhTrang bit,
);

create table khachHang(
	maKH int not null primary key,
	tenKH nVarChar(30),
	sdt char(13),
);

create table nhanVien(
	maNV nVarChar(13) not null primary key,
	tenNV nVarChar(30),
	gioiTinh nVarChar(3),
	sdt char(13),
	diaChi nVarChar(130),
	chucVu nVarChar(13),
	ngaySinh datetime,
	tinhTrang bit
);

create table phanQuyen(
	maQuyen int not null primary key,
	tenQuyen nVarChar(50),
	qLyTK bit,
	qLyBH bit,
	qLySP bit,
	qLyNV bit,
	qLyKH bit,
	qLyKM bit,
	qLyNH bit,
	xemThongKe bit
);

create table taiKhoan(
	maNV nVarChar(13) foreign key references nhanVien(maNV),
	maQuyen int foreign key references phanQuyen(maQuyen),
	tenDangNhap nVarChar(20),
	matKhau nVarChar(20),
	tinhTrang bit
);

create table ncc(
	maNCC int not null primary key,
	tenNCC nVarChar(130),
	sdt char(13),
	diaChi nVarChar(130),
	tinhTrang bit
);

create table phieuNhap(
	maPN int not null primary key,
	maNV nVarChar(13) foreign key references nhanVien(maNV),
	maNCC int foreign key references ncc(maNCC),
	ngayLap datetime,
	tongTien float,
	tinhTrang bit
);

create table CT_PhieuNhap(
	maPN int foreign key references phieuNhap(maPN),
	maSP nVarChar(20) foreign key references sanPham(maSP),
	constraint pk_CTPN primary key (maPN,maSP),
	giaNhap float,
	soLuong int,
	thanhTien float,
	tinhTrang bit
);

create table hoaDon(
	maHD int not null IDENTITY(1,1) primary key,
	maNV nVarChar(13) foreign key references nhanVien(maNV),
	maKH int foreign key references khachHang(maKH),
	ngayLap datetime,
	tongTien float,
	tienKhachDua float,
	tienThua float,
	tinhTrang bit
);

create table CT_HoaDon(
	maHD int foreign key references hoaDon(maHD),
	maSP nVarChar(20) foreign key references sanPham(maSP),
	constraint pk_CTHD primary key (maHD,maSP),
	giaBan float,
	soLuong int,
	maKM int foreign key references khuyenMai(maKM),
	thanhTien float,
	maSPDoi nVarChar(20),
	ngayDoi datetime,
	tinhTrangDoi bit
);

--loai sp
INSERT INTO loaiSP (maLoai, tenLoai, tinhTrang) 
VALUES 
(1, N'Sneakers', 1),
(2, N'Sandals', 1),
(3, N'Boots', 1);

--ma kich co
INSERT INTO kichCo (maKichCo, kichCo, tinhTrang)
VALUES 
(1, 38, 1),
(2, 39, 1),
(3, 40, 1),
(4, 41, 1),
(5, 42, 1);

--san pham
INSERT INTO sanPham (maSP, tenSP, giaBan, img, giaNhap, mau, tinhTrang, maLoai)
VALUES 
(N'G001', N'Nike Air Max', 1500000, NULL, 1000000, N'White', 1, 1),
(N'G002', N'Adidas Ultraboost', 1800000, NULL, 1200000, N'Black', 1, 1);

--so luong sp ở mỗi size
INSERT INTO sanPham_KichCo (maSP, maKichCo, soLuong, tinhTrang)
VALUES 
(N'G001', 1, 15, 1), -- Sản phẩm G001, size 38, có 15 đôi
(N'G001', 2, 10, 1), -- Sản phẩm G001, size 39, có 10 đôi
(N'G002', 1, 5, 1),  -- Sản phẩm G002, size 38, có 5 đôi
(N'G002', 3, 8, 1);  -- Sản phẩm G002, size 40, có 8 đôi

--khuyen mai
INSERT INTO khuyenMai (maKM, tenKM, giaTriGiam, ngayBD, ngayKT, tinhTrang)
VALUES 
(1, N'End of Season Sale', 15, '2024-10-01', '2024-11-01', 1),
(2, N'Black Friday Sale', 30, '2024-11-25', '2024-11-30', 1);

--khach hang
INSERT INTO khachHang (maKH, tenKH, sdt)
VALUES 
(1, N'Nguyen Van A', '0123456789'),
(2, N'Tran Thi B', '0987654321');

--nhan vien
INSERT INTO nhanVien (maNV, tenNV, gioiTinh, sdt, diaChi, chucVu, ngaySinh, tinhTrang)
VALUES 
(N'NV001', N'Le Quang', N'Nam', '0901234567', N'123 Le Loi, HCM', N'Quan ly', '1990-05-15', 1),
(N'NV002', N'Nguyen Huyen', N'Nu', '0912345678', N'456 Hai Ba Trung, HCM', N'Nhan vien', '1995-08-20', 1);

--phan quyen
INSERT INTO phanQuyen (maQuyen, tenQuyen, qLyTK, qLyBH, qLySP, qLyNV, qLyKH, qLyKM, qLyNH, xemThongKe)
VALUES 
(1, N'Admin', 1, 1, 1, 1, 1, 1, 1, 1),
(2, N'Nhan vien', 0, 1, 1, 0, 1, 0, 0, 0);

--tai khoan
INSERT INTO taiKhoan (maNV, maQuyen, tenDangNhap, matKhau, tinhTrang)
VALUES 
(N'NV001', 1, N'admin', N'123456', 1),
(N'NV002', 2, N'huyen123', N'654321', 1);

--ncc
INSERT INTO ncc (maNCC, tenNCC, sdt, diaChi, tinhTrang)
VALUES 
(1, N'Nike Supplier', '0900001111', N'789 Nguyen Trai, HCM', 1),
(2, N'Adidas Supplier', '0911112222', N'456 Tran Hung Dao, HCM', 1);

--phieu nhap
INSERT INTO phieuNhap (maPN, maNV, maNCC, ngayLap, tongTien, tinhTrang)
VALUES 
(1, N'NV001', 1, '2024-09-01', 10000000, 1),
(2, N'NV002', 2, '2024-10-05', 8000000, 1);

--chi tiet phieu nhap
INSERT INTO CT_PhieuNhap (maPN, maSP, giaNhap, soLuong, thanhTien, tinhTrang)
VALUES 
(1, N'G001', 1000000, 10, 10000000, 1),
(2, N'G002', 1200000, 15, 18000000, 1);

--hoa don
INSERT INTO hoaDon (maNV, maKH, ngayLap, tongTien, tienKhachDua, tienThua, tinhTrang)
VALUES 
(N'NV002', 1, '2024-10-15', 1500000, 2000000, 500000, 1);

--cT_hoa don
INSERT INTO CT_HoaDon (maHD, maSP, giaBan, soLuong, maKM, thanhTien, maSPDoi, ngayDoi, tinhTrangDoi)
VALUES 
(1, N'G001', 1500000, 1, 1, 1275000, NULL, NULL, 1);

--bao hanh
