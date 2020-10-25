USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 25.10.2020 23:57:03 ******/
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
