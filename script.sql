USE [DB47]
GO
/** Object:  Table [dbo].[Course]    Script Date: 4/14/2019 3:50:39 AM *****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Credits] [int] NOT NULL,
	[Term] [nvarchar](50) NOT NULL,
	[Fee] [money] NOT NULL,
	[Duration] [int] NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fee]    Script Date: 4/14/2019 3:50:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fee](
	[FId] [int] NOT NULL,
	[SId] [int] NOT NULL,
	[CId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Fee] PRIMARY KEY CLUSTERED 
(
	[FId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 4/14/2019 3:50:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[InId] [int] NOT NULL,
	[Pid] [int] NOT NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[InId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MCQ]    Script Date: 4/14/2019 3:50:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MCQ](
	[Id] [int] NOT NULL,
	[CId] [int] NOT NULL,
	[QuesNo] [int] NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Option1] [nvarchar](max) NOT NULL,
	[Option2] [nvarchar](max) NOT NULL,
	[Option3] [nvarchar](max) NULL,
	[Option4] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MCQ] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/14/2019 3:50:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[CNIC] [int] NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[DOB] [date] NOT NULL,
	[ContactNo] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Result]    Script Date: 4/14/2019 3:50:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[RId] [int] NOT NULL,
	[SId] [int] NOT NULL,
	[InId] [int] NOT NULL,
	[Id] [int] NOT NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[RId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 4/14/2019 3:50:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[SId] [int] NOT NULL,
	[PId] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[SId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentEnrolled]    Script Date: 4/14/2019 3:50:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentEnrolled](
	[CId] [int] NOT NULL,
	[SId] [int] NOT NULL,
	[Status] [bit] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Fee]  WITH CHECK ADD  CONSTRAINT [FK_Fee_Course] FOREIGN KEY([CId])
REFERENCES [dbo].[Course] ([CId])
GO
ALTER TABLE [dbo].[Fee] CHECK CONSTRAINT [FK_Fee_Course]
GO
ALTER TABLE [dbo].[Fee]  WITH CHECK ADD  CONSTRAINT [FK_Fee_Student] FOREIGN KEY([SId])
REFERENCES [dbo].[Student] ([SId])
GO
ALTER TABLE [dbo].[Fee] CHECK CONSTRAINT [FK_Fee_Student]
GO
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Instructor_Person] FOREIGN KEY([Pid])
REFERENCES [dbo].[Person] ([PId])
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [FK_Instructor_Person]
GO
ALTER TABLE [dbo].[MCQ]  WITH CHECK ADD  CONSTRAINT [FK_MCQ_Course] FOREIGN KEY([CId])
REFERENCES [dbo].[Course] ([CId])
GO
ALTER TABLE [dbo].[MCQ] CHECK CONSTRAINT [FK_MCQ_Course]
GO
ALTER TABLE [dbo].[MCQ]  WITH CHECK ADD  CONSTRAINT [FK_MCQ_MCQ] FOREIGN KEY([Id])
REFERENCES [dbo].[MCQ] ([Id])
GO
ALTER TABLE [dbo].[MCQ] CHECK CONSTRAINT [FK_MCQ_MCQ]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Instructor] FOREIGN KEY([InId])
REFERENCES [dbo].[Instructor] ([InId])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Instructor]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_MCQ] FOREIGN KEY([Id])
REFERENCES [dbo].[MCQ] ([Id])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_MCQ]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Student] FOREIGN KEY([SId])
REFERENCES [dbo].[Student] ([SId])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Student]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Person] FOREIGN KEY([PId])
REFERENCES [dbo].[Person] ([PId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Person]
GO
ALTER TABLE [dbo].[StudentEnrolled]  WITH CHECK ADD  CONSTRAINT [FK_StudentEnrolled_Course] FOREIGN KEY([CId])
REFERENCES [dbo].[Course] ([CId])
GO
ALTER TABLE [dbo].[StudentEnrolled] CHECK CONSTRAINT [FK_StudentEnrolled_Course]
GO
ALTER TABLE [dbo].[StudentEnrolled]  WITH CHECK ADD  CONSTRAINT [FK_StudentEnrolled_Student] FOREIGN KEY([SId])
REFERENCES [dbo].[Student] ([SId])
GO
ALTER TABLE [dbo].[StudentEnrolled] CHECK CONSTRAINT [FK_StudentEnrolled_Student]
GO
