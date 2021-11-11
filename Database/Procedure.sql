use QLThanhToan
go
--===============================================================
--Drop procedure getInfoKhachHangNuoc
create procedure getInfoKhachHangNuoc
as
	Select MaKH,HoTen,GioiTinh,DiaChi,SoDT,LoaiKH
	From KhachHang
	Where LoaiKH <> 1 
	order by HoTen
go
--================================================================
--Drop procedure getInfoKhachHangDien
create procedure getInfoKhachHangDien
as
	Select MaKH,HoTen,GioiTinh,DiaChi,SoDT,LoaiKH
	From KhachHang
	Where LoaiKH <> 0
	order by HoTen
go
--================================================================
--Drop procedure getInfoSoKhoiNuoc
create procedure getInfoSoKhoiNuoc( @MaKH uniqueidentifier )
as
	Select NgayLap,ChiSoCu,ChiSoMoi,SoKhoiThamHut,SoThangSuDung,ThanhTien
	From SoKhoiNuoc
	Where MaKH = @MaKH
	Order by ChiSoMoi
go
--================================================================
--Drop procedure getInfoSoChuDien
create procedure getInfoSoChuDien( @MaKH uniqueidentifier )
as
	Select NgayLap,ChiSoCu,ChiSoMoi,ThanhTien
	From SoChuDien
	Where MaKH = @MaKH
	Order by ChiSoMoi
go
--================================================================
--Drop procedure deleteKhachHangNuoc
create procedure deleteKhachHangNuoc(@maKH uniqueidentifier)
as
	if(exists (select * From KhachHang where MaKH = @MaKH and LoaiKH = -1))
		update KhachHang
		set LoaiKH = 1
		Where MaKH = @MaKH
	else
		Delete From KhachHang
		Where MaKH = @MaKH and LoaiKH = 0
go
--================================================================
--Drop procedure deleteKhachHangDien
create procedure deleteKhachHangDien(@maKH uniqueidentifier)
as
	if(exists (select * From KhachHang where MaKH = @MaKH and LoaiKH = -1))
		update KhachHang
		set LoaiKH = 0
		Where MaKH = @MaKH
	else
		Delete From KhachHang
		Where MaKH = @MaKH and LoaiKH = 1
go
--================================================================
--Drop procedure insertInfoKH
create procedure insertInfoKH
(
	@MaKH uniqueidentifier,
	@HoTen nvarchar(35), 
	@GioiTinh bit,
	@DiaChi ntext, 
	@SoDT nvarchar(12),
	@LoaiKH int
)
as
	Insert Into KhachHang(MaKH, HoTen, GioiTinh, DiaChi, SoDT, LoaiKH)
	values(@MaKH, @HoTen, @GioiTinh, @DiaChi, @SoDT, @LoaiKH)
go
--================================================================
--Drop procedure updateInfoKH
create procedure updateInfoKH
(
	@MaKH uniqueidentifier,
	@HoTen nvarchar(35), 
	@GioiTinh bit,
	@DiaChi ntext, 
	@SoDT nvarchar(12)
)
as
	Update KhachHang
	Set HoTen = @HoTen, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDT = @SoDT
	Where MaKH = @MaKH
go
--================================================================
--Drop procedure moveInfo
create procedure moveInfo(@MaKH uniqueidentifier)
as
	Update KhachHang
	Set LoaiKH =-1
	Where MaKH = @MaKH
go
--===============================================================
--Drop procedure insertInfoSoKhoiNuoc
create procedure insertInfoSoKhoiNuoc
(
	@MaKH uniqueidentifier,
	@NgayLap datetime ,
	@ChiSoCu int,
	@ChiSoMoi int,
	@SoThangSD int,
	@SoKhoiThamHut int,
	@ThanhTien real
)
as
	insert into SoKhoiNuoc(MaKH,NgayLap,ChiSoCu,ChiSoMoi,SoThangSuDung,SoKhoiThamHut,ThanhTien)
	values(@MaKH,@NgayLap,@ChiSoCu,@ChiSoMoi,@SoThangSD,@SoKhoiThamHut,@ThanhTien)
