CREATE TABLE dbo.Student
(
	StudentID int NOT NULL
	,StudentFName varchar NOT NULL
	,StudentLName varchar NOT NULL
	,BirthDate datetime NULL
	,StudentAddress varchar NULL
)

INSERT INTO Student (StudentFName, StudentLName, BirthDate, StudentAddress)
VALUES ('Jae', 'Kwak', 'ThisIsMyPassword12', 7/1/1989, '1234 176th ave, Lakewood, WA, 98466')


UPDATE Student
SET StudentFName = 'Taylor'
	, StudentPassword = 'ThisIsntMyPassword'
	, StudentLName = 'Something'
	, BirthDate = 1/1/1900
	,StudentAddress = '1111 11ST, Lakewood, WA, 98466'
WHERE StudentID = 2

