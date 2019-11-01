USE [StudentCourse]
GO

delete from Courses
delete from Students
delete from StudentCourseMaps
DBCC CHECKIDENT ('Courses', RESEED, 0)
DBCC CHECKIDENT ('Students', RESEED, 0)
go

declare @id int 
set @id = 1
while (@id <= 10)
begin
	INSERT INTO [dbo].[Courses]
			   ([Name])
		 VALUES
			   ('Course_' + CAST(@id as varchar(10)))
	set @id = @id + 1
end
GO

declare @id int
set @id = 1
while (@id <= 100)
begin
	INSERT INTO [dbo].[Students]
			   ([Name])
		 VALUES
			   ('Studen_' + CAST(@id as varchar(10)))
	set @id = @id + 1
end
GO

declare @id int
declare @map int
set @id = 1
while (@id <= 100)
begin
	set @map = @id % 10
	if (@map = 0)
		set @map = 10
	INSERT INTO [dbo].[StudentCourseMaps]
           ([StudentId]
           ,[CourseId]
           ,[Donated])
     VALUES
           (@id, @map, @id * 1000)

	set @map = (@id + 1) % 10
	if (@map = 0)
		set @map = 10
	INSERT INTO [dbo].[StudentCourseMaps]
           ([StudentId]
           ,[CourseId]
           ,[Donated])
     VALUES
           (@id, @map, @id * 1000)
	set @id = @id + 1
end


/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
  FROM [StudentCourse].[dbo].[Courses]

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
  FROM [StudentCourse].[dbo].[Students]

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [StudentId]
      ,[CourseId]
      ,[Donated]
  FROM [StudentCourse].[dbo].[StudentCourseMaps]