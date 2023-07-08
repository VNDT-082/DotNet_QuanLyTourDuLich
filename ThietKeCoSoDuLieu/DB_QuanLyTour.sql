/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     06/11/2022 10:31:41 SA                       */
/*==============================================================*/

/*==============================================================*/
/* Database: QuanLyTour                                              */
/*==============================================================*/
create database QuanLyTour
use [QuanLyTour]
go
/*==============================================================*/
/* Table: Accounts                                              */
/*==============================================================*/
create table Accounts (
   MaTK                 int identity(1,1)    ,
   MaLoaiAcc            int                  not null,
   TenTK                nvarchar(100)        null,
   TenDangNhap          varchar(50)          null,
   MatKhau				varchar(30)			 null,
   SDT                  varchar(11)          null,
   Email                varchar(50)          null,
   constraint PK_ACCOUNTS primary key nonclustered (MaTK)
)
go
--alter table Accounts
--alter column SDT varchar(11) null;
alter table Accounts
alter column Email varchar(50) null;
--select*from accounts
/*==============================================================*/
/* Index: PhanLoaiAcc_FK                                        */
/*==============================================================*/
--create index PhanLoaiAcc_FK on Accounts (
--MaLoaiAcc ASC
--)
--go

/*==============================================================*/
/* Table: ChiTietChuongTrinh                                    */
/*==============================================================*/
create table ChiTietChuongTrinh (
   id                   int identity(1,1)    ,
   MaCTTour             varchar(10)          not null,
   Ngay                 int				     null,
   GioDi                time(0)			     null,
   GioDen               time(0)				 null,
   DiemKhoiHanh         nvarchar(100)		 null,
   DiemDen              nvarchar(100)        null,
   MoTa                 ntext				 null,
   HinhAnh              varchar(30)          null,
   constraint PK_CHITIETCHUONGTRINH primary key nonclustered (id)
)
go
alter table ChiTietChuongTrinh
add constraint FK_CHITIETC_CTTOUR_CH_CHUONGTR foreign key(MaCTTour) references ChuongTrinhTour(MaCTTour)

/*==============================================================*/
/* Table: ChuongTrinhTour                                       */
/*==============================================================*/
create table ChuongTrinhTour (
   MaCTTour             varchar(10)          not null,
   TenChuongTrinhTour   nvarchar(200)        null,
   constraint PK_CHUONGTRINHTOUR primary key (MaCTTour)
)
go

alter table ChuongTrinhTour
add constraint fk_CHUONGTRINHTOUR_Tour foreign key(MaCTTour) references Tour(MaTour)
go
/*==============================================================*/
/* Table: DatVe                                                 */
/*==============================================================*/
create table DatVe (
   MaKhach              varchar(10)             not null,
   MaTour               varchar(10)             not null,
   NgayDat				smalldatetime			not null,
   SoLuongVe            int						null,
   Tong					int						null,
   TrangThai int null default 0
   constraint PK_DATVE primary key (MaKhach, MaTour, NgayDat)
)
go
--alter table DatVe
--add TrangThai int null default 0
alter table DatVe
add NgayDi date null;
--select * from DatVe
--alter table DatVe
--add constraint PK_DATVE primary key (MaKhach, MaTour, NgayDat)
/*==============================================================*/
/* Table: DatVeMB                                               */
/*==============================================================*/
create table DatVeMB (
   MaVe                 varchar(10)             not null,
   MaKhach              varchar(10)             not null,
   SoLuong				int						null,
   Tong					int						null,
   constraint PK_DATVEMB primary key (MaVe, MaKhach)
)
go


/*==============================================================*/
/* Table: HuongDanVien                                          */
/*==============================================================*/
create table HuongDanVien (
   MaHDV                varchar(10)          not null,
   MaTK                 int                  null,
   MaLoai               int                  null,
   TenHDV               nvarchar(30)         null,
   GioiTinh				nvarchar(3)         null,
   SDT                  varchar(11)          null,
   NgayVaoLam           date                 null,
   CCCD                 varchar(12)          null,
   constraint PK_HUONGDANVIEN primary key nonclustered (MaHDV)
)
go
--alter table HuongDanVien
--alter column GioiTinh   nvarchar(3) null;
--select *from HuongDanVien
/*==============================================================*/
/* Table: KhachHang                                             */
/*==============================================================*/
create table KhachHang (
   MaKhach              varchar(10)          not null,
   MaTK                 int                  null,
   TenKhach             nvarchar(30)          null,
   NgaySinh             date                 null,
   SDT                  varchar(10)          null,
   constraint PK_KHACHHANG primary key nonclustered (MaKhach)
)
go
--alter table KhachHang
--alter column  TenKhach nvarchar(30) null;

/*==============================================================*/
/* Table: LoaiAccounts                                          */
/*==============================================================*/
create table LoaiAccounts (
   MaLoaiAcc            int identity(1,1)    ,
   TenLoaiAcc           nvarchar(30)         null,
   constraint PK_LOAIACCOUNTS primary key nonclustered (MaLoaiAcc)
)
go

/*==============================================================*/
/* Table: LoaiHDV                                               */
/*==============================================================*/
create table LoaiHDV (
   MaLoai               int identity(1,1)       ,
   TenLoai              nvarchar(200)            null,
   constraint PK_LOAIHDV primary key nonclustered (MaLoai)
)
go

--alter table LoaiHDV
--alter COLUMN TenLoai nvarchar(200) null;
/*==============================================================*/
/* Table: LoaiVe                                                */
/*==============================================================*/
create table LoaiVe (
   MaLoaiVe             int identity(1,1)       ,
   TenLoaiVe            nvarchar(100)           null,
   constraint PK_LOAIVE primary key nonclustered (MaLoaiVe)
)
go

