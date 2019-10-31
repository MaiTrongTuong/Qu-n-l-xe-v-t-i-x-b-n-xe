USE master
GO
CREATE DATABASE QuanLyBenXe
GO 
USE QuanLyBenXe
GO
CREATE TABLE DuLieuChinh(
	STT         int  NOT NULL,
	Ma_Ben      varchar(50) NOT NULL,
	Ten_Ben     varchar(50) NOT NULL,
	QuanLyLoai  varchar(50) NOT NULL,
	Ma_Vung     varchar(50) NOT NULL,
	Dia_Chi     varchar(50) NOT NULL,
	SDT         int  NOT NULL, 
	CONSTRAINT PK_MaBen PRIMARY KEY CLUSTERED (
	 Ma_Ben ASC)
)
GO
CREATE TABLE DanhSach_XE
(
	STT          varchar(50) NOT NULL,
	Bien_Xe      varchar(50)NOT NULL,
    Ma_Ben       varchar(50)NOT NULL,
    Ten_Tuyen    varchar(50) NOT NULL,
	So_Ca        int         NOT NULL,
	primary key(Bien_Xe),
	 Foreign key(Ma_Ben) references DuLieuChinh(Ma_Ben),
)
GO
CREATE TABLE DS_TuyenDuong
(
	Bien_Xe       varchar(50)NOT NULL,
	Hang_Xe     varchar(50) NOT NULL,
    Ma_Tuyen     varchar(50) NOT NULL,
	So_Ca        int         NOT NULL,
	Ten_Tuyen    varchar(50) NOT NULL,
	ChieuDai_KM   numeric(5,2)  NOT NULL,
	CONSTRAINT PK_BienXe PRIMARY KEY CLUSTERED (
	 Bien_Xe ASC),
	 Foreign key(Bien_Xe) references DanhSach_Xe(Bien_Xe),
	 )
GO
CREATE TABLE DanhSach_LaiXe
(
	STT     varchar(50) NOT NULL,
	Hang_Xe     varchar(50) NOT NULL,
	Bien_Xe       varchar(50)NOT NULL,
    Ma_lai_xe    int NOT NULL,
	Ma_Ben       int NOT NULL,
    Ho_Va_Ten    varchar(50) NOT NULL,
	Dia_Chi      varchar(50) NOT NULL,
	Ca_Phu_Trach int         NOT NULL,
	Tien_Luong   money       NOT NULL,
	SDT          int         NOT NULL,	
	primary key (Ma_lai_Xe,Hang_Xe),
	 Foreign key(Bien_Xe) references DanhSach_Xe(Bien_Xe),
)
GO
CREATE TABLE ThongTin_HangXe
(
	Bien_Xe       varchar(50)NOT NULL,
    Hang_Xe     varchar(50) NOT NULL,
	Ma_lai_xe    int NOT NULL,
	Ma_Ben      varchar(50) NOT NULL,
	Gia_Ve       money  NOT NULL,
	Ngay_Mua    Datetime NOT NULL,
	Ngay_CapNhat Datetime  NOT NULL,
	So_NgaySuaChua  int  NOT NULL,
	Tien_Bao_Duong money  NOT NULL,
	So_LanHong    int    NOT NULL,
	primary key(Hang_Xe,Bien_Xe),
	Foreign key(Ma_Ben) references DuLieuChinh(Ma_Ben),
)
GO
CREATE TABLE LoaiXe
(   Loai_Xe       varchar(50)NOT NULL,
	Bien_Xe       varchar(50)NOT NULL,
    Gia_Ve       numeric(10,0)  NOT NULL,      
	Xep_Loai     varchar(50) NOT NULL,
	So_Cho       int  NOT NULL,
	primary key (Loai_Xe),
	Foreign key(Bien_Xe) references DanhSach_Xe(Bien_Xe),
)
GO
CREATE TABLE LichTrinh(
	Bien_Xe       varchar(50)NOT NULL,
	Ma_LichTrinh  int NOT NULL,
	Ma_lai_xe    int NOT NULL,
	Ma_Tuyen     varchar(50) NOT NULL,
	TG_KhoiHanh  smalldatetime NOT NULL,
    TG_KetThuc   smalldatetime NOT NULL,
    TG_CapNhat   smalldatetime NOT NULL,
    VanToc_TB    varchar(50) NOT NULL,
	primary key(Ma_LichTrinh),
	Foreign key(Bien_Xe) references DanhSach_Xe(Bien_Xe),
)
GO
CREATE TABLE Cap_Nhat  --luu tru thong tin ve xe
(
    Ma_CapNhat  varchar(50) NOT NULL,
    Hang_Xe     varchar(50) NOT NULL,
    Ngay_CapNhat Datetime NOT NULL,
	Ma_Ben       varchar(50)NOT NULL,
	Tong_Xe       int NOT NULL,
    SoXE_ThanhLy int NOT NULL,
    SoXE_HoatDong int NOT NULL,
    So_xe_DSC    int NOT NULL,
	primary key(Ma_CapNhat),
	Foreign key(Ma_Ben) references DuLieuChinh(Ma_Ben),
)
GO
CREATE TABLE DoanhThu_TrongNgay
( 
    Hang_Xe     varchar(50) NOT NULL,
	Ma_Ben       varchar(50)NOT NULL,
    Tong_Thu      money NOT NULL,
	Du_Toan       money  NOT NULL,
	Thue       money  NOT NULL,
	primary key(Hang_Xe),
	 Foreign key(Ma_Ben) references DuLieuChinh(Ma_Ben),
)


