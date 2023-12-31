USE [QLNS]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNV] [int] NULL,
	[maTrangThai] [varchar](50) NULL,
	[gioVaoLam] [datetime] NULL,
	[gioRaLam] [datetime] NULL,
	[tongSoGio] [int] NULL,
 CONSTRAINT [PK__ChamCong__3213E83F6CF0BF27] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nameCV] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DaoTao]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaoTao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNV] [int] NULL,
	[maTrangThai] [varchar](50) NULL,
	[idPbDaoTao] [int] NULL,
	[NgayDaoTao] [datetime] NULL,
	[NgayKetThucDT] [datetime] NULL,
	[NdDaoTao] [text] NULL,
 CONSTRAINT [PK__DaoTao__3213E83FE8BA5769] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HieuSuat]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HieuSuat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNV] [int] NULL,
	[noiDung] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDongLaoDong]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDongLaoDong](
	[idNV] [int] NOT NULL,
	[idLuong] [int] NULL,
	[idPB] [int] NULL,
	[maTrangThai] [varchar](50) NULL,
	[idCV] [int] NULL,
	[idVT] [int] NULL,
	[ngayLamViec] [datetime] NULL,
	[ngayKetThuc] [datetime] NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
	[deleted] [datetime] NULL,
 CONSTRAINT [PK_HopDongLaoDong] PRIMARY KEY CLUSTERED 
(
	[idNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyLuatAndKhenThuong]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyLuatAndKhenThuong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNV] [int] NULL,
	[maTrangThai] [varchar](50) NULL,
	[noiDung] [text] NULL,
 CONSTRAINT [PK__KyLuatAn__3213E83F8CF48620] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuLuong]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuLuong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNV] [int] NULL,
	[idLuong] [int] NULL,
	[idPTTT] [int] NULL,
	[soNgayNghi] [int] NULL,
	[noiDung] [text] NULL,
	[ngayThanhToan] [datetime] NULL,
	[maTrangThai] [varchar](50) NULL,
	[createdAt] [datetime] NULL,
	[updateAt] [datetime] NULL,
	[deleted] [datetime] NULL,
 CONSTRAINT [PK_LichSuLuong] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuNghiPhep]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuNghiPhep](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNV] [int] NULL,
	[idNghiPhep] [int] NULL,
	[noiDung] [ntext] NULL,
	[ngayNghi] [date] NULL,
	[ngayKetThucNghi] [date] NULL,
	[maTrangThai] [varchar](50) NULL,
	[createdAt] [datetime] NULL,
	[deleted] [datetime] NULL,
 CONSTRAINT [PK__NghiPhep__3213E83F521BAF72] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[idNV] [int] NOT NULL,
	[luongCB] [money] NULL,
	[phuCap] [money] NULL,
	[luongTong] [money] NULL,
 CONSTRAINT [PK__Luong__3213E83F23A56B53] PRIMARY KEY CLUSTERED 