/*==============================================================*/
/* Table: ThanhVien                                             */
/*==============================================================*/
create table ThanhVien (
   MaThanhVien          int identity(1,1)       ,
   MaKhach              varchar(10)             not null,
   TenThanhVien         nvarchar(30)            null,
   GioiTinh             bit						null,
   NgaySinh             date					null,
   CCCD                 varchar(12) 			null,
   constraint PK_THANHVIEN primary key nonclustered (MaThanhVien)
)
go

--select *from DatVe
--select *from ThanhVien
--alter table ThanhVien
--add constraint fk_Tour foreign key(MaTour) references Tour(MaTour);
/*==============================================================*/
/* Table: Tour                                                  */
/*==============================================================*/
create table Tour (
   MaTour               varchar(10)             not null,
   MaCTTour             int						not null,
   Huo_MaHDV            varchar(10)             null,
   TenTour              nvarchar(200)           null,
   DiaDiem              nvarchar(200)           null,
   ChiPhi               int						null,
   AnhBia               varchar(30)             null,
   constraint PK_TOUR primary key nonclustered (MaTour)
)
go

/*==============================================================*/
/* Index: HDV_Tour_FK                                           */
/*==============================================================*/
--create index HDV_Tour_FK on Tour (
--Huo_MaHDV ASC
--)
--go

/*==============================================================*/
/* Table: VeMayBay                                              */
/*==============================================================*/
create table VeMayBay (
   MaVe                 varchar(10)             not null,
   MaLoaiVe             int						null,
   TenVe                nvarchar(200)           null,
   NgayDi               date					null,
   NgayDen              date					null,
   GioDi                time(0)					null,
   GioiDen              time(0)					null,
   SanBayDi             nvarchar(100)           null,
   SanBayDen            nvarchar(100)           null,
   Gia					int						null,
   constraint PK_VEMAYBAY primary key nonclustered (MaVe)
)
go

create table LoaiTour(
	MaloaiTour int identity(1,1) not null,
	TenLoaiTour nvarchar(30)		null,
	constraint pk_LoaiTour primary key(MaLoaiTour)
)
alter table Tour
add MaLoaiTour int null;
alter table Tour
add constraint fk_Tour_LoaiTour foreign key(MaLoaiTour) references LoaiTour(MaLoaiTour)
--alter table VeMayBay
--alter COLUMN GioDi time(0) null;
--alter table VeMayBay
--alter COLUMN GioiDen time(0) null;
--===================================================================
create table GioiTinh
(
	MaGioiTinh int not null,
	TenGioiTinh nvarchar(3) null,
	constraint pk_gioiTinh primary key(MaGioiTinh)
)
insert into GioiTinh values
(1,N'Nam'),
(0,N'Nữ')
/*==============================================================*/
/* Index: Ve_LoaiVe_FK                                          */
/*==============================================================*/
--create index Ve_LoaiVe_FK on VeMayBay (
--MaLoaiVe ASC
--)
--go

alter table Accounts
   add constraint FK_PhanLoaiAccount foreign key (MaLoaiAcc)
      references LoaiAccounts (MaLoaiAcc)
go

ALTER TABLE Accounts
ADD CONSTRAINT unique_Accounts UNIQUE (TenDangNhap)
go

alter table ChiTietChuongTrinh
   add constraint FK_CHITIETC_CTTOUR_CH_CHUONGTR foreign key (MaCTTour)
      references ChuongTrinhTour (MaCTTour)
go

alter table DatVe
   add constraint FK_KH_DatVe foreign key (MaKhach)
      references KhachHang (MaKhach)
go

alter table DatVe
   add constraint FK_Tour_DatVe foreign key (MaTour)
      references Tour (MaTour)
go

alter table DatVeMB
   add constraint FK_VeMayBay_Datve foreign key (MaVe)
      references VeMayBay (MaVe)
go

alter table DatVeMB
   add constraint FK_KH_DatVeMB foreign key (MaKhach)
      references KhachHang (MaKhach)
go

alter table HuongDanVien
   add constraint FK_Accounts_HDV foreign key (MaTK)
      references Accounts (MaTK)
go

alter table HuongDanVien
   add constraint FK_HDV_LoaiHDV foreign key (MaLoai)
      references LoaiHDV (MaLoai)
go

alter table KhachHang
   add constraint FK_Accounts_Kh foreign key (MaTK)
      references Accounts (MaTK)
go

alter table ThanhVien
   add constraint FK_Doan_KH foreign key (MaKhach)
      references KhachHang (MaKhach)
go

alter table Tour
   add constraint FK_TOUR_HDV foreign key (Huo_MaHDV)
      references HuongDanVien (MaHDV)
go

alter table Tour
   add constraint FK_CTTour_Tour foreign key (MaCTTour)
      references ChuongTrinhTour (MaCTTour)
go

alter table VeMayBay
   add constraint FK_VeMayBay_LoaiVe foreign key (MaLoaiVe)
      references LoaiVe (MaLoaiVe)
go


--them du lieu cho bang loai accounts
insert into LoaiAccounts(TenLoaiAcc) values
( N'Quản trị viên'),
(N'Khách'),
(N'Nhân viên')
--select *from LoaiAccounts


--them du lieu cho bang loai Huong dan vien
insert into LoaiHDV(TenLoai) values
(N'hướng dẫn viên chuyên nghiệp'), 
(N'hướng dẫn viên không chuyên nghiệp, công tác viên'),
(N'hướng dẫn viên tại điểm'),
(N'hướng dẫn viên suốt tuyến'),
(N'hướng dẫn viên thành phố')
go
--select *from LoaiHDV

--them du lieu cho loai ve may bay
insert into LoaiVe( TenLoaiVe) values
	(N'Vé hạng nhất'),
	(N'Vé hạng thương gia'),
	(N'Vé hạng phổ thông đặc biệt'),
	(N'Vé hạng phổ thông')
