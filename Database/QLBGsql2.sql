CREATE DATABASE QLBG
GO
USE QLBG
GO
CREATE TABLE loaiSP(
	maLoai INT NOT NULL PRIMARY KEY,
	tenLoai NVARCHAR(20),
	tinhTrang BIT
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
	img NVARCHAR(20),
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
	tinhTrang bit,
	email nVarChar(30)
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
    makichCo int foreign key references kichCo(maKichCo),
	constraint pk_CTPN primary key (maPN,maSP,makichCo),
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
	maKM INT NULL FOREIGN key references dbo.khuyenMai(maKM),
	tienGiam FLOAT,	
	tienKhachDua float,
	tienThua float,
	tinhTrang bit
);

CREATE TABLE CT_HoaDon(
    maHD INT FOREIGN KEY REFERENCES hoaDon(maHD),
    maSP NVARCHAR(20) FOREIGN KEY REFERENCES sanPham(maSP),
    maKichCo INT FOREIGN KEY REFERENCES dbo.kichCo(maKichCo), -- Thêm kích cỡ vào
    CONSTRAINT pk_CTHD PRIMARY KEY (maHD, maSP, maKichCo), -- Thêm maKichCo vào khóa chính
    giaBan FLOAT,
    soLuong INT,
    thanhTien FLOAT,
    maSPDoi NVARCHAR(20) NULL,
    ngayDoi DATETIME NULL,
    tinhTrangDoi BIT
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
INSERT INTO sanPham (maSP,tenSP,giaBan,soLuong,img,giaNhap,mau,tinhTrang,maLoai) VALUES
	 (N'G001',N'Nike Air Max',1500000.0,0,'G001',1000000.0,N'White',1,1),
	 (N'G002',N'Adidas Ultraboost',1800000.0,0,'G002',1200000.0,N'Black',1,1),
	 (N'G003',N'Men Cloud X 3', 3000000.0,0,'G003',2500000.0,N'Grey',1,1),
	 (N'G004', N'Puma RS-X', 2200000.0, 0, 'G004', 1800000.0, N'Red', 1, 1),
     (N'G005', N'Converse Chuck', 1300000.0, 0, 'G005', 1000000.0, N'Black', 1, 2),
     (N'G006', N'Vans Old Skool', 1200000.0, 0, 'G006', 900000.0, N'White', 1, 2),
	 (N'G007', N'Reebok Club C', 1900000.0, 0, 'G007', 1500000.0, N'Blue and White', 1, 1),
	 (N'G008', N'New Balance 574', 2100000.0, 0, 'G008', 1700000.0, N'Grey', 1, 1),
	 (N'G009', N'Skechers D-Lite', 1700000.0, 0, 'G009', 1300000.0, N'Blue', 1, 3),
	 (N'G010', N'Fila Disruptor', 2000000.0, 0, 'G010', 1600000.0, N'White', 1, 1),
     (N'G011', N'Armour Hovr Phantom 3 Se Reflect', 2500000.0, 0, 'G011', 2200000.0, N'Black', 1, 1),
     (N'G012', N'Asics Gel-Kayano', 2400000.0, 0, 'G012', 2000000.0, N'Blue', 1, 3);

--so luong sp ở mỗi size
INSERT INTO sanPham_KichCo (maSP,maKichCo,soLuong,tinhTrang) VALUES
	 (N'G001',1,44,1),
	 (N'G001',2,24,1),
	 (N'G001',3,14,1),
	 (N'G001',4,14,1),
	 (N'G001',5,14,1),
	 (N'G002',1,37,1),
	 (N'G002',2,14,1),
	 (N'G002',3,22,1),
	 (N'G002',4,14,1),
	 (N'G002',5,2,1),
	 (N'G003',1,10,1),
	 (N'G003',5,2,1),
	 (N'G004',1,15,1),
	 (N'G004',3,1,1),
	 (N'G004',5,2,1);

--khuyen mai
INSERT INTO khuyenMai (maKM,tenKM,giaTriGiam,ngayBD,ngayKT,tinhTrang) VALUES
	 (1,N'End of Season Sale',15,'2024-10-01 00:00:00.0','2024-11-01 00:00:00.0',1),
	 (2,N'Black Friday Sale',30,'2024-11-25 00:00:00.0','2024-11-30 00:00:00.0',1),
	 (0,N'Không',0,NULL,NULL,1);

--khach hang
INSERT INTO khachHang (maKH,tenKH,sdt) VALUES
	 (1,N'Nguyen Van A',N'0357865238   '),
	 (2,N'Tran Thi B',N'0377354211   ');

--nhan vien
INSERT INTO nhanVien (maNV,tenNV,gioiTinh,sdt,diaChi,chucVu,ngaySinh,tinhTrang, email) VALUES
	 (N'NV001',N'Le Quang',N'Nam',N'0901234567   ',N'123 Le Loi, HCM',N'Quan ly','1990-05-15 00:00:00.0',1,'nv1@gmail.com'),
	 (N'NV002',N'Nguyen Huyen',N'Nu',N'0912345678   ',N'456 Hai Ba Trung, HCM',N'Nhan vien','1995-08-20 00:00:00.0',1,'nv2@gmail.com'),
	 (N'NV003',N'Nguyễn Quang',N'Nam',N'0912345678   ',N'456 Hai Ba Trung, HCM',N'Nhan vien','1995-08-20 00:00:00.0',1,'nv3@gmail.com'),
	 (N'NV004',N'Hồ Quang Hiếu',N'Nam',N'0987654321   ',N'273 An Duong Vuong',N'Thủ kho','1995-08-20 00:00:00.0',1,'nv4@gmail.com');
--phan quyen
INSERT INTO phanQuyen (maQuyen, tenQuyen, qLyTK, qLyBH, qLySP, qLyNV, qLyKH, qLyKM, qLyNH, xemThongKe)
VALUES 
	 (1,N'Admin',1,0,0,0,0,0,0,0),
	 (2,N'Quản lý',0,1,1,1,1,1,1,1),
	 (3,N'Nhân viên',0,1,0,0,1,0,0,0),
	 (4,N'Thủ kho',0,0,1,0,0,0,1,0);

--tai khoan
INSERT INTO taiKhoan (maNV, maQuyen, tenDangNhap, matKhau, tinhTrang)
VALUES 
	 (N'NV001',1,N'admin',N'123456',1),
	 (N'NV002',2,N'quanly1',N'123456',1),
	 (N'NV003',3,N'nhanvien1',N'123456',1),
	 (N'NV004',4,N'thukho1',N'123456',1);

--ncc
INSERT INTO ncc (maNCC,tenNCC,sdt,diaChi,tinhTrang) VALUES
	 (1,N'Nike Supplier',N'0900001111',N'789 Nguyen Trai, HCM',1),
	 (2,N'Adidas Supplier',N'0911112222',N'456 Tran Hung Dao, HCM',1),
	 (3,N'PUMA',N'0123456782',N'Mỹ',1),
	 (4,N'Hỏa Trâu',N'0192875934',N'Cát Tân, Phù Cát, Bình Định',1),
	 (5,N'ABC',N'0123456789',N'273 An Duong Vuong',1),
	 (6,N'DEF',N'0231435141',N'Thị Nghè',1),
	 (7,N'QƯE',N'0988654323',N'Quận 5',1),
	 (8,N'ZXC',N'0981237465',N'Quận 7',1),
	 (9,N'aaa',N'0123456767',N'Nhà Bè',0),
	 (13,N'Hỏa Bò',N'0192875934',N'Cát Tân, Phù Cát, Bình Định',1),
	 (14,N'test',N'0918273645',N'Không nhớ',0),
	 (15,N'CCC',N'0998982178',N'Cát Tân',0),
	 (16,N'Heniken',N'0987654321',N'Quan 5',1);

--phieu nhap
INSERT INTO phieuNhap (maPN,maNV,maNCC,ngayLap,tongTien,tinhTrang) VALUES
	 (1,N'NV001',1,'2024-09-01 00:00:00.0',25000000,1),
	 (2,N'NV002',2,'2024-10-05 00:00:00.0',15600000,1),
	 (3,N'NV001',1,'2024-10-10 00:00:00.0',10000000,1),
	 (4,N'NV001',1,'2024-10-13 00:00:00.0',20000000,1),
	 (5,N'NV002',2,'2024-10-17 00:00:00.0',30000000,1);

--chi tiet phieu nhap
INSERT INTO CT_PhieuNhap (maPN,maSP,giaNhap,soLuong,thanhTien,tinhTrang,makichCo) VALUES
	 (1,N'G002',1200000.0,2,2400000.0,1,2),
	 (1,N'G003',1200000.0,2,2400000.0,1,3),
	 (1,N'G001',1200000.0,1,1200000.0,1,4),
	 (2,N'G001',1000000.0,30,30000000,1,2),
	 (2,N'G001',1000000.0,25,25000000,1,1),
	 (3,N'G001',1000000.0,20,20000000,1,1),
	 (4,N'G002',1200000.0,1,1200000.0,1,1),
	 (5,N'G002',1200000.0,1,1200000.0,1,1),
	 (5,N'G003',1000000.0,1,1000000.0,1,1);
--hoa don
INSERT INTO hoaDon (maNV,maKH,ngayLap,tongTien,maKM,tienGiam,tienKhachDua,tienThua,tinhTrang) VALUES
	 (N'NV002',1,'2024-10-15 00:00:00.0',1500000.0,0,0,2000000.0,500000.0,1),
	 (N'NV002',2,'2024-10-27 00:00:00.0',1260000.0,2,540000.0,1500000.0,240000.0,1),
	 (N'NV002',1,'2024-10-26 00:00:00.0',1500000.0,0,0,2000000.0,500000.0,1),
	 (N'NV002',1,'2024-10-12 00:00:00.0',2520000.0,2,1080000.0,3000000.0,480000.0,1);

--cT_hoa don
INSERT INTO CT_HoaDon (maHD,maSP,maKichCo,giaBan,soLuong,thanhTien,maSPDoi,ngayDoi,tinhTrangDoi) VALUES
	 (1,N'G001',1,1500000.0,1,1500000.0,NULL,NULL,1),
	 (1,N'G001',2,1500000.0,1,1500000.0,NULL,NULL,1),
	 (2,N'G001',2,1500000.0,1,1500000.0,NULL,NULL,1);
--bao hanh