go
--===============================================================
--Drop procedure insertInfoSoChuDien
create procedure insertInfoSoChuDien
(
	@MaKH uniqueidentifier,
	@NgayLap datetime ,
	@ChiSoCu int,
	@ChiSoMoi int,
	@ThanhTien real
)
as
	insert into SoChuDien(MaKH,NgayLap,ChiSoCu,ChiSoMoi,ThanhTien)
	values(@MaKH,@NgayLap,@ChiSoCu,@ChiSoMoi,@ThanhTien)
go
--================================================================
--Drop procedure deleteInfoSoKhoiNuoc
create procedure deleteInfoSoKhoiNuoc
(
	@MaKH uniqueidentifier,
	@NgayLap datetime
)
as
	Delete From SoKhoiNuoc
	where MaKH = @MaKH and @NgayLap = NgayLap
go
--================================================================
--Drop procedure deleteInfoSoChuDien
create procedure deleteInfoSoChuDien
(
	@MaKH uniqueidentifier,
	@NgayLap datetime
)
as
	Delete From SoChuDien
	where MaKH = @MaKH and @NgayLap = NgayLap
go
--================================================================
--Drop procedure getInfoCTNuoc
create procedure getInfoCTNuoc
as
	Select MaDinhMuc,TenDinhMuc,DinhMuc,GiaDinhMuc,ThueVAT
	From CongThucNuoc
	order by MaDinhMuc
go
--================================================================
--Drop procedure getInfoCTDien
create procedure getInfoCTDien
as
	Select MaDinhMuc,TenDinhMuc,DinhMuc,GiaDinhMuc,ThueVAT
	From CongThucDien
	order by MaDinhMuc
go
--================================================================
--Drop procedure deleteCTNuoc
create procedure deleteCTNuoc
(
	@MaDinhMuc int
)
as
	delete From CongThucNuoc
	where MaDinhMuc = @MaDinhMuc
go
--================================================================
--Drop procedure deleteCTDien
create procedure deleteCTDien(@MaDinhMuc int)
as
	delete From CongThucDien
	where MaDinhMuc = @MaDinhMuc
go
--================================================================
--Drop procedure insertCTNuoc
create procedure insertCTNuoc
(
	@TenDinhMuc nvarchar(255),
	@DinhMuc int,
	@GiaDinhMuc real,
	@ThueVAT real
)
as
	Insert into CongThucNuoc(TenDinhMuc,DinhMuc,GiaDinhMuc,ThueVAT)
	values(@TenDinhMuc,@DinhMuc,@GiaDinhMuc,@ThueVAT)
go
--================================================================
--Drop procedure insertCTDien
create procedure insertCTDien
(
	@TenDinhMuc nvarchar(255),
	@DinhMuc int,
	@GiaDinhMuc real,
	@ThueVAT real
)
as
	Insert into CongThucDien(TenDinhMuc,DinhMuc,GiaDinhMuc,ThueVAT)
	values(@TenDinhMuc,@DinhMuc,@GiaDinhMuc,@ThueVAT)
go
--================================================================
--Drop procedure updateCTNuoc
create procedure updateCTNuoc
(
	@MaDinhMuc int,
	@TenDinhMuc nvarchar(255),
	@DinhMuc int,
	@GiaDinhMuc real,
	@ThueVAT real
)
as
	Update CongThucNuoc
	Set TenDinhMuc=@TenDinhMuc,DinhMuc=@DinhMuc,GiaDinhMuc=@GiaDinhMuc,ThueVAT=@ThueVAT
	Where MaDinhMuc=@MaDinhMuc
go
--================================================================
--Drop procedure updateCTDien
create procedure updateCTDien
(
	@MaDinhMuc int,
	@TenDinhMuc nvarchar(255),
	@DinhMuc int,
	@GiaDinhMuc real,
	@ThueVAT real
)
as
	Update CongThucDien
	Set TenDinhMuc=@TenDinhMuc,DinhMuc=@DinhMuc,GiaDinhMuc=@GiaDinhMuc,ThueVAT=@ThueVAT
	Where MaDinhMuc=@MaDinhMuc
go