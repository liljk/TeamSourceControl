CREATE DATABASE GradesDB
GO

USE GradesDB
GO

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

--test Employee data
INSERT INTO Employees
VALUES 
	('Bob' + 'Ross' + 'Password' + 'Email' + 'OfficeLocationLocation')
	,('Van' + 'Gough' + 'NotAPassword' + 'NotAnEmail' + 'NotAnOfficeLocation')