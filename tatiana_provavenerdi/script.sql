USE [master]
GO
/****** Object:  Database [ProvaAgenti]    Script Date: 12/11/2021 15:22:50 ******/
CREATE DATABASE [ProvaAgenti]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProvaAgenti', FILENAME = N'C:\Users\Tatiana\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\ProvaAgenti.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProvaAgenti_log', FILENAME = N'C:\Users\Tatiana\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\ProvaAgenti.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProvaAgenti] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProvaAgenti].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProvaAgenti] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [ProvaAgenti] SET ANSI_NULLS ON 
GO
ALTER DATABASE [ProvaAgenti] SET ANSI_PADDING ON 
GO
ALTER DATABASE [ProvaAgenti] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [ProvaAgenti] SET ARITHABORT ON 
GO
ALTER DATABASE [ProvaAgenti] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProvaAgenti] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProvaAgenti] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProvaAgenti] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProvaAgenti] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [ProvaAgenti] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [ProvaAgenti] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProvaAgenti] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [ProvaAgenti] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProvaAgenti] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProvaAgenti] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProvaAgenti] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProvaAgenti] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProvaAgenti] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProvaAgenti] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProvaAgenti] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProvaAgenti] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProvaAgenti] SET RECOVERY FULL 
GO
ALTER DATABASE [ProvaAgenti] SET  MULTI_USER 
GO
ALTER DATABASE [ProvaAgenti] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProvaAgenti] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProvaAgenti] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProvaAgenti] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProvaAgenti] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProvaAgenti] SET QUERY_STORE = OFF
GO
USE [ProvaAgenti]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ProvaAgenti]
GO
/****** Object:  Table [dbo].[AgentePolizia]    Script Date: 12/11/2021 15:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgentePolizia](
	[CF] [nvarchar](50) NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Cognome] [nvarchar](50) NOT NULL,
	[AreaGeografica] [nvarchar](50) NOT NULL,
	[AnnoInizioAttivita] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AgentePolizia] ([CF], [Nome], [Cognome], [AreaGeografica], [AnnoInizioAttivita]) VALUES (N'abc123', N'valentino', N'Rossi', N'area1', CAST(N'1998-12-01T00:00:00.000' AS DateTime))
INSERT [dbo].[AgentePolizia] ([CF], [Nome], [Cognome], [AreaGeografica], [AnnoInizioAttivita]) VALUES (N'acd345', N're', N'leone', N'area1', CAST(N'2001-04-17T00:00:00.000' AS DateTime))
INSERT [dbo].[AgentePolizia] ([CF], [Nome], [Cognome], [AreaGeografica], [AnnoInizioAttivita]) VALUES (N'ado', N'sebastian', N'vettel', N'area1', CAST(N'1999-05-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AgentePolizia] ([CF], [Nome], [Cognome], [AreaGeografica], [AnnoInizioAttivita]) VALUES (N'are10', N'Maria ', N'Rossi', N'area3', CAST(N'2020-12-02T00:00:00.000' AS DateTime))
INSERT [dbo].[AgentePolizia] ([CF], [Nome], [Cognome], [AreaGeografica], [AnnoInizioAttivita]) VALUES (N'av123', N'Mario', N'Rossi3', N'area1', CAST(N'2020-02-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AgentePolizia] ([CF], [Nome], [Cognome], [AreaGeografica], [AnnoInizioAttivita]) VALUES (N'cln456', N'louis', N'hamilton', N'area 1', CAST(N'2019-12-01T00:00:00.000' AS DateTime))
INSERT [dbo].[AgentePolizia] ([CF], [Nome], [Cognome], [AreaGeografica], [AnnoInizioAttivita]) VALUES (N'rr23', N'mario', N'rossi', N'area1', CAST(N'1987-02-01T00:00:00.000' AS DateTime))
INSERT [dbo].[AgentePolizia] ([CF], [Nome], [Cognome], [AreaGeografica], [AnnoInizioAttivita]) VALUES (N'rre123', N'giuseppe ', N'verdi', N'area2', CAST(N'1999-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[AgentePolizia] ([CF], [Nome], [Cognome], [AreaGeografica], [AnnoInizioAttivita]) VALUES (N'tre33', N'Aliona ', N'Oglinda', N'areaProttetta', CAST(N'2012-12-01T00:00:00.000' AS DateTime))
GO
USE [master]
GO
ALTER DATABASE [ProvaAgenti] SET  READ_WRITE 
GO
