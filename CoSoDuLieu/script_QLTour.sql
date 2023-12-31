USE [master]
GO
/****** Object:  Database [QuanLyTour]    Script Date: 12/19/2022 12:01:54 AM ******/
CREATE DATABASE [QuanLyTour]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyTour', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyTour.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyTour_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyTour_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyTour] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTour].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyTour] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyTour] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyTour] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyTour] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyTour] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyTour] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyTour] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyTour] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTour] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyTour] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyTour] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyTour] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyTour] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyTour] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyTour] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyTour] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyTour] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyTour] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyTour] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyTour] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyTour] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyTour] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyTour] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyTour] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyTour] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyTour] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyTour] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyTour] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyTour] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyTour] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyTour', N'ON'
GO
ALTER DATABASE [QuanLyTour] SET QUERY_STORE = OFF
GO
USE [QuanLyTour]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiAcc] [int] NOT NULL,
	[TenTK] [nvarchar](100) NULL,
	[TenDangNhap] [varchar](50) NULL,
	[SDT] [varchar](11) NULL,
	[Email] [varchar](50) NULL,
	[MatKhau] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietChuongTrinh]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietChuongTrinh](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaCTTour] [varchar](10) NOT NULL,
	[Ngay] [int] NULL,
	[GioDi] [time](0) NULL,
	[GioDen] [time](0) NULL,
	[DiemKhoiHanh] [nvarchar](100) NULL,
	[DiemDen] [nvarchar](100) NULL,
	[MoTa] [ntext] NULL,
	[HinhAnh] [varchar](30) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuongTrinhTour]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinhTour](
	[MaCTTour] [varchar](10) NOT NULL,
	[TenChuongTrinhTour] [nvarchar](200) NULL,
 CONSTRAINT [PK_CHUONGTRINHTOUR] PRIMARY KEY CLUSTERED 
(
	[MaCTTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatVe]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatVe](
	[MaKhach] [varchar](10) NOT NULL,
	[MaTour] [varchar](10) NOT NULL,
	[SoLuongVe] [int] NULL,
	[Tong] [int] NULL,
	[NgayDat] [smalldatetime] NOT NULL,
	[NgayDi] [date] NULL,
	[GiaVe] [float] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_DATVE] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC,
	[MaTour] ASC,
	[NgayDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatVeMB]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatVeMB](
	[MaVe] [varchar](10) NOT NULL,
	[MaKhach] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[Tong] [int] NULL,
 CONSTRAINT [PK_DATVEMB] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC,
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioiTinh]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioiTinh](
	[MaGioiTinh] [int] NOT NULL,
	[TenGioiTinh] [nvarchar](3) NULL,
 CONSTRAINT [pk_gioiTinh] PRIMARY KEY CLUSTERED 
(
	[MaGioiTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HuongDanVien]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HuongDanVien](
	[MaHDV] [varchar](10) NOT NULL,
	[MaTK] [int] NULL,
	[MaLoai] [int] NULL,
	[TenHDV] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[SDT] [varchar](11) NULL,
	[NgayVaoLam] [date] NULL,
	[CCCD] [varchar](12) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhach] [varchar](10) NOT NULL,
	[MaTK] [int] NULL,
	[TenKhach] [nvarchar](30) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiAccounts]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiAccounts](
	[MaLoaiAcc] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiAcc] [nvarchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHDV]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHDV](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTour]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTour](
	[MaloaiTour] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiTour] [nvarchar](30) NULL,
 CONSTRAINT [pk_LoaiTour] PRIMARY KEY CLUSTERED 
(
	[MaloaiTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiVe]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiVe](
	[MaLoaiVe] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiVe] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tour]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tour](
	[MaTour] [varchar](10) NOT NULL,
	[Huo_MaHDV] [varchar](10) NULL,
	[TenTour] [nvarchar](200) NULL,
	[DiaDiem] [nvarchar](200) NULL,
	[ChiPhi] [int] NULL,
	[AnhBia] [varchar](30) NULL,
	[MaLoaiTour] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[MaThanhVien] [int] IDENTITY(1,1) NOT NULL,
	[MaKhach] [varchar](10) NOT NULL,
	[TenThanhVien] [nvarchar](30) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[CCCD] [varchar](12) NULL,
	[MaTour] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeMayBay]    Script Date: 12/19/2022 12:01:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeMayBay](
	[MaVe] [varchar](10) NOT NULL,
	[MaLoaiVe] [int] NULL,
	[TenVe] [nvarchar](200) NULL,
	[NgayDi] [date] NULL,
	[NgayDen] [date] NULL,
	[GioDi] [time](0) NULL,
	[GioiDen] [time](0) NULL,
	[SanBayDi] [nvarchar](100) NULL,
	[SanBayDen] [nvarchar](100) NULL,
	[Gia] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (3, 1, N'Võ Nguyễn Duy Tân', N'vonguyenduytan', N'03845778323', N'tanVnd@gmail.com', N'123')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (4, 3, N'Nguyễn Văn A', N'nguyenvana', N'03845778324', N'a@gmail.com                                       ', N'456')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (5, 2, N'Nguyễn Đức Hữu', N'nguyenduchuu', N'0384577832', N'huu@gmail.com                                     ', N'789')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (6, 2, N'Lê Sin', N'lesin', N'0937584634', N'sin@gmail.com                                     ', N'789')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (7, 2, N'Báo Đời Đầu', N'baodoidau', N'0336363323', N'bao@gmail.com                                     ', N'quyettambao')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (8, 2, N'Muốn Qua Môn', N'account_06', N'03845778327', N'acc06@gmail.com                                   ', N'789')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (9, 3, N'Nguyễn Văn B', N'nguyenvanb', N'09845778321', N'b@gmail.com                                       ', N'456')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (10, 3, N'Nguyễn Văn C', N'nguyenvanc', N'09845778322', N'c@gmail.com                                       ', N'456')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (11, 3, N'Nguyễn Văn D', N'nguyenvand', N'09845778323', N'd@gmail.com                                       ', N'456')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (12, 3, N'Nguyễn Văn E', N'nguyenvane', N'09845778324', N'e@gmail.com                                       ', N'456')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (13, 3, N'Nguyễn Văn F', N'nguyenvanf', N'09845778325', N'f@gmail.com                                       ', N'456')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (15, 2, N'Tran thi be bay', N'tranthibebay', N'0395638596', N'bebay@gmail.com', N'789')
INSERT [dbo].[Accounts] ([MaTK], [MaLoaiAcc], [TenTK], [TenDangNhap], [SDT], [Email], [MatKhau]) VALUES (57, 2, N'Cristiano Ronaldo', N'ronaldo', N'0339837586', N'ronaldo@gmail.com', N'789')
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietChuongTrinh] ON 

INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (1, N'T01', 1, CAST(N'20:00:00' AS Time), CAST(N'06:55:00' AS Time), N'SÀI GÒN', N'TOKYO', N'Hướng dẫn Viên công ty đón quý khách tại Tân Sơn Nhất, làm thủ tục cho 
quý khách bay đi Nhật Bản trên chuyến bay SGN - HND. Quý khách dùng bữa 
sáng trên máy bay của hãng hàng không 5***** All Nippon Airways – Nhật Bản. 
Quý khách cần có: Xác nhận Vaccine COVID -19 03 mũi tiêm chủng theo quy định
(tiếng Anh hoặc song ngữ)', N'h0.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (2, N'T01', 2, CAST(N'06:55:00' AS Time), CAST(N'09:30:00' AS Time), N'TOKYO', N'OSAKA', N'Đến Tokyo, đoàn đáp sân bay Haneda - một trong những sân bay lớn và nhộn
nhịp nhất thế giới cũng như khu vực châu Á. HDV địa phương đón Quý đoàn và 
bắt đầu chuyến hành trình khám phá “Đất nước mặt trời mọc”.
- Đền Meiji-jingu ngôi đại đền Thần đạo này là nơi dành riêng cho 
Thiên hoàng Minh Trị (1852 – 1912) vị thiên hoàng đầu tiên của Nhật Bản hiện đại.', N'h2.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (3, N'T01', 2, CAST(N'09:30:00' AS Time), CAST(N'11:59:00' AS Time), N'TOKYO', N'OSAKA', N'- Hoàng Cung Tokyo Imperial Palace là nơi hoàng gia Nhật Bản sinh sống 
và làm việc trong suốt hai thế kỷ qua (tham quan và chụp ảnh bên ngoài). 
Nằm ngay phía trước là cây cầu Nijubashi (Nhị Trọng Kiều) hay còn gọi là 
cầu Mắt kính (Meganebashi) vì nhìn từ xa sẽ thấy hình dạng cầu khá giống 
cặp mắt kiếng đeo mắt.', N'h3.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (4, N'T01', 2, CAST(N'12:30:00' AS Time), CAST(N'23:59:00' AS Time), N'TOKYO', N'OSAKA', N'Trưa: Đoàn dùng bữa trưa tại nhà hàng địa phương và tiếp tục di chuyển 
đến ga Tokyo. Đoàn khởi hành đi Osaka với khoảng thời gian cực ngắn nhờ 
tàu siêu tốc Shinkansen - một trong những phương tiện tốt nhất và nhanh 
nhất để đi qua các thành phố lớn của Nhật Bản. Đến Osaka, xe đón đoàn về 
khách sạn, nhận phòng.
Tự do mua sắm thả ga tại Shinsaibashi – phố mua sắm nổi tiếng nhất
ở khu Shisaibashi Suji, thành phố Osaka. Đây là một khu phức hợp tập trung 
với đủ các mặt hàng kinh doanh, trung tâm mua sắm này trải dài vô tận hết
cả một con đường với hàng trăm cửa hàng kinh doanh sầm uất.
Tối: Đoàn dùng bữa tối tại nhà hàng địa phương. Nghỉ đêm tại Osaka.', N'h5.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (5, N'T01', 3, CAST(N'06:30:00' AS Time), CAST(N'12:30:00' AS Time), N'OSAKA', N'KYOTO – GIFU', N'Sáng: Đoàn dùng điểm tâm sáng tại khách sạn, làm thủ tục trả phòng. 
Sau đó khởi hành đi tham quan:
- Lâu đài Osaka tọa lạc trên một ngọn đồi được bao quanh bởi một công viên 
khổng lồ với vô vàn những cây anh đào, mơ và mận, thảm thực vật phong phú 
nơi đây hứa hẹn mang đến cảnh quan đẹp mắt trong cả mùa thu lẫn mùa xuân.', N'h6.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (6, N'T01', 3, CAST(N'13:00:00' AS Time), CAST(N'23:59:00' AS Time), N'OSAKA', N'KYOTO – GIFU', N'Trưa: Đoàn dùng bữa trưa và tiếp tục đi đến Kyoto tham quan:
- Rừng tre Arashiyama - một trong những thắng cảnh hàng đầu của Kyoto
- Chùa vàng Kinkaku-ji được UNESCO công nhận là Di sản Văn hóa thế giới, 
ngôi chùa được phủ mạ vàng 24k, du khách sẽ choáng ngợp trước sắc vàng lấp 
lành của ngôi chùa cổ kính này được mệnh danh là xa hoa bậc nhất tại Kyoto.
Chiều: Đoàn di chuyển đến Gifu và dùng bữa tối tại nhà hàng địa phương, 
tự do khám phá Gifu về đêm.
Nghỉ đêm tại Gifu.', N'h8.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (7, N'T02', 1, CAST(N'21:00:00' AS Time), CAST(N'05:40:00' AS Time), N'TPHCM', N' INCHEON', N'Tối: Quý khách có mặt tại sân bay Tân Sơn Nhất ga đi quốc tế. Trưởng Đoàn
hướng dẫn làm thủ tục check in chuyến bay VJ864 đi Hàn Quốc
(Nghỉ đêm trên máy bay).
Quý khách cần có xác nhận vaccine 2 mũi và giấy test PCR âm tính Việt Nam', N'h0.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (8, N'T02', 2, CAST(N'07:00:00' AS Time), CAST(N'11:59:00' AS Time), N'SEOUL', N'THÁP NAMSAN', N'Đoàn đáp sân bay Incheon. Trưởng đoàn hỗ trợ quý khách làm thủ tục test
PCR Covid để nhập cảnh Hàn Quốc. Xe và HDV đón đoàn đi ăn sáng sau đó bắt
đầu chuyến tham quan đất nước Hàn Quốc xinh đẹp.
- Tháp NamSan – tọa lạc trên núi Namsan mang đến cho du khách những góc nhìn 
toàn cảnh thủ đô, cùng gắn khóa tình yêu và chụp ảnh cực đẹp. 
(Phí thang máy lên tháp tự túc)', N'h9.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (9, N'T02', 2, CAST(N'13:00:00' AS Time), CAST(N'23:59:00' AS Time), N'SEOUL', N'THÁP NAMSAN', N'Trưa: Đoàn dùng cơm tại nhà hàng địa phương, sau đó tham quan:
- Quảng trường Gwanghwamun – Seoul quy hoạch nơi này thành điểm nhấn chính
cho thành phố, giống như đại lộ Champ-Élysées ở Paris
19h00: Đoàn dùng cơm tối và về khách sạn nghỉ ngơi, Tự do khám phá Seoul
về đêm.', N'h10.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (10, N'T02', 3, CAST(N'07:00:00' AS Time), CAST(N'11:59:00' AS Time), N'Gyeonggi-do', N'CÔNG VIÊN EVERLAND', N'Sáng: Quý khách dùng điểm tâm sáng tại khách sạn. 
Bắt đầu chương trình tham quan:
- Cung điện Gyeongbokgung (Cảnh Phúc Cung) – cung điện nằm ở phía bắc 
của thủ đô Seoul, được xây dựng vào năm 1395 dưới triều vua Taejo thuộc 
triều đại Joseon, kiến trúc cực đẹp.', N'h11.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (11, N'T02', 3, CAST(N'13:00:00' AS Time), CAST(N'23:59:00' AS Time), N'SEOUL', N'CÔNG VIÊN EVERLAND ', N'Trưa: Đoàn dùng cơm tại nhà hàng địa phương, sau đó tham quan:
- Bảo tàng Dân gian Quốc gia Hàn Quốc là nơi trưng bày các vật dụng trong
đời sống hàng ngày và văn hóa dân gian của người Hàn Quốc từ thời cổ đại 
đến nay.
- Blue House (Phủ Tổng Thống Hàn Quốc hay còn gọi là Nhà Xanh) – tọa lạc 
tại trung tâm thủ đô Seoul. Đây là nơi sinh sống và làm việc của 
Tổng Thống đương nhiệm Hàn Quốc (chụp hình bên ngoài)
Tối: Đoàn dùng bữa tối tại nhà hàng địa phương, tự do khám phá Seoul về đêm.', N'h12.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (12, N'T02', 4, CAST(N'07:00:00' AS Time), CAST(N'11:59:00' AS Time), N'SEOUL', N' NAMI', N'Sáng: Quý khách dùng bữa sáng tại khách sạn. Đoàn tham quan mua sắm:
- Cửa hàng mỹ phẩm nội địa Hàn Quốc.
- Cửa hàng nhân sâm Chính Phủ, cửa hàng miễn thuế Duty Free.
- Trải nghiệm làm Kimchi – mặc đồ Hanbok.', N'h13.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (13, N'T02', 4, CAST(N'13:00:00' AS Time), CAST(N'16:59:00' AS Time), N'SEOUL', N' NAMI', N'Trưa: Đoàn dùng bữa trưa tại nhà hàng địa phương, tham quan:
- Đảo Nami – Nổi tiếng với những tán lá phông đỏ rực một góc trời cùng 
hàng ngân hạnh vàng rực, thẳng tắp đã từng xuất hiện trong bộ phim 
“Bản tình ca mùa Đông”.', N'h14.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (14, N'T02', 4, CAST(N'17:00:00' AS Time), CAST(N'23:59:00' AS Time), N'SEOUL', N' NAMI', N'Tối: Dùng buổi tối tại nhà hàng địa phương.
Sau đó ghé Chợ GwangJang hoặc Chợ Myeongdong: tham quan, mua sắm 
đến giờ hẹn, xe đón quý khách về lại khách sạn nghỉ ngơi.
Ngày cuối trở về Thành phố Hồ Chí Minh.', N'h15.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (29, N'T04', 1, CAST(N'00:15:00' AS Time), CAST(N'08:00:00' AS Time), N'TP.HỒ CHÍ MINH', N'SINGAPORE', N'Quý khách có mặt tại sân bay quốc tế Tân Sơn Nhất, 
Trưởng đoàn hướng dẫn Quý khách làm thủ tục đáp chuyến bay VJ822 bay chuyến
00:15 đi SINGAPORE . Đoàn nghỉ đêm trên máy bay.', N'hh11.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (30, N'T04', 2, CAST(N'08:15:00' AS Time), CAST(N'11:00:00' AS Time), N'MARINA BAY SANDS SINGAPORE ', N' COUNTDOWN 2023 ', N'SSau khi ăn sáng tại khách sạn.
- Quý khách tham quan khu vườn sinh thái đặc biệt mang tên Bay South Garden
với hệ thống “siêu cây” năng lượng mặt trời. Khu vườn nằm trong dự án Gardens 
by the Bay, dự án công viên sinh thái lớn nhất Singapore nhằm nâng cao chất lượng 
cuộc sống, giữ được màu xanh cho đô thị sầm uất. Toàn bộ dự án có tổng diện tích
101 ha, được chia làm 3 khu riêng biệt là: Bay South, Bay East và Bay Central.', N'hh12.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (31, N'T04', 3, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'SINGAPORE   ', N'TP.HỒ CHÍ MINH ', N'Ăn sáng tại khách sạn. Đoàn tự do nghỉ ngơi tại khách sạn sau đó làm 
thủ tục trả phòng và di chuyển ra sân bay quốc tế Changi làm thủ tục đón chuyến bay về nước.
Về đến sân bay Tân Sơn Nhất, kết thúc chuyến tham quan. Trưởng đoàn công ty chia tay và hẹn
gặp lại Quý khách trong những chương trình sau. ', N'hh13.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (32, N'T03', 1, CAST(N'00:15:00' AS Time), CAST(N'08:00:00' AS Time), N'TP.HỒ CHÍ MINH', N'NARITA', N'Quý khách có mặt tại sân bay quốc tế Tân Sơn Nhất, 
Trưởng đoàn hướng dẫn Quý khách làm thủ tục đáp chuyến bay VJ822 bay 
chuyến 00:15 đi Narita. Đoàn nghỉ đêm trên máy bay.', N'hh1.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (33, N'T03', 2, CAST(N'08:15:00' AS Time), CAST(N'11:00:00' AS Time), N'NARITA ', N'YAMANASHI', N'Sáng: Xe và hướng dẫn địa phương chào mừng đoàn đến với Nhật Bản, 
Hướng dẫn đưa Quý khách khởi hành đi Yamanashi. Xe sẽ đưa đoàn đi 
tham quan: Ngôi làng cổ Oshino Hakkai – Là ngôi làng cổ nằm yên bình
dưới chân núi Phú Sĩ. Cho đến ngày nay, những ngôi nhà ở làng Oshino Hakkai
vẫn mang nét kiến trúc truyền thống Nhật Bản xa xưa.', N'hh2.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (34, N'T03', 2, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'NARITA ', N'YAMANASHI', N'Trưa: Đoàn dùng cơm trưa. Xe tiếp tục đưa đoàn tham quan:
- Tham quan và chụp ảnh trải nghiệm khu trượt tuyết FUJITEN (bao gồm trải 
nghiệm trượt máng)
Núi Phú Sĩ – Là ngọn núi cao nhất Nhật Bản so với mực nước biển là 3776 mét.
Đây cũng là danh lam thắng cảnh, di tích lịch sử, và đã được công nhận là 
di sản văn hóa thế giới.
Quý khách sẽ lên trạm dừng chân thứ 5 ở độ cao 2.300m để ngắm núi Phú Sĩ
rõ hơn (nếu thời tiết cho phép). ', N'hh3.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (35, N'T03', 2, CAST(N'17:15:00' AS Time), CAST(N'23:00:00' AS Time), N'NARITA ', N'YAMANASHI', N'Tối: Xe đưa Quý khách về khách sạn Shinko Hotel ( hoặc khách sạn có tiêu
chuẩn tương đương) nhận phòng nghỉ ngơi.
Đoàn dùng cơm tối tại khách sạn, sau đó trải nghiệm tắm Onsen - nét văn hóa
độc đáo ở xứ sở hoa anh đào.', N'hh4.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (36, N'T03', 3, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'YAMANASHI  ', N'TOKYO ', N'Sáng: Quý khách dùng điểm tâm sáng tại khách sạn. Đoàn làm thủ tục trả phòng
và khởi hành đi Saitama.
- Oedo Kawagoe: khu Phố Kurazukuri với các tòa nhà phong cách nhà chứa tường đất
sét từ thời kỳ Edo, Thành cổ Kawagoe và những khu đất đền Kita, nơi bạn sẽ tìm thấy
ngôi đền Toshogu và một vài di tích của Thành cổ Edo nguyên thủy.  ', N'hh5.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (37, N'T03', 3, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'YAMANASHI  ', N'TOKYO ', N'Trưa: Đoàn khởi hành về Tokyo dùng cơm trưa. Xe tiếp tục đưa đoàn đi tham quan:
Đoàn mua sắm tại khu phố thương mại nổi tiếng ở Tokyo: thành phố điện tử Akihabara
- hàng trăm món đồ điện tử được trưng bày nơi đây tha hồ cho du khách nhìn ngắm. 
Giá đồ điện tử ở đây rẻ hơn từ 20-30%, có cả hệ thống bán ưu tiên miễn thuế cho 
người nước ngoài.  ', N'hh6.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (38, N'T03', 3, CAST(N'17:15:00' AS Time), CAST(N'23:59:00' AS Time), N'YAMANASHI  ', N'TOKYO ', N'Tối: Xe đưa Quý khách đi dùng 
cơm tối. Sau đó đoàn về khách sạn Shinjuku Washington (hoặc KS có tiêu chuẩn tương
đương) nhận phòng và nghỉ ngơi. Nghỉ đêm tại Tokyo. ', N'hh7.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (39, N'T03', 4, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'TOKYO', N'NARITA  ', N'Sáng: Quý khách dùng điểm tâm sáng tại khách sạn. Đoàn làm thủ tục trả phòng và
khởi hành đi tham quan:
- Hòn đảo nhân tạo Odaiba nằm bên vịnh Tokyo, kết nối với trung tâm qua cây cầu Rainbow.
“Bản sao tượng Nữ thần Tự do” – Trước đây, người Pháp cho mang bức tượng gốc hiện
đặt tại thủ đô Paris sang triển lãm, rồi sau đó mang trở lại về nước. Để thu hút du
khách tham quan, phiên bản tượng Nữ thần Tự do được dựng lên sau khi bức tượng gốc
được trao trả. ', N'hh8.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (40, N'T03', 4, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'TOKYO', N'NARITA  ', N'Trưa: Đoàn dùng cơm trưa. Xe đưa Quý khách khởi hành về Narita.
- Tiếp tục tham quan và mua sắm tại Shisui Premium Outlets - là khu mua sắm hàng 
đầu của Nhật, mở cửa vào năm 2013. Có 120 cửa hàng của các thương hiệu lớn và
nhiều cửa hàng khác. ', N'hh9.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (41, N'T03', 4, CAST(N'17:15:00' AS Time), CAST(N'23:00:00' AS Time), N'TOKYO', N'NARITA', N'Tối: Đoàn dùng cơm tối. Sau đó đoàn về Marroad International Narita Hotel 
(hoặc KS có tiêu chuẩn tương đương) nhận phòng nghỉ ngơi. Nghỉ đêm tại Narita.', N'hh10.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (42, N'T03', 5, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'TOKYO', N'NARITA  ', N'Sáng: Quý khách dùng bữa sáng nhẹ,
sau đó xe đưa đoàn ra sân bay quốc tế Narita và làm thủ tục đáp chuyến bay VJ823
về lại Tp. Hồ Chí Minh bay lúc 08:55. 
Về đến sân bay Quốc tế Tân Sơn Nhất. Kết thúc chương trình.
Chia tay Quý khách. Hẹn gặp lại quý khách!', N'hh6.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (50, N'T05', 1, CAST(N'00:15:00' AS Time), CAST(N'08:00:00' AS Time), N'TP.HỒ CHÍ MINH', N'SEOUL ', N'Quý khách có mặt tại sân bay quốc tế Tân Sơn Nhất, 
Trưởng đoàn hướng dẫn Quý khách làm thủ tục đáp chuyến bay VJ822 bay chuyến 00:15 đi SEOUL.
Đoàn nghỉ đêm trên máy bay.', N'hh14.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (51, N'T05', 2, CAST(N'08:15:00' AS Time), CAST(N'11:00:00' AS Time), N'ĐẢO NAMI ', N'TRƯỢT TUYẾT ELYSIAN', N'SSáng: Đoàn trả phòng dùng bữa sáng, sau đó tham quan:
- Đảo Nami - là một trong những điểm đến hấp dẫn không thể bỏ qua dành cho những người
muốn du lịch Hàn Quốc. Bạn có thể lựa chọn bất cứ thời điểm nào để đến đây, vì cả bốn
mùa đảo Nami đều mang những vẻ đẹp riêng vô cùng hấp dẫn, khiến bạn phải lòng ngay từ 
lần đầu đặt chân đến...', N'hh15.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (52, N'T05', 2, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'ĐẢO NAMI ', N'TRƯỢT TUYẾT ELYSIAN', N'Trưa: Đoàn dùng bữa trưa và tối tại nhà hàng địa phương.
- Tham quan khu trượt tuyết Elysan Gangchon: hệ thống khu giải trí phức hợp nằm trong
khung cảnh hoành tráng của vùng núi Tỉnh Gangwondo. Quý khách có thể tận hưởng cảm 
giác thú vị trước thiên nhiên bao phủ tuyết trắng, lưu lại các bức ảnh kỷ niệm mùa
tuyết rơi và trải nghiệm môn thể thao trượt tuyết trên đường trượt (Không bao gồm phí
thuê đồ, dụng cụ trượt )', N'h16.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (53, N'T05', 2, CAST(N'17:15:00' AS Time), CAST(N'23:00:00' AS Time), N'ĐẢO NAMI ', N'TRƯỢT TUYẾT ELYSIAN', N'Tối: Về khách sạn nhận phòng, nghỉ ngơi hoặc tự do vui chơi, khám phá Seoul về đêm.', N'hh4.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (54, N'T05', 3, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'YAMANAELYSIANSHI  ', N'SEOUL CITY ', N'Sáng: Quý khách dùng bữa sáng tại khách sạn. 
Sau đó khởi hành đi tham quan mua sắm tại quốc bảo thứ 2 của Hàn Quốc: 
- Cửa hàng mỹ phẩm nội địa,
- Cửa hàng sâm chính phủ, cửa hàng miễn thuế Duty Free', N'h17.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (55, N'T05', 3, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'YAMANAELYSIANSHI  ', N'SEOUL CITY ', N'Trưa: Dùng bữa trưa tại nhà hàng địa phương. Chiều tham quan:
- Cung điện Kyeongbok (Cảnh Phúc Cung) – cung điện hoàng gia nằm ở phía bắc của 
thủ đô Seoul, được xây dựng vào năm 1395 dưới triều vua Taejo thuộc triều đại Jos eon', N'h18.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (56, N'T05', 3, CAST(N'17:15:00' AS Time), CAST(N'23:59:00' AS Time), N'YAMANAELYSIANSHI  ', N'SEOUL CITY ', N'Tối: Dùng buổi tối tại nhà hàng sau đó về khách sạn, nghỉ ngơi hoặc tự do dạo chơi 
ở các khu chợ đêm Seoul. ', N'h19.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (57, N'T05', 4, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'SEOUL ', N'LOTTE WORLD', N'Sáng: Quý khách dùng bữa sáng tại khách sạn. Đoàn di chuyển đi tham quan mua sắm:
- Cửa hàng tinh dầu thông đỏ, cửa hàng nông sản.
Trưa: Đoàn dùng bữa trưa tại nhà hàng địa phương, tham quan:
- Lotte World - là một trong những điểm đến không thể bỏ qua ở trung tâm thành phố Seoul. 
Đây là công viên giải trí hàng đầu gồm khu giải trí trong nhà và khu ngoài trời thu hút
du khách trong và ngoài nước tìm đến để trải nghiệm những trò chơi cảm giác mạnh, 
mạo hiểm để có những khoảnh khắc đáng nhớ tại đây (Áp dụng từ 10/12/2022 đến hết tháng 02/2023).', N'h20.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (58, N'T05', 4, CAST(N'17:15:00' AS Time), CAST(N'23:00:00' AS Time), N'SEOUL ', N'LOTTE WORLD  ', N'Tối: Đoàn dùng bữa tối tại nhà hàng địa phương. Tự do khám phá Seoul về đêm với các
khu chợ đêm của địa phương.', N'hh10.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (59, N'T05', 5, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'SEOUL ', N'TP. HỒ CHÍ MINH  ', N'Sáng: Quý khách làm thủ tục trả phòng, dùng bữa sáng. Khởi hành đi tham quan:
- Mua sắm và tham quan tại cửa hàng miễn thuế Duty Free.
- Bảo tàng cổ Alive - thực sự là một thử thách thú vị. Đây là một mê cung vui nhộn
xen lẫn một chút kinh dị, từng xuất hiện trong chương trình truyền hình ăn khách 
“Running Man”. Đến đây vui chơi chắc chắn bạn sẽ có những trải nghiệm độc đáo và hấp dẫn.', N'h21.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (60, N'T06', 1, CAST(N'00:15:00' AS Time), CAST(N'08:00:00' AS Time), N'TP.HỒ CHÍ MINH', N'PHUKET ', N'Quý khách có mặt tại ga đi quốc tế sân bay Tân Sơn Nhất, đáp chuyến bay VJ809 
SGN-HKT 09:00 - 10:55 đi Phuket. Đoàn tới sân bay Phuket, chào đón Quý khách đến
với vương quốc của nụ cười Thái Lan.
Trưa: Đoàn dùng bữa trưa.
Đoàn tham quan:
- Phrom Thep Cape – nằm tại phía nam của đảo nơi ngắm hoàng hôn tuyệt vời nhất 
Phuket nơi mà hàng ngàn du khách đều muốn đặt chân đến như để check in và nhìn
thấy được thời điểm mặt trời dần tắt nơi phía chân trời.', N'h22.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (61, N'T06', 2, CAST(N'08:15:00' AS Time), CAST(N'11:00:00' AS Time), N'PHUKET  ', N'ĐẢO PHI PHI ', N'Sáng: Đoàn dùng bữa sáng tại khách sạn, hướng dẫn viên sẽ đưa đoàn khởi hành
khám phá thiên đường đảo Phuket:
- Đảo Phi Phi - hòn đảo nổi tiếng trong giới du lịch thế giới: Quý khách tự do 
tắm biển và nghỉ ngơi tận hưởng vẻ đẹp.', N'h23.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (62, N'T06', 2, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'NARITA ', N'YAMANASHI', N'Trưa:Trưa: Đoàn dùng bữa trưa trên đảo.
Chiều Quý khách tiếp tục tham quan chụp ảnh trước khi rời Phi Phi quay trở về đất liền.
Tối: Đoàn ăn tối tại nhà hàng. Nghỉ đêm tại khách sạn. Tối Quý khách có thể tự túc 
dạo phố hoặc đăng ký option (Chi phí tự túc)
- Phố cổ Phuket với những tòa nhà kiến trúc Bồ Đào Nha cổ được lưu giữ. 
Quý khách có thể tự do dạo chơi và chụp ảnh tại đây. 
Phố cổ có bày bán những mặt hàng lưu niệm và trang phục truyền thống của người Thái.', N'h24.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (63, N'T06', 3, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'PHUKET   ', N'SHOPPING ', N'Sáng: Đoàn dùng bữa sáng tại khách sạn, 
xe đón đoàn khởi hành đi Shopping tại cửa hàng địa phương.
- Tham quan mua sắm tại cửa hàng đá quý Gems Galerry nổi tiếng tại Phuket. Sau đó đoàn sẽ 
đi tham quan & xem xiếc rắn tại trung tâm nghiên cứu rắn độc.', N'h25.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (64, N'T06', 3, CAST(N'17:15:00' AS Time), CAST(N'23:59:00' AS Time), N'PHUKET   ', N'SHOPPING ', N'Quý khách tự túc ăn trưa.
Tối: Xe đưa đoàn đi ăn BBQ theo phong cách thailand, sau đó về khách sạn nghỉ ngơi tự do
khám phá Phuket về đêm', N'h26.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (65, N'T06', 4, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'PHUKET ', N'TP.HCM   ', N'Sáng: Ăn sáng tại khách sạn, Đoàn 
làm thủ tục trả phòng. Quý khách tham quan
- Chùa Kathu nổi tiếng linh thiêng tại thành phố biển Phuket.', N'h27.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (66, N'T07', 1, CAST(N'00:15:00' AS Time), CAST(N'08:00:00' AS Time), N'TP.HỒ CHÍ MINH', N'NICE  ', N'Hướng dẫn viên công ty đón Quý Khách tại ga quốc tế sân bay Quốc tế Tân Sơn Nhất
đáp chuyến bay khởi hành đi NICE.
Nghỉ đêm trên máy bay.', N'h29.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (67, N'T07', 2, CAST(N'08:15:00' AS Time), CAST(N'11:00:00' AS Time), N'NICE   ', N'THAM QUAN NICE ', N'Quý khách hạ cánh xuống sân bay NICE, làm thủ tục nhập cảnh, khởi hành dùng cơm trưa.
Quý khách tham quan:
- Nice Oldtown - Phố cổ Nice, Dù là đêm hay ngày, nơi đây vẫn nhộn nhịp với nhịp sống rộn rã. 
- Quảng trường Massena: Đây là một trong những quảng trường lớn nhất của vùng 
Cote dAzur, Nice. Nơi này thường được tổ chức các lễ hội lớn trong năm như phiên 
chợ Giáng sinh và ngày Quốc khánh Pháp 14/7 để người dân địa phương và du khách 
cùng tham dự. Điểm nhấn của quảng trường là đài phun nước mặt trời "La Fontaine du Soleil"
ở khu trung tâm. Ở giữa là tượng thần Apollo với tấm áo choàng uy nghi trong tay.
- Promenade Des Anglais - một trong những bờ biển nổi tiếng và mang tính biểu tượng
của Nice, lối đi dạo sống động chạy dọc theo bờ biển xanh lam rợp bóng cây, với nhiều
khu vườn tuyệt đẹp và các công trình kiến trúc cổ cho du khách khám phá.', N'h30.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (68, N'T07', 3, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'NICE', N'MONACO', N'Quý khách dùng điểm tâm tại khách sạn,
khởi hành đến với Công Quốc Monaco – quốc gia nằm lọt trong lòng nước Pháp và bên cạnh 
bờ biển Địa Trung Hải, Monaco là quốc gia độc lập với diện tích nhỏ thứ hai trên 
thế giới và là một trong những nước giàu và có lối sống xa xỉ nhất thế giới.
Quý khách tham quan:
- Monaco Palace Square – Quảng trường cung điện Monaco - một trong những công trình
được đánh giá cao nhất về sự tráng lệ và lỗng lẫy. 
- Notre Dame de Monaco – Nhà thờ Đức Bà Monaco.', N'h31.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (69, N'T07', 4, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'MONACO ', N'TP.HCM   ', N'Đoàn về tới Thành phố Hồ Chí Minh.
Công ty chào và hẹn gặp lại quý khách vào hành trình tới !!!.', N'h32.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (70, N'T08', 1, CAST(N'00:15:00' AS Time), CAST(N'08:00:00' AS Time), N'ĐÓN ĐOÀN ', N'QUẢNG BÌNH - HUẾ  ', N'Sáng: 04:30 Nhân Viên Công ty sẽ đón quý khách tại sân bay Tân Sơn Nhất, làm thủ tục 
khởi hành đi Huế trên chuyến bay VJ302 lúc 06:40.
08:00 Đến Huế, Xe và HDV đón đoàn đến nhà hàng dùng điểm tâm sáng (chi phí tự túc).
Sau đó xa sẽ đưa Đoàn khởi hành đi: 
-  Phong Nha - Kẻ Bàng: Di Sản Thiên Nhiên Thế Giới. Trên đường đi, đoàn viếng thăm 
Thánh Địa La Vang là một trong những địa điểm hành hương quan trọng không chỉ riêng 
đồng bào Công giáo, mà còn của cả người không Công giáo và khách du lịch quốc tế. 
Tiếp đến đoàn dừng chân  ngắm nhìn Vĩ tuyến 17 - Cầu Hiền Lương - Sông Bến Hải 
(Chi Phí tự túc).', N'h33.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (71, N'T08', 1, CAST(N'08:15:00' AS Time), CAST(N'11:00:00' AS Time), N'ĐÓN ĐOÀN ', N'QUẢNG BÌNH - HUẾ  ', N'08:00 Đến Huế , Xe và HDV đón đoàn đến nhà hàng dùng điểm tâm sáng (chi phí tự túc).
Trưa: Dùng cơm trưa tại nhà hàng ở Phong Nha, nghỉ ngơi tại nhà hàng. 
 Sau bữa trưa, đoàn ngồi thuyền ngược dòng sông Son, chinh phục Động Phong Nha kỳ vĩ, 
 một thắng cảnh thiên nhiên mà tạo hoá đã ban tặng cho người dân Quảng Bình. 
 Nơi đây, sự giao hoà của rừng nguyên sinh và sông Son, cùng với động khô và động nước 
 tạo nên một bức tranh thuỷ mặc làm say lòng người. Đây là một trong những vùng đá vôi
 nhiệt đới cổ đại nhất, rộng lớn nhất thế giới với diện tích trên 200.000 ha. Có hệ 
 thống hơn 300 hang động lớn nhỏ, tiềm ẩn nhiều điều kỳ lạ và hấp dẫn. Hang Bi Ký, 
 Cô Tiên và Cung Đình dưới sâu lòng núi, nơi có con sông ngầm từ đất nước bạn Lào 
 chảy sang.
15h30: Đoàn khởi hành về lại Cố Đô Huế theo đường Trường Sơn - Hồ Chí Minh Huyền Thoại.
Tối: Đoàn dùng cơm tối tại nhà hàng Đông Hà, Quảng Trị.
Đến Huế, về khách sạn nghỉ ngơi, tự do thưởng thức đặc sản và tham quan thành phố Huế về đêm.', N'h34.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (72, N'T08', 2, CAST(N'08:15:00' AS Time), CAST(N'11:00:00' AS Time), N'CHÙA THIÊN MỤ - ĐẠI NỘI ', N'ĐÀ NẴNG ', N'Sáng: Dùng điểm tâm buffet  tại khách sạn. 09:00 Đoàn đi tham quan:
- Chùa Thiên Mụ, một ngôi  chùa cổ nằm trên đồi Hà Khê, tả ngạn sông Hương. Chùa Thiên Mụ 
- là một trong những thắng cảnh đẹp được nhắc đến nhiều nhất tại Huế. 
Không chỉ đi vào những bài thơ lãng mạn của xứ Huế mà còn trong cả câu ca, 
Thiên Mụ cũng được coi là một ngôi chùa linh thiêng và những cảnh không 
thể bỏ qua của bất cứ du khách nào khi đặt chân đến thủ đô cổ xưa này.', N'h35.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (73, N'T08', 2, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'CHÙA THIÊN MỤ - ĐẠI NỘI ', N'ĐÀ NẴNG ', N'Trưa: Xe đưa đoàn đến nhà hàng dùng cơm trưa. Sau đó đoàn khởi hành về khách sạn 4*
nhận phòng nghỉ  ngơi.
Chiều: Đoàn tham quan Đại Nội - Kinh Thành Hoàng Cung của 13 vị Vua triều Nguyễn với 
Ngọ Môn, điện Thái Hoà, Tử Cấm Thành, Thế Miếu, Hiển Lâm Các, Cửu Đỉnh
Đây cũng là một trong những di sản của Việt Nam được UNESCO công nhận là Di sản văn 
hóa thế giới.', N'h36.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (74, N'T08', 2, CAST(N'17:15:00' AS Time), CAST(N'23:00:00' AS Time), N'CHÙA THIÊN MỤ - ĐẠI NỘI ', N'ĐÀ NẴNG ', N'Tối: Ăn tối tại Nhà Hàng. Đoàn khởi hành về Đà Nẵng. 
Quý khách tự do khám phá thành phố Đà Nẵng về đêm. Quý khách ngồi thuyền sông Hàn 
(Chi phí tự túc) ngắm thành phố Đà Nẵng lung linh về đêm với “Tứ đại Mỹ Cầu” 
độc đáo và nổi tiếng hoặc tự do dạo chơi khu bờ Đông Sông Hàn với các điểm nhấn 
như tượng Cá chép hóa Rồng, Cầu tình yêu… xem cầu Rồng phun Lửa và Nước
(Thứ bảy và Chủ nhật hàng tuần).', N'h37.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (75, N'T08', 3, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'ĐÀ NẴNG', N'HỘI AN ', N'Sáng: Dùng điểm tâm buffet tại khách sạn, làm thủ tục trả phòng. Khởi hành đi Đà Nẵng.

09h00: Đến Đà Nẵng, đoàn khởi hành đi tham quan Bán đảo Sơn Trà một món quà lớn mà 
thiên nhiên ưu ái ban tặng cho thành phố Đà Nẵng. 
Mang trong mình một vẻ đẹp nguyên sơ, hữu tình, bãi biển nước trong vắt, những tán
cây xanh rợp bóng, nơi đây có không khí trong lành kết hợp cùng nguồn tài nguyên
phong phú và là nơi thu hút rất nhiều khách du lịch trên cả nước.', N'h33.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (76, N'T08', 3, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'ĐÀ NẴNG', N'HỘI AN ', N'Trưa: Xe đưa đoàn đến nhà hàng dùng cơm trưa với món đặc sản “Bánh Tráng Cuốn Thịt Heo”.
Sau đó đoàn khởi hành  về  khách sạn 4* nhận phòng nghỉ ngơi.
Chiều: Đoàn tự do tắm biển Mỹ Khê.
16h00: Đoàn khởi hành đi tham quan:
- Tham quan Ngũ Hành Sơn, Làng Nghề Điêu Khắc Đá Non Nước với các pho tượng bằng 
Đá được điêu khắc dưới bàn tay tài hoa của nghệ nhân nơi đây.', N'h39.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (77, N'T08', 4, CAST(N'07:15:00' AS Time), CAST(N'11:00:00' AS Time), N'HỘI AN ', N'TP.HCM   ', N'Đoàn về tới Thành phố Hồ Chí Minh. Công ty chào và hẹn gặp lại quý khách
vào hành trình tới !!!.', N'h40.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (78, N'T09', 1, CAST(N'07:20:00' AS Time), CAST(N'21:30:00' AS Time), N'CAIRO', N'CAIRO', N'Bay t? Tp.HCM ho?c Hà N?i đ?n Cairo v?i hàng không 5-sao Emirates quá c?nh t?i Dubai. 
T?n hư?ng gh? ng?i r?ng r?i, ?m th?c qu?c t? và gi?i trí trên màn h?nh riêng. Ngh? đêm trên máy bay.', N'T09_a7.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (79, N'T09', 1, CAST(N'06:00:00' AS Time), CAST(N'12:00:00' AS Time), N'TP. HỒ CHÍ MINH', N'CAIRO', N'Bay từ Tp.HCM hoặc Hà Nội đến Cairo với hàng không 5-sao Emirates quá cảnh tại Dubai.
Tận hưởng ghế ngồi rộng rãi, ẩm thực quốc tế và giải trí trên màn hình riêng. Nghỉ đêm trên máy bay.
Đến sân bay Cairo, đại diện của chúng tôi đón và đưa bạn về khách sạn. Hướng dẫn viên sẽ tiếp đón bạn tại khách sạn và cung cấp các thông tin cho hành trình khám phá Ai Cập sắp tới của bạn. Nghỉ đêm tại khách sạn ở Cairo.', N'T09_a1.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (80, N'T09', 2, CAST(N'06:00:00' AS Time), CAST(N'23:00:00' AS Time), N'CAIRO', N' GIZA', N'Sau bữa sáng, bắt đầu chuyến tham quan với các Đại Kim tự tháp và tượng Nhân sư tại Cao nguyên Giza, trước khi đến Sakkara để tham quan Kim tự tháp Step - kim tự tháp hoàn thành đầu tiên ở Ai Cập - cũng như các lăng mộ Pharonic cổ đại. Nghỉ đêm trên xe trong khi di chuyển đến Aswan.', N'T09_a2.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (81, N'T09', 2, CAST(N'06:00:00' AS Time), CAST(N'23:00:00' AS Time), N'CAIRO', N' ASWAN', N'Đến Aswan, đại diện của chúng tôi đón và đưa bạn đến Du Thuyền sông Nile 5*. Bắt đầu một ngày với chuyến tham quan Đền Philae lãng mạn - nằm trên đỉnh một hòn đảo đẹp như tranh vẽ. Chỉ có thể đến nơi tuyệt đẹp này bằng thuyền nhỏ, mang đến cảm giác hết sức đặc biệt và tráng lệ. ', N'T09_a3.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (82, N'T09', 3, CAST(N'06:00:00' AS Time), CAST(N'23:00:00' AS Time), N'NILE CRUISE ', N'NILE CRUISE ', N'Xuôi theo dòng sông Nile, bạn có thể thư giãn trên boong tàu, thưởng ngoạn cuộc sống nông thôn trên bờ biển và cảnh quan ngoạn mục của dòng sông hùng vĩ này. Đến thăm đền Kom Ombo với hai lối vào đối xứng hoàn hảo nhìn ra bờ sông. ', N'T09_a4.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (83, N'T10', 1, CAST(N'00:15:00' AS Time), CAST(N'08:00:00' AS Time), N'TRUNG TÂM TP. HỒ CHÍ MINH', N'Mộc Châu', N'06h00: Xe ô tô và hướng dẫn viên đón quý khách tại Nhà hát lớn lúc 6h00 và Trung tâm 
hội nghị quốc gia lúc 6h20. khởi hành đi Bản Lác ,Mai Châu ,Hoà Bình (cách Hà Nội 130 km). 
Trên đường đi, Quý khách sẽ được chiêm ngưỡng cảnh núi non trùng điệp vùng Tây Bắc tổ quốc. 
Quý khách tự do dùng bữa sáng tại nhà hàng. (không bao gồm giá tour)

10h00: Xe dừng trên đèo Thung Khe để quý khách ngắm cảnh, chụp ảnh toàn cảnh thung lũng Mai Châu,
checkin đèo đá trắng, thưởng thức đặc sản.', N'h48.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (84, N'T10', 2, CAST(N'08:15:00' AS Time), CAST(N'11:00:00' AS Time), N'HAPPYLAND', N'THÁC DẢI YẾM - HÀ NỘI', N'07h00: Sau bữa sáng xe và hướng dẫn viên đưa Qúy khách đi thăm quan

- Happy land: Với rất nhiều loài hoa, tạo thành cảnh quan bạt ngàn ấn tượng bất kỳ du khách 
nào khi đặt chân đến nơi đây, trồng thành từng khu trông giống như một tiểu Đà Lạt mọc giữa
lòng thảo nguyên xanh Mộc Châu.', N'h49.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (85, N'T10', 2, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'HAPPYLAND', N'THÁC DẢI YẾM - HÀ NỘI', N'Thác Dải Yếm: Thác ngày đêm đổ xuống trắng xóa, ầm ào, không chỉ mang đến cho du khách 
sự thích thú trước một khung cảnh vừa huyền bí vừa kỳ vĩ của đất trời mà còn cảm giác 
sảng khoái khi được hòa mình vào những ngọn gió mang hơi nước mát lành vừa hùng vĩ vừa thơ mộng.', N'h50.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (86, N'T10', 2, CAST(N'17:15:00' AS Time), CAST(N'23:00:00' AS Time), N'HAPPYLAND', N'THÁC DẢI YẾM - HÀ NỘI', N'12h00: Quý khách dùng bữa trưa tại nhà hàng. Sau bữa trưa quý khách lên xe khởi hành về Hà Nội.
Trên đường về, Quý khách mua sắm những đặc sản Mộc Châu như măng chua, bánh sữa, rau củ quả… về 
làm quà cho gia đình ,bạn bè và người thân.

18h30: Về đến Hà Nội, chia tay đoàn kết thúc chương trình, hẹn gặp lại quý khách 
trong những chương trình tiếp theo. Xin chân thành cảm ơn!', N'h51.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (87, N'T11', 1, CAST(N'00:15:00' AS Time), CAST(N'08:00:00' AS Time), N'TRUNG TÂM TP. HỒ CHÍ MINH', N'ROVANIEMI', N'Trưởng đoàn công ty đón quý khách tại điểm hẹn sân bay Tân Sơn Nhất. Đoàn làm thủ tục 
lên chuyến bay tới Rovaniemi – thủ phủ của vùng Lapland, Phần Lan. Chuyến bay quá cảnh 
tùy theo hàng không. Nghỉ đêm trên máy bay.', N'h52.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (88, N'T11', 2, CAST(N'08:15:00' AS Time), CAST(N'11:00:00' AS Time), N'ROVANIEMI ', N'ROVANIEMI ', N'Đến Rovaniemi - cửa ngõ đến Lapland nơi có làng Ông già Noel. Là thủ phủ của tỉnh Lapland.
Xe đưa Quý khách ghé thăm Làng Ông già Noel để gặp gỡ và tận mắt nhìn thấy văn phòng làm việc
của ông, nơi ông đọc thư của các em bé từ khắp nơi trên thế giới gửi về.
Quý khách được nhận giấy chứng nhận đã vượt qua vòng Bắc cực (Artic Circle) 
– một trong 5 vĩ tuyến quan trọng trên bản đồ Trái Đất. Ăn tối và nghỉ ngơi tại khách sạn.
', N'h53.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (89, N'T11', 3, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'ROVANIEMI ', N'IVALO', N'Ăn sáng buffet dinh dưỡng theo phong cách Scandinavian tại khách sạn. Bắt đầu hành trình 
khám phá thành phố Rovaniemi:

- Trang trại tuần lộc Đoàn trải nghiệm xe tuần lộc kéo giữa cánh rừng tuyết trắng như trong 
truyện cổ tích. Tại đây, Quý khách có cơ hội trải nghiệm những chiếc xe trượt tuyết đặc trưng, 
chiêm ngưỡng thiên nhiên hùng vĩ, tận tay cho những chú tuần lộc ăn và thưởng thức trà hoặc 
cà phê nóng trong thời tiết giá lạnh.

Sau bữa trưa, đoàn di chuyển đến Ivalo để chuẩn bị tham gia hành trình Săn “Bắc cực quang”
huyền bí – hiện tượng thiên nhiên kì thú chỉ một số nơi trên Trái Đất mới có thể nhìn thấy. 
Bắc cực quang hoạt động từ cuối tháng 8 tới giữa tháng 4 năm sau. 
Tùy theo điều kiện thời tiết và một số điều kiện khách quan khác mà Quý khách có thể nhìn 
thấy Bắc cực quang với nhiều màu sắc khác nhau (như xanh lá, hồng, vàng, tím) hoặc khó 
nhìn thấy nếu trời âm u, nhiều mây hoặc không đủ tối. Quý khách nghỉ ngơi tại khách sạn.', N'h54.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (90, N'T11', 4, CAST(N'17:15:00' AS Time), CAST(N'23:00:00' AS Time), N'IVALO ', N'TỰ DO TRẢI NGHIỆM HOẠT ĐỘNG XỨ LẠNH ', N'Ăn sáng trễ sau một đêm dài Săn Bắc Cực Quang.

Quý khách có một ngày tự do lựa chọn trải nghiệm các hoạt động mùa đông đặc trưng tại khu vực 
này (Chi phí tự túc):

- Ngồi xe chó kéo Husky safari tận hưởng niềm vui và năng lượng từ những chú chó trong mùa 
đông tuyệt đẹp ngay trên mặt hồ Inari

+ Giá tham khảo: 5.000.000 VNĐ/ khách

+ Thời lượng tham khảo: 1,5 - 2 tiếng
- Đi bộ trên tuyết và đắm chìm vào cảm giác đầy mê hoặc của rừng, tuyết, không khí nơi đây Giá 
tham khảo Gentle snowshoeing: 2.100.000 VNĐ/ khách. Thời lượng tham khảo: 2 tiếng

- Giá tham khảo Snowshoeing adventure: 2.800.000 VNĐ/ khách bao gồm ăn trưa ngoài trời. 
Thời lượng tham khảo: 4 tiếng

- Câu cá trên băng Ice fishing: học cách câu cá trên băng và trải nghiệm câu cá như một người 
dân địa phương thực thụ ( Giá tham khảo: 4.500.000 VNĐ/ khách bao gồm ăn trưa ngoài trời. 
Thời lượng tham khảo: 4 tiếng) ', N'h55.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (91, N'T11', 5, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'IVALO  ', N'KIRKENES ', N'Ăn sáng và trả phòng khách sạn. Xe đưa Quý khách đến Kirkenes – thị trấn thuộc vùng 
cực bắc của Na Uy, gần biên giới Na Uy và Phần Lan.
Sau bữa trưa, Quý khách tham gia chương trình xem bắt cua Hoàng đế - tìm hiểu quy trình và 
cách thức đánh bắt của người dân địa phương và thưởng thức đặc sản cua Hoàng đế khổng 
lồ tươi ngon của vùng Kirkenes vừa đánh bắt được.', N'h56.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (92, N'T11', 6, CAST(N'11:15:00' AS Time), CAST(N'17:00:00' AS Time), N'IVALO  ', N'TP. HỒ CHÍ MINH ', N'Tại sân bay Tân Sơn Nhất, 
Trưởng đoàn công ty chào tạm biệt Quý khách. Kết thúc chuyến tham quan.', N'h54.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (93, N'T19', 1, CAST(N'19:15:00' AS Time), CAST(N'11:00:00' AS Time), N'TP.HCM', N'SYDNEY  ', N'19:30: Quý khách tập trung tại sân bay Tân Sơn Nhất, trưởng đoàn của công ty đón Quý khách 
tại cổng D2, ga đi Quốc tế làm thủ tục đáp chuyến bay đi Sydney. Quý khách nghỉ đêm trên máy bay.

Chuyến bay: JQ62 SGN – SYD SS1 22:35 – 10:15', N'h95.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (94, N'T19', 2, CAST(N'08:15:00' AS Time), CAST(N'19:00:00' AS Time), N'SYDNEY', N'SYDNEY CITY TOUR ', N'11:00 Đoàn tới Sydney, xe và HDV đón khách dùng cơm trưa. Sau đó tham quan:

- Nhà hát Con Sò (Sydney Opera House) có kiến trúc cực kỳ ấn tượng và nổi tiếng của Sydney với
ba mặt hướng ra biển.
- Phố cổ The Rocks – nơi những người da trắng đầu tiên định cư ở Úc.
 Vườn Bách Thảo (Botanic Garden) – vườn thực vật được mở cửa từ năm 1816 với diện tích 30 hectares. ', N'h96.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (95, N'T19', 3, CAST(N'07:15:00' AS Time), CAST(N'19:00:00' AS Time), N'SYDNEY   ', N'SYDNEY ZOO – BLUE MOUNTAIN ', N'Sáng: Quý khách ăn sáng tại khách sạn. Sau đó, xe đưa đoàn tham quan Sydney Zoo - nơi đây tập 
trung các loài động vật đặc trưng của nước Úc như Kangaroo và Koala. 
Qúy khách được trải nghiệm, chụp ảnh với các loại động vật đặc trưng của Úc. (Tùy vào thời
gian tham quan)
Trưa: Sau khi dùng cơm trưa, Đoàn tiếp tục chương trình tham quan.

- Khu bảo tồn thiên nhiên Blue Mountain – di sản thế giới, nơi còn lưu giữ nguyên vẹn những
nét hoang sơ từ thời thổ dân sinh sống.
- Tự do chụp hình núi Ba chị em (Three sisters), nếu may mắn du khách có thể chụp được những
bức hình cùng với người thổ dân với ống khèn và những giai điệu truyền thống.

- Trải nghiệm tàu kéo Sennic World: khám phá Blue Mountains với chuyến đường sắt trên không. 
Thưởng ngoạn cảnh rừng nhiệt đới với núi đá và thung lũng Jamison tuyệt đẹp. 
Sau khi dừng ở trạm cuối, đoàn tản bộ qua rừng nhiệt đới Jurassic.', N'h97.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (96, N'T19', 4, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'SYDNEY  ', N'MELBOURNE  (52KM)  - LUCERN ', N'Sáng: Qúy khách dùng bữa sáng tại khách sạn. Xe đưa đoàn ra sân bay đáp chuyến bay đi Melbourne
trên chuyến bay JQ509 SYD – MEL 09:10 – 10:45. Đoàn đến sân bay Melbourne, xe và HDV đón đoàn di 
chuyển đi ăn trưa.

Trưa: Sau bữa trưa, Quý khách bắt đầu một hành trình khám phá thành phố Melbourne với những 
cảnh đẹp như:

- Toà Nhà Quốc Hội Bang Victoria, Nhà Thờ Thánh Patrick - ngôi nhà thờ cổ được xây dựng vào 
thế kỷ 19 với kiến trúc Gothic đặc trưng.
- Vườn thực vật Fitzroy - là khu vườn lịch sử đẹp nhất của thành phố Melbourne. Khu vườn có 
lịch sử được xây dựng như một khu bảo tồn vào năm 1848,
 thiết kế của khu vườn theo kiểu thời kì Victoria cổ điển.', N'h98.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (97, N'T19', 5, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'MELBOURNE  ', N'BALLARAT – BACCHUS MASH', N'Sáng: Quý khách dùng bữa
sáng tại khách sạn. Xe đưa đoàn khởi hành tham quan:

- Bacchus Marsh (Nông trại trái cây): Thung lũng màu mỡ nằm ở phía tây bắc Melbourne, nổi tiếng
với những vườn trái cây, di tích và kỳ quan thiên nhiên, với lịch sử lâu đời từ giữa những năm 1850. 
Quý khách sẽ được tự tay hái và ăn tại chỗ. Mua táo và dâu cùng các loại trái cây chín mọng khác
tùy theo mùa vụ (Táo, lê, cherry, dâu tây, v.v.). 
Quý khách cũng có thể mua về làm quà tặng cho bạn bè và người thân. (Chi phí tự túc)
Đoàn tiếp tục hành trình tới Thị trấn Ballarat – Đô thị cổ kính với hơn 80.000 dân, nơi thời gian 
như đang dừng lại ở thế kỷ 19, Thị trấn đã diễn ra cơn sốt đào vàng dữ dội năm 1850 với những ngôi 
nhà mang kiến trúc đặc trưng của bang Victoria.', N'h99.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (98, N'T19', 6, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'MELBOURNE ', N'TP.HỒ CHÍ MINH', N'Sáng: Qúy khách dùng điểm tâm tại khách sạn. 
Nghỉ ngơi tại khách sạn.

Trưa:  Ăn trưa tại nhà hàng địa phương sau đó di chuyển ra sân bay Melbourne làm thủ tục check in 
chuyến bay về Việt Nam lúc 16:40, đoàn đến TP HCM lúc  21:05.

Hành trình: JQ63 MELSGN SS1 16:40 - 21:05

Quý khách nhận hành lý, kết thúc chương trình tour. Xin chào tạm biệt và hẹn gặp lại Quý khách.', N'h100.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (99, N'T20', 1, CAST(N'19:15:00' AS Time), CAST(N'11:00:00' AS Time), N'TP.HCM', N'BLUE MOUNTAINS  ', N'19:30: Quý khách tập trung tại sân bay Tân Sơn Nhất, trưởng đoàn của công ty đón Quý khách tại cổng D2, 
ga đi Quốc tế làm thủ tục đáp chuyến bay đi Sydney. Quý khách nghỉ đêm trên máy bay.

Chuyến bay: JQ62 SGN – SYD SS1 22:35 – 10:15', N'h95.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (100, N'T20', 2, CAST(N'08:15:00' AS Time), CAST(N'19:00:00' AS Time), N'SYDNEY', N'SYDNEY CITY TOUR ', N'Ăn sáng tại khách sạn. Khởi hành đi vườn quốc 
gia Blue Mountains - vùng đất trước kia thuộc các bộ tộc thổ dân Úc.
	Đến Blue Mountains, đoàn dùng bữa trưa. Quý khách sẽ đi cáp treo qua thung lũng, ngắm những thác nước
trắng xóa nổi bật trong sắc xanh thiên nhiên hùng vĩ; 
ngồi xe điện xuống thung lũng Jamison để khám phá hệ thực vật còn nguyên sơ tại đây. Rời Blue Mountains, 
Tham quan  công viên Featherdale là niềm kiêu hãnh của người dân 
Australia, nơi nuôi dưỡng hơn 2.200 loài động vật quý hiếm, đặc trưng nhất của Châu Úc như gấu Koala, 
Kanguru, thú mỏ vị… Bên cạnh đó cũng có rất nhiều loài động vật quý 
hiếm khác như chim cánh cụt Fairy Penguins, cá sấu nước mặn… Tới đây bạn sẽ được tận hưởng một đời sống
hoang dã thật sự được cho các con Kanguru ăn, “hun” những chú Koala hiền lành và chụp hình với những con
vật dễ thương khác. Nơi đây cũng bày bán rất nhiều những món quà lưu niệm và cả những quán cà phê
“hoang dã” rất ấn tượng. 
Ăn tối. Nhận phòng và nghỉ đêm tại Sydney. ', N'h101.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (101, N'T20', 3, CAST(N'07:15:00' AS Time), CAST(N'19:00:00' AS Time), N'SYDNEY   ', N'MELBOURNE ', N'Sau khi ăn sáng. Quý khách tự do mua sắm cho đến giờ ra sân bay đáp chuyến bay đi Melbourne bằng hãng
hàng không nội địa của Úc. Đến Melbourne. Quý khách tham quan thành phố Melbourne gồm: Khu Phố Tàu, 
Kho bạc, Toà Thị Chính, Toà Nhà Quốc Hội, nhà thờ Thánh Patrick - ngôi nhà thờ cổ được xây dựng vào
thế kỷ 19 với kiến trúc Gothic đặc trưng, Đài tưởng niệm, Vườn Thực Vật Fitzroy - Khu vườn có hồ nước 
trong xanh, những ngôi nhà kính trồng cây độc đáo, đài phun nước, những tác phẩm điêu khắc ấn tượng… 
Tiếp tục tham quan Quảng trường Federation, Ga phố Flinders - là nhà ga chính của Melbourne, địa điểm
nổi tiếng có bề dày lịch sử với kiến trúc cổ đại được lưu giữ đến tận bây giờ, tham quan sông Yarra, 
khu Arts Percinct..
 Quý khách ăn tối và tự do nghỉ ngơi , khám phá thánh phố Melbourne', N'h102.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (102, N'T20', 4, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'SYDNEY  ', N'THUNG LŨNG YARRA	  ', N'Dùng bữa sáng tại khách sạn xong, xe đưa đoàn đến khám phá những điểm du lịch thú vị không thể bỏ qua: 
Yarra Valley Chocolaterie & Ice Creamery: đây là nhà máy sản xuất sô cô la nằm trên thung lũng
Yarra Valley. Ờ đây có các loại sô cô la đặc biệt, kem, thức uống và đồ ăn được phục vụ trong nhà 
và ngoài trời. Quý khách sẽ được thưởng đa dạng các loại sô cô la tại đây. Đoàn tiếp tục đến 
Rayners Orchard, đây là một vườn trái cây gia đình ở Yarra Valley, trồng hơn 450 cây ăn quả, 
bao gồm cây quả hạch, cây họ cam quýt, những loại cây khác như ổi, ổi dứa và rất nhiều trái cây 
ngon ngọt khác. Mùa xuân có đào, cam, chanh, đại hoàng và xuân đào. Nếu có thể, Quý khách nên 
thử một vòng quanh khu vườn bằng xe máy kéo với chủ nông trại để thử vài loại quả và tìm hiểu 
thêm về những loại quả mà Quý khách thích.', N'h103.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (103, N'T20', 5, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'MELBOURNE  ', N'BALLARAT – BACCHUS MASH', N'Sáng: Quý khách dùng bữa sáng tại khách sạn. Xe đưa đoàn khởi hành tham quan:

- Bacchus Marsh (Nông trại trái cây): Thung lũng màu mỡ nằm ở phía tây bắc Melbourne, nổi tiếng 
với những vườn trái cây, di tích và kỳ quan thiên nhiên, với lịch sử lâu đời từ giữa những năm 1850. 
Quý khách sẽ được tự tay hái và ăn tại chỗ. 
Mua táo và dâu cùng các loại trái cây chín mọng khác tùy theo mùa vụ (Táo, lê, cherry, dâu tây, v.v.). 
Quý khách cũng có thể mua về làm quà tặng cho bạn bè và người thân. (Chi phí tự túc)
Đoàn tiếp tục hành trình tới Thị trấn Ballarat – Đô thị cổ kính với hơn 80.000 dân, nơi thời gian 
như đang dừng lại ở thế kỷ 19, Thị trấn đã diễn ra cơn sốt đào vàng dữ dội năm 1850 với những ngôi 
nhà mang kiến trúc đặc trưng của bang Victoria.', N'h104.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (104, N'T20', 6, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'MELBOURNE ', N'TP.HỒ CHÍ MINH', N'Ăn sáng. Quý khách tự do cho đến giờ ra sân bay về Việt Nam.

*Tùy vào tình hình thực tế, thứ tự các điểm tham quan trong chương trình có thể thay đổi nhưng 
vẫn đảm bảo đầy đủ các điểm tham quan như lúc đầu  

Quý khách nhận hành lý, kết thúc chương trình tour. Xin chào tạm biệt và hẹn gặp lại Quý khách.', N'h105.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (105, N'T33', 1, CAST(N'19:15:00' AS Time), CAST(N'11:00:00' AS Time), N'TP.HCM', N'LOS ANGELES', N'Trưởng đoàn công ty đón Quý khách tại sân bay Tân Sơn Nhất, đáp chuyến bay đến Los Angeles - 
nơi được mệnh danh là “Thành phố Thiên Thần”, quá cảnh Đài Loan, sau đó làm thủ tục nối chuyến
đi Los Angeles..', N'h0.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (106, N'T33', 2, CAST(N'08:15:00' AS Time), CAST(N'19:00:00' AS Time), N'LOS ANGELES', N' PHIM TRƯỜNG UNIVERSAL', N'Sau khi ăn sáng, Quý khách bắt đầu hành trình trong ngày tham quan trung tâm kinh đô điện 
ảnh Hollywood, Quý khách tản bộ trên đại lộ Hollywood, dừng chân tại nhà hát Mann’s Chinese Theatre
với sân trước của nhà hát in kín dấu giày và dấu bàn tay của hầu hết các nghệ sĩ điện ảnh tiếng tăm.', N'T31_1.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (107, N'T33', 2, CAST(N'07:15:00' AS Time), CAST(N'19:00:00' AS Time), N'PHIM TRƯỜNG UNIVERSAL', N'HOLLYWOOD', N'Quý khách tiếp tục tham quan Dolby Theatre - nơi diễn ra lễ trao giải Oscar hàng năm.

- Quý khách tham quan công viên Universal Studios trường quay của các bộ phim nổi tiếng 
trong lịch sử điện ảnh thế giới như Kingkong, Hàm cá mập, Công viên khủng long v.v.', N'T31_2.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (108, N'T33', 2, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'PHIM TRƯỜNG UNIVERSAL', N'HOLLYWOOD', N'- Đặc biệt xem phim 3D Kingkong - Bộ phim 3D lớn nhất Thế Giới về mức độ hoành tráng - 
Quý khách như lạc vào khu rừng nguyên sinh tận mắt chứng kiến những pha hành động của Kingkong. 
Phim 4D Transformer, Quý khách như được hành động cùng các nhân vật trong phim, chắc chắn sẽ để 
lại Quý khách những ấn tượng khó quên về các kỹ xảo làm phim của điện ảnh Hollywood. ', N'T31_4.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (109, N'T33', 3, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N' LOS ANGELES ', N'LAS VEGAS', N'Sau bữa sáng, xe đón và đưa đoàn đến Las Vegas xuyên qua hoang mạc Mojave thuộc quận 
San Bernardino trên đường 66 được nhắc đến trong lời bài hát “Route 66” của ban nhạc 
Rolling Stones. Trên đường đoàn dừng chân mua sắm tại đại siêu thị Barstow - nằm ở phía 
Tây hoang mạc Mojave. ', N'T31_5.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (110, N'T33', 4, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'LAS VEGAS', N'GRAND CANYON', N'Sau bữa sáng, xe đưa đoàn đi tham quan Grand Canyon - một trong 7 kỳ quan thiên nhiên 
của thế giới với những vực sâu, những phiến đá được xếp thành nhiều tầng. Đến đây, Quý khách 
sẽ choáng ngợp khi nhìn thấy những tảng đá vôi to lớn với vô số đỉnh nhọn với nhiều hình thù kỳ lạ,
những vực hẻm trải dài từ Marble George đến Grand Waschiffs hơn 300km với độ sâu thăm thẳm…', N'T31_6.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (111, N'T33', 5, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'LAS VEGAS', N'GRAND CANYON', N'Sau bữa tối, xe đưa Quý khách chạy dọc theo trục đường nhộn nhịp, tràn ngập ánh sáng 
của Las Vegas để ngắm nhìn “The Strip” - con đường dài hơn 6 km tập trung những khách sạn và 
casino tiếng tăm và sang trọng bậc nhất như Bellagio nổi tiếng với màn trình diễn nhạc nước ngoài 
trời hoành tráng, Ceasars Palace - Với lối kiến trúc Roma cổ, tinh xảo cùng rất nhiều bức tượng mang 
tên các vị hoàng đế La Mã, Caesars Palace luôn là nơi dừng chân của các vị khách siêu VIP, trong đó 
có tổng thống Barack Obama và nữ danh ca Celine Dion. ', N'T31_7.png')
INSERT [dbo].[ChiTietChuongTrinh] ([id], [MaCTTour], [Ngay], [GioDi], [GioDen], [DiemKhoiHanh], [DiemDen], [MoTa], [HinhAnh]) VALUES (112, N'T33', 6, CAST(N'14:15:00' AS Time), CAST(N'19:00:00' AS Time), N'LAS VEGAS', N'LAS VEGAS', N'Quý khách có thể tìm được những món hàng hiệu với giá cả phải chăng, Quý khách ăn trưa tại 
khu mua sắm. Tiếp tục hành trình đến Los Angeles.

Đoàn tham quan khu vực Little Saigon nơi có cộng đồng người Việt sinh sống đông đúc. 
Quý khách tự do mua sắm và tham quan Thương Xá Phước Lộc Thọ nổi tiếng tại Bờ Tây Nước Mỹ.', N'T31_8.png')
SET IDENTITY_INSERT [dbo].[ChiTietChuongTrinh] OFF
GO
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T01', N'Tour Nhật Bản 7N6Đ: Cung Đường Vàng - Hành Trình Mùa Thu')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T02', N'Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T03', N'Tour Nhật Bản 4N4Đ: Tokyo - Yamanashi - Núi Phú Sĩ - Mùa Đông Nhật Bản')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T04', N'Tour Singapore 3N2Đ: Countdown New Year 2023 Marina Bay Sands 5 Sao')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T05', N'Tour Tết Quý Mão Hàn Quốc 5N4Đ: Seoul - Trượt tuyết Elysian - Show Painter')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T06', N'Thái Lan 4N3Đ: Thiên Đường Biển Phuket - Đảo Phi Phi')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T07', N'Tour Nam Âu 11N10Đ: Trải Nghiệm Mùa Đông - Pháp - Tây Ban Nha - Bồ Đào Nha')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T08', N'Tour Cao Cấp Đà Nẵng 4N3Đ: Huế - Quảng Bình - Đà Nẵng - Bà Nà - Hội An')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T09', N'Tour Ai Cập 8N7Đ: Trải nghiệm Du Thuyền 5 Sao Sông Nile Huyền Bí')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T10', N'Tour Mộc Châu 2N1Đ: Mùa Hoa Mận Trắng')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T11', N'Tour Bắc Âu Thăm Quê Hương Ông Già Noel 8N7Đ: Phần Lan - Nauy')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T19', N'Tour Úc 6N5Đ: Khám Phá Sydney - Melbourne')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T20', N'Tour Tết Quý Mão Úc 7N6Đ: Hành Trình Khám Phá Châu Úc Mùa Xuân')
INSERT [dbo].[ChuongTrinhTour] ([MaCTTour], [TenChuongTrinhTour]) VALUES (N'T33', N'Tour Bờ Tây Hoa Kỳ 7N6Đ: Los Angeles - Hollywood - Las Vegas - Grand Canyon - Universal Studio')
GO
INSERT [dbo].[DatVe] ([MaKhach], [MaTour], [SoLuongVe], [Tong], [NgayDat], [NgayDi], [GiaVe], [TrangThai]) VALUES (N'KH02', N'T01', 1, 39990000, CAST(N'2022-11-19T22:03:00' AS SmallDateTime), CAST(N'2022-11-25' AS Date), NULL, 0)
INSERT [dbo].[DatVe] ([MaKhach], [MaTour], [SoLuongVe], [Tong], [NgayDat], [NgayDi], [GiaVe], [TrangThai]) VALUES (N'KH02', N'T02', 1, 13990000, CAST(N'2022-11-19T20:42:00' AS SmallDateTime), CAST(N'2023-01-01' AS Date), NULL, 0)
INSERT [dbo].[DatVe] ([MaKhach], [MaTour], [SoLuongVe], [Tong], [NgayDat], [NgayDi], [GiaVe], [TrangThai]) VALUES (N'KH02', N'T02', 1, 13990000, CAST(N'2022-11-19T22:04:00' AS SmallDateTime), CAST(N'2023-02-01' AS Date), NULL, 0)
INSERT [dbo].[DatVe] ([MaKhach], [MaTour], [SoLuongVe], [Tong], [NgayDat], [NgayDi], [GiaVe], [TrangThai]) VALUES (N'KH02', N'T02', 1, 13990000, CAST(N'2022-11-22T09:51:00' AS SmallDateTime), CAST(N'2022-11-23' AS Date), NULL, 1)
INSERT [dbo].[DatVe] ([MaKhach], [MaTour], [SoLuongVe], [Tong], [NgayDat], [NgayDi], [GiaVe], [TrangThai]) VALUES (N'KH02', N'T02', 2, 27980000, CAST(N'2022-11-28T16:08:00' AS SmallDateTime), CAST(N'2023-01-20' AS Date), 13990000, 1)
INSERT [dbo].[DatVe] ([MaKhach], [MaTour], [SoLuongVe], [Tong], [NgayDat], [NgayDi], [GiaVe], [TrangThai]) VALUES (N'KH02', N'T02', 2, 27980000, CAST(N'2022-11-28T16:21:00' AS SmallDateTime), CAST(N'2023-10-20' AS Date), 13990000, 0)
INSERT [dbo].[DatVe] ([MaKhach], [MaTour], [SoLuongVe], [Tong], [NgayDat], [NgayDi], [GiaVe], [TrangThai]) VALUES (N'KH04', N'T02', 2, 30000000, CAST(N'2022-12-12T22:41:00' AS SmallDateTime), CAST(N'2023-01-28' AS Date), 15000000, 0)
INSERT [dbo].[DatVe] ([MaKhach], [MaTour], [SoLuongVe], [Tong], [NgayDat], [NgayDi], [GiaVe], [TrangThai]) VALUES (N'KH07', N'T07', 3, 74670000, CAST(N'2022-12-18T15:07:00' AS SmallDateTime), CAST(N'2023-08-20' AS Date), 24890000, 0)
GO
INSERT [dbo].[GioiTinh] ([MaGioiTinh], [TenGioiTinh]) VALUES (0, N'Nữ')
INSERT [dbo].[GioiTinh] ([MaGioiTinh], [TenGioiTinh]) VALUES (1, N'Nam')
GO
INSERT [dbo].[HuongDanVien] ([MaHDV], [MaTK], [MaLoai], [TenHDV], [GioiTinh], [SDT], [NgayVaoLam], [CCCD]) VALUES (N'HDV01', 4, 5, N'Vương Hạo', N'Nam', N'0733887555', CAST(N'2016-02-27' AS Date), N'375202016738')
INSERT [dbo].[HuongDanVien] ([MaHDV], [MaTK], [MaLoai], [TenHDV], [GioiTinh], [SDT], [NgayVaoLam], [CCCD]) VALUES (N'HDV02', 9, 8, N'Heuristic', N'Nam', N'0733887556', CAST(N'2018-04-20' AS Date), N'463202012365')
INSERT [dbo].[HuongDanVien] ([MaHDV], [MaTK], [MaLoai], [TenHDV], [GioiTinh], [SDT], [NgayVaoLam], [CCCD]) VALUES (N'HDV03', 10, 8, N'Robinson', N'Nam', N'0733887557', CAST(N'2020-01-29' AS Date), N'533202013253')
INSERT [dbo].[HuongDanVien] ([MaHDV], [MaTK], [MaLoai], [TenHDV], [GioiTinh], [SDT], [NgayVaoLam], [CCCD]) VALUES (N'HDV04', 11, 7, N'Ngọc Hiếu', N'Nữ', N'0733887558', CAST(N'2019-08-12' AS Date), N'346202011724')
INSERT [dbo].[HuongDanVien] ([MaHDV], [MaTK], [MaLoai], [TenHDV], [GioiTinh], [SDT], [NgayVaoLam], [CCCD]) VALUES (N'HDV05', 12, 6, N'Marie Curie', N'Nữ', N'0733887559', CAST(N'2011-10-30' AS Date), N'932202018253')
INSERT [dbo].[HuongDanVien] ([MaHDV], [MaTK], [MaLoai], [TenHDV], [GioiTinh], [SDT], [NgayVaoLam], [CCCD]) VALUES (N'HDV06', 13, 9, N'Minh Vương', N'Nam', N'0733887550', CAST(N'2022-07-23' AS Date), N'692202016394')
INSERT [dbo].[HuongDanVien] ([MaHDV], [MaTK], [MaLoai], [TenHDV], [GioiTinh], [SDT], [NgayVaoLam], [CCCD]) VALUES (N'HDV07', 13, 9, N'Minh Vương', N'Nam', N'0733887550', CAST(N'2020-01-30' AS Date), N'692202016397')
INSERT [dbo].[HuongDanVien] ([MaHDV], [MaTK], [MaLoai], [TenHDV], [GioiTinh], [SDT], [NgayVaoLam], [CCCD]) VALUES (N'HDV08', 13, 9, N'Hoàng Gia', N'Nam', N'0733887550', CAST(N'2002-12-12' AS Date), N'692202016397')
GO
INSERT [dbo].[KhachHang] ([MaKhach], [MaTK], [TenKhach], [NgaySinh], [SDT]) VALUES (N'KH01', 5, N'Nguyễn Đức Hữu', CAST(N'2002-01-01' AS Date), N'0384578325')
INSERT [dbo].[KhachHang] ([MaKhach], [MaTK], [TenKhach], [NgaySinh], [SDT]) VALUES (N'KH02', 6, N'Lê Sin', CAST(N'2002-01-01' AS Date), N'0937584634')
INSERT [dbo].[KhachHang] ([MaKhach], [MaTK], [TenKhach], [NgaySinh], [SDT]) VALUES (N'KH03', 7, N'Nguyễn Hữu X', CAST(N'2002-01-01' AS Date), N'0384978329')
INSERT [dbo].[KhachHang] ([MaKhach], [MaTK], [TenKhach], [NgaySinh], [SDT]) VALUES (N'KH04', 8, N'Trần Văn H', CAST(N'2002-01-01' AS Date), N'0937584634')
INSERT [dbo].[KhachHang] ([MaKhach], [MaTK], [TenKhach], [NgaySinh], [SDT]) VALUES (N'KH05', 9, N'Trần Thi Y', CAST(N'2002-01-01' AS Date), N'0937584634')
INSERT [dbo].[KhachHang] ([MaKhach], [MaTK], [TenKhach], [NgaySinh], [SDT]) VALUES (N'KH06', 10, N'Võ Thị Bé', CAST(N'2002-01-01' AS Date), N'0937584634')
INSERT [dbo].[KhachHang] ([MaKhach], [MaTK], [TenKhach], [NgaySinh], [SDT]) VALUES (N'KH07', 57, N'Cristiano Ronaldo', CAST(N'1895-02-05' AS Date), N'0339837586')
GO
SET IDENTITY_INSERT [dbo].[LoaiAccounts] ON 

INSERT [dbo].[LoaiAccounts] ([MaLoaiAcc], [TenLoaiAcc]) VALUES (1, N'Quản trị viên')
INSERT [dbo].[LoaiAccounts] ([MaLoaiAcc], [TenLoaiAcc]) VALUES (2, N'Khách')
INSERT [dbo].[LoaiAccounts] ([MaLoaiAcc], [TenLoaiAcc]) VALUES (3, N'Nhân viên')
SET IDENTITY_INSERT [dbo].[LoaiAccounts] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiHDV] ON 

INSERT [dbo].[LoaiHDV] ([MaLoai], [TenLoai]) VALUES (5, N'hướng dẫn viên chuyên nghiệp')
INSERT [dbo].[LoaiHDV] ([MaLoai], [TenLoai]) VALUES (6, N'hướng dẫn viên không chuyên nghiệp, công tác viên')
INSERT [dbo].[LoaiHDV] ([MaLoai], [TenLoai]) VALUES (7, N'hướng dẫn viên tại điểm')
INSERT [dbo].[LoaiHDV] ([MaLoai], [TenLoai]) VALUES (8, N'hướng dẫn viên suốt tuyến')
INSERT [dbo].[LoaiHDV] ([MaLoai], [TenLoai]) VALUES (9, N'hướng dẫn viên thành phố')
SET IDENTITY_INSERT [dbo].[LoaiHDV] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiTour] ON 

INSERT [dbo].[LoaiTour] ([MaloaiTour], [TenLoaiTour]) VALUES (1, N'Tour trong nước')
INSERT [dbo].[LoaiTour] ([MaloaiTour], [TenLoaiTour]) VALUES (2, N'Tour châu á')
INSERT [dbo].[LoaiTour] ([MaloaiTour], [TenLoaiTour]) VALUES (3, N'Tour châu âu')
INSERT [dbo].[LoaiTour] ([MaloaiTour], [TenLoaiTour]) VALUES (4, N'Tour châu phi')
INSERT [dbo].[LoaiTour] ([MaloaiTour], [TenLoaiTour]) VALUES (5, N'Tour châu úc')
INSERT [dbo].[LoaiTour] ([MaloaiTour], [TenLoaiTour]) VALUES (6, N'Tour châu mĩ')
SET IDENTITY_INSERT [dbo].[LoaiTour] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiVe] ON 

INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe]) VALUES (1, N'Vé hạng nhất')
INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe]) VALUES (2, N'Vé hạng thương gia')
INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe]) VALUES (3, N'Vé hạng phổ thông đặc biệt')
INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe]) VALUES (4, N'Vé hạng phổ thông')
INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe]) VALUES (5, N'Vé hạng nhất')
INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe]) VALUES (6, N'Vé hạng thương gia')
INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe]) VALUES (7, N'Vé hạng phổ thông đặc biệt')
INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe]) VALUES (8, N'Vé hạng phổ thông')
SET IDENTITY_INSERT [dbo].[LoaiVe] OFF
GO
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T01', N'HDV01', N'Tour Nhật Bản 7N6Đ: Cung Đường Vàng - Hành Trình Mùa Thu', N'Nhật Bản', 39990000, N'h1.png', 2)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T02', N'HDV02', N'Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung', N'Hàn Quốc', 15000000, N'h7.png', 2)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T03', N'HDV03', N'Tour Nhật Bản 4N4Đ: Tokyo - Yamanashi - Núi Phú Sĩ - Mùa Đông Nhật Bản', N'Nhật Bản', 24890000, N'T01_H01.png', 2)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T04', N'HDV04', N'Tour Singapore 3N2Đ: Countdown New Year 2023 Marina Bay Sands 5 Sao', N'Singapore', 39990000, N'T02_H02.png', 2)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T05', N'HDV05', N'Tour Tết Quý Mão Hàn Quốc 5N4Đ: Seoul - Trượt tuyết Elysian - Show Painter', N'Hàn Quốc', 28890000, N'T03_H03.png', 2)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T06', N'HDV06', N'Thái Lan 4N3Đ: Thiên Đường Biển Phuket - Đảo Phi Phi', N'Thái Lan', 29290000, N'T04_H04.png', 2)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T07', N'HDV03', N'Tour Nam Âu 11N10Đ: Trải Nghiệm Mùa Đông - Pháp - Tây Ban Nha - Bồ Đào Nha', N'Nam Âu', 24890000, N'T05_H05.png', 3)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T08', N'HDV04', N'Tour Cao Cấp Đà Nẵng 4N3Đ: Huế - Quảng Bình - Đà Nẵng - Bà Nà - Hội An', N'Đà Nẵng', 24990000, N'T06_H06.png', 1)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T09', N'HDV01', N'Tour Ai Cập 8N7Đ: Trải nghiệm Du Thuyền 5 Sao Sông Nile Huyền Bí', N'Ai Cập', 137000000, N'T31_HH31.png', 4)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T10', N'HDV02', N'Tour Mộc Châu 2N1Đ: Mùa Hoa Mận Trắng', N'Mộc Châu', 24890000, N'T08_H8.png', 1)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T11', N'HDV03', N'Tour Bắc Âu Thăm Quê Hương Ông Già Noel 8N7Đ: Phần Lan - Nauy', N'Bắc Âu', 24890000, N'T09_H09.png', 2)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T19', N'HDV04', N'Tour Úc 6N5Đ: Khám Phá Sydney - Melbourne', N'Châu Úc', 24890000, N'T17_H17.png', 5)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T20', N'HDV06', N'Tour Tết Quý Mão Úc 7N6Đ: Hành Trình Khám Phá Châu Úc Mùa Xuân', N'Châu Úc', 24890000, N'T15_H15.png', 5)
INSERT [dbo].[Tour] ([MaTour], [Huo_MaHDV], [TenTour], [DiaDiem], [ChiPhi], [AnhBia], [MaLoaiTour]) VALUES (N'T33', N'HDV04', N'Tour Bờ Tây Hoa Kỳ 7N6Đ: Los Angeles - Hollywood - Las Vegas - Grand Canyon - Universal Studio', N'Tây Hoa Kỳ', 24890000, N'T31_H31.png', 6)
GO
SET IDENTITY_INSERT [dbo].[ThanhVien] ON 

INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (22, N'KH01', N'Nguyễn Thị Tuyết Nhung', 0, CAST(N'2002-07-10' AS Date), N'375202016739', N'T01')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (23, N'KH01', N'Nguyễn Thị Lài', 0, CAST(N'2002-08-11' AS Date), N'305202016738', N'T01')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (24, N'KH01', N'Nguyễn Đăng Khoa', 1, CAST(N'2002-12-22' AS Date), N'101202019573', N'T01')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (25, N'KH01', N'Nguyễn Thuý Ngần', 0, CAST(N'2002-04-25' AS Date), N'407202015635', N'T02')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (26, N'KH02', N'Phạm Quốc Anh', 1, CAST(N'2001-06-21' AS Date), N'503202019267', N'T02')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (27, N'KH02', N'Trần Trung Hiếu', 1, CAST(N'2000-11-19' AS Date), N'708202019273', N'T02')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (28, N'KH02', N'Huỳnh Thị Lệ Xuân', 0, CAST(N'2003-03-04' AS Date), N'007202019372', N'T01')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (29, N'KH04', N'nguyen thi be 3', 0, CAST(N'2002-08-08' AS Date), N'398457508584', N'T01')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (30, N'KH04', N'nguyen thi be tu', 0, CAST(N'2004-01-10' AS Date), N'398457508588', N'T01')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (31, N'KH04', N'nguyen thi be ba', 0, CAST(N'2002-02-08' AS Date), N'34354', N'T05')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (32, N'KH04', N'nguyen thi be tu', 0, CAST(N'2004-02-08' AS Date), N'34354', N'T05')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (37, N'KH04', N'nguyen van a', 0, CAST(N'2002-01-01' AS Date), N'1214342', N'T05')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (38, N'KH04', N'nguyen van b', 1, CAST(N'2003-01-01' AS Date), N'1214343', N'T05')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (35, N'KH04', N'nguyen thi be ba', 0, CAST(N'2002-02-20' AS Date), N'132143', N'T06')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (36, N'KH04', N'nguyen thi be tu', 0, CAST(N'2002-02-20' AS Date), N'132144', N'T06')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (39, N'KH07', N'messi', 1, CAST(N'1987-01-01' AS Date), N'456543455', N'T07')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (40, N'KH07', N'pepe', 1, CAST(N'1985-01-01' AS Date), N'456543454', N'T07')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [MaKhach], [TenThanhVien], [GioiTinh], [NgaySinh], [CCCD], [MaTour]) VALUES (41, N'KH07', N'maxelo', 1, CAST(N'1985-01-01' AS Date), N'456543453', N'T07')
SET IDENTITY_INSERT [dbo].[ThanhVien] OFF
GO
INSERT [dbo].[VeMayBay] ([MaVe], [MaLoaiVe], [TenVe], [NgayDi], [NgayDen], [GioDi], [GioiDen], [SanBayDi], [SanBayDen], [Gia]) VALUES (N'V01', 1, N'Tp.Hồ Chí Minh-Khánh Hòa', CAST(N'2022-11-06' AS Date), CAST(N'2022-11-06' AS Date), CAST(N'08:35:00' AS Time), CAST(N'09:45:00' AS Time), N'Sân bay Quốc tế Tân Sơn Nhất', N'Sân bay Quốc tế Cam Ranh', 692000)
INSERT [dbo].[VeMayBay] ([MaVe], [MaLoaiVe], [TenVe], [NgayDi], [NgayDen], [GioDi], [GioiDen], [SanBayDi], [SanBayDen], [Gia]) VALUES (N'V02', 2, N'Việt Nam-Hàn Quốc', CAST(N'2022-11-10' AS Date), CAST(N'2022-11-10' AS Date), CAST(N'12:15:00' AS Time), CAST(N'19:35:00' AS Time), N'Sân bay Quốc tế Tân Sơn Nhất', N'Incheon International Airport', 1965000)
INSERT [dbo].[VeMayBay] ([MaVe], [MaLoaiVe], [TenVe], [NgayDi], [NgayDen], [GioDi], [GioiDen], [SanBayDi], [SanBayDen], [Gia]) VALUES (N'V03', 3, N'Việt Nam-Nhật Bản', CAST(N'2022-11-16' AS Date), CAST(N'2022-11-16' AS Date), CAST(N'02:35:00' AS Time), CAST(N'09:45:00' AS Time), N'Sân bay Quốc tế Tân Sơn Nhất', N'Tokyo - Narita (NRT), Nhật Bản', 8560000)
INSERT [dbo].[VeMayBay] ([MaVe], [MaLoaiVe], [TenVe], [NgayDi], [NgayDen], [GioDi], [GioiDen], [SanBayDi], [SanBayDen], [Gia]) VALUES (N'V04', 4, N'Tp.Hồ Chí Minh-Khánh Hòa', CAST(N'2022-11-06' AS Date), CAST(N'2022-11-06' AS Date), CAST(N'08:35:00' AS Time), CAST(N'09:45:00' AS Time), N'Sân bay Quốc tế Tân Sơn Nhất', N'Sân bay Quốc tế Cam Ranh', 692000)
INSERT [dbo].[VeMayBay] ([MaVe], [MaLoaiVe], [TenVe], [NgayDi], [NgayDen], [GioDi], [GioiDen], [SanBayDi], [SanBayDen], [Gia]) VALUES (N'V05', 2, N'Hà Nội-Đà Nẵng', CAST(N'2022-11-06' AS Date), CAST(N'2022-11-06' AS Date), CAST(N'08:35:00' AS Time), CAST(N'09:45:00' AS Time), N'Sân bay Quốc tế Tân Sơn Nhất', N'Sân bay Quốc tế Cam Ranh', 692000)
GO
/****** Object:  Index [PK_ACCOUNTS]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [PK_ACCOUNTS] PRIMARY KEY NONCLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [unique_Accounts]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [unique_Accounts] UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK_CHITIETCHUONGTRINH]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[ChiTietChuongTrinh] ADD  CONSTRAINT [PK_CHITIETCHUONGTRINH] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_HUONGDANVIEN]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[HuongDanVien] ADD  CONSTRAINT [PK_HUONGDANVIEN] PRIMARY KEY NONCLUSTERED 
(
	[MaHDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_KHACHHANG]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [PK_KHACHHANG] PRIMARY KEY NONCLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK_LOAIACCOUNTS]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[LoaiAccounts] ADD  CONSTRAINT [PK_LOAIACCOUNTS] PRIMARY KEY NONCLUSTERED 
(
	[MaLoaiAcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK_LOAIHDV]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[LoaiHDV] ADD  CONSTRAINT [PK_LOAIHDV] PRIMARY KEY NONCLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK_LOAIVE]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[LoaiVe] ADD  CONSTRAINT [PK_LOAIVE] PRIMARY KEY NONCLUSTERED 
(
	[MaLoaiVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_TOUR]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[Tour] ADD  CONSTRAINT [PK_TOUR] PRIMARY KEY NONCLUSTERED 
(
	[MaTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK_THANHVIEN]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[ThanhVien] ADD  CONSTRAINT [PK_THANHVIEN] PRIMARY KEY NONCLUSTERED 
(
	[MaThanhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_VEMAYBAY]    Script Date: 12/19/2022 12:01:54 AM ******/
ALTER TABLE [dbo].[VeMayBay] ADD  CONSTRAINT [PK_VEMAYBAY] PRIMARY KEY NONCLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DatVe] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_PhanLoaiAccount] FOREIGN KEY([MaLoaiAcc])
REFERENCES [dbo].[LoaiAccounts] ([MaLoaiAcc])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_PhanLoaiAccount]
GO
ALTER TABLE [dbo].[ChiTietChuongTrinh]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETC_CTTOUR_CH_CHUONGTR] FOREIGN KEY([MaCTTour])
REFERENCES [dbo].[ChuongTrinhTour] ([MaCTTour])
GO
ALTER TABLE [dbo].[ChiTietChuongTrinh] CHECK CONSTRAINT [FK_CHITIETC_CTTOUR_CH_CHUONGTR]
GO
ALTER TABLE [dbo].[ChuongTrinhTour]  WITH CHECK ADD  CONSTRAINT [fk_CHUONGTRINHTOUR_Tour] FOREIGN KEY([MaCTTour])
REFERENCES [dbo].[Tour] ([MaTour])
GO
ALTER TABLE [dbo].[ChuongTrinhTour] CHECK CONSTRAINT [fk_CHUONGTRINHTOUR_Tour]
GO
ALTER TABLE [dbo].[DatVe]  WITH CHECK ADD  CONSTRAINT [FK_KH_DatVe] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KhachHang] ([MaKhach])
GO
ALTER TABLE [dbo].[DatVe] CHECK CONSTRAINT [FK_KH_DatVe]
GO
ALTER TABLE [dbo].[DatVe]  WITH CHECK ADD  CONSTRAINT [FK_Tour_DatVe] FOREIGN KEY([MaTour])
REFERENCES [dbo].[Tour] ([MaTour])
GO
ALTER TABLE [dbo].[DatVe] CHECK CONSTRAINT [FK_Tour_DatVe]
GO
ALTER TABLE [dbo].[DatVeMB]  WITH CHECK ADD  CONSTRAINT [FK_KH_DatVeMB] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KhachHang] ([MaKhach])
GO
ALTER TABLE [dbo].[DatVeMB] CHECK CONSTRAINT [FK_KH_DatVeMB]
GO
ALTER TABLE [dbo].[DatVeMB]  WITH CHECK ADD  CONSTRAINT [FK_VeMayBay_Datve] FOREIGN KEY([MaVe])
REFERENCES [dbo].[VeMayBay] ([MaVe])
GO
ALTER TABLE [dbo].[DatVeMB] CHECK CONSTRAINT [FK_VeMayBay_Datve]
GO
ALTER TABLE [dbo].[HuongDanVien]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_HDV] FOREIGN KEY([MaTK])
REFERENCES [dbo].[Accounts] ([MaTK])
GO
ALTER TABLE [dbo].[HuongDanVien] CHECK CONSTRAINT [FK_Accounts_HDV]
GO
ALTER TABLE [dbo].[HuongDanVien]  WITH CHECK ADD  CONSTRAINT [FK_HDV_LoaiHDV] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiHDV] ([MaLoai])
GO
ALTER TABLE [dbo].[HuongDanVien] CHECK CONSTRAINT [FK_HDV_LoaiHDV]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Kh] FOREIGN KEY([MaTK])
REFERENCES [dbo].[Accounts] ([MaTK])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_Accounts_Kh]
GO
ALTER TABLE [dbo].[Tour]  WITH CHECK ADD  CONSTRAINT [FK_TOUR_HDV] FOREIGN KEY([Huo_MaHDV])
REFERENCES [dbo].[HuongDanVien] ([MaHDV])
GO
ALTER TABLE [dbo].[Tour] CHECK CONSTRAINT [FK_TOUR_HDV]
GO
ALTER TABLE [dbo].[Tour]  WITH CHECK ADD  CONSTRAINT [fk_Tour_LoaiTour] FOREIGN KEY([MaLoaiTour])
REFERENCES [dbo].[LoaiTour] ([MaloaiTour])
GO
ALTER TABLE [dbo].[Tour] CHECK CONSTRAINT [fk_Tour_LoaiTour]
GO
ALTER TABLE [dbo].[ThanhVien]  WITH CHECK ADD  CONSTRAINT [FK_Doan_KH] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KhachHang] ([MaKhach])
GO
ALTER TABLE [dbo].[ThanhVien] CHECK CONSTRAINT [FK_Doan_KH]
GO
ALTER TABLE [dbo].[ThanhVien]  WITH CHECK ADD  CONSTRAINT [fk_Tour] FOREIGN KEY([MaTour])
REFERENCES [dbo].[Tour] ([MaTour])
GO
ALTER TABLE [dbo].[ThanhVien] CHECK CONSTRAINT [fk_Tour]
GO
ALTER TABLE [dbo].[VeMayBay]  WITH CHECK ADD  CONSTRAINT [FK_VeMayBay_LoaiVe] FOREIGN KEY([MaLoaiVe])
REFERENCES [dbo].[LoaiVe] ([MaLoaiVe])
GO
ALTER TABLE [dbo].[VeMayBay] CHECK CONSTRAINT [FK_VeMayBay_LoaiVe]
GO
USE [master]
GO
ALTER DATABASE [QuanLyTour] SET  READ_WRITE 
GO
