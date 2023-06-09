USE [master]
GO
/****** Object:  Database [KinderPingvi]    Script Date: 12.05.2023 22:15:07 ******/
CREATE DATABASE [KinderPingvi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KinderPingvi', FILENAME = N'D:\ssms\MSSQL14.SQLCUTE\MSSQL\DATA\KinderPingvi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KinderPingvi_log', FILENAME = N'D:\ssms\MSSQL14.SQLCUTE\MSSQL\DATA\KinderPingvi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KinderPingvi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KinderPingvi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KinderPingvi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KinderPingvi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KinderPingvi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KinderPingvi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KinderPingvi] SET ARITHABORT OFF 
GO
ALTER DATABASE [KinderPingvi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KinderPingvi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KinderPingvi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KinderPingvi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KinderPingvi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KinderPingvi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KinderPingvi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KinderPingvi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KinderPingvi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KinderPingvi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KinderPingvi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KinderPingvi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KinderPingvi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KinderPingvi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KinderPingvi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KinderPingvi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KinderPingvi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KinderPingvi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KinderPingvi] SET  MULTI_USER 
GO
ALTER DATABASE [KinderPingvi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KinderPingvi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KinderPingvi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KinderPingvi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KinderPingvi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KinderPingvi] SET QUERY_STORE = OFF
GO
USE [KinderPingvi]
GO
/****** Object:  Table [dbo].[DiskS]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiskS](
	[id_Disk] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[countOrder] [int] NOT NULL,
	[User_id] [int] NOT NULL,
 CONSTRAINT [PK_DiskS] PRIMARY KEY CLUSTERED 
(
	[id_Disk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemOrder]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemOrder](
	[id_ItemOrder] [int] IDENTITY(1,1) NOT NULL,
	[Item_id] [int] NOT NULL,
	[Order_id] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[TypeItems_id] [int] NOT NULL,
 CONSTRAINT [PK_ItemOrder] PRIMARY KEY CLUSTERED 
(
	[id_ItemOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Id_item] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Price] [nchar](10) NOT NULL,
	[Photo] [image] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Id_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id_order] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Price_id] [int] NOT NULL,
	[User_id_Client] [int] NOT NULL,
	[User_id_Worker] [int] NOT NULL,
	[TypeOrder_id] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[id_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PriceList]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceList](
	[id_Price] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[photo] [image] NOT NULL,
 CONSTRAINT [PK_PriceList] PRIMARY KEY CLUSTERED 
(
	[id_Price] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PriceListOrder]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceListOrder](
	[id_PriceOrder] [int] IDENTITY(1,1) NOT NULL,
	[Order_id] [int] NOT NULL,
	[Price_id] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_PriceListOrder] PRIMARY KEY CLUSTERED 
(
	[id_PriceOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id_role] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeItems]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeItems](
	[id_typeItem] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TypeItems] PRIMARY KEY CLUSTERED 
(
	[id_typeItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOrders]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOrders](
	[id_typeOrder] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TypeOrders] PRIMARY KEY CLUSTERED 
(
	[id_typeOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12.05.2023 22:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id_User] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Role_id] [int] NOT NULL,
	[Code] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id_role], [title]) VALUES (1, N'Менеджер ')
INSERT [dbo].[Roles] ([Id_role], [title]) VALUES (2, N'Мастер')
INSERT [dbo].[Roles] ([Id_role], [title]) VALUES (3, N'Клиент')
INSERT [dbo].[Roles] ([Id_role], [title]) VALUES (4, N'Администратор')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
ALTER TABLE [dbo].[DiskS]  WITH CHECK ADD  CONSTRAINT [FK_DiskS_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([Id_User])
GO
ALTER TABLE [dbo].[DiskS] CHECK CONSTRAINT [FK_DiskS_Users]
GO
ALTER TABLE [dbo].[ItemOrder]  WITH CHECK ADD  CONSTRAINT [FK_ItemOrder_Items] FOREIGN KEY([Item_id])
REFERENCES [dbo].[Items] ([Id_item])
GO
ALTER TABLE [dbo].[ItemOrder] CHECK CONSTRAINT [FK_ItemOrder_Items]
GO
ALTER TABLE [dbo].[ItemOrder]  WITH CHECK ADD  CONSTRAINT [FK_ItemOrder_Orders] FOREIGN KEY([Order_id])
REFERENCES [dbo].[Orders] ([id_order])
GO
ALTER TABLE [dbo].[ItemOrder] CHECK CONSTRAINT [FK_ItemOrder_Orders]
GO
ALTER TABLE [dbo].[ItemOrder]  WITH CHECK ADD  CONSTRAINT [FK_ItemOrder_TypeItems] FOREIGN KEY([TypeItems_id])
REFERENCES [dbo].[TypeItems] ([id_typeItem])
GO
ALTER TABLE [dbo].[ItemOrder] CHECK CONSTRAINT [FK_ItemOrder_TypeItems]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_TypeOrders] FOREIGN KEY([TypeOrder_id])
REFERENCES [dbo].[TypeOrders] ([id_typeOrder])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_TypeOrders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([User_id_Client])
REFERENCES [dbo].[Users] ([Id_User])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users1] FOREIGN KEY([User_id_Worker])
REFERENCES [dbo].[Users] ([Id_User])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users1]
GO
ALTER TABLE [dbo].[PriceListOrder]  WITH CHECK ADD  CONSTRAINT [FK_PriceListOrder_Orders] FOREIGN KEY([Order_id])
REFERENCES [dbo].[Orders] ([id_order])
GO
ALTER TABLE [dbo].[PriceListOrder] CHECK CONSTRAINT [FK_PriceListOrder_Orders]
GO
ALTER TABLE [dbo].[PriceListOrder]  WITH CHECK ADD  CONSTRAINT [FK_PriceListOrder_PriceList] FOREIGN KEY([Price_id])
REFERENCES [dbo].[PriceList] ([id_Price])
GO
ALTER TABLE [dbo].[PriceListOrder] CHECK CONSTRAINT [FK_PriceListOrder_PriceList]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([Role_id])
REFERENCES [dbo].[Roles] ([Id_role])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [KinderPingvi] SET  READ_WRITE 
GO
