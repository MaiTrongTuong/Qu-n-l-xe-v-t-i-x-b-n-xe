USE master
GO
IF DB_ID('QuanlyBenXe') IS NOT NULL
	DROP DATABASE QuanLyBenXe
CREATE DATABASE QuanLyBenXe
GO 
USE QuanLyBenXe
GO
CREATE TABLE ChuXe
(
	MaChuXe      nvarchar(50) NOT NULL,
	HoTen        nvarchar(50)NOT NULL,
	MatKhau      nvarchar(50)NOT NULL,
    CMT            int NOT NULL,
	DiaChi       nvarchar(50) NOT NULL,
    SDT           nvarchar(10),	
	primary key (MaChuXe),
)
GO
CREATE TABLE ChatLuong(
        MaChatLuong nvarchar(50) NOT NULL,
		ChatLuong    nvarchar(50) NOT NULL,
		primary key(MaChatLuong)
)
GO
CREATE TABLE TuyenDuong
(
    MaTuyen     nvarchar(50) NOT NULL,
	NoiXuatPhat nvarchar(50)        NOT NULL,
	DiemDen      nvarchar(50) NOT NULL,
	KhoangCach   nvarchar(50)  NOT NULL,
	CONSTRAINT PK_MaTuyenn PRIMARY KEY CLUSTERED (
	 MaTuyen ASC),
	 )
GO
CREATE TABLE LenhXuatBen
(
	Malxb nvarchar(50) NOT NULL,
	TrangThai nvarchar(50) NOT NULL,
	GioRa       datetime ,
	GioVao       datetime,
	primary key(Malxb)
)

CREATE TABLE XE
(
	MaXe               nvarchar(50) NOT NULL,
	BienSo             nvarchar(50)NOT NULL,
    HieuXe             nvarchar(50) NOT NULL,
	LoaiXe             int NOT NULL,
	ChuXe              nvarchar(50) NOT NULL,
	ChatLuong          nvarchar(50) NOT NULL,
	TrangThaiHoatDong   nvarchar(50) NOT NULL,
	TaiXeChinh           nvarchar(50) NOT NULL,
	CONSTRAINT PK_MaXe PRIMARY KEY CLUSTERED (
	 MaXE ASC),
	Foreign key(ChuXe) references ChuXe(MaChuXe),
	Foreign key(ChatLuong) references ChatLuong(MaChatLuong),
	Foreign key(MaXe) references LenhXuatBen(Malxb),
)
Go
CREATE TABLE Ve
(
	MaVe nvarchar(50) NOT NULL,
	Ghe nvarchar(10) NOT NULL,
	MaXe nvarchar(50) NOT NULL,
	GiaVe  nvarchar(50)NOT NULL,
	primary key(MaVe),
	Foreign key(MaXe) references Xe(MaXe),
)
CREATE TABLE PhieuDangTai
(
	MaTuyen nvarchar(50) NOT NULL,
	MaXe nvarchar(50) NOT NULL,
	ThoiGian datetime NOT NULL,
	primary key(MaTuyen,MaXe),
	Foreign key(MaTuyen) references TuyenDuong(MaTuyen),
	Foreign key(MaXe) references XE(MaXe),
)