(
	[idNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maNV] [varchar](255) NULL,
	[fistName] [nvarchar](255) NULL,
	[lastName] [nvarchar](255) NULL,
	[address] [nvarchar](255) NULL,
	[image] [nvarchar](255) NULL,
	[ngaySinh] [datetime] NULL,
	[trinhDo] [nvarchar](255) NULL,
	[chuyenNganh] [nvarchar](255) NULL,
	[idVitri] [int] NULL,
	[idCongViec] [int] NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[maStatus] [nvarchar](100) NULL,
 CONSTRAINT [PK__NhanVien__3213E83FDA810A26] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVienShip]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVienShip](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNV] [int] NULL,
	[idNNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomNhanVien]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNhanVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NULL,
	[noiDung] [ntext] NOT NULL,
 CONSTRAINT [PK__NhomNhan__3213E83F4DCFB09B] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNguoiQuanLi] [int] NULL,
	[namePB] [nvarchar](255) NULL,
	[duAnThamGia] [nvarchar](255) NULL,
	[soLuongNVTG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PTTT]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PTTT](
	[id] [money] NOT NULL,
	[name] [nvarchar](255) NULL,
 CONSTRAINT [PK__PTTT__3213E83FFE114845] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusNhanviens]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusNhanviens](
	[Ma] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_StatusNhanviens] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNghiPhep] [int] NULL,
	[createdAt] [datetime] NULL,
	[deleted] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[ma] [varchar](50) NOT NULL,
	[name] [nvarchar](255) NULL,
 CONSTRAINT [PK_TrangThai] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViTri]    Script Date: 10/19/2023 1:31:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViTri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nameVT] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231012080918_init', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231012081214_addIdentity', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231012081622_addTrangThaiInTableNhanVien', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231012104529_addGioiTinhInTableNhanVien', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231012113151_addUpdateNhanVienAndStatusNhanVien', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231012123320_update2', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231012162844_update3', N'7.0.11')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd44598bd-e149-42b6-bb08-e9da59cd6226', N'Admin', N'ADMIN', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'f752cb54-b2b8-4ace-bd7d-8b763cf7f664', N'User', N'USER', NULL)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0dd3d059-5c8e-43ab-baed-b90e590dec43', N'd44598bd-e149-42b6-bb08-e9da59cd6226')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0dd3d059-5c8e-43ab-baed-b90e590dec43', N'f752cb54-b2b8-4ace-bd7d-8b763cf7f664')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6a6ebd1b-55cd-4bfa-9c11-13462c551bc8', N'f752cb54-b2b8-4ace-bd7d-8b763cf7f664')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'98383fdc-6f63-47a1-861e-a6ce34c700a9', N'f752cb54-b2b8-4ace-bd7d-8b763cf7f664')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cc30edf5-7a81-4494-8d22-70b0dc95874b', N'f752cb54-b2b8-4ace-bd7d-8b763cf7f664')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd062b8fa-4e44-4605-af30-22752dde08c4', N'f752cb54-b2b8-4ace-bd7d-8b763cf7f664')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0dd3d059-5c8e-43ab-baed-b90e590dec43', N'admin', N'ADMIN', NULL, NULL, 0, N'AQAAAAIAAYagAAAAELH5I6gbwjpP5FH0yqu/pIfaX9Enz/qapid4nIyKdtADiSmEuSWjGdqB4jvSaHL/lg==', N'LOQXNNGXDHQXJCBBULZKEDOH7XEXMUAT', N'fe920128-8c19-4617-b001-dc1662a0c6c0', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6a6ebd1b-55cd-4bfa-9c11-13462c551bc8', N'joy3', N'JOY3', NULL, NULL, 0, N'AQAAAAIAAYagAAAAENsIX2nmqtF0eYIga4WwF3pWyd/LdtErNu9iUhN32ib0cjKVLxg29HWEgBWP7SYtDQ==', N'JDF44EF6G3T4LHHVVUHFS7SOYUHVE6GS', N'381aa6fe-91fe-4f7b-88c2-30277b66f513', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'98383fdc-6f63-47a1-861e-a6ce34c700a9', N'xxxcc', N'XXXCC', NULL, NULL, 0, N'AQAAAAIAAYagAAAAENjhSr1LQDLRKoY6/P+5riQCEswZJcpKT13q6IGlTt1QDAGZ+106RumtBG7Hsa2f1w==', N'42IFVCN3R7GVWLWMWNZIGOMJ4W55YKJJ', N'aaa97c0b-9541-481f-b936-3ba96532c698', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'cc30edf5-7a81-4494-8d22-70b0dc95874b', N'joyx', N'JOYX', NULL, NULL, 0, N'AQAAAAIAAYagAAAAEE5l6YGAUJinsB++L7qq+XPf2BgWWKZl9nyPiCaG3wd7mA+mWu5A32DcM6YHiEaSyw==', N'X3NCPE3XQDB5DZZLKHSQDKDO6LZ2YZPH', N'91e64fe2-0c32-4f10-8e3c-99380705fa04', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd062b8fa-4e44-4605-af30-22752dde08c4', N'nghiacc', N'NGHIACC', NULL, NULL, 0, N'AQAAAAIAAYagAAAAEKr72c/Ye8I1fkWjcRhsT2CPfmHP4pV76HR16J4TKCFya9zR5yEWx2sTmSmAKWqy0w==', N'I7CUXMOIZNBDPO433NKU74GQJFCZGVGO', N'160e8ccf-8505-404d-b8c5-000c52acc76c', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[CongViec] ON 