go
--select*from LoaiVe
insert into VeMayBay values
('V01',1,N'Tp.Hồ Chí Minh-Khánh Hòa','2022-11-06','2022-11-06','08:35:00','09:45:00',
N'Sân bay Quốc tế Tân Sơn Nhất',N'Sân bay Quốc tế Cam Ranh',692000),
('V02',2,N'Việt Nam-Hàn Quốc','2022-11-10','2022-11-10','12:15:00','19:35:00',
N'Sân bay Quốc tế Tân Sơn Nhất',N'Incheon International Airport',1965000),
('V03',3,N'Việt Nam-Nhật Bản','2022-11-16','2022-11-16','02:35:00','09:45:00',
N'Sân bay Quốc tế Tân Sơn Nhất',N'Tokyo - Narita (NRT), Nhật Bản',8560000),
('V04',4,N'Tp.Hồ Chí Minh-Khánh Hòa','2022-11-06','2022-11-06','08:35:00','09:45:00',
N'Sân bay Quốc tế Tân Sơn Nhất',N'Sân bay Quốc tế Cam Ranh',692000),
('V05',2,N'Hà Nội-Đà Nẵng','2022-11-06','2022-11-06','08:35:00','09:45:00',
N'Sân bay Quốc tế Tân Sơn Nhất',N'Sân bay Quốc tế Cam Ranh',692000)
select*from VeMayBay


--Them du lieu cho account
insert into Accounts values
(1,N'Võ Nguyễn Duy Tân','vonguyenduytan','03845778323','tan@gmail.com','123'),
(3,N'Nguyễn Văn A','nguyenvana','03845778324','a@gmail.com','456'),
(2,N'Nguyễn Đức Hữu','nguyenduchuu','03845778325','huu@gmail.com','789'),
(2,N'Lê Sin','lesin','0937584634','sin@gmail.com','789'),
(2,N'Báo Đời Đầu','baodoidau','0336363323','bao@gmail.com','quyettambao'),
(2,N'Muốn Qua Môn','account_06','03845778327','acc06@gmail.com','789'),

(3,N'Nguyễn Văn B','nguyenvanb','09845778321','b@gmail.com','456'),
(3,N'Nguyễn Văn C','nguyenvanc','09845778322','c@gmail.com','456'),
(3,N'Nguyễn Văn D','nguyenvand','09845778323','d@gmail.com','456'),
(3,N'Nguyễn Văn E','nguyenvane','09845778324','e@gmail.com','456'),
(3,N'Nguyễn Văn F','nguyenvanf','09845778325','f@gmail.com','456')
--select *from Accounts
--update Accounts
--set Email='tanVnd@gmail.com'
--where MaTK=3
--them du lieu vao bang Huong Dan Vien
insert into HuongDanVien values
('HDV01',4,5,N'Vương Hạo',N'Nam','0733887555','2016-02-27','375202016738'),
('HDV02',9,8,N'Heuristic',N'Nam','0733887556','2018-04-20','463202012365'),
('HDV03',10,8,N'Robinson',N'Nam','0733887557','2020-01-29','533202013253'),
('HDV04',11,7,N'Ngọc Hiếu',N'Nữ','0733887558','2019-08-12','346202011724'),
('HDV05',12,6,N'Marie Curie',N'Nữ','0733887559','2011-10-30','932202018253'),
('HDV06',13,9,N'Minh Vương',N'Nam','0733887550','2022-11-01','692202016397')

set dateformat dmy
insert into HuongDanVien values
('HDV07',13,9,N'Minh Vương',N'Nam','0733887550','30-01-2020','692202016397')


--select*from HuongDanVien
update HuongDanVien
set MaHDV='HDV06',
MaTK=13,MaLoai=9,TenHDV=N'Minh Vương',GioiTinh=N'Nam',NgayVaoLam='2022-07-23',CCCD='692202016394'
where MaHDV='HDV06';


--them du lieu cho bang khach hang
insert into KhachHang values
('KH01',5,N'Nguyễn Đức Hữu','2002-01-01','0384578325'),
('KH02',6,N'Lê Sin','2002-01-01','0937584634')


insert into KhachHang(MaKhach,TenKhach,NgaySinh,SDT) values
('KH03',N'Nguyễn Hữu X','2002-01-01','0384978329'),
('KH04',N'Trần Văn H','2002-01-01','0937584634'),
('KH05',N'Trần Thi Y','2002-01-01','0937584634'),
('KH06',N'Võ Thị Bé','2002-01-01','0937584634'),
('KH07',N'Hoàng Thị Em','2002-01-01','0937584634'),
('KH08',N'Huỳnh Thị V','2002-01-01','0937584634')

--select*from KhachHang

--them du lieu bao bang chuong trinh tour
--nuoc ngoai
insert into ChuongTrinhTour values
(N'Tour Nhật Bản 7N6Đ: Cung Đường Vàng - Hành Trình Mùa Thu'),
(N'Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung'),
(N'Tour Nhật Bản 4N4Đ: Tokyo - Thiên Đường Mùa Thu'),
(N'Tour Nam Phi 8N7Đ: Cape Town - Sun City - Pretoria - Mùa Hoa Phượng Tím'),
(N'Tour Thái Lan 5N4Đ: Bangkok - Muong Boran - Nong Nooch - Pattaya'),
(N'Tour Cao Cấp Dubai 5N4Đ: Tháp Burj - Sa Mạc Safari - Đảo Cọ Nhân Tạo - City Tour'),
(N'Tour Tết Quý Mão 5N4Đ: Trải Nghiệm Hai Quốc Gia Singapore - Malaysia')
--viet nam
insert into ChuongTrinhTour values
(N'Tour Tây Bắc 4N3Đ: Mộc Châu - Sơn La - Điện Biên - Lai Châu - SaPa'),
(N'Tour Đà Lạt 3N3D: Tà Đùng - Đà Lạt Wonder Resort 4 Sao'),
(N'Tour Tây Nguyên 3N3Đ: Măng Đen - Kon Tum - Gia Lai - Buôn Mê - Tà Đùng'),
(N'Tour Tết Huế 4N3Đ: Đà Nẵng - Hội An - Bà Nà - Huế'),
(N'Tour Nam Du 3N3Đ: Quần Đảo Nam Du - Hòn Củ Tron Xe Giường Nằm'),
(N'Tour Tết Phú Quốc 3N2Đ: Grand World - Hòn Thơm - Địa Trung Hải'),
(N'Tour Tết Quý Mão Đà Lạt 3N3Đ: Thành Phố Bốn Mùa Hoa'),
(N'Tour Tết Đà Nẵng 4N3Đ: Hội An - Rừng Dừa Bảy Mẫu - Bà Nà'),
(N'Tour Tết Đà Nẵng 3N2Đ: Hội An - Rừng Dừa Bảy Mẫu - Bà Nà')

