CREATE DATABASE StudentDB
GO

USE StudentDB
GO

CREATE TABLE Students
(
	StudentID int PRIMARY KEY Identity NOT NULL
	,StudentFName varchar(50) NOT NULL
	,StudentLName varchar(50) NOT NULL
	,BirthDate datetime NULL
	,StudentAddress varchar(100) NULL
	,StudentPassword varchar(50) NOT NULL
)