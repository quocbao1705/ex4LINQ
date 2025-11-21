create database PhieuNhapHang
use PhieuNhapHang
go 
create table NhaCungCap(
	MaNCC nvarchar (5) primary key,
	TenNCC nvarchar (50),
	);
	
create table SanPham(
	MaSP nvarchar (5) primary key,
	TenSP nvarchar (50),
	DonGia decimal,
	);

create table PhieuNhap(
	MaPN nvarchar (5) primary key,
	MaNCC nvarchar (5) foreign key references NhaCungCap(MaNCC),
	NgayNhap datetime,
	);

create table ChiTietPhieuNhap(
	MaPN nvarchar (5),
	MaSP nvarchar(5),
	SoLuong int,
	DonGia decimal,
	primary key (MaPN,MaSP),
	foreign key (MaPN) references PhieuNhap(MaPN),
	foreign key (MaSP) references SanPham(MaSP),
	);

	insert into SanPham (MaSP,TenSP,DonGia)
	values ('SP001',N'Máy giặt',15000000),
	('SP002',N'Máy lạnh',10000000),
	('SP003',N'Tủ lạnh',15000000)

	insert into NhaCungCap(MaNCC,TenNCC)
	values ('NCC01',N'Điện máy xanh'),
	('NCC02',N'Điện máy chợ lớn')

	drop table SanPham
	drop table NhaCungCap
	drop table PhieuNhap
	drop table ChiTietPhieuNhap
	
	
USE PhieuNhapHang
GO

-- 1. Lấy danh sách Nhà Cung Cấp
CREATE PROC sp_GetAllNhaCungCap
AS
BEGIN
    SELECT * FROM NhaCungCap
END
GO

-- 2. Lấy danh sách Sản Phẩm
CREATE PROC sp_GetAllSanPham
AS
BEGIN
    SELECT * FROM SanPham
END
GO

-- 3. Lấy giá Sản phẩm theo Mã
CREATE PROC sp_GetSanPhamByID
    @MaSP nvarchar(5)
AS
BEGIN
    SELECT * FROM SanPham WHERE MaSP = @MaSP
END
GO

-- 4. Lấy danh sách Phiếu Nhập
CREATE PROC sp_GetAllPhieuNhap
AS
BEGIN
    SELECT * FROM PhieuNhap ORDER BY NgayNhap DESC
END
GO

-- 5. Thêm Phiếu Nhập (Header)
CREATE PROC sp_InsertPhieuNhap
    @MaPN nvarchar(5),
    @MaNCC nvarchar(5),
    @NgayNhap datetime
AS
BEGIN
    INSERT INTO PhieuNhap(MaPN, MaNCC, NgayNhap)
    VALUES(@MaPN, @MaNCC, @NgayNhap)
END
GO

-- 6. Lấy chi tiết phiếu nhập (để hiển thị lên Grid)
-- Tự tính thành tiền luôn ở đây để Grid hiển thị
CREATE PROC sp_GetAllChiTiet
AS
BEGIN
    SELECT 
        ct.MaPN, 
        ct.MaSP, 
        ct.SoLuong, 
        ct.DonGia,
        (ct.SoLuong * ct.DonGia) AS ThanhTien
    FROM ChiTietPhieuNhap ct
    ORDER BY ct.MaPN DESC
END
GO

-- 7. Thêm Chi Tiết
CREATE PROC sp_InsertChiTiet
    @MaPN nvarchar(5),
    @MaSP nvarchar(5),
    @SoLuong int,
    @DonGia decimal(18,0)
AS
BEGIN
    INSERT INTO ChiTietPhieuNhap(MaPN, MaSP, SoLuong, DonGia)
    VALUES(@MaPN, @MaSP, @SoLuong, @DonGia)
END
GO

-- 8. Cập nhật Chi Tiết
CREATE PROC sp_UpdateChiTiet
    @MaPN nvarchar(5),
    @MaSP nvarchar(5),
    @SoLuong int,
    @DonGia decimal(18,0)
AS
BEGIN
    UPDATE ChiTietPhieuNhap
    SET SoLuong = @SoLuong, DonGia = @DonGia
    WHERE MaPN = @MaPN AND MaSP = @MaSP
END
GO

-- 9. Xóa Chi Tiết
CREATE PROC sp_DeleteChiTiet
    @MaPN nvarchar(5),
    @MaSP nvarchar(5)
AS
BEGIN
    DELETE FROM ChiTietPhieuNhap WHERE MaPN = @MaPN AND MaSP = @MaSP
END
GO

-- 10. Kiểm tra chi tiết đã tồn tại chưa
CREATE PROC sp_CheckChiTietExist
    @MaPN nvarchar(5),
    @MaSP nvarchar(5)
AS
BEGIN
    SELECT COUNT(*) FROM ChiTietPhieuNhap WHERE MaPN = @MaPN AND MaSP = @MaSP
END
GO