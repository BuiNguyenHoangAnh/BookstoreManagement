CREATE DATABASE QLNS
USE QLNS

CREATE TABLE NHANVIEN
(
	MaNhanVien nchar(10)PRIMARY KEY,
	HoTenNhanVien nchar(100),
	DiaChi nchar(100),
	DienThoai nchar(20),
	Email nchar(50),
	TienLuong float
)

CREATE TABLE SACH
(
	MaSach		nchar(10)PRIMARY KEY,
	TenSach		nchar(100),
	TheLoai		nchar(50),
	TacGia		nchar(100),
	SoLuongTon	int,
)


CREATE TABLE PHIEUNHAP
(
	MaPhieuNhap	nchar(10)PRIMARY KEY not null,
	NgayNhap datetime,
)

CREATE TABLE CHITIETPHIEUNHAP
(
	MaChiTietPhieuNHap	nchar(10)PRIMARY KEY not null,
	MaPhieuNhap	nchar(10)FOREIGN KEY REFERENCES PHIEUNHAP(MaPhieuNhap),
	MaSach	nchar(10)FOREIGN KEY REFERENCES SACH(MaSach),
	SoLuongNhap	int,
)

CREATE TABLE KHACHHANG
(
	MaKhachHang	nchar(10)PRIMARY KEY not null,
	HoTenKhachHang nchar(100),
	DiaChi nchar(100),
	DienThoai nchar(20),
	Email nchar(50),
	SoTienNo float
)

CREATE TABLE HOADON
(
	MaHoaDon	nchar(10)PRIMARY KEY not null,
	MaKhachHang nchar(10)FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
	NgayLapHoaDon datetime,
	TongThanhTien int,
	MaNhanVienLap nchar(10)FOREIGN KEY REFERENCES NHANVIEN(MaNhanVien)
)

DELETE FROM HOADON
CREATE TABLE CHITIETHOADON
(
	MaChiTietHoaDon	nchar(10)PRIMARY KEY not null,
	MaHoaDon nchar(10)FOREIGN KEY REFERENCES HOADON(MaHoaDon),
	MaSach nchar(10)FOREIGN KEY REFERENCES SACH(MaSach),
	SoLuongBan int,
	DonGiaBan float,
)

CREATE TABLE PHIEUTHUTIEN
(
	MaPhieuThu	nchar(10)PRIMARY KEY not null,
	SoTienThu float,
	NgayThuTien datetime,
	MaKhachHang nchar(10)FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
)

CREATE TABLE BAOCAOTON
(
	MaChiTietTon	nchar(10)PRIMARY KEY not null,
	Thang int,
	Nam int,
	MaSach nchar(10)FOREIGN KEY REFERENCES SACH(MaSach),
	TonDau int,
	TonPhatSinh int,
	TonCuoi int,
)

CREATE TABLE BAOCAOCONGNO
(
	MaChiTietCongNo	nchar(10)PRIMARY KEY not null,
	Thang int,
	Nam int,
	MaKhachHang nchar(10)FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
	NoDau float,
	NoCuoi float,
	NoPhatSinh float,
)

CREATE TABLE THAMSO
(
	MaThamSo	int identity(1,1) PRIMARY KEY not null,
	SoLuongNhapItNhat int,
	SoLuongTonToiDaTruocNhap int,
	SoLuongTonSauToiThieu int,
	SoTienNoToiDa float,
	SuDungQuyDinh4 int,
)

CREATE TABLE NGUOIDUNG
(
	MaNguoiDung	int identity(1,1) PRIMARY KEY,
	NguoiDung nchar(10),
	MatKhau nchar(10),
)



insert into NGUOIDUNG values('Admin',123456)
insert into NGUOIDUNG values('Manager',123)

insert into THAMSO values(150,300,20,20000,1)

insert into SACH values('MS001', N'Đắc nhân tâm', N'Tâm lí học', 'Dale Carnegie', 20)
insert into SACH values('MS002', 'Doraemon', N'Truyện tranh', 'Fujiko Fujio', 15)
insert into SACH values('MS003', 'UML Distilled', N'Tin học', 'Martin Fowler',30)

insert into NHANVIEN values('NV001', N'Nguyễn Văn A', N'23 Lý Tự Trọng', '01234567890', 'anv@gmail.com', 1300000)
insert into NHANVIEN values('NV002', N'Phạm Thị B', N'37 Tôn Đức Thắng', '01243567777', 'bpt@gmail.com', 1500000)
insert into NHANVIEN values('NV003', N'Lê Văn C', N'52 Nguyễn Du', '012456789534', 'clv@gmail.com', 1250000)

insert into KHACHHANG values('KH001', N'Phan Thanh D', N'37 Lê Văn Hưu', '01235667673', 'dpt@gmail.com', 0)
insert into KHACHHANG values('KH002', N'Nguyễn Tôn N', N'46 Lê Lợi', '01224555542', 'nnt@gmail.com', 10000)
insert into KHACHHANG values('KH003', N'Phạm Văn G', N'23 Đông Du', '01235665555', 'gpv@gmail.com', 0)