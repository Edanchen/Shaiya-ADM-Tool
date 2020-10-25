USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[Tool]    Script Date: 25.10.2020 23:57:03 ******/
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
