--Homework requirement 1/6

-- Find all Students with FirstName= Antonio
SELECT *
FROM dbo.[Student] 
WHERE FirstName = 'Antonio'
GO

-- Find all Students with DateOfBirthgreater than ‘01.01.1999’
SELECT *
FROM dbo.[Student] 
WHERE DateOfBirth > '01.01.1999'
GO

--Find all Male students
SELECT *
FROM dbo.[Student] 
WHERE Gender = 'M'
GO

--Find all Students with LastNamestarting With ‘T’
SELECT *
FROM dbo.[Student] 
WHERE LastName LIKE 'T%'
GO

--Find all Students Enrolled in January/1998
SELECT *
FROM dbo.[Student] 
WHERE EnrolledDate>='1998-01-01' AND EnrolledDate<='1998-01-31'
GO

--Find all Students with LastNamestarting With ‘J’ enrolled in January/1998
SELECT *
FROM dbo.[Student] 
WHERE LastName LIKE 'J%' AND EnrolledDate>='1998-01-01' AND EnrolledDate<='1998-01-31'
GO



--Homework requirement 2/6

--Find all Students with FirstName= Antonio ordered by Last Name
SELECT *
FROM dbo.[Student] 
WHERE FirstName = 'Antonio'
ORDER BY LastName ASC
GO

--List all Students ordered by FirstName
SELECT *
FROM dbo.[Student] 
ORDER BY FirstName ASC
GO

--Find all Male students ordered by EnrolledDate, starting from the last enrolled
SELECT *
FROM dbo.[Student] 
ORDER BY EnrolledDate DESC
GO

--Homework requirement 3/6

--List all Teacher First Names and Student First Names in single result set with duplicates
SELECT FirstName 
FROM dbo.[Teacher] 
UNION ALL
SELECT FirstName 
FROM dbo.[Student] 
GO

--List all Teacher Last Names and Student Last Names in single result set. Remove duplicates
SELECT LastName 
FROM dbo.[Teacher] 
UNION ALL
SELECT LastName 
FROM dbo.[Student] 
GO

--List all common First Names for Teachers and Students
SELECT FirstName
FROM [dbo].[Student]
INTERSECT
SELECT FirstName
FROM [dbo].[Teacher]
GO



--Homework requirement 4/6

--Change GradeDetailstable always to insert value 100 in AchievementMaxPointscolumn if no value is provided on insert
ALTER TABLE [dbo].[GradeDetails]
ADD CONSTRAINT DF_Achievement_Max_Points
DEFAULT 100 FOR [AchievementMaxPoints]
GO
SELECT*
FROM [dbo].[GradeDetails]
GO

--Change GradeDetailstable to prevent inserting AchievementPointsthat will more than AchievementMaxPoints
ALTER TABLE [dbo].[GradeDetails] WITH CHECK
ADD CONSTRAINT CHK_Achievement_Max_Points
CHECK (AchievementPoints <= AchievementMaxPoints)
GO
SELECT*
FROM [dbo].[GradeDetails]
GO

--Change AchievementTypetable to guarantee unique names across the Achievement types
ALTER TABLE [dbo].[AchievementType] WITH CHECK
ADD CONSTRAINT UC_Achievement_Name UNIQUE(Name)
GO
SELECT*
FROM [dbo].[AchievementType]
GO



--Homework requirement 5/6

--Create Foreign key constraints from diagram or with script
ALTER TABLE [dbo].[Grade] ADD CONSTRAINT [FK_Grade_Student] FOREIGN KEY ([StudentID]) REFERENCES [dbo].[Student]([ID]);
ALTER TABLE [dbo].[Grade] ADD CONSTRAINT [FK_Grade_Teacher] FOREIGN KEY ([TeacherID]) REFERENCES [dbo].[Teacher]([ID]);
ALTER TABLE [dbo].[Grade] ADD CONSTRAINT [FK_Grade_Course] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Course]([ID]);
ALTER TABLE [dbo].[GradeDetalist] ADD CONSTRAINT [FK_GradeDetalist_Grade] FOREIGN KEY ([GradeID]) REFERENCES [dbo].[Grade]([ID]);
ALTER TABLE [dbo].[GradeDetalist] ADD CONSTRAINT [FK_GradeDetalist_AchievementType] FOREIGN KEY ([AchievementTypeID]) REFERENCES [dbo].[AchievementType]([ID]);



--Homework requirement 6/6

--List all possible combinations of Courses names and AchievementTypenames that can be passed by student
SELECT c.Name as CoursesNames, a.Name as AchievementTypeNames
FROM Course as c
CROSS JOIN AchievementType as a
GO

--List all Teachers that has any exam Grade
SELECT DISTINCT t.FirstName
FROM Teacher as t
INNER JOIN Grade as g ON t.ID = g.TeacherID
GO

--List all Teachers without exam Grade
SELECT DISTINCT t.FirstName
FROM Teacher as t
LEFT JOIN Grade as g ON t.ID = g.TeacherID
WHERE g.Grade IS NULL
GO

--List all Students without exam Grade (using Right Join)
SELECT s.FirstName, s.LastName
FROM Grade AS g
RIGHT JOIN Student AS s ON s.ID = g.StudentID
WHERE g.StudentID IS NULL
GO