INSERT [dbo].[CongViec] ([id], [nameCV]) VALUES (1, N'Phân tích yêu c?u')
INSERT [dbo].[CongViec] ([id], [nameCV]) VALUES (2, N'Thiết kế hệ thống')
INSERT [dbo].[CongViec] ([id], [nameCV]) VALUES (3, N'Lập trình ứng dụng')
INSERT [dbo].[CongViec] ([id], [nameCV]) VALUES (4, N'Kỹ thuật phần mề')
INSERT [dbo].[CongViec] ([id], [nameCV]) VALUES (5, N'Quản lý dự án')
INSERT [dbo].[CongViec] ([id], [nameCV]) VALUES (6, N'Hỗ trợ khách hàng')
INSERT [dbo].[CongViec] ([id], [nameCV]) VALUES (7, N'Phát triển phần mềm')
INSERT [dbo].[CongViec] ([id], [nameCV]) VALUES (8, N'Tối ưu hóa')
INSERT [dbo].[CongViec] ([id], [nameCV]) VALUES (9, N'Kiểm thử phần mềm')
SET IDENTITY_INSERT [dbo].[CongViec] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([id], [maNV], [fistName], [lastName], [address], [image], [ngaySinh], [trinhDo], [chuyenNganh], [idVitri], [idCongViec], [GioiTinh], [maStatus]) VALUES (5, N'admin', N'Huu', N'Nghia', N'An Giang', N'nghia.jpg', CAST(N'2003-07-12T00:00:00.000' AS DateTime), N'Đại Học', N'KTPM', 1, 1, NULL, N'CV1')
INSERT [dbo].[NhanVien] ([id], [maNV], [fistName], [lastName], [address], [image], [ngaySinh], [trinhDo], [chuyenNganh], [idVitri], [idCongViec], [GioiTinh], [maStatus]) VALUES (6, N'joyx1', N'Huỳnh', N'Hữu Nghĩa', N'An Giang', N'z4348278517416_106b82e0e4c3a88c0a050637a0f3d182.jpg', CAST(N'2003-12-07T00:00:00.000' AS DateTime), N'Thạc sĩ', N'Công nghệ thông tin', 2, 7, N'Nam', N'CV1')
INSERT [dbo].[NhanVien] ([id], [maNV], [fistName], [lastName], [address], [image], [ngaySinh], [trinhDo], [chuyenNganh], [idVitri], [idCongViec], [GioiTinh], [maStatus]) VALUES (7, N'joyX', N'Huỳnh', N'Hữu Nghĩa', N'An Giang', N'WIN_20230528_23_07_43_Pro.jpg', CAST(N'2003-12-07T00:00:00.000' AS DateTime), N'Cử nhân', N'Trí tuệ nhân tạ', 4, 7, N'Nam', N'CV2')
INSERT [dbo].[NhanVien] ([id], [maNV], [fistName], [lastName], [address], [image], [ngaySinh], [trinhDo], [chuyenNganh], [idVitri], [idCongViec], [GioiTinh], [maStatus]) VALUES (8, N'joyx2', N'Sơn ', N'Tùng', N'Thái Bình', N'z4348278517416_106b82e0e4c3a88c0a050637a0f3d182.jpg', CAST(N'1999-12-09T00:00:00.000' AS DateTime), N'Thạc sĩ', N'Kỹ thuật phần mềm', 2, 7, N'Nam', N'CV1')
INSERT [dbo].[NhanVien] ([id], [maNV], [fistName], [lastName], [address], [image], [ngaySinh], [trinhDo], [chuyenNganh], [idVitri], [idCongViec], [GioiTinh], [maStatus]) VALUES (9, N'admin1', N'Huỳnh', N'Hữu Nghĩa', N'An Giang', N'z4348278517416_106b82e0e4c3a88c0a050637a0f3d182.jpg', CAST(N'2003-12-07T00:00:00.000' AS DateTime), N'Tiến sĩ', N'Công nghệ thông tin', 2, 6, N'Nam', N'CV1')
INSERT [dbo].[NhanVien] ([id], [maNV], [fistName], [lastName], [address], [image], [ngaySinh], [trinhDo], [chuyenNganh], [idVitri], [idCongViec], [GioiTinh], [maStatus]) VALUES (10, N'joyx3', N'Huỳnh', N'Hữu Nghĩa', N'An Giang', N'z4348278517416_106b82e0e4c3a88c0a050637a0f3d182.jpg', CAST(N'2003-12-02T00:00:00.000' AS DateTime), N'Cử nhân', N'Kỹ thuật phần mềm', 1, 4, N'Nam', N'CV1')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[NhomNhanVien] ON 