--select*from ChuongTrinhTour

--them du lieu vao bang chi tiet chuong trinh tour
--Tour Nhật Bản 7N6Đ: Cung Đường Vàng - Hành Trình Mùa Thu
delete ChiTietChuongTrinh
insert into ChiTietChuongTrinh values
(1,1,'20:00','06:55',N'SÀI GÒN',N'TOKYO',
N'Hướng dẫn Viên công ty đón quý khách tại Tân Sơn Nhất, làm thủ tục cho 
quý khách bay đi Nhật Bản trên chuyến bay SGN - HND. Quý khách dùng bữa 
sáng trên máy bay của hãng hàng không 5***** All Nippon Airways – Nhật Bản. 
Quý khách cần có: Xác nhận Vaccine COVID -19 03 mũi tiêm chủng theo quy định
(tiếng Anh hoặc song ngữ)','h0.png'),
(1,2,'06:55','09:30',N'TOKYO',N'OSAKA',
N'Đến Tokyo, đoàn đáp sân bay Haneda - một trong những sân bay lớn và nhộn
nhịp nhất thế giới cũng như khu vực châu Á. HDV địa phương đón Quý đoàn và 
bắt đầu chuyến hành trình khám phá “Đất nước mặt trời mọc”.
- Đền Meiji-jingu ngôi đại đền Thần đạo này là nơi dành riêng cho 
Thiên hoàng Minh Trị (1852 – 1912) vị thiên hoàng đầu tiên của Nhật Bản hiện đại.','h2.png'),
(1,2,'09:30','11:59',N'TOKYO',N'OSAKA',
N'- Hoàng Cung Tokyo Imperial Palace là nơi hoàng gia Nhật Bản sinh sống 
và làm việc trong suốt hai thế kỷ qua (tham quan và chụp ảnh bên ngoài). 
Nằm ngay phía trước là cây cầu Nijubashi (Nhị Trọng Kiều) hay còn gọi là 
cầu Mắt kính (Meganebashi) vì nhìn từ xa sẽ thấy hình dạng cầu khá giống 
cặp mắt kiếng đeo mắt.','h3.png'),
(1,2,'12:30','23:59',N'TOKYO',N'OSAKA',
N'Trưa: Đoàn dùng bữa trưa tại nhà hàng địa phương và tiếp tục di chuyển 
đến ga Tokyo. Đoàn khởi hành đi Osaka với khoảng thời gian cực ngắn nhờ 
tàu siêu tốc Shinkansen - một trong những phương tiện tốt nhất và nhanh 
nhất để đi qua các thành phố lớn của Nhật Bản. Đến Osaka, xe đón đoàn về 
khách sạn, nhận phòng.
Tự do mua sắm thả ga tại Shinsaibashi – phố mua sắm nổi tiếng nhất
ở khu Shisaibashi Suji, thành phố Osaka. Đây là một khu phức hợp tập trung 
với đủ các mặt hàng kinh doanh, trung tâm mua sắm này trải dài vô tận hết
cả một con đường với hàng trăm cửa hàng kinh doanh sầm uất.
Tối: Đoàn dùng bữa tối tại nhà hàng địa phương. Nghỉ đêm tại Osaka.','h5.png'),
(1,3,'06:30','12:30',N'OSAKA',N'KYOTO – GIFU',
N'Sáng: Đoàn dùng điểm tâm sáng tại khách sạn, làm thủ tục trả phòng. 
Sau đó khởi hành đi tham quan:
- Lâu đài Osaka tọa lạc trên một ngọn đồi được bao quanh bởi một công viên 
khổng lồ với vô vàn những cây anh đào, mơ và mận, thảm thực vật phong phú 
nơi đây hứa hẹn mang đến cảnh quan đẹp mắt trong cả mùa thu lẫn mùa xuân.','h6.png'),
(1,3,'13:00','23:59',N'OSAKA',N'KYOTO – GIFU',
N'Trưa: Đoàn dùng bữa trưa và tiếp tục đi đến Kyoto tham quan:
- Rừng tre Arashiyama - một trong những thắng cảnh hàng đầu của Kyoto
- Chùa vàng Kinkaku-ji được UNESCO công nhận là Di sản Văn hóa thế giới, 
ngôi chùa được phủ mạ vàng 24k, du khách sẽ choáng ngợp trước sắc vàng lấp 
lành của ngôi chùa cổ kính này được mệnh danh là xa hoa bậc nhất tại Kyoto.
Chiều: Đoàn di chuyển đến Gifu và dùng bữa tối tại nhà hàng địa phương, 
tự do khám phá Gifu về đêm.
Nghỉ đêm tại Gifu.','h8.png')

--Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung
insert into ChiTietChuongTrinh values
(2,1,'21:00','05:40',N'TPHCM',N' INCHEON',
N'Tối: Quý khách có mặt tại sân bay Tân Sơn Nhất ga đi quốc tế. Trưởng Đoàn
hướng dẫn làm thủ tục check in chuyến bay VJ864 đi Hàn Quốc
(Nghỉ đêm trên máy bay).
Quý khách cần có xác nhận vaccine 2 mũi và giấy test PCR âm tính Việt Nam','h0.png'),
(2,2,'07:00','11:59',N'SEOUL',N'THÁP NAMSAN',
N'Đoàn đáp sân bay Incheon. Trưởng đoàn hỗ trợ quý khách làm thủ tục test
PCR Covid để nhập cảnh Hàn Quốc. Xe và HDV đón đoàn đi ăn sáng sau đó bắt
đầu chuyến tham quan đất nước Hàn Quốc xinh đẹp.
- Tháp NamSan – tọa lạc trên núi Namsan mang đến cho du khách những góc nhìn 
toàn cảnh thủ đô, cùng gắn khóa tình yêu và chụp ảnh cực đẹp. 
(Phí thang máy lên tháp tự túc)','h9.png'),
(2,2,'13:00','23:59',N'SEOUL',N'THÁP NAMSAN',
N'Trưa: Đoàn dùng cơm tại nhà hàng địa phương, sau đó tham quan:
- Quảng trường Gwanghwamun – Seoul quy hoạch nơi này thành điểm nhấn chính
cho thành phố, giống như đại lộ Champ-Élysées ở Paris
19h00: Đoàn dùng cơm tối và về khách sạn nghỉ ngơi, Tự do khám phá Seoul
về đêm.','h10.png'),
(2,3,'07:00','11:59',N'Gyeonggi-do',N'CÔNG VIÊN EVERLAND',
N'Sáng: Quý khách dùng điểm tâm sáng tại khách sạn. 
Bắt đầu chương trình tham quan:
- Cung điện Gyeongbokgung (Cảnh Phúc Cung) – cung điện nằm ở phía bắc 
của thủ đô Seoul, được xây dựng vào năm 1395 dưới triều vua Taejo thuộc 
triều đại Joseon, kiến trúc cực đẹp.','h11.png'),
(2,3,'13:00','23:59',N'SEOUL',N'CÔNG VIÊN EVERLAND ',
N'Trưa: Đoàn dùng cơm tại nhà hàng địa phương, sau đó tham quan:
- Bảo tàng Dân gian Quốc gia Hàn Quốc là nơi trưng bày các vật dụng trong
đời sống hàng ngày và văn hóa dân gian của người Hàn Quốc từ thời cổ đại 
đến nay.
- Blue House (Phủ Tổng Thống Hàn Quốc hay còn gọi là Nhà Xanh) – tọa lạc 
tại trung tâm thủ đô Seoul. Đây là nơi sinh sống và làm việc của 
Tổng Thống đương nhiệm Hàn Quốc (chụp hình bên ngoài)
Tối: Đoàn dùng bữa tối tại nhà hàng địa phương, tự do khám phá Seoul về đêm.','h12.png'),
(2,4,'07:00','11:59',N'SEOUL',N' NAMI',
N'Sáng: Quý khách dùng bữa sáng tại khách sạn. Đoàn tham quan mua sắm:
- Cửa hàng mỹ phẩm nội địa Hàn Quốc.
- Cửa hàng nhân sâm Chính Phủ, cửa hàng miễn thuế Duty Free.
- Trải nghiệm làm Kimchi – mặc đồ Hanbok.','h13.png'),
(2,4,'13:00','16:59',N'SEOUL',N' NAMI',
N'Trưa: Đoàn dùng bữa trưa tại nhà hàng địa phương, tham quan:
- Đảo Nami – Nổi tiếng với những tán lá phông đỏ rực một góc trời cùng 
hàng ngân hạnh vàng rực, thẳng tắp đã từng xuất hiện trong bộ phim 
“Bản tình ca mùa Đông”.','h14.png'),
(2,4,'17:00','23:59',N'SEOUL',N' NAMI',
N'Tối: Dùng buổi tối tại nhà hàng địa phương.
Sau đó ghé Chợ GwangJang hoặc Chợ Myeongdong: tham quan, mua sắm 
đến giờ hẹn, xe đón quý khách về lại khách sạn nghỉ ngơi.
Ngày cuối trở về Thành phố Hồ Chí Minh.','h15.png')
--select * from ChiTietChuongTrinh





--them du lieu cho bang thanh vien
insert into ThanhVien values 
('KH01',N'Nguyễn Thị Tuyết Nhung',0,'2002-07-10','375202016739','T01'),
('KH01',N'Nguyễn Thị Lài',0,'2002-08-11','305202016738','T01'),
('KH01',N'Nguyễn Đăng Khoa',1,'2002-12-22','101202019573','T01'),
('KH01',N'Nguyễn Thuý Ngần',0,'2002-04-25','407202015635','T02'),
('KH02',N'Phạm Quốc Anh',1,'2001-06-21','503202019267','T02'),
('KH02',N'Trần Trung Hiếu',1,'2000-11-19','708202019273','T02'),
('KH02',N'Huỳnh Thị Lệ Xuân',0,'2003-03-04','007202019372','T01')

--select*from ThanhVien
--select *
--from ThanhVien
--where MaKhach='kh01'
insert into LoaiTour values
(N'Tour trong nước'),
(N'Tour châu á'),
(N'Tour châu âu'),
(N'Tour châu phi'),
(N'Tour châu úc'),
(N'Tour châu mĩ')


--them du lieu vao bang tour
insert into Tour values
('T01',1,'HDV01',N'Tour Nhật Bản 7N6Đ: Cung Đường Vàng - Hành Trình Mùa Thu',N'Nhật Bản',39990000,'h1.png'),
('T02',2,'HDV02',N'Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung',N'Hàn Quốc',13990000,'h7.png')
 update Tour
 set MaLoaiTour=2
 where MaTour='T01' or MaTour='T02'
--select *from LoaiTour
select *from Accounts
select*from KhachHang
select *from LoaiAccounts
select *from DatVe
select*from ThanhVien
select*from Tour
where MaLoaiTour=2;
select * from Tour
select * from ChuongTrinhTour
where MaCTTour=1;
delete Accounts
where MaTK=56
delete KhachHang
where MaKhach= 'KH08'

set dateformat dmy
insert into DatVe values ('KH07', 'T02', 1,24890000, GETDATE(),'27/02/2023',24890000)

set dateformat dmy
delete DatVe
where MaKhach='KH07'
and MaTour='T05'
and NgayDat='18/12/2022 15:36:00'

select*from ChiTietChuongTrinh

set dateformat mdy  
insert into DatVe(MaKhach,MaTour,SoLuongVe,Tong,NgayDat,NgayDi,GiaVe) 
values ('KH04', 'T02', 2,30000000, GETDATE(),'01/28/2023',15000000)


select id,Ngay from ChiTietChuongTrinh where MaCTTour='T01' and Ngay=3
select*from ChiTietChuongTrinh where id=5
select id as'MaChiTiet', Ngay from ChiTietChuongTrinh where MaCTTour = 'T04' and Ngay = 1;
--++++++
delete ChuongTrinhTour
delete Tour
alter table Tour
drop column MaCTTour
---=====
set dateformat mdy 
insert into DatVe values ('KH04', 'T06', 2,58580000, GETDATE(),'20/12/2022',29290000)

select dv.MaTour,t.TenTour, dv.NgayDat 
from DatVe dv, Tour t 
where dv.MaKhach = 'KH02'and t.MaTour = dv.MaTour
select *from Accounts
select *from KhachHang
select *from ChuongTrinhTour

select *from Tour
select *from ChuongTrinhTour
select *from ChiTietChuongTrinh
select ctt.MaCTTour,ctt.Ngay, count(ctt.Ngay) as'SoLuong'
from ChiTietChuongTrinh ctt,Tour t where ctt.MaCTTour = t.MaTour and t.MaTour = 'T06' 
group by ctt.Ngay, ctt.MaCTTour order by ctt.Ngay

select ctt.id, ctt.MaCTTour, ctt.Ngay, ctt.GioDi, ctt.GioDen,  ctt.DiemKhoiHanh, ctt.DiemDen, ctt.MoTa, ctt.HinhAnh 
from ChiTietChuongTrinh ctt, Tour t 
where t.MaTour = ctt.MaCTTour and t.MaTour = 'T06' and ctt.Ngay=1;



select *from ThanhVien

select*from KhachHang where MaKhach='kh01';
select* from KhachHang where MaTK = ;
	select ctt.id,ctt.MaCTTour,ctt.Ngay,ctt.GioDi,ctt.GioDen,ctt.DiemKhoiHanh,ctt.DiemDen,ctt.MoTa,ctt.HinhAnh
	from ChiTietChuongTrinh ctt, Tour t
	where t.MaCTTour=ctt.MaCTTour
	and t.MaTour='T02' and ctt.Ngay=1
select ctt.MaCTTour,count(ctt.Ngay) as'Ngay'
from ChiTietChuongTrinh ctt,Tour t
where ctt.MaCTTour=t.MaCTTour and t.MaTour='T01'
group by ctt.Ngay, ctt.MaCTTour
order by Ngay

select ctt.id, ctt.MaCTTour, ctt.Ngay, ctt.GioDi, ctt.GioDen, 
ctt.DiemKhoiHanh, ctt.DiemDen, ctt.MoTa, ctt.HinhAnh
from ChiTietChuongTrinh ctt, Tour t where t.MaCTTour = ctt.MaCTTour and t.MaTour = 'T01' and ctt.Ngay=1;
select *from ThanhVien
select *from GioiTinh

select *from DatVe
alter table DatVe
add GiaVe float null;
select*from ThanhVien
delete from DatVe
where MaKhach='KH02' and MaTour='T01' and  NgayDat= (select MAX(NgayDat) from DatVe
where MaKhach='KH02' and MaTour='T01')
select*from DatVe
select *from Tour
select dv.MaTour, TenTour, SoLuongVe, GiaVe, NgayDat, NgayDi, Tong, TrangThai from DatVe dv, Tour t where dv.MaTour=t.MaTour and dv.MaKhach='KH02'

select *from DatVe
select MAX(NgayDat) from DatVe
where MaKhach='KH02' and MaTour='T01'

delete from ThanhVien
where MaKhach='KH01' and MaTour='T01'

SET DATEFORMAT mdy
insert into ThanhVien values
('KH01',N'NGUYỄN THỊ THU',0,'03/17/2001','375202016539')

select *from KhachHang
select*from Tour
insert into Tour values
('MaTour','hdv','ten','dia diem',chphi,'hinhanh','malt')
delete Tour
where MaTour='';

update Tour
set Huo_MaHDV='', TenTour='', DiaDiem='', ChiPhi='', AnhBia='', MaLoaiTour=''
where MaTour='';
select *from ChuongTrinhTour
select *from ChiTietChuongTrinh
insert into ChuongTrinhTour values
('',N'')
insert into ChiTietChuongTrinh(MaCTTour) values
('')

update Tour 
set Huo_MaHDV = 'HDV02', 
TenTour = 'Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung', 
DiaDiem = 'Hàn Quốc', ChiPhi = '14990000', AnhBia = 'h7.png', MaLoaiTour = '2'
where MaTour = 'HDV02'; 


--===============================================================================================================
--===============================================================================================================

			-------INSERT DU LIEU BEN DUOI NHE BAN OYYY!!!

--===============================================================================================================
--===============================================================================================================
--===============================================================================================================

-----------------------------DA THEM----------------------------------
select * from Tour
select * from ChuongTrinhTour
select * from ChiTietChuongTrinh
SELECT *FROM LoaiTour
--THEM TOUR
insert into Tour values
('T01',1,'HDV01',N'Tour Nhật Bản 7N6Đ: Cung Đường Vàng - Hành Trình Mùa Thu',N'Nhật Bản',39990000,'h1.png'),
('T02',2,'HDV02',N'Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung',N'Hàn Quốc',13990000,'h7.png')
 
 --THEM CHU0ONG TRINH TOUR
 insert into ChuongTrinhTour values
('T01',N'Tour Nhật Bản 7N6Đ: Cung Đường Vàng - Hành Trình Mùa Thu'),
('T02',N'Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung')

--THEM CHI TIET CHUONG TRINH TOUR
insert into ChiTietChuongTrinh values
('T01',1,'20:00','06:55',N'SÀI GÒN',N'TOKYO',
N'Hướng dẫn Viên công ty đón quý khách tại Tân Sơn Nhất, làm thủ tục cho 
quý khách bay đi Nhật Bản trên chuyến bay SGN - HND. Quý khách dùng bữa 
sáng trên máy bay của hãng hàng không 5***** All Nippon Airways – Nhật Bản. 
Quý khách cần có: Xác nhận Vaccine COVID -19 03 mũi tiêm chủng theo quy định
(tiếng Anh hoặc song ngữ)','h0.png'),
('T01',2,'06:55','09:30',N'TOKYO',N'OSAKA',
N'Đến Tokyo, đoàn đáp sân bay Haneda - một trong những sân bay lớn và nhộn
nhịp nhất thế giới cũng như khu vực châu Á. HDV địa phương đón Quý đoàn và 
bắt đầu chuyến hành trình khám phá “Đất nước mặt trời mọc”.
- Đền Meiji-jingu ngôi đại đền Thần đạo này là nơi dành riêng cho 
Thiên hoàng Minh Trị (1852 – 1912) vị thiên hoàng đầu tiên của Nhật Bản hiện đại.','h2.png'),
('T01',2,'09:30','11:59',N'TOKYO',N'OSAKA',
N'- Hoàng Cung Tokyo Imperial Palace là nơi hoàng gia Nhật Bản sinh sống 
và làm việc trong suốt hai thế kỷ qua (tham quan và chụp ảnh bên ngoài). 
Nằm ngay phía trước là cây cầu Nijubashi (Nhị Trọng Kiều) hay còn gọi là 
cầu Mắt kính (Meganebashi) vì nhìn từ xa sẽ thấy hình dạng cầu khá giống 
cặp mắt kiếng đeo mắt.','h3.png'),
('T01',2,'12:30','23:59',N'TOKYO',N'OSAKA',
N'Trưa: Đoàn dùng bữa trưa tại nhà hàng địa phương và tiếp tục di chuyển 
đến ga Tokyo. Đoàn khởi hành đi Osaka với khoảng thời gian cực ngắn nhờ 
tàu siêu tốc Shinkansen - một trong những phương tiện tốt nhất và nhanh 
nhất để đi qua các thành phố lớn của Nhật Bản. Đến Osaka, xe đón đoàn về 
khách sạn, nhận phòng.
Tự do mua sắm thả ga tại Shinsaibashi – phố mua sắm nổi tiếng nhất
ở khu Shisaibashi Suji, thành phố Osaka. Đây là một khu phức hợp tập trung 
với đủ các mặt hàng kinh doanh, trung tâm mua sắm này trải dài vô tận hết
cả một con đường với hàng trăm cửa hàng kinh doanh sầm uất.
Tối: Đoàn dùng bữa tối tại nhà hàng địa phương. Nghỉ đêm tại Osaka.','h5.png'),
('T01',3,'06:30','12:30',N'OSAKA',N'KYOTO – GIFU',
N'Sáng: Đoàn dùng điểm tâm sáng tại khách sạn, làm thủ tục trả phòng. 
Sau đó khởi hành đi tham quan:
- Lâu đài Osaka tọa lạc trên một ngọn đồi được bao quanh bởi một công viên 
khổng lồ với vô vàn những cây anh đào, mơ và mận, thảm thực vật phong phú 
nơi đây hứa hẹn mang đến cảnh quan đẹp mắt trong cả mùa thu lẫn mùa xuân.','h6.png'),
('T01',3,'13:00','23:59',N'OSAKA',N'KYOTO – GIFU',
N'Trưa: Đoàn dùng bữa trưa và tiếp tục đi đến Kyoto tham quan:
- Rừng tre Arashiyama - một trong những thắng cảnh hàng đầu của Kyoto
- Chùa vàng Kinkaku-ji được UNESCO công nhận là Di sản Văn hóa thế giới, 
ngôi chùa được phủ mạ vàng 24k, du khách sẽ choáng ngợp trước sắc vàng lấp 
lành của ngôi chùa cổ kính này được mệnh danh là xa hoa bậc nhất tại Kyoto.
Chiều: Đoàn di chuyển đến Gifu và dùng bữa tối tại nhà hàng địa phương, 
tự do khám phá Gifu về đêm.
Nghỉ đêm tại Gifu.','h8.png')

--Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung
insert into ChiTietChuongTrinh values
('T02',1,'21:00','05:40',N'TPHCM',N' INCHEON',
N'Tối: Quý khách có mặt tại sân bay Tân Sơn Nhất ga đi quốc tế. Trưởng Đoàn
hướng dẫn làm thủ tục check in chuyến bay VJ864 đi Hàn Quốc
(Nghỉ đêm trên máy bay).
Quý khách cần có xác nhận vaccine 2 mũi và giấy test PCR âm tính Việt Nam','h0.png'),
('T02',2,'07:00','11:59',N'SEOUL',N'THÁP NAMSAN',
N'Đoàn đáp sân bay Incheon. Trưởng đoàn hỗ trợ quý khách làm thủ tục test
PCR Covid để nhập cảnh Hàn Quốc. Xe và HDV đón đoàn đi ăn sáng sau đó bắt
đầu chuyến tham quan đất nước Hàn Quốc xinh đẹp.
- Tháp NamSan – tọa lạc trên núi Namsan mang đến cho du khách những góc nhìn 
toàn cảnh thủ đô, cùng gắn khóa tình yêu và chụp ảnh cực đẹp. 
(Phí thang máy lên tháp tự túc)','h9.png'),
('T02',2,'13:00','23:59',N'SEOUL',N'THÁP NAMSAN',
N'Trưa: Đoàn dùng cơm tại nhà hàng địa phương, sau đó tham quan:
- Quảng trường Gwanghwamun – Seoul quy hoạch nơi này thành điểm nhấn chính
cho thành phố, giống như đại lộ Champ-Élysées ở Paris
19h00: Đoàn dùng cơm tối và về khách sạn nghỉ ngơi, Tự do khám phá Seoul
về đêm.','h10.png'),
('T02',3,'07:00','11:59',N'Gyeonggi-do',N'CÔNG VIÊN EVERLAND',
N'Sáng: Quý khách dùng điểm tâm sáng tại khách sạn. 
Bắt đầu chương trình tham quan:
- Cung điện Gyeongbokgung (Cảnh Phúc Cung) – cung điện nằm ở phía bắc 
của thủ đô Seoul, được xây dựng vào năm 1395 dưới triều vua Taejo thuộc 
triều đại Joseon, kiến trúc cực đẹp.','h11.png'),
('T02',3,'13:00','23:59',N'SEOUL',N'CÔNG VIÊN EVERLAND ',
N'Trưa: Đoàn dùng cơm tại nhà hàng địa phương, sau đó tham quan:
- Bảo tàng Dân gian Quốc gia Hàn Quốc là nơi trưng bày các vật dụng trong
đời sống hàng ngày và văn hóa dân gian của người Hàn Quốc từ thời cổ đại 
đến nay.
- Blue House (Phủ Tổng Thống Hàn Quốc hay còn gọi là Nhà Xanh) – tọa lạc 
tại trung tâm thủ đô Seoul. Đây là nơi sinh sống và làm việc của 
Tổng Thống đương nhiệm Hàn Quốc (chụp hình bên ngoài)
Tối: Đoàn dùng bữa tối tại nhà hàng địa phương, tự do khám phá Seoul về đêm.','h12.png'),
('T02',4,'07:00','11:59',N'SEOUL',N' NAMI',
N'Sáng: Quý khách dùng bữa sáng tại khách sạn. Đoàn tham quan mua sắm:
- Cửa hàng mỹ phẩm nội địa Hàn Quốc.
- Cửa hàng nhân sâm Chính Phủ, cửa hàng miễn thuế Duty Free.
- Trải nghiệm làm Kimchi – mặc đồ Hanbok.','h13.png'),
('T02',4,'13:00','16:59',N'SEOUL',N' NAMI',
N'Trưa: Đoàn dùng bữa trưa tại nhà hàng địa phương, tham quan:
- Đảo Nami – Nổi tiếng với những tán lá phông đỏ rực một góc trời cùng 
hàng ngân hạnh vàng rực, thẳng tắp đã từng xuất hiện trong bộ phim 
“Bản tình ca mùa Đông”.','h14.png'),
('T02',4,'17:00','23:59',N'SEOUL',N' NAMI',
N'Tối: Dùng buổi tối tại nhà hàng địa phương.
Sau đó ghé Chợ GwangJang hoặc Chợ Myeongdong: tham quan, mua sắm 
đến giờ hẹn, xe đón quý khách về lại khách sạn nghỉ ngơi.
Ngày cuối trở về Thành phố Hồ Chí Minh.','h15.png')




------------------------------------------------CHUA THEM-----------------------------
----------------------------------------------BAT DAU THEM TU DAY ------------------------------
------------DUA TREN PHAN CAU TRUC DA THEM BEN TREN NHE------------------------------------
---------------------------------------------------------------------------------------
--1.THEM TOUR TRUOC ___TOUR DUA VAO PHAN DU LIEU CUA PHAN CHUA THEM _____HOAC THEM KHAC CUNG DC
--2.SAU KHI THEM TOUR THI THEM CHUONG TRINH TOUR VA CUOI CUNG CHI TIET CHUONG TRINH TOUR
--3.THEM TOUR CHO DEU NHA 
--MOI LOAI TOUR THEM 2 3 TOUR DUOC ROI
-----------------------------------MAI YEU-----------------------------------------
 insert into ChuongTrinhTour values
(N'Tour Nhật Bản 7N6Đ: Cung Đường Vàng - Hành Trình Mùa Thu'),
(N'Tour Cao Cấp Hàn Quốc 4N4Đ: Seoul - Nami - Everland - Hoàng Cung'),
(N'Tour Nhật Bản 4N4Đ: Tokyo - Thiên Đường Mùa Thu'),
(N'Tour Nam Phi 8N7Đ: Cape Town - Sun City - Pretoria - Mùa Hoa Phượng Tím'),
(N'Tour Thái Lan 5N4Đ: Bangkok - Muong Boran - Nong Nooch - Pattaya'),
(N'Tour Cao Cấp Dubai 5N4Đ: Tháp Burj - Sa Mạc Safari - Đảo Cọ Nhân Tạo - City Tour'),
(N'Tour Tết Quý Mão 5N4Đ: Trải Nghiệm Hai Quốc Gia Singapore - Malaysia')
--viet nam
insert into ChuongTrinhTour values
(N'Tour Tây Bắc 4N3Đ: Mộc Châu - Sơn La - Điện Biên - Lai Châu - SaPa'),
(N'Tour Đà Lạt 3N3D: Tà Đùng - Đà Lạt Wonder Resort 4 Sao'),
(N'Tour Tây Nguyên 3N3Đ: Măng Đen - Kon Tum - Gia Lai - Buôn Mê - Tà Đùng'),
(N'Tour Tết Huế 4N3Đ: Đà Nẵng - Hội An - Bà Nà - Huế'),
(N'Tour Nam Du 3N3Đ: Quần Đảo Nam Du - Hòn Củ Tron Xe Giường Nằm'),
(N'Tour Tết Phú Quốc 3N2Đ: Grand World - Hòn Thơm - Địa Trung Hải'),
(N'Tour Tết Quý Mão Đà Lạt 3N3Đ: Thành Phố Bốn Mùa Hoa'),
(N'Tour Tết Đà Nẵng 4N3Đ: Hội An - Rừng Dừa Bảy Mẫu - Bà Nà'),
(N'Tour Tết Đà Nẵng 3N2Đ: Hội An - Rừng Dừa Bảy Mẫu - Bà Nà')

