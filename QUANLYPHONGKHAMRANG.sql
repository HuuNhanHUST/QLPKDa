﻿-- Tạo cơ sở dữ liệu
create DATABASE QuanlyPhongKhamRang;
USE QuanlyPhongKhamRang;

-- Tạo bảng BenhNhan
CREATE TABLE BenhNhan (
    MaBenhNhan CHAR(50) NOT NULL,
    TenBenhNhan NVARCHAR(100) NULL,
    SoDienThoai VARCHAR(20) NULL,
    Avatar VARBINARY(MAX) NULL,
    DiaChi NVARCHAR(1000),
    PRIMARY KEY (MaBenhNhan)
);
-- Tạo bảng DichVu
CREATE TABLE DichVu (
    MaDichVu CHAR(50) NOT NULL,
    TenDichVu NVARCHAR(100) NULL,
    GiaDV DECIMAL(18, 2) CHECK (GiaDV > 0) NULL,
    PRIMARY KEY (MaDichVu)
);
-- Tạo bảng Thuoc_
CREATE TABLE Thuoc_ (
    MaThuoc CHAR(50) NOT NULL,
    TenThuoc NVARCHAR(100) NULL,
    GiaThuoc DECIMAL(18, 2) CHECK (GiaThuoc > 0) NULL,
    PRIMARY KEY (MaThuoc)
);

-- Cập nhật bảng ToaThuoc để không lưu trường TongTien
create TABLE ToaThuoc (
    MaToa CHAR(50) NOT NULL,
    LieuLuon NVARCHAR(1000) NULL,
	MaThuoc CHAR(50) NOT NULL,
    MaBenhNhan CHAR(50) NOT NULL,
	soluong int,
    ngaylap datetime,
    PRIMARY KEY (MaToa),
    FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan (MaBenhNhan),
	FOREIGN KEY (MaThuoc) REFERENCES Thuoc_ (MaThuoc)
);
select * from toathuoc
-- Tạo bảng LichHen
create TABLE LichHen (
    MaLichHen CHAR(50) NOT NULL,
    NgayHenGN datetime null,
    NgayHenTT datetime,

    MaBenhNhan CHAR(50) NOT NULL,
    MaDichVu CHAR(50),
    Ghichu NVARCHAR(1000),
    PRIMARY KEY (MaLichHen),
    FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan (MaBenhNhan),
    FOREIGN KEY (MaDichVu) REFERENCES DichVu (MaDichVu)
);

-- Tạo bảng HoaDon với MaBenhNhan là khóa ngoại tham chiếu đến bảng BenhNhan
create TABLE HoaDon (
    MaHoaDon CHAR(50) NOT NULL,
    ngaylap datetime,
	MaToa CHAR(50)  NULL,
    MaBenhNhan CHAR(50) NOT NULL,
    PRIMARY KEY (MaHoaDon),
	FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan (MaBenhNhan),
	MaDichVu CHAR(50)  NULL, 
	FOREIGN KEY (MaToa) REFERENCES ToaThuoc (MaToa) -- Liên kết với bảng ToaThuoc
);


INSERT INTO BenhNhan (MaBenhNhan, TenBenhNhan, SoDienThoai,Avatar, DiaChi) VALUES
('BN001', N'Nguyễn Văn A', '0912345678',(SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\QLPKDa\PICTURE\bacsix.png', SINGLE_BLOB) AS ImageData), N'Hà Nội'),
('BN002', N'Lê Thị B', '0987654321',(SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\QLPKDa\PICTURE\basixBN.jpg', SINGLE_BLOB) AS ImageData), N'TP. Hồ Chí Minh'),
('BN003', N'Phạm Văn C', '0933221144',(SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\QLPKDa\PICTURE\basixBN2.png', SINGLE_BLOB) AS ImageData), N'Đà Nẵng');

INSERT INTO DichVu (MaDichVu, TenDichVu, GiaDV) VALUES
('DV001', N'Khám tổng quát', 500000),
('DV002', N'Xét nghiệm máu', 300000),
('DV003', N'Chụp X-quang', 700000);
INSERT INTO Thuoc_ (MaThuoc, TenThuoc, GiaThuoc) VALUES
('TH001', N'Paracetamol', 20000),
('TH002', N'Amoxicillin', 50000),
('TH003', N'Vitamin C', 15000);
INSERT INTO ToaThuoc (MaToa, MaThuoc,LieuLuon, MaBenhNhan, ngaylap,soluong) VALUES
('TOA001','TH001', N'Uống 2 viên mỗi ngày sau ăn', 'BN001', '2025-01-04 08:30:00',10),
('TOA002','TH002', N'Uống 1 viên mỗi sáng', 'BN002', '2025-01-12 14:45:00',100);


INSERT INTO LichHen (MaLichHen, NgayHenGN, NgayHenTT, MaBenhNhan, MaDichVu, Ghichu) 
VALUES
('LH001', NULL, '2025-01-04 08:30:00', 'BN001', 'DV001', N'Khám sức khỏe định kỳ'),
('LH002', NULL, '2025-01-12 14:45:00', 'BN002', 'DV002', N'Xét nghiệm máu định kỳ');



select *from DichVu

select *from hoadon  

select *from LichHen
select *from ToaThuoc
select *from BenhNhan