INSERT [dbo].[NhomNhanVien] ([id], [name], [noiDung]) VALUES (1, N'Nhóm Phát tri?n A', N'D? án A')
INSERT [dbo].[NhomNhanVien] ([id], [name], [noiDung]) VALUES (2, N'Nhóm Phát tri?n B', N'D? án B')
INSERT [dbo].[NhomNhanVien] ([id], [name], [noiDung]) VALUES (3, N'Nhóm Ki?m th?', N'D? án C')
INSERT [dbo].[NhomNhanVien] ([id], [name], [noiDung]) VALUES (4, N'Nhóm H? tr?', N'D? án D')
SET IDENTITY_INSERT [dbo].[NhomNhanVien] OFF
GO
INSERT [dbo].[PTTT] ([id], [name]) VALUES (1.0000, N'Ti?n m?t')
INSERT [dbo].[PTTT] ([id], [name]) VALUES (2.0000, N'Chuy?n kho?n ngân hàng')
INSERT [dbo].[PTTT] ([id], [name]) VALUES (3.0000, N'Ví di?n t?')
GO
INSERT [dbo].[StatusNhanviens] ([Ma], [Name]) VALUES (N'CV1', N'Đang làm việc')
INSERT [dbo].[StatusNhanviens] ([Ma], [Name]) VALUES (N'CV2', N'Đã nghĩ việc')
INSERT [dbo].[StatusNhanviens] ([Ma], [Name]) VALUES (N'DT1', N'Đang đào tạo')
INSERT [dbo].[StatusNhanviens] ([Ma], [Name]) VALUES (N'DT2', N'Đã kết thúc quá trình đào tạo')
GO
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'CC1', N'Có')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'CC2', N'Đi trễ')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'CC3', N'Vắng')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'CV1', N'Ðang làm việc')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'CV2', N'Đã kết thúc làm việc')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'DT1', N'Ðang đào tạo')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'DT2', N'Đã kết thúc đào tạo')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'HDLD1', N'Thử việc')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'HDLD2', N'Chính thức')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'HDLD3', N'Nghĩ làm')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'KL', N'Kỉ luật')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'KQ1', N'Đã duyệt')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'KQ2', N'Ðang duyệt')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'KQ3', N'Không duyệt')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'KT', N'Khen thưởng')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'TTL1', N'Ðã thanh toán')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'TTL2', N'Chưa thanh toán')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'TTL3', N'Đang xử lí')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'XNP1', N'Có phép')
INSERT [dbo].[TrangThai] ([ma], [name]) VALUES (N'XNP2', N'Không phép')
GO
SET IDENTITY_INSERT [dbo].[ViTri] ON 

