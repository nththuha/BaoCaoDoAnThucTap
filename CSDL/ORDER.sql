USE [master]
GO
/****** Object:  Database [OrderManagement]    Script Date: 8/29/2022 2:54:42 PM ******/
CREATE DATABASE [OrderManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OrderManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OrderManagement.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OrderManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OrderManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OrderManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OrderManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OrderManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OrderManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OrderManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OrderManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OrderManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [OrderManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OrderManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OrderManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OrderManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OrderManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OrderManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OrderManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OrderManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OrderManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OrderManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OrderManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OrderManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OrderManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OrderManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OrderManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OrderManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OrderManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OrderManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [OrderManagement] SET  MULTI_USER 
GO
ALTER DATABASE [OrderManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OrderManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OrderManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OrderManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [OrderManagement] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OrderManagement', N'ON'
GO
USE [OrderManagement]
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[MABAN] [nvarchar](256) NOT NULL,
	[TENBAN] [nvarchar](max) NOT NULL,
	[SOGHE] [int] NOT NULL,
 CONSTRAINT [PK_BAN] PRIMARY KEY CLUSTERED 
(
	[MABAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MABP] [nvarchar](256) NOT NULL,
	[TENBP] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[MABP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_BAN]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_BAN](
	[IDCTB] [int] IDENTITY(1,1) NOT NULL,
	[MABAN] [nvarchar](256) NOT NULL,
	[MAPHONG] [nvarchar](256) NOT NULL,
	[TRANGTHAI] [nvarchar](256) NOT NULL,
	[SOGHE] [int] NOT NULL,
 CONSTRAINT [PK_CT_BAN] PRIMARY KEY CLUSTERED 
(
	[IDCTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_DATBAN]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DATBAN](
	[IDCTDB] [int] IDENTITY(1,1) NOT NULL,
	[IDPD] [int] NOT NULL,
	[IDCTB] [int] NOT NULL,
 CONSTRAINT [PK_CT_DATBAN] PRIMARY KEY CLUSTERED 
(
	[IDCTDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_DATMON]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DATMON](
	[IDCTDM] [int] IDENTITY(1,1) NOT NULL,
	[MAMA] [nvarchar](256) NOT NULL,
	[IDPD] [int] NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[TRANGTHAI] [nvarchar](max) NOT NULL,
	[CHUTHICH] [nvarchar](max) NOT NULL,
	[GIA] [int] NOT NULL,
 CONSTRAINT [PK_CT_DATMON] PRIMARY KEY CLUSTERED 
(
	[IDCTDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_MONAN]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_MONAN](
	[IDCTMA] [int] IDENTITY(1,1) NOT NULL,
	[MAMA] [nvarchar](256) NOT NULL,
	[MANL] [nvarchar](256) NOT NULL,
	[SOLUONG] [int] NOT NULL,
 CONSTRAINT [PK_CT_MONAN] PRIMARY KEY CLUSTERED 
(
	[IDCTMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPN_NGUYENLIEU]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPN_NGUYENLIEU](
	[IDCTPN] [int] IDENTITY(1,1) NOT NULL,
	[IDPN] [int] NOT NULL,
	[MANL] [nvarchar](256) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[GIA] [int] NOT NULL,
 CONSTRAINT [PK_CTPN_NGUYENLIEU] PRIMARY KEY CLUSTERED 
(
	[IDCTPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [nvarchar](256) NOT NULL,
	[IDNV] [int] NOT NULL,
	[NGAY] [date] NOT NULL,
	[TRIGIA] [int] NOT NULL,
	[MASOTHUE] [nvarchar](50) NULL,
	[HOTENKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[IDKH] [int] NOT NULL,
	[HOTEN] [nvarchar](max) NOT NULL,
	[SDT] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIMONAN]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIMONAN](
	[MALMA] [nvarchar](256) NOT NULL,
	[TENLMA] [nvarchar](max) NOT NULL,
	[HINHANH] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_LOAIMONAN] PRIMARY KEY CLUSTERED 
(
	[MALMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONAN](
	[MAMA] [nvarchar](256) NOT NULL,
	[TENMA] [nvarchar](max) NOT NULL,
	[CHUTHICH] [nvarchar](max) NOT NULL,
	[TRANGTHAI] [nvarchar](max) NOT NULL,
	[HINHANH] [nvarchar](max) NOT NULL,
	[MALMA] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_MONAN] PRIMARY KEY CLUSTERED 
(
	[MAMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[MANL] [nvarchar](256) NOT NULL,
	[TENNL] [nvarchar](max) NOT NULL,
	[DONVI] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_NGUYENLIEU] PRIMARY KEY CLUSTERED 
(
	[MANL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[IDNV] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](max) NOT NULL,
	[SDT] [nvarchar](max) NOT NULL,
	[DIACHI] [nvarchar](max) NOT NULL,
	[EMAIL] [nvarchar](max) NOT NULL,
	[MAPB] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUDAT]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDAT](
	[IDPD] [int] IDENTITY(1,1) NOT NULL,
	[IDKH] [int] NOT NULL,
	[IDNV] [int] NOT NULL,
	[NGAY] [date] NOT NULL,
	[IDHD] [nvarchar](256) NULL,
 CONSTRAINT [PK_PHIEUDAT] PRIMARY KEY CLUSTERED 
(
	[IDPD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAPNGUYENLIEU]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAPNGUYENLIEU](
	[IDPN] [int] IDENTITY(1,1) NOT NULL,
	[IDNV] [int] NOT NULL,
	[NGAY] [date] NOT NULL,
 CONSTRAINT [PK_PHIEUNHAPNGUYENLIEU] PRIMARY KEY CLUSTERED 
(
	[IDPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MAPHONG] [nvarchar](256) NOT NULL,
	[TENPHONG] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MAPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MATK] [nvarchar](256) NOT NULL,
	[MATKHAU] [nvarchar](max) NOT NULL,
	[IDNV] [int] NOT NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[MATK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAYDOIGIAMON]    Script Date: 8/29/2022 2:54:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAYDOIGIAMON](
	[IDGM] [int] IDENTITY(1,1) NOT NULL,
	[MAMA] [nvarchar](256) NOT NULL,
	[IDNV] [int] NOT NULL,
	[NGAY] [date] NOT NULL,
	[GIA] [int] NOT NULL,
 CONSTRAINT [PK_THAYDOIGIAMON] PRIMARY KEY CLUSTERED 
(
	[IDGM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_CT_MONAN]    Script Date: 8/29/2022 2:54:42 PM ******/
ALTER TABLE [dbo].[CT_MONAN] ADD  CONSTRAINT [IX_CT_MONAN] UNIQUE NONCLUSTERED 
(
	[MAMA] ASC,
	[IDCTMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TAIKHOAN]    Script Date: 8/29/2022 2:54:42 PM ******/
ALTER TABLE [dbo].[TAIKHOAN] ADD  CONSTRAINT [IX_TAIKHOAN] UNIQUE NONCLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_BAN]  WITH CHECK ADD  CONSTRAINT [FK_BAN_CT_BAN] FOREIGN KEY([MABAN])
REFERENCES [dbo].[BAN] ([MABAN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_BAN] CHECK CONSTRAINT [FK_BAN_CT_BAN]
GO
ALTER TABLE [dbo].[CT_BAN]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_CT_BAN] FOREIGN KEY([MAPHONG])
REFERENCES [dbo].[PHONG] ([MAPHONG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_BAN] CHECK CONSTRAINT [FK_PHONG_CT_BAN]
GO
ALTER TABLE [dbo].[CT_DATBAN]  WITH CHECK ADD  CONSTRAINT [FK_CT_DATBAN_CT_BAN] FOREIGN KEY([IDCTB])
REFERENCES [dbo].[CT_BAN] ([IDCTB])
GO
ALTER TABLE [dbo].[CT_DATBAN] CHECK CONSTRAINT [FK_CT_DATBAN_CT_BAN]
GO
ALTER TABLE [dbo].[CT_DATBAN]  WITH CHECK ADD  CONSTRAINT [FK_CT_DATBAN_PHIEUDAT] FOREIGN KEY([IDPD])
REFERENCES [dbo].[PHIEUDAT] ([IDPD])
GO
ALTER TABLE [dbo].[CT_DATBAN] CHECK CONSTRAINT [FK_CT_DATBAN_PHIEUDAT]
GO
ALTER TABLE [dbo].[CT_DATMON]  WITH CHECK ADD  CONSTRAINT [FK_MONAN_CT_DATMON] FOREIGN KEY([MAMA])
REFERENCES [dbo].[MONAN] ([MAMA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_DATMON] CHECK CONSTRAINT [FK_MONAN_CT_DATMON]
GO
ALTER TABLE [dbo].[CT_DATMON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUDAT_CT_DATMONX] FOREIGN KEY([IDPD])
REFERENCES [dbo].[PHIEUDAT] ([IDPD])
GO
ALTER TABLE [dbo].[CT_DATMON] CHECK CONSTRAINT [FK_PHIEUDAT_CT_DATMONX]
GO
ALTER TABLE [dbo].[CT_MONAN]  WITH CHECK ADD  CONSTRAINT [FK_MONAN_CT_MONAN1] FOREIGN KEY([MAMA])
REFERENCES [dbo].[MONAN] ([MAMA])
GO
ALTER TABLE [dbo].[CT_MONAN] CHECK CONSTRAINT [FK_MONAN_CT_MONAN1]
GO
ALTER TABLE [dbo].[CT_MONAN]  WITH CHECK ADD  CONSTRAINT [FK_NGUYENLIEU_CT_MONAN] FOREIGN KEY([MANL])
REFERENCES [dbo].[NGUYENLIEU] ([MANL])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_MONAN] CHECK CONSTRAINT [FK_NGUYENLIEU_CT_MONAN]
GO
ALTER TABLE [dbo].[CTPN_NGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [FK_NGUYENLIEU_CTPN_NGUYENLIEU] FOREIGN KEY([MANL])
REFERENCES [dbo].[NGUYENLIEU] ([MANL])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTPN_NGUYENLIEU] CHECK CONSTRAINT [FK_NGUYENLIEU_CTPN_NGUYENLIEU]
GO
ALTER TABLE [dbo].[CTPN_NGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPNGUYENLIEU_CTPN_NGUYENLIEU] FOREIGN KEY([IDPN])
REFERENCES [dbo].[PHIEUNHAPNGUYENLIEU] ([IDPN])
GO
ALTER TABLE [dbo].[CTPN_NGUYENLIEU] CHECK CONSTRAINT [FK_PHIEUNHAPNGUYENLIEU_CTPN_NGUYENLIEU]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_HOADON] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_NHANVIEN_HOADON]
GO
ALTER TABLE [dbo].[MONAN]  WITH CHECK ADD  CONSTRAINT [FK_LOAIMONAN_MONAN] FOREIGN KEY([MALMA])
REFERENCES [dbo].[LOAIMONAN] ([MALMA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MONAN] CHECK CONSTRAINT [FK_LOAIMONAN_MONAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_BOPHAN_NHANVIEN] FOREIGN KEY([MAPB])
REFERENCES [dbo].[BOPHAN] ([MABP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_BOPHAN_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUDAT]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_PHIEUDAT] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HOADON] ([MAHD])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PHIEUDAT] CHECK CONSTRAINT [FK_HOADON_PHIEUDAT]
GO
ALTER TABLE [dbo].[PHIEUDAT]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_PHIEUDAT] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KHACHHANG] ([IDKH])
GO
ALTER TABLE [dbo].[PHIEUDAT] CHECK CONSTRAINT [FK_KHACHHANG_PHIEUDAT]
GO
ALTER TABLE [dbo].[PHIEUDAT]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_PHIEUDAT] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[PHIEUDAT] CHECK CONSTRAINT [FK_NHANVIEN_PHIEUDAT]
GO
ALTER TABLE [dbo].[PHIEUNHAPNGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_PHIEUNHAPNGUYENLIEU] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[PHIEUNHAPNGUYENLIEU] CHECK CONSTRAINT [FK_NHANVIEN_PHIEUNHAPNGUYENLIEU]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_TAIKHOAN] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_NHANVIEN_TAIKHOAN]
GO
ALTER TABLE [dbo].[THAYDOIGIAMON]  WITH CHECK ADD  CONSTRAINT [FK_MONAN_THAYDOIGIAMON] FOREIGN KEY([MAMA])
REFERENCES [dbo].[MONAN] ([MAMA])
GO
ALTER TABLE [dbo].[THAYDOIGIAMON] CHECK CONSTRAINT [FK_MONAN_THAYDOIGIAMON]
GO
ALTER TABLE [dbo].[THAYDOIGIAMON]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_THAYDOIGIAMON1] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[THAYDOIGIAMON] CHECK CONSTRAINT [FK_NHANVIEN_THAYDOIGIAMON1]
GO
USE [master]
GO
ALTER DATABASE [OrderManagement] SET  READ_WRITE 
GO
