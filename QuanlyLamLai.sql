CREATE DATABASE QuanlyLamLai;
USE QuanlyLamLai;

-- Tạo bảng BenhNhan
CREATE TABLE BenhNhan (
    MaBenhNhan CHAR(50) NOT NULL,
    TenBenhNhan NVARCHAR(100) NULL,
    SoDienThoai VARCHAR(20) NULL,
    Avatar VARBINARY(MAX) NULL,
    DiaChi NVARCHAR(1000),
    PRIMARY KEY (MaBenhNhan)
);

-- Tạo bảng HoaDon với MaDichVu làm khóa ngoại tham chiếu đến bảng DichVu
CREATE TABLE HoaDon (
    MaHoaDon CHAR(50) NOT NULL,
    GhiChu NVARCHAR(100) NULL,
    MaBenhNhan CHAR(50) NOT NULL,
    MaDichVu CHAR(50) NULL,  -- Thêm cột MaDichVu
    PRIMARY KEY (MaHoaDon),
    FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan (MaBenhNhan),
    FOREIGN KEY (MaDichVu) REFERENCES DichVu (MaDichVu)  -- Tạo khóa ngoại
);

-- Tạo bảng DichVu không chứa mã hóa đơn
CREATE TABLE DichVu (
    MaDichVu CHAR(50) NOT NULL,
    TenDichVu NVARCHAR(100) NULL,
    Gia DECIMAL(18, 2) CHECK (Gia > 0) NULL,
    PRIMARY KEY (MaDichVu)
);

-- Tạo bảng LichHen
CREATE TABLE LichHen (
    MaLichHen CHAR(50) NOT NULL,
    NgayHenTT DATETIME NULL,
    NgayHenGN DATETIME NULL,
    MaBenhNhan CHAR(50) NOT NULL,
    MaDichVu CHAR(50),
    Ghichu NVARCHAR(1000),
    PRIMARY KEY (MaLichHen),
    FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan (MaBenhNhan),
    FOREIGN KEY (MaDichVu) REFERENCES DichVu (MaDichVu)
);

-- Tạo bảng ToaThuoc
CREATE TABLE ToaThuoc (
    MaToa CHAR(50) NOT NULL,
    LieuLuon NVARCHAR(1000) NULL,
    SoLuong INT CHECK (SoLuong > 0) NULL,
    MaHoaDon CHAR(50) NOT NULL,
    MaBenhNhan CHAR(50) NOT NULL,
    PRIMARY KEY (MaToa),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon (MaHoaDon),
    FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan (MaBenhNhan)
);

-- Tạo bảng Thuoc_
CREATE TABLE Thuoc_ (
    MaThuoc CHAR(50) NOT NULL,
    TenThuoc NVARCHAR(100) NULL,
    Gia DECIMAL(18, 2) CHECK (Gia > 0) NULL,
    MaToa CHAR(50) NOT NULL,
    PRIMARY KEY (MaThuoc),
    FOREIGN KEY (MaToa) REFERENCES ToaThuoc (MaToa)
);

-- Tạo bảng DoanhThu
CREATE TABLE DoanhThu (
    MaDoanhThu CHAR(50) PRIMARY KEY,
    MaDichVu CHAR(50) NOT NULL,
    NgayHoaDon DATETIME,
    Gia DECIMAL,
    FOREIGN KEY (MaDichVu) REFERENCES DichVu (MaDichVu)
);

