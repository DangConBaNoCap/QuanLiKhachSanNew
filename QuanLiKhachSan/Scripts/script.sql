USE [master]
GO
/****** Object:  Database [QuanLiKhachSan]    Script Date: 11/21/2016 2:31:21 PM ******/
CREATE DATABASE [QuanLiKhachSan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiKhachSan', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLiKhachSan.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiKhachSan_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLiKhachSan_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiKhachSan] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiKhachSan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiKhachSan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiKhachSan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiKhachSan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiKhachSan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLiKhachSan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiKhachSan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiKhachSan] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiKhachSan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiKhachSan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiKhachSan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiKhachSan] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLiKhachSan]
GO
/****** Object:  Table [dbo].[ChiTietThuePhong]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietThuePhong](
	[MaHD] [int] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[NgayTra] [datetime] NULL,
 CONSTRAINT [PK_ChiTietThuePhong] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[GiaDV] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HDThanhToanPhong]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDThanhToanPhong](
	[MaThanhToan] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NULL,
	[MaNV] [int] NULL,
	[NgayThanhToan] [datetime] NULL,
	[TienPhong] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HDThanhToanPhong] PRIMARY KEY CLUSTERED 
(
	[MaThanhToan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [varchar](50) NULL,
	[GioiTinh] [int] NULL,
	[CMND] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[LoaiPhong] [nvarchar](50) NULL,
	[GiaTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [int] NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiPhong] [int] NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SuDungDV]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuDungDV](
	[MaHD] [int] NOT NULL,
	[MaDV] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_SuDungDV] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[MaTB] [int] IDENTITY(1,1) NOT NULL,
	[TenThietBi] [nvarchar](50) NULL,
	[GiaTB] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ThietBi] PRIMARY KEY CLUSTERED 
(
	[MaTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuePhong](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[NgayThue] [datetime] NULL,
	[MaKH] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangBiPhong]    Script Date: 11/21/2016 2:31:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangBiPhong](
	[MaLoaiPhong] [int] NOT NULL,
	[MaTB] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_TrangBiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC,
	[MaTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietThuePhong] ([MaHD], [MaPhong], [NgayTra]) VALUES (1, 1, NULL)
INSERT [dbo].[ChiTietThuePhong] ([MaHD], [MaPhong], [NgayTra]) VALUES (1, 2, NULL)
INSERT [dbo].[ChiTietThuePhong] ([MaHD], [MaPhong], [NgayTra]) VALUES (2, 3, NULL)
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (1, N'Ăn sáng', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (2, N'Ăn Trưa/Tối', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (3, N'Tắm bể bơi', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (4, N'Giặt là', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (5, N'Chơi Tennis', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (6, N'Chơi Golf', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (7, N'Đỗ xe', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (8, N'Indoor Game', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (9, N'Trượt cỏ', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (10, N'Tham Quan DT', CAST(500000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[DichVu] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [DiaChi], [DienThoai], [GioiTinh], [CMND]) VALUES (1, N'Nguyễn Như Trang', N'121 Trần Quốc Hoàn', N'01683699633', 1, 26559983)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [DiaChi], [DienThoai], [GioiTinh], [CMND]) VALUES (2, N'Trần Quốc Đại', N'23 Hoàng Diệu', N'03986623369', 0, 33669995)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [LoaiPhong], [GiaTien]) VALUES (1, N'Đơn', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [LoaiPhong], [GiaTien]) VALUES (2, N'Đôi', CAST(700000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [LoaiPhong], [GiaTien]) VALUES (3, N'Nhóm', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [LoaiPhong], [GiaTien]) VALUES (4, N'VIP', CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [LoaiPhong], [GiaTien]) VALUES (5, N'VVIP', CAST(3000000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [LoaiPhong], [GiaTien]) VALUES (6, N'Hội Nghị nhỏ ', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [LoaiPhong], [GiaTien]) VALUES (7, N'Hội Nghị vừa', CAST(10000000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [LoaiPhong], [GiaTien]) VALUES (8, N'Hội Nghị lớn', CAST(20000000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi]) VALUES (1, N'Ha Vu Thu Trang', CAST(0x0000884400000000 AS DateTime), 1, N'236 Hoàng quốc Việt')
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi]) VALUES (2, N'Hà Xuân Tùng', CAST(0x000087FB00000000 AS DateTime), 0, N'Cầu Giấy- Hà Nôi')
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi]) VALUES (3, N'Nguyễn Minh Tuấn', CAST(0x000087D300000000 AS DateTime), 0, N'Hai Bà Trưng - Hà Nội')
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi]) VALUES (4, N'Đỗ Hoài Trung', CAST(0x0000863E00000000 AS DateTime), 0, N'Đống Đa-Hà Nội')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (1, 1, 1)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (2, 1, 1)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (3, 1, 1)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (4, 2, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (5, 2, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (6, 2, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (7, 3, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (8, 3, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (9, 3, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (10, 4, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (11, 4, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (12, 4, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (13, 5, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (14, 5, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (15, 5, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (16, 6, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (17, 6, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (18, 6, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (19, 7, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (20, 7, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (21, 8, 0)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang]) VALUES (22, 8, 0)
SET IDENTITY_INSERT [dbo].[Phong] OFF
INSERT [dbo].[SuDungDV] ([MaHD], [MaDV], [SoLuong], [MaNV]) VALUES (1, 1, 2, 1)
INSERT [dbo].[SuDungDV] ([MaHD], [MaDV], [SoLuong], [MaNV]) VALUES (1, 3, 1, 3)
INSERT [dbo].[SuDungDV] ([MaHD], [MaDV], [SoLuong], [MaNV]) VALUES (1, 4, 5, 1)
INSERT [dbo].[SuDungDV] ([MaHD], [MaDV], [SoLuong], [MaNV]) VALUES (1, 5, 1, 3)
INSERT [dbo].[SuDungDV] ([MaHD], [MaDV], [SoLuong], [MaNV]) VALUES (2, 5, 2, 4)
INSERT [dbo].[SuDungDV] ([MaHD], [MaDV], [SoLuong], [MaNV]) VALUES (2, 6, 3, 4)
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'HaTrang', N'kentty', 1)
SET IDENTITY_INSERT [dbo].[ThuePhong] ON 

INSERT [dbo].[ThuePhong] ([MaHD], [MaNV], [NgayThue], [MaKH]) VALUES (1, 1, CAST(0x0000A65900000000 AS DateTime), 1)
INSERT [dbo].[ThuePhong] ([MaHD], [MaNV], [NgayThue], [MaKH]) VALUES (2, 2, CAST(0x0000A6C900000000 AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[ThuePhong] OFF
ALTER TABLE [dbo].[ChiTietThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThuePhong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[ChiTietThuePhong] CHECK CONSTRAINT [FK_ChiTietThuePhong_Phong]
GO
ALTER TABLE [dbo].[ChiTietThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThuePhong_ThuePhong] FOREIGN KEY([MaHD])
REFERENCES [dbo].[ThuePhong] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietThuePhong] CHECK CONSTRAINT [FK_ChiTietThuePhong_ThuePhong]
GO
ALTER TABLE [dbo].[HDThanhToanPhong]  WITH CHECK ADD  CONSTRAINT [FK_HDThanhToanPhong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HDThanhToanPhong] CHECK CONSTRAINT [FK_HDThanhToanPhong_NhanVien]
GO
ALTER TABLE [dbo].[HDThanhToanPhong]  WITH CHECK ADD  CONSTRAINT [FK_HDThanhToanPhong_ThuePhong] FOREIGN KEY([MaHD])
REFERENCES [dbo].[ThuePhong] ([MaHD])
GO
ALTER TABLE [dbo].[HDThanhToanPhong] CHECK CONSTRAINT [FK_HDThanhToanPhong_ThuePhong]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
ALTER TABLE [dbo].[SuDungDV]  WITH CHECK ADD  CONSTRAINT [FK_SuDungDV_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[SuDungDV] CHECK CONSTRAINT [FK_SuDungDV_DichVu]
GO
ALTER TABLE [dbo].[SuDungDV]  WITH CHECK ADD  CONSTRAINT [FK_SuDungDV_ThuePhong] FOREIGN KEY([MaHD])
REFERENCES [dbo].[ThuePhong] ([MaHD])
GO
ALTER TABLE [dbo].[SuDungDV] CHECK CONSTRAINT [FK_SuDungDV_ThuePhong]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_KhachHang]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_NhanVien]
GO
ALTER TABLE [dbo].[TrangBiPhong]  WITH CHECK ADD  CONSTRAINT [FK_TrangBiPhong_LoaiPhong] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[TrangBiPhong] CHECK CONSTRAINT [FK_TrangBiPhong_LoaiPhong]
GO
ALTER TABLE [dbo].[TrangBiPhong]  WITH CHECK ADD  CONSTRAINT [FK_TrangBiPhong_ThietBi] FOREIGN KEY([MaTB])
REFERENCES [dbo].[ThietBi] ([MaTB])
GO
ALTER TABLE [dbo].[TrangBiPhong] CHECK CONSTRAINT [FK_TrangBiPhong_ThietBi]
GO
USE [master]
GO
ALTER DATABASE [QuanLiKhachSan] SET  READ_WRITE 
GO
