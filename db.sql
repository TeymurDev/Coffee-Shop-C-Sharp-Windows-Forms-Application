USE [master]
GO
/****** Object:  Database [SeeYouLatte]    Script Date: 1/17/2020 4:16:27 PM ******/
CREATE DATABASE [SeeYouLatte]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SeeYouLatte_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SeeYouLatte.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SeeYouLatte_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SeeYouLatte.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SeeYouLatte] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SeeYouLatte].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SeeYouLatte] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SeeYouLatte] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SeeYouLatte] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SeeYouLatte] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SeeYouLatte] SET ARITHABORT OFF 
GO
ALTER DATABASE [SeeYouLatte] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SeeYouLatte] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SeeYouLatte] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SeeYouLatte] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SeeYouLatte] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SeeYouLatte] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SeeYouLatte] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SeeYouLatte] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SeeYouLatte] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SeeYouLatte] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SeeYouLatte] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SeeYouLatte] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SeeYouLatte] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SeeYouLatte] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SeeYouLatte] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SeeYouLatte] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SeeYouLatte] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SeeYouLatte] SET RECOVERY FULL 
GO
ALTER DATABASE [SeeYouLatte] SET  MULTI_USER 
GO
ALTER DATABASE [SeeYouLatte] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SeeYouLatte] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SeeYouLatte] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SeeYouLatte] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SeeYouLatte] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SeeYouLatte] SET QUERY_STORE = OFF
GO
USE [SeeYouLatte]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 1/17/2020 4:16:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 1/17/2020 4:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[IsFirstTime] [bit] NULL,
	[RoleId] [int] NULL,
	[ActiveEmp] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 1/17/2020 4:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Count] [int] NULL,
	[Price] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 1/17/2020 4:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[Status] [bit] NULL,
	[EmployeeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 1/17/2020 4:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NULL,
	[CategoryId] [int] NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 1/17/2020 4:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (1, N'None', 0)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (2, N'Hot Drinks', 0)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (3, N'Hamburgers', 0)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (4, N'Cakes', 0)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (11, N'All', 0)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (14, N'any', 0)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (15, N'Hot Coffee Drinks', 1)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (16, N'Cold Coffee Drinks', 1)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (17, N'Sweets', 1)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (18, N'Food and Beverages', 0)
GO
INSERT [dbo].[Categories] ([Id], [Name], [Active]) VALUES (19, N'Food', 1)
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (1, N'Samir', N'Dadash-zade', N'samirdadash', N'^+???w?Fn????LJ?$?!????Hu?', 0, 1, 1)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (2, N'Kamran', N'Alibeyli', N'kamranali', N'??l?7t????7eh
36]g??8*?O?fO', 0, 2, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (3, N'Ruslan', N'Cebrayilli', N'ruslancebis', N'??l?7t????7eh
36]g??8*?O?fO', 0, 3, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (4, N'Perviz', N'Dunqus', N'pervizdunqus', N'??l?7t????7eh
36]g??8*?O?fO', 0, 3, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (5, N'Elvin', N'Ibrahimov', N'elvinibish', N'??l?7t????7eh
36]g??8*?O?fO', 0, 2, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (6, N'Humay', N'Xudayarova', N'humayxuda', N'4 ??=??w?r^&#?$??y7eGV`??_', 1, 3, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (11, N'Misir', N'Esgerov', N'misiresger', N'4 ??=??w?r^&#?$??y7eGV`??_', 1, 2, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (12, N'Roberto', N'Baggio', N'RoberBag', N'^+???w?Fn????LJ?$?!????Hu?', 1, 3, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (13, N'Batman', N'Gotham', N'batgot', N'??l?7t????7eh
36]g??8*?O?fO', 0, 2, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (14, N'Resul', N'Agarzayev', N'resulaga', N'??l?7t????7eh
36]g??8*?O?fO', 0, 2, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (15, N'Elvin', N'Ekberov', N'elvinekber', N'Y?G?*???Y??t?????Y?????s???', 1, 3, 0)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (16, N'Teymur', N'Code', N'teycod', N'Y?G?*???Y??t?????Y?????s???', 1, 1, 1)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (17, N'John', N'Doe', N'jodo', N'Y?G?*???Y??t?????Y?????s???', 1, 3, 1)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (18, N'Kyle', N'Stadler', N'kyst', N'Y?G?*???Y??t?????Y?????s???', 0, 3, 1)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (19, N'Ahmad', N'Dupree', N'ahdup', N'Y?G?*???Y??t?????Y?????s???', 0, 2, 1)
GO
INSERT [dbo].[Employees] ([Id], [Firstname], [Lastname], [Username], [Password], [IsFirstTime], [RoleId], [ActiveEmp]) VALUES (20, N'Rafael', N'Brown', N'rabr', N'Y?G?*???Y??t?????Y?????s???', 1, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (1, 1, 5, 0, CAST(7.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (2, 1, 5, 2, CAST(7.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (3, 1, 11, 2, CAST(4.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (4, 1, 10, 2, CAST(2.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (5, 2, 8, 2, CAST(2.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (6, 2, 1, 3, CAST(3.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (7, 3, 8, 2, CAST(2.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (8, 3, 1, 3, CAST(3.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (9, 4, 3, 1, CAST(1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (10, 4, 10, 1, CAST(2.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (11, 5, 3, 2, CAST(1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (12, 5, 4, 4, CAST(3.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (13, 6, 5, 1, CAST(7.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (14, 6, 11, 3, CAST(4.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (15, 7, 3, 2, CAST(1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (16, 7, 10, 1, CAST(2.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (17, 25, 17, 1, CAST(4.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (18, 25, 20, 2, CAST(2.88 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (19, 26, 15, 1, CAST(5.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (20, 26, 17, 2, CAST(4.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (21, 28, 12, 5, CAST(5.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (22, 28, 20, 10, CAST(2.88 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (23, 28, 17, 5, CAST(4.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (24, 29, 18, 2, CAST(7.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (25, 29, 13, 1, CAST(2.11 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (26, 31, 12, 3, CAST(5.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (27, 32, 19, 2, CAST(3.45 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (1002, 1002, 18, 1, CAST(7.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (1003, 1002, 13, 2, CAST(2.11 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (1004, 1003, 18, 1, CAST(7.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (1005, 1003, 13, 2, CAST(2.11 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (1, CAST(N'2019-10-02T19:38:45.007' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (2, CAST(N'2019-10-02T19:54:57.650' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (3, CAST(N'2019-10-02T19:54:57.900' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (4, CAST(N'2019-10-02T20:04:09.187' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (5, CAST(N'2019-10-02T20:58:00.480' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (6, CAST(N'2019-10-03T10:34:33.860' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (7, CAST(N'2019-10-03T11:33:29.207' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (8, CAST(N'2019-10-04T14:47:27.040' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (9, CAST(N'2019-10-04T14:47:28.580' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (10, CAST(N'2019-10-04T14:47:31.437' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (11, CAST(N'2019-10-04T14:47:55.700' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (12, CAST(N'2019-10-04T14:47:56.267' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (13, CAST(N'2019-10-04T14:50:00.463' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (14, CAST(N'2019-10-04T15:18:35.187' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (15, CAST(N'2019-10-04T16:29:13.433' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (16, CAST(N'2019-10-04T16:29:23.117' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (17, CAST(N'2019-10-04T16:56:24.920' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (18, CAST(N'2019-10-04T16:56:29.997' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (19, CAST(N'2019-10-04T16:56:46.043' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (20, CAST(N'2019-10-04T16:58:17.373' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (21, CAST(N'2019-10-04T16:58:20.957' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (22, CAST(N'2019-10-04T16:58:22.753' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (23, CAST(N'2019-10-04T16:58:24.940' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (24, CAST(N'2019-10-04T16:58:25.323' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (25, CAST(N'2019-10-04T17:15:18.320' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (26, CAST(N'2019-10-04T19:02:51.587' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (27, CAST(N'2019-10-04T19:03:40.513' AS DateTime), 1, 2)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (28, CAST(N'2019-10-05T18:38:34.197' AS DateTime), 0, 19)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (29, CAST(N'2019-10-05T18:58:17.417' AS DateTime), 0, 19)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (30, CAST(N'2019-10-05T19:11:21.260' AS DateTime), 0, 19)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (31, CAST(N'2019-10-05T19:18:53.680' AS DateTime), 0, 19)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (32, CAST(N'2019-10-05T19:21:06.943' AS DateTime), 0, 19)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (1002, CAST(N'2019-10-06T22:47:54.717' AS DateTime), 1, 19)
GO
INSERT [dbo].[Orders] ([Id], [Date], [Status], [EmployeeId]) VALUES (1003, CAST(N'2019-10-06T22:52:54.173' AS DateTime), 0, 19)
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (1, N'Cappuccino', CAST(3.50 AS Decimal(18, 2)), 2, 0)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (3, N'Water', CAST(1.00 AS Decimal(18, 2)), 1, 0)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (4, N'Sandwich', CAST(3.00 AS Decimal(18, 2)), 3, 0)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (5, N'Tiramisu', CAST(7.00 AS Decimal(18, 2)), 4, 0)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (6, N'Cheesecake', CAST(10.50 AS Decimal(18, 2)), 4, 0)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (8, N'Badimcan', CAST(2.50 AS Decimal(18, 2)), 4, 0)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (9, N'Albali', CAST(2.00 AS Decimal(18, 2)), 4, 0)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (10, N'none', CAST(2.00 AS Decimal(18, 2)), 3, 0)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (11, N'Fanta', CAST(4.00 AS Decimal(18, 2)), 1, 0)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (12, N'Latte', CAST(5.00 AS Decimal(18, 2)), 15, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (13, N'Americano', CAST(2.11 AS Decimal(18, 2)), 15, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (15, N'Frapuchino', CAST(5.00 AS Decimal(18, 2)), 16, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (16, N'Cold Coffee', CAST(2.00 AS Decimal(18, 2)), 16, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (17, N'Carrot Cake', CAST(4.00 AS Decimal(18, 2)), 17, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (18, N'Tart', CAST(7.00 AS Decimal(18, 2)), 17, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (19, N'CheeseBurger', CAST(3.45 AS Decimal(18, 2)), 19, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryId], [IsActive]) VALUES (20, N'ChickenBurger', CAST(2.88 AS Decimal(18, 2)), 19, 1)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'Admin')
GO
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (3, N'Barista')
GO
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'Cashier')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Categori__737584F68A3918EA]    Script Date: 1/17/2020 4:16:29 PM ******/
ALTER TABLE [dbo].[Categories] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__536C85E4ACC243D1]    Script Date: 1/17/2020 4:16:29 PM ******/
ALTER TABLE [dbo].[Employees] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Products__737584F6BB228029]    Script Date: 1/17/2020 4:16:29 PM ******/
ALTER TABLE [dbo].[Products] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Roles__737584F671AC1A7D]    Script Date: 1/17/2020 4:16:29 PM ******/
ALTER TABLE [dbo].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
USE [master]
GO
ALTER DATABASE [SeeYouLatte] SET  READ_WRITE 
GO
