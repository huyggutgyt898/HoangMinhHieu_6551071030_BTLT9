CREATE DATABASE QL_ChiTieu
GO

USE QL_ChiTieu
GO

CREATE TABLE ChiTieu
(
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    NgayChi DATE NOT NULL,
    NoiDung NVARCHAR(100) NOT NULL,
    LoaiChi NVARCHAR(30) NOT NULL,
    SoTien DECIMAL(18,0) NOT NULL,
    GhiChu NVARCHAR(200) NULL
)
GO

INSERT INTO ChiTieu(NgayChi,NoiDung,LoaiChi,SoTien,GhiChu)
VALUES
('2026-10-01',N'Cơm trưa',N'Ăn uống',35000,N''),
('2026-10-02',N'Xăng xe',N'Đi lại',60000,N''),
('2026-10-03',N'Photo giáo trình',N'Học tập',25000,N''),
('2026-10-04',N'Xem phim',N'Giải trí',90000,N''),
('2026-10-05',N'Trá sữa',N'Ăn uống',40000,N''),
('2026-10-06',N'Mua sách',N'Học tập',150000,N''),
('2026-10-07',N'Tiền điện',N'Khác',500000,N''),
('2026-10-08',N'Ăn sáng',N'Ăn uống',25000,N''),
('2026-10-09',N'Gửi xe',N'Đi lại',10000,N''),
('2026-10-10',N'Cafe',N'Ăn uống',45000,N'');

SELECT * FROM   ChiTieu;