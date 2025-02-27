USE [master]
GO
/****** Object:  Database [Stok_Takip]    Script Date: 5.02.2025 17:48:23 ******/
CREATE DATABASE [Stok_Takip]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stok_Takip', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Stok_Takip.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Stok_Takip_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Stok_Takip_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Stok_Takip] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stok_Takip].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stok_Takip] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Stok_Takip] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Stok_Takip] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Stok_Takip] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Stok_Takip] SET ARITHABORT OFF 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stok_Takip] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stok_Takip] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Stok_Takip] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Stok_Takip] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stok_Takip] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Stok_Takip] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stok_Takip] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stok_Takip] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Stok_Takip] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Stok_Takip] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Stok_Takip] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stok_Takip] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Stok_Takip] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Stok_Takip] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Stok_Takip] SET  MULTI_USER 
GO
ALTER DATABASE [Stok_Takip] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Stok_Takip] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Stok_Takip] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Stok_Takip] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Stok_Takip] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Stok_Takip] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Stok_Takip] SET QUERY_STORE = ON
GO
ALTER DATABASE [Stok_Takip] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Stok_Takip]
GO
/****** Object:  Table [dbo].[kategoribilgileri]    Script Date: 5.02.2025 17:48:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategoribilgileri](
	[kategori] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici_Bilgi]    Script Date: 5.02.2025 17:48:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici_Bilgi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_adi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marka]    Script Date: 5.02.2025 17:48:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marka](
	[kategori] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[müşteri]    Script Date: 5.02.2025 17:48:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[müşteri](
	[tc] [nvarchar](50) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satis]    Script Date: 5.02.2025 17:48:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satis](
	[tc] [nvarchar](50) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[barkodno] [nvarchar](50) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[miktari] [int] NOT NULL,
	[satisfiyati] [decimal](18, 2) NOT NULL,
	[toplamfiyati] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sepet]    Script Date: 5.02.2025 17:48:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sepet](
	[tc] [nvarchar](50) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[barkodno] [nvarchar](50) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[miktari] [int] NOT NULL,
	[satisfiyati] [decimal](18, 2) NOT NULL,
	[toplamfiyati] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urun]    Script Date: 5.02.2025 17:48:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urun](
	[barkodno] [nvarchar](50) NOT NULL,
	[kategori] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[miktari] [int] NOT NULL,
	[satisfiyati] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Stok_Takip] SET  READ_WRITE 
GO
