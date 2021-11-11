--Drop database QLThanhToan
create database QLThanhToan
go
use QLThanhToan
go
--=======================================================
--Drop table KhachHang
create table KhachHang
(
	MaKH uniqueidentifier primary key,
	HoTen nvarchar (35) not null,
	GioiTinh bit default 0,
	DiaChi nvarchar (255),
	SoDT nvarChar (12),
	LoaiKH int default 0
)
go
--========================================================
--Drop table ChiSoDien
create table SoChuDien
(
	MaKH uniqueidentifier foreign key references KhachHang(MaKH),
	NgayLap datetime default getdate(),
	ChiSoCu int not null,
	ChiSoMoi int not null,
	ThanhTien real,
	unique (MaKH,NgayLap)
)
go
--===========================================================
--Drop table ChiSoNuoc
create table SoKhoiNuoc
(
	MaKH uniqueidentifier foreign key references KhachHang(MaKH),
	NgayLap datetime default getdate(),
	ChiSoCu int,
	ChiSoMoi int,
	SoKhoiThamHut int not null default 0,
	SoThangSuDung int not null default 0,
	ThanhTien real,
	unique (MaKH,NgayLap)
)
go
--============================================================
--Drop table CongThucDien
create table CongThucDien
(
	MaDinhMuc int identity(0,1)primary key,
	TenDinhMuc nvarchar(255)unique,
	DinhMuc int,
	GiaDinhMuc real,
	ThueVAT real default 0
)
go
--============================================================
--Drop table CongThucNuoc
create table CongThucNuoc
(
	MaDinhMuc int identity(0,1)primary key,
	TenDinhMuc nvarchar(255)unique,
	DinhMuc int,
	GiaDinhMuc real,
	ThueVAT real default 0
)
go