CREATE TABLE Luong
(
	MaLuong  nvarchar(50) NOT NULL,
    MucLuong  nvarchar(50)NOT NULL,
	primary key (MaLuong)
)
GO
CREATE TABLE ChucVu
(   MaChucVu       nvarchar(50)NOT NULL,
	ChucVu       nvarchar(50)NOT NULL,
	primary key (MaChucVu),
)
GO
CREATE TABLE PhongBan(
	MaPhongBan       nvarchar(50)NOT NULL,
	TenPhongBan      nvarchar(50) NOT NULL,
	primary key(MaPhongBan),
)
GO
CREATE TABLE NhanVien
(
	MaNhanVien    nvarchar(50) NOT NULL,
	HoTen         nvarchar(50) NOT NULL,
	NgaySinh       Date NOT NULL,
    QueQuan        nvarchar(50) NOT NULL,
	DienThoai     nvarchar(50)NOT NULL,
    MatKhau    nvarchar(50) NOT NULL,
	ChucVu      nvarchar(50) NOT NULL,
	TienLuong   nvarchar(50) NOT NULL,
	Phong         nvarchar(50) NOT NULL,
	primary key (MaNhanVien),
	Foreign key(ChucVu) references ChucVu(MaChucVu),
	Foreign key(Phong) references PhongBan(MaPhongBan),
	Foreign key(TienLuong) references Luong(MaLuong),
)
GO
CREATE TABLE HoaDon  --luu tru thong tin ve xe
(
    MaHoaDon    nvarchar(50) NOT NULL,
    ThoiGian     nvarchar(50) NOT NULL,
	NgXuatHD     nvarchar(50)NOT NULL,
	MaSoVe       nvarchar(50)NOT NULL,
    SoTien        nvarchar(50)NOT NULL,
	primary key(MaHoaDon),
	Foreign key(NgXuatHD) references NhanVien(MaNhanVien),
	Foreign key(MaSoVe) references Ve(MaVe),
)
GO
INSERT INTO ChuXe (MaChuXe,HoTen,MatKhau, CMT,DiaChi,SDT)
VALUES 
('CX01','Lan','1234','132355113',N'15 Nghĩa Hòa-QTB-Tphcm', '0982313231'),
('CX02','Vỹ','1911','132355934',N'228 Cộng Hòa-QTB-Tphcm', '0982313231');
GO
INSERT INTO ChatLuong (MaChatLuong,ChatLuong)
VALUES 
('CL01',N'Tiêu Chuẩn'),
('CL02',N'Giá Rẽ');
GO
INSERT INTO TuyenDuong(MaTuyen,NoiXuatPhat,DiemDen,KhoangCach)
VALUES
('MT01','TPHCM',N'Nha Trang','600'),
('MT02','TPHCM',N'Bình Thuận','219');
GO
INSERT INTO LenhXuatBen(Malxb,TrangThai,GioRa,GioVao)
VALUES
('A15',N'Được Xuất Bến','11:50:00','18:50:00'),
('B13',N'Đang Hổng','','');
GO
INSERT INTO Xe(MaXe,BienSo,HieuXe,LoaiXe,ChuXe,ChatLuong,TrangThaiHoatDong,TaiXeChinh)
VALUES
('A15','81723','TOYOTA',40,'CX01','CL01',N'Đang Hoạt Động',N'Bành Trọng Tường'),
('B13','09612','TOYOTA',20,'CX02','CL02',N'Đang OFF',N'Bành Trọng Mai');
GO
INSERT INTO PhieuDangTai(MaTuyen,MaXe,ThoiGian)
VALUES
('MT01','A15','10/09/2019'),
('MT02','B13','10/07/2019');
GO
INSERT INTO Ve(MaVe,Ghe,MaXe,GiaVe)
VALUES
('MV01','A7','A15','90000'),
('MV02','A3','B13','12000');
GO
INSERT INTO ChucVu(MaChucVu,ChucVu)
VALUES
('TN01',N'Thu Ngân'),
('BV01',N'Bảo Vệ');
GO
INSERT INTO Luong(MaLuong,MucLuong)
VALUES
('ML02','12000000'),
('ML01','9000000');
GO
INSERT INTO PhongBan(MaPhongBan,TenPhongBan)
VALUES
('PB101','Phòng Bán Vé'),
('PB102','Phòng Bảo Vệ');
GO
INSERT INTO NhanVien(MaNhanVien,HoTen,NgaySinh,QueQuan,DienThoai,MatKhau,ChucVu,TienLuong,Phong)
VALUES
('NV02',N'Hoàng Minh Ngân','10/10/1999',N'Đồng Nai','098132455','1234','TN01','ML02','PB101'),
('NV01',N'Hoàng Minh Tuấn','10/10/1997',N'Đồng Nai','098132845','1234','BV01','ML01','PB102');
GO
INSERT INTO HoaDon(MaHoaDon,ThoiGian,NgXuatHD,MaSoVe,SoTien)
VALUES
('HD01','8:45:00','NV01','MV01','90000'),
('HD02','9:45:0','NV01','MV02','120000');
GO

------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
--Procudure

--Truy xuất thông tin đăng nhập cho nhân viên
use QuanLyBenXe;
go

if object_id('DangNhapNhanVien') is not null
	drop proc DangNhapNhanVien;
go
create proc DangNhapNhanVien
as
select MaNhanVien, MatKhau, MaChucVu
from NhanVien,ChucVu
where NhanVien.ChucVu=ChucVu.MaChucVu;
go

exec DangNhapNhanVien;
go