-- Thêm dữ liệu vào bảng BenhNhan
INSERT INTO BenhNhan (MaBenhNhan, TenBenhNhan, SoDienThoai, Avatar, DiaChi)
VALUES 
('BN001', N'Nguyen Van A', '0123456789', 
    (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\QLPKDa\PICTURE\bacsix.png', SINGLE_BLOB) AS ImageData),
    N'Linh Đông, Thủ Đức, Tp Hồ Chí Minh'),
('BN002', N'Tran Thi B', '0987654321', 
    (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\QLPKDa\PICTURE\basixBN.jpg', SINGLE_BLOB) AS ImageData),
    N'17A Tô Ngọc Vân, Thủ Đức, Tp Hồ Chí Minh'),
('BN003', N'Le Van C', '0912345678', 
    (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\QLPKDa\PICTURE\basixBN2.png', SINGLE_BLOB) AS ImageData),
    N'488A/10B Phạm Văn Đồng, Thủ Đức, Tp Hồ Chí Minh'),
('BN004', N'Pham Thi D', '0934567890', 
    (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\QLPKDa\PICTURE\bnhan4.jpg', SINGLE_BLOB) AS ImageData),
    N'101 Quang Trung, Gò Vấp, Tp Hồ Chí Minh'),
('BN005', N'Nguyen Van E', '0967890123', 
    (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\QLPKDa\PICTURE\bnhan5.jpg', SINGLE_BLOB) AS ImageData),
    N'4011/10B/10/11/2A Linh Tây, Thủ Đức, Tp Hồ Chí Minh'),
('BN006', N'Tran Van F', '0978901234', 
    (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\QLPKDa\PICTURE\bnhan6.jpg', SINGLE_BLOB) AS ImageData),
    N'124 Lê Văn Việt, Quận 9, Tp Hồ Chí Minh');

-- Thêm dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (MaHoaDon, GhiChu, MaBenhNhan, MaDichVu)
VALUES
('HD001', N'Hóa đơn khám nha khoa', 'BN001', 'DV001'),
('HD002', N'Hóa đơn tẩy trắng răng', 'BN002', 'DV002'),
('HD003', N'Hóa đơn nhổ răng', 'BN003', 'DV003'),
('HD004', N'Hóa đơn điều trị nha chu', 'BN004', 'DV004'),
('HD005', N'Hóa đơn cấy ghép răng', 'BN005', 'DV005');

-- Thêm dữ liệu vào bảng DichVu
INSERT INTO DichVu (MaDichVu, TenDichVu, Gia)
VALUES
('DV001', N'Khám nha khoa', 300000),
('DV002', N'Tẩy trắng răng', 500000),
('DV003', N'Nhổ răng', 200000),
('DV004', N'Diều trị nha chu', 600000),
('DV005', N'Cấy ghép răng', 1500000);

-- Thêm dữ liệu vào bảng LichHen
INSERT INTO LichHen (MaLichHen, NgayHenTT, NgayHenGN, MaBenhNhan, MaDichVu, Ghichu)
VALUES
('LH001', '2025-01-10 08:00', '2025-01-10 09:00', 'BN001', 'DV001', N'Hẹn khám nha khoa'),
('LH002', '2025-01-11 10:00', '2025-01-11 11:00', 'BN002', 'DV002', N'Hẹn tẩy trắng răng'),
('LH003', '2025-01-12 14:00', '2025-01-12 15:00', 'BN003', 'DV003', N'Hẹn nhổ răng'),
('LH004', '2025-01-13 08:30', '2025-01-13 09:30', 'BN004', 'DV004', N'Hẹn điều trị nha chu'),
('LH005', '2025-01-14 16:00', '2025-01-14 17:00', 'BN005', 'DV005', N'Hẹn cấy ghép răng');
-- Thêm dữ liệu vào bảng ToaThuoc
INSERT INTO ToaThuoc (MaToa, LieuLuon, SoLuong, MaHoaDon, MaBenhNhan)
VALUES
('TT001', N'Liều thuốc chống viêm', 2, 'HD001', 'BN001'),
('TT002', N'Liều thuốc giảm đau', 3, 'HD002', 'BN002'),
('TT003', N'Liều thuốc giảm đau', 1, 'HD003', 'BN003'),
('TT004', N'Liều thuốc kháng sinh', 2, 'HD004', 'BN004'),
('TT005', N'Liều thuốc an thần', 1, 'HD005', 'BN005');

-- Thêm dữ liệu vào bảng Thuoc_
INSERT INTO Thuoc_ (MaThuoc, TenThuoc, Gia, MaToa)
VALUES
('T001', N'Thuốc giảm đau', 100000, 'TT001'),
('T002', N'Thuốc kháng sinh', 200000, 'TT002'),
('T003', N'Thuốc chống viêm', 150000, 'TT003'),
('T004', N'Thuốc chống viêm', 120000, 'TT004'),
('T005', N'Thuốc an thần', 180000, 'TT005');

-- Thêm dữ liệu vào bảng DoanhThu
INSERT INTO DoanhThu (MaDoanhThu, MaDichVu, NgayHoaDon, Gia)
VALUES
('DT001', 'DV001', '2025-01-10', 300000),
('DT002', 'DV002', '2025-01-11', 500000),
('DT003', 'DV003', '2025-01-12', 200000),
('DT004', 'DV004', '2025-01-13', 600000),
('DT005', 'DV005', '2025-01-14', 1500000);

