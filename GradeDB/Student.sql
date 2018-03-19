CREATE DATABASE GradesDB
GO

USE GradesDB
GO
 
CREATE TABLE Course
(
	CourseID int PRIMARY KEY Identity(100, 15) NOT NULL
	,CourseName varchar(50) NOT NULL
	,CourseDescription varchar(255) NULL
)

CREATE TABLE Students
(
	StudentID int PRIMARY KEY Identity NOT NULL
	,StudentFName varchar(50) NOT NULL
	,StudentLName varchar(50) NOT NULL
	,BirthDate datetime NULL
	,StudentEmail varchar(100) NULL
	,StudentPassword varchar(50) NOT NULL
)

CREATE TABLE Employees
(
	EmployeeID int PRIMARY KEY IDENTITY NOT NULL
	,EmployeeFName varchar(50) NOT NULL
	,EmployeeLName varchar(50) NOT NULL
	,EmployeePassword varchar(50) NOT NULL
	,EmployeeEmail varchar(100) NULL
	,EmployeeOfficeLocation varchar(100) NULL
)

CREATE TABLE Grades
(
	StudentID int REFERENCES Students(StudentID )
	,CourseID int REFERENCES Course(CourseID)
	,Assignment varchar NOT NULL
	,AssignmentGrade tinyint NOT NULL
	,StudentScore tinyint NOT NULL
	,StudentGrade tinyint NOT NULL
)


--test Employee data
INSERT INTO Employees
VALUES 
	('Bob', 'Ross', 'Password', 'Email', 'OfficeLocationLocation')
	,('Van', 'Gough', 'NotAPassword', 'NotAnEmail', 'NotAnOfficeLocation')

--INSERT INTO Grades
--VALUES
	--(