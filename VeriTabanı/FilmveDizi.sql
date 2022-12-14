USE [master]
GO
/****** Object:  Database [FilmveDizi_Arsivi]    Script Date: 6.11.2022 21:18:06 ******/
CREATE DATABASE [FilmveDizi_Arsivi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FilmveDizi_Arsivi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\FilmveDizi_Arsivi.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FilmveDizi_Arsivi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\FilmveDizi_Arsivi_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FilmveDizi_Arsivi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET ARITHABORT OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET  MULTI_USER 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FilmveDizi_Arsivi]
GO
/****** Object:  Table [dbo].[Tbl_FilmveDizi]    Script Date: 6.11.2022 21:18:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_FilmveDizi](
	[Filmid] [int] IDENTITY(1,1) NOT NULL,
	[FilmAd] [varchar](30) NULL,
	[FilmTur] [varchar](30) NULL,
	[FilmCikis] [varchar](7) NULL,
	[FilmYonetmen] [varchar](30) NULL,
	[FilmIMDB] [float] NULL,
	[FilmResim] [varchar](200) NULL,
	[FilmTarih] [int] NULL,
	[FilmveDizi] [varchar](4) NULL,
	[FilmIzlendimi] [bit] NULL,
 CONSTRAINT [PK_Tbl_FilmveDizi] PRIMARY KEY CLUSTERED 
(
	[Filmid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_FilmveDizi] ON 

INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (1, N'Yıldızlar Arası', N'Bilim Kurgu / Macera', N'Yabancı', N'Christopher Nolan', 8.6, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\interstailer.jpg', 2014, N'Film', 1)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (3, N'Marslı', N'Bilim Kurgu / Dram', N'Yabancı', N'Ridley Scott', 8, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\Marslı.jpg', 2015, N'Film', 1)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (4, N'Jhon Wick 2', N'Aksiyon / Neo-Noir', N'Yabancı', N'Chad Stahelski', 7.5, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\jhon wick 2.jpg', 2014, N'Film', 1)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (5, N'Uzay Yolcuları', N'Bilim Kurgu / Romantik', N'Yabancı', N'Morten Tyldum', 7, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\Uzay Yolcuları.jpg', 2016, N'Film', 1)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (6, N'Deadpool', N'Aksiyon / Macera', N'Yabancı', N'Tim Miller', 8, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\deadpool.jpg', 2016, N'Film', 1)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (7, N'Açlık Oyunları', N'Bilim Kurgu / Aksiyon', N'Yabancı', N'Gary Ross', 7.2, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\açlık oyunları.jpg', 2012, N'Film', 0)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (8, N'Ralph ve İnternet', N'Çocuk / Komedi', N'Yabancı', N'Phil Johnston, Rich Moore', 7, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\ralph ve internet.jpg', 2018, N'Film', 0)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (9, N'Kurtlar Vadisi', N'Aksiyon / Siyaset', N'Yerli', N'Osman Sınav', 7.6, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\Kurtlar Vadisi.jpg', 2003, N'Dizi', 0)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (10, N'Game of Thrones', N'Drama', N'Yabancı', N'Tim Van Patten, Brian Kirk', 9.2, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\game of thrones.jpg', 2011, N'Dizi', 0)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (11, N'Spartaküs', N'Drama', N'Yabancı', N'Stanley Kubrick', 8.5, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\spartaküs.jpg', 2010, N'Dizi', 1)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (12, N'Avatar: The Last Airbender', N'Çocuk', N'Yabancı', N'M. Night Shyamalan', 9.3, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\Avatar - The Last Airbender.jpg', 2005, N'Dizi', 1)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (13, N'The Legend of Korra', N'Çocuk', N'Yabancı', N'Joaquim Dos Santos Ki Hyun Ryu', 8.4, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\The Legend of Korra.jpg', 2012, N'Dizi', 1)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (14, N'Ayla', N'Savaş / Dram', N'Yerli', N'Can Ulkay', 8.5, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\Ayla.jpg', 2017, N'Film', 0)
INSERT [dbo].[Tbl_FilmveDizi] ([Filmid], [FilmAd], [FilmTur], [FilmCikis], [FilmYonetmen], [FilmIMDB], [FilmResim], [FilmTarih], [FilmveDizi], [FilmIzlendimi]) VALUES (18, N'Suicide Squad', N'Aksiyon / Macera', N'Yabancı', N'David Ayer', 5.9, N'C:\Users\w10\OneDrive\Masaüstü\SOFTWARE\Software Projects\Visual Studio (C# Form) Denemeleri\102. ORN. Film Arsivi\Projeye Ait Resimler\Suicide Squad - Gerçek Kötüler.jpg', 2016, N'Film', NULL)
SET IDENTITY_INSERT [dbo].[Tbl_FilmveDizi] OFF
USE [master]
GO
ALTER DATABASE [FilmveDizi_Arsivi] SET  READ_WRITE 
GO
