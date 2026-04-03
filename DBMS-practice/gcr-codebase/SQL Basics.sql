/******************************************************************************************
 FILE NAME : DBMS_MSSQL_MEGA_ALL_IN_ONE.sql
 PURPOSE   : COMPLETE DBMS + SQL (ABSOLUTE BEGINNER → INTERVIEW READY)
 DBMS      : MICROSOFT SQL SERVER (MSSQL)
******************************************************************************************/

/******************************************************************************************
 SECTION 1 : DATABASE CREATION (DDL) – SAFE RESET
******************************************************************************************/

USE master;
GO

IF DB_ID('DBMS_Mega') IS NOT NULL
BEGIN
    ALTER DATABASE DBMS_Mega SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE DBMS_Mega;
END;
GO

CREATE DATABASE DBMS_Mega;
GO

USE DBMS_Mega;
GO

/******************************************************************************************
 SECTION 2 : TABLES + CONSTRAINTS + KEYS
******************************************************************************************/

IF OBJECT_ID('Projects','U') IS NOT NULL DROP TABLE Projects;
IF OBJECT_ID('Employees','U') IS NOT NULL DROP TABLE Employees;
IF OBJECT_ID('Departments','U') IS NOT NULL DROP TABLE Departments;
GO

CREATE TABLE Departments (
    DepartmentID INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName VARCHAR(50) UNIQUE NOT NULL
);
GO

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Age INT CHECK (Age >= 18),
    Salary INT CHECK (Salary > 0),
    DepartmentID INT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Employee_Department
        FOREIGN KEY (DepartmentID)
        REFERENCES Departments(DepartmentID)
);
GO

CREATE TABLE Projects (
    ProjectID INT,
    EmployeeID INT,
    ProjectName VARCHAR(50),
    PRIMARY KEY (ProjectID, EmployeeID)
);
GO

/******************************************************************************************
 SECTION 3 : INSERT DATA (DML)
******************************************************************************************/

INSERT INTO Departments VALUES ('HR'), ('IT'), ('Finance');

INSERT INTO Employees (Name, Email, Age, Salary, DepartmentID)
VALUES
('Alice', 'alice@gmail.com', 25, 60000, 1),
('Bob', 'bob@gmail.com', 30, 50000, 2),
('Charlie', 'charlie@gmail.com', 28, 70000, 2),
('David', 'david@gmail.com', 35, 45000, 3),
('Eve', 'eve@gmail.com', 32, 65000, 2);

INSERT INTO Projects VALUES
(1,1,'Payroll'),
(2,2,'ERP'),
(3,2,'CRM'),
(4,3,'Analytics');
GO

/******************************************************************************************
 SECTION 4 : BASIC QUERIES + AGGREGATES (DQL)
******************************************************************************************/

SELECT * FROM Employees;
SELECT DISTINCT DepartmentID FROM Employees;

SELECT DepartmentID, COUNT(*) AS TotalEmployees
FROM Employees
GROUP BY DepartmentID
HAVING COUNT(*) > 1;

SELECT
SUM(Salary) AS TotalSalary,
AVG(Salary) AS AvgSalary,
MIN(Salary) AS MinSalary,
MAX(Salary) AS MaxSalary,
COUNT(*) AS EmpCount,
STDEV(Salary) AS SalaryStdDev,
VAR(Salary) AS SalaryVariance
FROM Employees;
GO

/******************************************************************************************
 SECTION 5 : ALL SQL JOINS
******************************************************************************************/

SELECT e.Name, d.DepartmentName
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID;

SELECT e.Name, d.DepartmentName
FROM Employees e
LEFT JOIN Departments d ON e.DepartmentID = d.DepartmentID;

SELECT e.Name, d.DepartmentName
FROM Employees e
RIGHT JOIN Departments d ON e.DepartmentID = d.DepartmentID;

SELECT e.Name, d.DepartmentName
FROM Employees e
FULL JOIN Departments d ON e.DepartmentID = d.DepartmentID;

SELECT e.Name, d.DepartmentName
FROM Employees e
CROSS JOIN Departments d;

SELECT A.Name AS Employee1, B.Name AS Employee2
FROM Employees A
JOIN Employees B
ON A.DepartmentID = B.DepartmentID
AND A.EmployeeID <> B.EmployeeID;
GO

/******************************************************************************************
 SECTION 6 : SUBQUERIES (ALL TYPES)
******************************************************************************************/

SELECT Name FROM Employees
WHERE Salary = (SELECT MAX(Salary) FROM Employees);

SELECT Name FROM Employees
WHERE DepartmentID IN (SELECT DepartmentID FROM Departments);

SELECT Name FROM Employees e1
WHERE Salary >
(
    SELECT AVG(Salary)
    FROM Employees e2
    WHERE e1.DepartmentID = e2.DepartmentID
);

