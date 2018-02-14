CREATE DATABASE GradesDB
GO

USE GradesDB
GO

CREATE TABLE Students
(
	StudentID int PRIMARY KEY Identity(123454321, 8) NOT NULL
	,CourseID int FOREIGN KEY REFERENCES Course(CourseID)
	,StudentFName varchar(50) NOT NULL
	,StudentLName varchar(50) NOT NULL
	,BirthDate datetime NULL
	,StudentEmail varchar(100) NULL
	,StudentPassword varchar(50) NOT NULL
)

CREATE TABLE Course
(
	CourseID int PRIMARY KEY Identity(100, 15) NOT NULL
	,CourseName varchar(50) NOT NULL
	,CourseDescription varchar(255) NULL
)

CREATE TABLE Employees
(
	EmployeeID int PRIMARY KEY identity(987656789, 3) NOT NULL
	,CourseID int FOREIGN KEY REFERENCES Course(CourseID)
	,EmployeeFName varchar(50) NOT NULL
	,EmployeeLName varchar(50) NOT NULL
	,EmployeePassword varchar(50) NOT NULL
	,EmployeeEmail varchar(100) NULL
	,EmployeeOfficeLocation varchar(100) NULL
)