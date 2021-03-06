USE [master]
GO
/****** Object:  Database [ZakazivanjePregleda]    Script Date: 2/9/2020 1:14:56 PM ******/
CREATE DATABASE [ZakazivanjePregleda]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZakazivanjePregleda', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ZakazivanjePregleda.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ZakazivanjePregleda_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ZakazivanjePregleda_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ZakazivanjePregleda] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZakazivanjePregleda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZakazivanjePregleda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZakazivanjePregleda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZakazivanjePregleda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ZakazivanjePregleda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZakazivanjePregleda] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ZakazivanjePregleda] SET  MULTI_USER 
GO
ALTER DATABASE [ZakazivanjePregleda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZakazivanjePregleda] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZakazivanjePregleda] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZakazivanjePregleda] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ZakazivanjePregleda] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ZakazivanjePregleda]
GO
/****** Object:  Table [dbo].[tblHronicnaBolest]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHronicnaBolest](
	[HronicnaBolestID] [int] IDENTITY(1,1) NOT NULL,
	[DijagnozaBolesti] [nvarchar](50) NOT NULL,
	[DatumPostavljanja] [date] NOT NULL,
	[Terapija] [nvarchar](50) NULL,
	[DatumPoslednjeKontrole] [date] NOT NULL,
 CONSTRAINT [PK_tblHronicnaBolest] PRIMARY KEY CLUSTERED 
(
	[HronicnaBolestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKarton]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKarton](
	[KartonID] [int] IDENTITY(1,1) NOT NULL,
	[Napomena] [nvarchar](50) NULL,
	[HronicnaBolest] [int] NULL,
	[Visina] [int] NULL,
	[Tezina] [int] NULL,
	[Upozorenje] [nvarchar](50) NULL,
	[IzabraniLekar] [int] NULL,
 CONSTRAINT [PK_tblKarton] PRIMARY KEY CLUSTERED 
(
	[KartonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLekar]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLekar](
	[LekarID] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Specijalista] [nvarchar](50) NOT NULL,
	[Ustanova] [int] NULL,
 CONSTRAINT [PK_tblLekar] PRIMARY KEY CLUSTERED 
(
	[LekarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOsiguranje]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOsiguranje](
	[OsiguranjeID] [int] IDENTITY(1,1) NOT NULL,
	[VrstaOsiguranja] [nvarchar](50) NOT NULL,
	[BrojPolise] [int] NOT NULL,
	[IzdavacOsiguranja] [nvarchar](50) NOT NULL,
	[DatumIzdavanjaOsiguranja] [date] NOT NULL,
	[DatumIstekaOsiguranja] [date] NOT NULL,
 CONSTRAINT [PK_tblOsiguranje] PRIMARY KEY CLUSTERED 
(
	[OsiguranjeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPacijent]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPacijent](
	[PacijentID] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[LBO] [int] NULL,
	[Telefon] [int] NULL,
	[DatumRodjenja] [date] NOT NULL,
	[Adresa] [nvarchar](50) NULL,
	[Osiguranje] [int] NULL,
 CONSTRAINT [PK_tblPacijent] PRIMARY KEY CLUSTERED 
(
	[PacijentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUstanova]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUstanova](
	[UstanovaID] [int] IDENTITY(1,1) NOT NULL,
	[Adresa] [nvarchar](50) NOT NULL,
	[VrstaUstanove] [nvarchar](50) NOT NULL,
	[Direktor] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblUstanova] PRIMARY KEY CLUSTERED 
(
	[UstanovaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblZakPregleda]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblZakPregleda](
	[ZakazivanjeID] [int] IDENTITY(1,1) NOT NULL,
	[Lekar] [int] NULL,
	[Pacijent] [int] NULL,
	[DatumPocetkaPregleda] [datetime] NULL,
	[DatumZavrsetkaPregleda] [datetime] NULL,
 CONSTRAINT [PK_tblZakPregleda] PRIMARY KEY CLUSTERED 
(
	[ZakazivanjeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vwHronicnaBolest]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwHronicnaBolest]
AS
SELECT        dbo.tblHronicnaBolest.*
FROM            dbo.tblHronicnaBolest

GO
/****** Object:  View [dbo].[vwKarton]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwKarton]
AS
SELECT        dbo.tblKarton.*, dbo.tblHronicnaBolest.DijagnozaBolesti, dbo.tblHronicnaBolest.DatumPoslednjeKontrole
FROM            dbo.tblKarton INNER JOIN
                         dbo.tblHronicnaBolest ON dbo.tblKarton.HornicnaBolest = dbo.tblHronicnaBolest.HronicnaBolestID

GO
/****** Object:  View [dbo].[vwLekar]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwLekar]
AS
SELECT        dbo.tblLekar.*, dbo.tblUstanova.VrstaUstanove, dbo.tblUstanova.Adresa
FROM            dbo.tblLekar INNER JOIN
                         dbo.tblUstanova ON dbo.tblLekar.Ustanova = dbo.tblUstanova.UstanovaID

GO
/****** Object:  View [dbo].[vwOsiguranje]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwOsiguranje]
AS
SELECT        dbo.tblOsiguranje.*
FROM            dbo.tblOsiguranje

GO
/****** Object:  View [dbo].[vwPacijent]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwPacijent]
AS
SELECT        dbo.tblKarton.IzabraniLekar, dbo.tblPacijent.PacijentID, dbo.tblPacijent.Ime, dbo.tblPacijent.Prezime, dbo.tblPacijent.LBO, dbo.tblPacijent.Telefon, 
                         dbo.tblPacijent.DatumRodjenja, dbo.tblPacijent.Adresa, dbo.tblPacijent.Osiguranje, dbo.tblKarton.Upozorenje, dbo.tblOsiguranje.DatumIzdavanjaOsiguranja, 
                         dbo.tblOsiguranje.DatumIstekaOsiguranja, dbo.tblOsiguranje.BrojPolise
FROM            dbo.tblPacijent INNER JOIN
                         dbo.tblKarton ON dbo.tblPacijent.LBO = dbo.tblKarton.KartonID INNER JOIN
                         dbo.tblOsiguranje ON dbo.tblPacijent.Osiguranje = dbo.tblOsiguranje.OsiguranjeID

GO
/****** Object:  View [dbo].[vwUstanova]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwUstanova]
AS
SELECT        dbo.tblUstanova.*
FROM            dbo.tblUstanova

GO
/****** Object:  View [dbo].[vwZakazivanjePregleda]    Script Date: 2/9/2020 1:14:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwZakazivanjePregleda]
AS
SELECT        dbo.tblZakPregleda.ZakazivanjeID, dbo.tblZakPregleda.Lekar, dbo.tblZakPregleda.Pacijent, dbo.tblZakPregleda.DatumPocetkaPregleda, 
                         dbo.tblZakPregleda.DatumZavrsetkaPregleda, dbo.tblPacijent.Ime, dbo.tblPacijent.Prezime, dbo.tblPacijent.LBO, dbo.tblLekar.Ustanova, dbo.tblLekar.Ime AS Expr1, 
                         dbo.tblLekar.Specijalista
FROM            dbo.tblZakPregleda INNER JOIN
                         dbo.tblPacijent ON dbo.tblZakPregleda.Pacijent = dbo.tblPacijent.PacijentID INNER JOIN
                         dbo.tblLekar ON dbo.tblZakPregleda.Lekar = dbo.tblLekar.LekarID

GO
ALTER TABLE [dbo].[tblKarton]  WITH CHECK ADD  CONSTRAINT [FK_tblKarton_tblHronicnaBolest] FOREIGN KEY([HronicnaBolest])
REFERENCES [dbo].[tblHronicnaBolest] ([HronicnaBolestID])
GO
ALTER TABLE [dbo].[tblKarton] CHECK CONSTRAINT [FK_tblKarton_tblHronicnaBolest]
GO
ALTER TABLE [dbo].[tblKarton]  WITH CHECK ADD  CONSTRAINT [FK_tblKarton_tblLekar] FOREIGN KEY([IzabraniLekar])
REFERENCES [dbo].[tblLekar] ([LekarID])
GO
ALTER TABLE [dbo].[tblKarton] CHECK CONSTRAINT [FK_tblKarton_tblLekar]
GO
ALTER TABLE [dbo].[tblLekar]  WITH CHECK ADD  CONSTRAINT [FK_tblLekar_tblUstanova] FOREIGN KEY([Ustanova])
REFERENCES [dbo].[tblUstanova] ([UstanovaID])
GO
ALTER TABLE [dbo].[tblLekar] CHECK CONSTRAINT [FK_tblLekar_tblUstanova]
GO
ALTER TABLE [dbo].[tblPacijent]  WITH CHECK ADD  CONSTRAINT [FK_tblPacijent_tblKarton] FOREIGN KEY([LBO])
REFERENCES [dbo].[tblKarton] ([KartonID])
GO
ALTER TABLE [dbo].[tblPacijent] CHECK CONSTRAINT [FK_tblPacijent_tblKarton]
GO
ALTER TABLE [dbo].[tblPacijent]  WITH CHECK ADD  CONSTRAINT [FK_tblPacijent_tblOsiguranje] FOREIGN KEY([Osiguranje])
REFERENCES [dbo].[tblOsiguranje] ([OsiguranjeID])
GO
ALTER TABLE [dbo].[tblPacijent] CHECK CONSTRAINT [FK_tblPacijent_tblOsiguranje]
GO
ALTER TABLE [dbo].[tblZakPregleda]  WITH CHECK ADD  CONSTRAINT [FK_tblZakPregleda_tblLekar] FOREIGN KEY([Lekar])
REFERENCES [dbo].[tblLekar] ([LekarID])
GO
ALTER TABLE [dbo].[tblZakPregleda] CHECK CONSTRAINT [FK_tblZakPregleda_tblLekar]
GO
ALTER TABLE [dbo].[tblZakPregleda]  WITH CHECK ADD  CONSTRAINT [FK_tblZakPregleda_tblPacijent] FOREIGN KEY([Pacijent])
REFERENCES [dbo].[tblPacijent] ([PacijentID])
GO
ALTER TABLE [dbo].[tblZakPregleda] CHECK CONSTRAINT [FK_tblZakPregleda_tblPacijent]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblHronicnaBolest"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 259
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwHronicnaBolest'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwHronicnaBolest'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblKarton"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblHronicnaBolest"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 135
               Right = 477
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwKarton'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwKarton'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblLekar"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblUstanova"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwLekar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwLekar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblOsiguranje"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 269
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwOsiguranje'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwOsiguranje'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblPacijent"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblKarton"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 135
               Right = 436
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tblOsiguranje"
            Begin Extent = 
               Top = 6
               Left = 474
               Bottom = 135
               Right = 705
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwPacijent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwPacijent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblUstanova"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUstanova'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUstanova'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblPacijent"
            Begin Extent = 
               Top = 121
               Left = 327
               Bottom = 250
               Right = 507
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tblLekar"
            Begin Extent = 
               Top = 6
               Left = 515
               Bottom = 135
               Right = 685
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tblZakPregleda"
            Begin Extent = 
               Top = 11
               Left = 69
               Bottom = 140
               Right = 290
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwZakazivanjePregleda'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwZakazivanjePregleda'
GO
USE [master]
GO
ALTER DATABASE [ZakazivanjePregleda] SET  READ_WRITE 
GO