SELECT Name,
(SELECT DepartmentName FROM Departments d WHERE d.DepartmentID = e.DepartmentID) AS Department
FROM Employees e;

SELECT DepartmentID, AvgSalary
FROM (
    SELECT DepartmentID, AVG(Salary) AS AvgSalary
    FROM Employees
    GROUP BY DepartmentID
) AS DeptAvg
WHERE AvgSalary > 55000;
GO

/******************************************************************************************
 SECTION 7 : STORED PROCEDURES (ALL TYPES)
******************************************************************************************/

IF OBJECT_ID('GetAllEmployees','P') IS NOT NULL DROP PROCEDURE GetAllEmployees;
GO
CREATE PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT * FROM Employees;
END;
GO
EXEC GetAllEmployees;
GO

IF OBJECT_ID('GetEmployeesByDepartment','P') IS NOT NULL DROP PROCEDURE GetEmployeesByDepartment;
GO
CREATE PROCEDURE GetEmployeesByDepartment
@DeptName VARCHAR(50)
AS
BEGIN
    SELECT e.Name, d.DepartmentName
    FROM Employees e
    JOIN Departments d ON e.DepartmentID = d.DepartmentID
    WHERE d.DepartmentName = @DeptName;
END;
GO
EXEC GetEmployeesByDepartment 'IT';
GO

IF OBJECT_ID('GetTotalSalaryByDepartment','P') IS NOT NULL DROP PROCEDURE GetTotalSalaryByDepartment;
GO
CREATE PROCEDURE GetTotalSalaryByDepartment
@DeptName VARCHAR(50),
@TotalSalary INT OUTPUT
AS
BEGIN
    SELECT @TotalSalary = SUM(Salary)
    FROM Employees e
    JOIN Departments d ON e.DepartmentID = d.DepartmentID
    WHERE d.DepartmentName = @DeptName;
END;
GO

DECLARE @Sal INT;
EXEC GetTotalSalaryByDepartment 'HR', @Sal OUTPUT;
PRINT @Sal;
GO

/******************************************************************************************
 SECTION 8 : FUNCTIONS
******************************************************************************************/

IF OBJECT_ID('GetBonus','FN') IS NOT NULL DROP FUNCTION GetBonus;
GO
CREATE FUNCTION GetBonus(@Salary INT)
RETURNS INT
AS
BEGIN
    RETURN @Salary * 0.10;
END;
GO

SELECT Name, Salary, dbo.GetBonus(Salary) AS Bonus FROM Employees;
GO

IF OBJECT_ID('GetEmployeesByDeptID','IF') IS NOT NULL DROP FUNCTION GetEmployeesByDeptID;
GO
CREATE FUNCTION GetEmployeesByDeptID(@DeptID INT)
RETURNS TABLE
AS
RETURN (
    SELECT Name, Salary FROM Employees WHERE DepartmentID = @DeptID
);
GO

SELECT * FROM dbo.GetEmployeesByDeptID(2);
GO

/******************************************************************************************
 SECTION 9 : VIEWS
******************************************************************************************/

IF OBJECT_ID('EmployeeSalaryView','V') IS NOT NULL DROP VIEW EmployeeSalaryView;
GO
CREATE VIEW EmployeeSalaryView
AS
SELECT Name, Salary FROM Employees;
GO

IF OBJECT_ID('ITEmployeesView','V') IS NOT NULL DROP VIEW ITEmployeesView;
GO
CREATE VIEW ITEmployeesView
AS
SELECT Name, Salary FROM Employees WHERE DepartmentID = 2;
GO

IF OBJECT_ID('EmployeeDepartmentView','V') IS NOT NULL DROP VIEW EmployeeDepartmentView;
GO
CREATE VIEW EmployeeDepartmentView
AS
SELECT e.Name, d.DepartmentName
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID;
GO

IF OBJECT_ID('AvgSalaryByDepartment','V') IS NOT NULL DROP VIEW AvgSalaryByDepartment;
GO
CREATE VIEW AvgSalaryByDepartment
AS
SELECT DepartmentID, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY DepartmentID;
GO

/******************************************************************************************
 SECTION 10 : CURSORS
******************************************************************************************/

DECLARE @EmpName VARCHAR(50);

DECLARE EmpCursor CURSOR FOR
SELECT Name FROM Employees;

OPEN EmpCursor;
FETCH NEXT FROM EmpCursor INT O @EmpName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Employee: ' + @EmpName;
    FETCH NEXT FROM EmpCursor INTO @EmpName;
END;

CLOSE EmpCursor;
DEALLOCATE EmpCursor;
GO

/******************************************************************************************
 FINAL VERIFICATION
******************************************************************************************/

SELECT * FROM Employees;
SELECT * FROM Departments;
SELECT * FROM Projects;
GO
