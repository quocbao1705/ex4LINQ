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
	