USE [master]
GO
/****** Object:  Database [gimnasio_db]    Script Date: 21/11/2021 10:19:07 a.m. ******/
CREATE DATABASE [gimnasio_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gimnasio_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gimnasio_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gimnasio_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gimnasio_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [gimnasio_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gimnasio_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gimnasio_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gimnasio_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gimnasio_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gimnasio_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gimnasio_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [gimnasio_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gimnasio_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gimnasio_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gimnasio_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gimnasio_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gimnasio_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gimnasio_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gimnasio_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gimnasio_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gimnasio_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gimnasio_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gimnasio_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gimnasio_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gimnasio_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gimnasio_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gimnasio_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gimnasio_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gimnasio_db] SET RECOVERY FULL 
GO
ALTER DATABASE [gimnasio_db] SET  MULTI_USER 
GO
ALTER DATABASE [gimnasio_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gimnasio_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gimnasio_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gimnasio_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gimnasio_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gimnasio_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'gimnasio_db', N'ON'
GO
ALTER DATABASE [gimnasio_db] SET QUERY_STORE = OFF
GO
USE [gimnasio_db]
GO
/****** Object:  Table [dbo].[socios]    Script Date: 21/11/2021 10:19:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[socios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](200) NULL,
	[apellido] [varchar](200) NULL,
	[sexo] [char](1) NULL,
	[pase] [int] NULL,
	[pago] [int] NULL,
	[estatus] [int] NULL,
	[fecha_ingreso] [date] NULL,
	[dni] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[socios] ON 

INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (46, N'juan', N'gomez', N'M', 2, 2, 0, CAST(N'2021-11-20' AS Date), 123456)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (47, N'jorge', N'perez', N'M', 1, 1, 1, CAST(N'2021-11-20' AS Date), 124566)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (48, N'ines', N'torres', N'F', 2, 2, 0, CAST(N'2021-11-20' AS Date), 8412451)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (49, N'juan', N'barranco', N'F', 1, 1, 1, CAST(N'2021-11-20' AS Date), 32111321)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (50, N'tomas', N'perez', N'M', 1, 1, 0, CAST(N'2021-11-20' AS Date), 1212455)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (51, N'francisco', N'lisardo', N'M', 2, 2, 1, CAST(N'2021-11-20' AS Date), 1254312)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (52, N'maria', N'valles', N'F', 0, 0, 1, CAST(N'2021-11-20' AS Date), 32111222)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (53, N'cristina', N'robles', N'F', 0, 0, 0, CAST(N'2021-11-20' AS Date), 1112231)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (54, N'sofia', N'sorondo', N'F', 2, 2, 1, CAST(N'2021-11-20' AS Date), 444232)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (55, N'ezequiel', N'gonzalez', N'M', 2, 2, 0, CAST(N'2021-11-20' AS Date), 1235123)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (56, N'julian', N'alvarez', N'M', 0, 0, 1, CAST(N'2021-11-20' AS Date), 1212341)
INSERT [dbo].[socios] ([id], [nombre], [apellido], [sexo], [pase], [pago], [estatus], [fecha_ingreso], [dni]) VALUES (57, N'ricardo', N'garcia', N'M', 1, 1, 0, CAST(N'2021-11-20' AS Date), 34512252)
SET IDENTITY_INSERT [dbo].[socios] OFF
GO
USE [master]
GO
ALTER DATABASE [gimnasio_db] SET  READ_WRITE 
GO
