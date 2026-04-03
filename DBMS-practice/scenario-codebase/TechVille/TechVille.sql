/* =========================================================
   TECHVILLE SMART CITY – FULL MEGA SQL FILE
   ONE FILE | SAFE TO RE-RUN
   ========================================================= */

------------------------------------------------------------
-- 0. CREATE DATABASE (IF NOT EXISTS)
------------------------------------------------------------
IF DB_ID('TechVilleDB') IS NULL
    CREATE DATABASE TechVilleDB;
GO

USE TechVilleDB;
GO

------------------------------------------------------------
-- 1. CLEANUP (FOR RE-RUN SAFETY)
------------------------------------------------------------
DROP PROCEDURE IF EXISTS dbo.sp_AssignService;
DROP PROCEDURE IF EXISTS dbo.sp_InsertService;
DROP PROCEDURE IF EXISTS dbo.sp_GetCitizen;
DROP PROCEDURE IF EXISTS dbo.sp_InsertCitizen;
DROP PROCEDURE IF EXISTS dbo.sp_LogError;
GO

DROP TABLE IF EXISTS CitizenServices;
DROP TABLE IF EXISTS Services;
DROP TABLE IF EXISTS Citizens;
DROP TABLE IF EXISTS ErrorLogs;
GO

------------------------------------------------------------
-- 2. TABLES
------------------------------------------------------------
CREATE TABLE Citizens (
    CitizenId INT IDENTITY PRIMARY KEY,
    CitizenCode VARCHAR(20) UNIQUE NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    Age INT CHECK (Age >= 0),
    Income DECIMAL(10,2) CHECK (Income >= 0),
    ResidencyYears INT CHECK (ResidencyYears >= 0),
    Zone VARCHAR(20),
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE Services (
    ServiceId INT IDENTITY PRIMARY KEY,
    ServiceName VARCHAR(50),
    ServiceType VARCHAR(30),
    IsEmergency BIT,
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE CitizenServices (
    CitizenServiceId INT IDENTITY PRIMARY KEY,
    CitizenId INT FOREIGN KEY REFERENCES Citizens(CitizenId),
    ServiceId INT FOREIGN KEY REFERENCES Services(ServiceId),
    RequestDate DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE ErrorLogs (
    LogId INT IDENTITY PRIMARY KEY,
    ErrorMessage VARCHAR(500),
    ErrorType VARCHAR(100),
    LoggedAt DATETIME DEFAULT GETDATE()
);
GO

------------------------------------------------------------
-- 3. STORED PROCEDURES
------------------------------------------------------------

-- INSERT CITIZEN
CREATE PROCEDURE dbo.sp_InsertCitizen
    @CitizenCode VARCHAR(20),
    @FullName VARCHAR(100),
    @Age INT,
    @Income DECIMAL(10,2),
    @ResidencyYears INT,
    @Zone VARCHAR(20)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Citizens WHERE CitizenCode = @CitizenCode)
        RAISERROR ('Duplicate Citizen Code',16,1);

    INSERT INTO Citizens
    VALUES (@CitizenCode,@FullName,@Age,@Income,@ResidencyYears,@Zone,GETDATE());
END;
GO

-- GET CITIZEN
CREATE PROCEDURE dbo.sp_GetCitizen
    @CitizenCode VARCHAR(20)
AS
BEGIN
    SELECT * FROM Citizens WHERE CitizenCode = @CitizenCode;
END;
GO

-- INSERT SERVICE
CREATE PROCEDURE dbo.sp_InsertService
    @ServiceName VARCHAR(50),
    @ServiceType VARCHAR(30),
    @IsEmergency BIT
AS
BEGIN
    INSERT INTO Services
    VALUES (@ServiceName,@ServiceType,@IsEmergency,GETDATE());
END;
GO

-- ASSIGN SERVICE
CREATE PROCEDURE dbo.sp_AssignService
    @CitizenId INT,
    @ServiceId INT
AS
BEGIN
    INSERT INTO CitizenServices
    VALUES (@CitizenId,@ServiceId,GETDATE());
END;
GO

-- LOG ERROR
CREATE PROCEDURE dbo.sp_LogError
    @ErrorMessage VARCHAR(500),
    @ErrorType VARCHAR(100)
AS
BEGIN
    INSERT INTO ErrorLogs
    VALUES (@ErrorMessage,@ErrorType,GETDATE());
END;
GO

------------------------------------------------------------
-- 4. OPTIONAL TEST DATA (CAN DELETE LATER)
------------------------------------------------------------
EXEC dbo.sp_InsertCitizen
    'TC-101','Ananya Shukla',22,50000,3,'Zone-A';
GO

EXEC dbo.sp_InsertService
    'Healthcare','Medical',0;
GO

DECLARE @CitizenId INT =
    (SELECT CitizenId FROM Citizens WHERE CitizenCode='TC-101');

DECLARE @ServiceId INT =
    (SELECT TOP 1 ServiceId FROM Services WHERE ServiceName='Healthcare');

EXEC dbo.sp_AssignService @CitizenId, @ServiceId;
GO

------------------------------------------------------------
-- 5. VERIFICATION
------------------------------------------------------------
SELECT * FROM Citizens;
SELECT * FROM Services;
SELECT * FROM CitizenServices;
SELECT * FROM ErrorLogs;
GO
