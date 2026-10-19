CREATE DATABASE QL_DaNgoai;
GO
USE QL_DaNgoai;
GO

CREATE TABLE ChuyenDi (
    MaChuyen INT IDENTITY(1,1) PRIMARY KEY,
    TenChuyen NVARCHAR(100) NOT NULL,
    DiaDiem NVARCHAR(100) NOT NULL,
    NgayDi DATE NOT NULL,
    SoNguoi INT NOT NULL,
    NganSach DECIMAL(18,0) NOT NULL,
    PhuongTien NVARCHAR(30) NOT NULL,
    DaHoanThanh BIT NOT NULL DEFAULT 0,
    GhiChu NVARCHAR(200) NULL
);
GO

-- Chèn 8 chuyến đi mẫu có ngày đi trải từ vài ngày đến vài tuần tới
INSERT INTO ChuyenDi (TenChuyen, DiaDiem, NgayDi, SoNguoi, NganSach, PhuongTien, DaHoanThanh, GhiChu) VALUES
(N'Cắm trại đồi chè', N'Đà Lạt', DATEADD(day, 3, GETDATE()), 6, 3500000, N'Ô tô', 0, N'Mang theo áo ấm'),
(N'Khám phá phố cổ', N'Hội An', DATEADD(day, 7, GETDATE()), 4, 4200000, N'Máy bay', 0, NULL),
(N'Tắm biển cuối tuần', N'Vũng Tàu', DATEADD(day, 2, GETDATE()), 8, 2000000, N'Xe khách', 0, NULL),
(N'Chinh phục đỉnh núi', N'Sa Pa', DATEADD(day, 12, GETDATE()), 5, 5500000, N'Tàu hỏa', 0, N'Chuẩn bị giày leo núi'),
(N'Săn mây đón gió', N'Đà Lạt', DATEADD(day, 15, GETDATE()), 4, 3000000, N'Xe máy', 0, NULL),
(N'Nghỉ dưỡng biển xanh', N'Nha Trang', DATEADD(day, 20, GETDATE()), 6, 6000000, N'Máy bay', 0, NULL),
(N'Khám phá hang động', N'Quảng Bình', DATEADD(day, 25, GETDATE()), 5, 4500000, N'Tàu hỏa', 0, NULL),
(N'Du lịch sinh thái', N'Cần Thơ', DATEADD(day, 5, GETDATE()), 10, 2500000, N'Ô tô', 1, N'Đã hoàn thành');
GO