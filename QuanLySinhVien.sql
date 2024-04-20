CREATE DATABASE QuanLySinhVien;

GO
USE QuanLySinhVien;

CREATE TABLE Khoa (
    KhoaId INT PRIMARY KEY,
    TenKhoa NVARCHAR(100)
);

CREATE TABLE Lop (
    LopId INT PRIMARY KEY,
    TenLop NVARCHAR(100),
    KhoaId INT,
    FOREIGN KEY (KhoaId) REFERENCES Khoa(KhoaId)
);

CREATE TABLE SinhVien (
    SinhVienId INT PRIMARY KEY,
    Ten NVARCHAR(100),
    Tuoi INT,
    LopId INT,
    FOREIGN KEY (LopId) REFERENCES Lop(LopId)
);

-- Chèn dữ liệu vào bảng Khoa
INSERT INTO Khoa (KhoaId, TenKhoa)
VALUES(1, N'CNTT'),
	  (2, N'KT'),
	  (3, N'NN')

-- Chèn dữ liệu vào bảng Lop
INSERT INTO Lop (LopId, TenLop, KhoaId)
VALUES(1, N'Lớp CNTT 1', 1),
	  (2, N'Lớp CNTT 2', 1),
	  (3, N'Lớp Kinh tế 1', 2),
	  (4, N'Lớp Kinh tế 2', 2),
	  (5, N'Lớp Anh văn 1', 3),
	  (6, N'Lớp Anh văn 2', 3)

-- Chèn dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (SinhVienId, Ten, Tuoi, LopId)
VALUES(1, N'Nguyễn Văn A', 20, 1),
	  (2, N'Trần Thị B', 19, 1),
	  (3, N'Lê Hoàng C', 21, 1),
	  (4, N'Phạm Minh D', 18, 2),
	  (5, N'Lê Thị E', 19, 2),
	  (6, N'Trần Văn F', 20, 2),
	  (7, N'Hoàng Thị G', 22, 3),
	  (8, N'Vũ Minh H', 20, 3),
	  (9, N'Đặng Văn I', 19, 3),
	  (10, N'Nguyễn Thị K', 21, 4),
	  (11, N'Trần Văn L', 20, 4),
	  (12, N'Phạm Thị M', 18, 4),
	  (13, N'Lê Văn N', 20, 5),
	  (14, N'Hoàng Thị P', 19, 5),
	  (15, N'Vũ Văn Q', 21, 5),
	  (16, N'Trần Thị T', 22, 6),
	  (17, N'Nguyễn Minh U', 19, 6),
	  (18, N'Hoàng Văn V', 20, 6)