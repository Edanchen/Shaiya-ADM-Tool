USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[Vorgangart]    Script Date: 25.10.2020 23:57:03 ******/
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