INSERT [dbo].[ViTri] ([id], [nameVT]) VALUES (1, N'Beginer')
INSERT [dbo].[ViTri] ([id], [nameVT]) VALUES (2, N'Senior')
INSERT [dbo].[ViTri] ([id], [nameVT]) VALUES (3, N'Juinor')
INSERT [dbo].[ViTri] ([id], [nameVT]) VALUES (4, N'Manager')
INSERT [dbo].[ViTri] ([id], [nameVT]) VALUES (9, N'Testing')
SET IDENTITY_INSERT [dbo].[ViTri] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [unique_maNV]    Script Date: 10/19/2023 1:31:35 AM ******/
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [unique_maNV] UNIQUE NONCLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HopDongLaoDong] ADD  CONSTRAINT [DF_HopDongLaoDong_createdAt]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[LichSuLuong] ADD  CONSTRAINT [DF_LichSuLuong_createdAt]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[LichSuNghiPhep] ADD  CONSTRAINT [DF_LichSuNghiPhep_createdAt]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[ThongBao] ADD  CONSTRAINT [DF_ThongBao_createdAt]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK__ChamCong__idNV__4BAC3F29] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK__ChamCong__idNV__4BAC3F29]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_ChamCong_TrangThai] FOREIGN KEY([maTrangThai])
REFERENCES [dbo].[TrangThai] ([ma])
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK_ChamCong_TrangThai]
GO
ALTER TABLE [dbo].[DaoTao]  WITH CHECK ADD  CONSTRAINT [FK__DaoTao__idNV__693CA210] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[DaoTao] CHECK CONSTRAINT [FK__DaoTao__idNV__693CA210]
GO
ALTER TABLE [dbo].[DaoTao]  WITH CHECK ADD  CONSTRAINT [FK__DaoTao__idPbDaoT__6A30C649] FOREIGN KEY([idPbDaoTao])
REFERENCES [dbo].[PhongBan] ([id])
GO
ALTER TABLE [dbo].[DaoTao] CHECK CONSTRAINT [FK__DaoTao__idPbDaoT__6A30C649]
GO
ALTER TABLE [dbo].[DaoTao]  WITH CHECK ADD  CONSTRAINT [FK_DaoTao_TrangThai] FOREIGN KEY([maTrangThai])
REFERENCES [dbo].[TrangThai] ([ma])
GO
ALTER TABLE [dbo].[DaoTao] CHECK CONSTRAINT [FK_DaoTao_TrangThai]
GO
ALTER TABLE [dbo].[HieuSuat]  WITH CHECK ADD  CONSTRAINT [FK__HieuSuat__idNV__5CD6CB2B] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[HieuSuat] CHECK CONSTRAINT [FK__HieuSuat__idNV__5CD6CB2B]
GO
ALTER TABLE [dbo].[HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [FK__HopDongLao__idCV__59063A47] FOREIGN KEY([idCV])
REFERENCES [dbo].[CongViec] ([id])
GO
ALTER TABLE [dbo].[HopDongLaoDong] CHECK CONSTRAINT [FK__HopDongLao__idCV__59063A47]
GO
ALTER TABLE [dbo].[HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [FK__HopDongLao__idNV__5535A963] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[HopDongLaoDong] CHECK CONSTRAINT [FK__HopDongLao__idNV__5535A963]
GO
ALTER TABLE [dbo].[HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [FK__HopDongLao__idPB__571DF1D5] FOREIGN KEY([idPB])
REFERENCES [dbo].[PhongBan] ([id])
GO
ALTER TABLE [dbo].[HopDongLaoDong] CHECK CONSTRAINT [FK__HopDongLao__idPB__571DF1D5]
GO
ALTER TABLE [dbo].[HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [FK__HopDongLao__idVT__59FA5E80] FOREIGN KEY([idVT])
REFERENCES [dbo].[ViTri] ([id])
GO
ALTER TABLE [dbo].[HopDongLaoDong] CHECK CONSTRAINT [FK__HopDongLao__idVT__59FA5E80]
GO
ALTER TABLE [dbo].[HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDongLaoDong_TrangThai] FOREIGN KEY([maTrangThai])
REFERENCES [dbo].[TrangThai] ([ma])
GO
ALTER TABLE [dbo].[HopDongLaoDong] CHECK CONSTRAINT [FK_HopDongLaoDong_TrangThai]
GO
ALTER TABLE [dbo].[KyLuatAndKhenThuong]  WITH CHECK ADD  CONSTRAINT [FK__KyLuatAndK__idNV__656C112C] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[KyLuatAndKhenThuong] CHECK CONSTRAINT [FK__KyLuatAndK__idNV__656C112C]
GO
ALTER TABLE [dbo].[KyLuatAndKhenThuong]  WITH CHECK ADD  CONSTRAINT [FK_KyLuatAndKhenThuong_TrangThai] FOREIGN KEY([maTrangThai])
REFERENCES [dbo].[TrangThai] ([ma])
GO
ALTER TABLE [dbo].[KyLuatAndKhenThuong] CHECK CONSTRAINT [FK_KyLuatAndKhenThuong_TrangThai]
GO
ALTER TABLE [dbo].[LichSuLuong]  WITH CHECK ADD  CONSTRAINT [FK_LichSuLuong_Luong] FOREIGN KEY([idLuong])
REFERENCES [dbo].[Luong] ([idNV])
GO
ALTER TABLE [dbo].[LichSuLuong] CHECK CONSTRAINT [FK_LichSuLuong_Luong]
GO
ALTER TABLE [dbo].[LichSuLuong]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_NhanVien] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[LichSuLuong] CHECK CONSTRAINT [FK_Table_1_NhanVien]
GO
ALTER TABLE [dbo].[LichSuLuong]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_TrangThai] FOREIGN KEY([maTrangThai])
REFERENCES [dbo].[TrangThai] ([ma])
GO
ALTER TABLE [dbo].[LichSuLuong] CHECK CONSTRAINT [FK_Table_1_TrangThai]
GO
ALTER TABLE [dbo].[LichSuNghiPhep]  WITH CHECK ADD  CONSTRAINT [FK_LichSuNghiPhep_NhanVien] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[LichSuNghiPhep] CHECK CONSTRAINT [FK_LichSuNghiPhep_NhanVien]
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_NhanVien] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_CongViec] FOREIGN KEY([idCongViec])
REFERENCES [dbo].[CongViec] ([id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_CongViec]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_StatusNhanviens_maStatus] FOREIGN KEY([maStatus])
REFERENCES [dbo].[StatusNhanviens] ([Ma])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_StatusNhanviens_maStatus]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ViTri] FOREIGN KEY([idVitri])
REFERENCES [dbo].[ViTri] ([id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ViTri]
GO
ALTER TABLE [dbo].[NhanVienShip]  WITH CHECK ADD  CONSTRAINT [FK__NhanVienS__idNNV__7B5B524B] FOREIGN KEY([idNNV])
REFERENCES [dbo].[NhomNhanVien] ([id])
GO
ALTER TABLE [dbo].[NhanVienShip] CHECK CONSTRAINT [FK__NhanVienS__idNNV__7B5B524B]
GO
ALTER TABLE [dbo].[NhanVienShip]  WITH CHECK ADD  CONSTRAINT [FK__NhanVienSh__idNV__7A672E12] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[NhanVienShip] CHECK CONSTRAINT [FK__NhanVienSh__idNV__7A672E12]
GO
ALTER TABLE [dbo].[PhongBan]  WITH CHECK ADD  CONSTRAINT [FK__PhongBan__idNguo__412EB0B6] FOREIGN KEY([idNguoiQuanLi])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[PhongBan] CHECK CONSTRAINT [FK__PhongBan__idNguo__412EB0B6]
GO
