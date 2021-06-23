USE [master]
GO
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'SEDCHome')
	ALTER DATABASE [SEDCHome] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
USE [Master]
GO
DROP DATABASE IF EXISTS [SEDCHome]
GO
CREATE DATABASE [SEDCHome]
GO
USE [SEDCHome]
GO

DROP TABLE IF EXISTS [dbo].[GradeDetails];
DROP TABLE IF EXISTS [dbo].[Grade];
DROP TABLE IF EXISTS [dbo].[AchievementType];
DROP TABLE IF EXISTS [dbo].[Course];
DROP TABLE IF EXISTS [dbo].[Student];
DROP TABLE IF EXISTS [dbo].[Teacher];
GO

CREATE TABLE [dbo].[Teacher]
(
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[AcademicRank] [nvarchar](50) NOT NULL,
	[HireDate] [date] NOT NULL,
	CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
)
GO

CREATE TABLE [dbo].[Student]
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[EnrolledDate] [date] NOT NULL,
	[Gender] [char](1) NOT NULL,
	[NationalIDNumber] [nvarchar](50) NOT NULL,
	[StudentCardNumber] [nvarchar](50) NOT NULL,
	CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
)
GO

CREATE TABLE [dbo].[Course]
(
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Credit] [tinyint] NOT NULL,
	[AcademicYear] [tinyint] NOT NULL,
	[Semester] [tinyint] NOT NULL,
	CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
)
GO

CREATE TABLE [dbo].[AchievementType]
(
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[ParticipationRate] [tinyint] NOT NULL,
	CONSTRAINT [PK_AchievementType] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
)
GO

CREATE TABLE [dbo].[Grade]
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [smallint] NOT NULL,
	[TeacherID] [smallint] NOT NULL,
	[Grade] [tinyint] NOT NULL,
	[Comment] [nvarchar](100) NULL,
	[CreatedDate] [datetime] NOT NULL,
	CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
)
GO

CREATE TABLE [dbo].[GradeDetails]
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GradeID] [int] NOT NULL,
	[AchievementTypeID] [tinyint] NOT NULL,
	[AchievementPoints] [tinyint] NOT NULL,
	[AchievementMaxPoints] [tinyint] NOT NULL,
	[AchievementDate] [datetime] NOT NULL,
	CONSTRAINT [PK_GradeDetails] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
)
GO