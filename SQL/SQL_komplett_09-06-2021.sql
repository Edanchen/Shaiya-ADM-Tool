USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 09.06.2021 19:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Benutzer] [varchar](30) NOT NULL,
	[Passwort] [varchar](30) NOT NULL,
	[Rechte] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 09.06.2021 19:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nchar](20) NOT NULL,
	[Password] [nchar](20) NOT NULL,
	[IP] [nchar](20) NOT NULL,
	[Date] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticketart]    Script Date: 09.06.2021 19:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticketart](
	[Art] [varchar](50) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tickets]    Script Date: 09.06.2021 19:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tickets](
	[TicketID] [int] IDENTITY(1000,1) NOT NULL,
	[Art] [varchar](50) NOT NULL,
	[Account] [varchar](50) NOT NULL,
	[Char] [varchar](50) NOT NULL,
	[Text] [ntext] NOT NULL,
	[Datum] [datetime] NOT NULL,
	[Replay] [int] NOT NULL,
	[Bearbeiter] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tool]    Script Date: 09.06.2021 19:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tool](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nchar](20) NULL,
	[Tool] [nchar](20) NULL,
	[Date] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vorgaenge]    Script Date: 09.06.2021 19:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vorgaenge](
	[GV] [int] IDENTITY(1000,1) NOT NULL,
	[UserID] [nchar](20) NULL,
	[Date] [datetime] NULL,
	[Text] [ntext] NULL,
	[Status] [nchar](20) NULL,
	[Zugewiesenan] [nchar](20) NULL,
	[Thema] [nchar](20) NULL,
	[Art] [nchar](20) NULL,
	[Type] [nchar](30) NULL,
	[Erstelltdurch] [nchar](20) NULL,
	[Letzterbearbeiter] [nchar](20) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vorgangart]    Script Date: 09.06.2021 19:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vorgangart](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Thema] [varchar](25) NOT NULL,
	[Art] [varchar](25) NOT NULL,
	[Typ] [varchar](25) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tickets] ADD  CONSTRAINT [DF_tickets_Replay]  DEFAULT ((0)) FOR [Replay]
GO
