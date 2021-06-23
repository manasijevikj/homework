CREATE DATABASE SEDCHome
GO

USE [SEDCHome]
GO

DROP TABLE IF EXISTS [dbo].[Student];
DROP TABLE IF EXISTS [dbo].[Course];
DROP TABLE IF EXISTS [dbo].[Teacher];
DROP TABLE IF EXISTS [dbo].[Grade];
DROP TABLE IF EXISTS [dbo].[GradeDetails];
DROP TABLE IF EXISTS [dbo].[AchievementType];
GO


CREATE TABLE [dbo].[Student](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [FirstName] [nvarchar](30) NOT NULL,
        [LastName] [nvarchar](30) NOT NULL,
        [DateOfBirth] [date] NULL,
        [EnrolledDate] [date] NULL,
        [Gender] [nchar](1) NULL,
        [NationalIDNumber] [int] NULL,
		[StudentCardNumber] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
        [Id] ASC
))
GO

CREATE TABLE [dbo].[Course]
(
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](40) NOT NULL,
	[Credit] [tinyint] NOT NULL,
	[AcademicYear] [tinyint] NULL,
	[Semester] [tinyint] NULL,
	CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
)
GO

CREATE TABLE [dbo].[Teacher](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [FirstName] [nvarchar](30) NOT NULL,
        [LastName] [nvarchar](30) NOT NULL,
        [DateOfBirth] [date] NULL,
        [AcademicRank] [int] NULL,
		[StudentCardNumber] [int] NULL,
		[HireDate] [date] NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
        [Id] ASC
))
GO

CREATE TABLE [dbo].[Grade]
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [smallint] NOT NULL,
	[TeacherID] [smallint] NOT NULL,
	[Grade] [tinyint] NOT NULL,
	[Comment] [nvarchar](150) NULL,
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

CREATE TABLE [dbo].[AchievementType]
(
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](40) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[ParticipationRate] [tinyint] NOT NULL,
	CONSTRAINT [PK_AchievementType] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
)
GO

