﻿/*
COMMON STRUCTURE
	Id BIGINT PRIMARY KEY IDENTITY(1,1),
	Uuid UNIQUEIDENTIFIER UNIQUE,
	CreatedBy VARCHAR(255),
	CreatedAt DATETIME,
	LastUpdatedBy VARCHAR(255),
	LastUpdatedAt DATETIME,
	IsActive BIT,
	IsDeleted BIT
*/
USE master
GO

IF EXISTS(select * from sys.databases where name='SelfCare')
ALTER DATABASE SelfCare SET SINGLE_USER WITH ROLLBACK IMMEDIATE

DROP DATABASE SelfCare

CREATE DATABASE SelfCare
GO

-- NDK COMMON STRUCTURE
USE SelfCare
GO
CREATE SCHEMA NDK AUTHORIZATION DBO
GO

IF OBJECT_ID('NDK.USER') IS NULL
CREATE TABLE NDK.[User](
	Id BIGINT PRIMARY KEY IDENTITY(1,1),
	Uuid UNIQUEIDENTIFIER UNIQUE,

	FirstName VARCHAR(255),
	LastName VARCHAR(255),
	Email VARCHAR(255),
	UserName VARCHAR(255),
	[Password] VARCHAR(1000),

	CreatedBy VARCHAR(255),
	CreatedAt DATETIME,
	LastUpdatedBy VARCHAR(255),
	LastUpdatedAt DATETIME,
	IsActive BIT,
	IsDeleted BIT
);
GO

IF OBJECT_ID('NDK.Permission') IS NULL
CREATE TABLE NDK.Permission(
	Id BIGINT PRIMARY KEY IDENTITY(1,1),
	Uuid UNIQUEIDENTIFIER UNIQUE,

	[Key] VARCHAR(255),
	[Value] VARCHAR(255),


	CreatedBy VARCHAR(255),
	CreatedAt DATETIME,
	LastUpdatedBy VARCHAR(255),
	LastUpdatedAt DATETIME,
	IsActive BIT,
	IsDeleted BIT
);

GO
IF OBJECT_ID('NDK.Role') IS NULL
CREATE TABLE NDK.[Role](
	Id BIGINT PRIMARY KEY IDENTITY(1,1),
	Uuid UNIQUEIDENTIFIER UNIQUE,

	[Key] VARCHAR(255),
	[Value] VARCHAR(255),


	CreatedBy VARCHAR(255),
	CreatedAt DATETIME,
	LastUpdatedBy VARCHAR(255),
	LastUpdatedAt DATETIME,
	IsActive BIT,
	IsDeleted BIT
);

GO
IF OBJECT_ID('NDK.Role_Permission') IS NULL
CREATE TABLE NDK.[Role_Permission]
(
	Id BIGINT PRIMARY KEY IDENTITY(1,1),
	Uuid UNIQUEIDENTIFIER UNIQUE,

	RoleId BIGINT,
	PermissionId BIGINT,


	CreatedBy VARCHAR(255),
	CreatedAt DATETIME,
	LastUpdatedBy VARCHAR(255),
	LastUpdatedAt DATETIME,
	IsActive BIT,
	IsDeleted BIT,

	CONSTRAINT FK_RXP_RID FOREIGN KEY (RoleId) REFERENCES NDK.[Role](Id),
	CONSTRAINT FK_RXP_PID FOREIGN KEY (PermissionId) REFERENCES NDK.[Permission](Id),
);

GO
IF OBJECT_ID('NDK.User_Role') IS NULL
CREATE TABLE NDK.[User_Role](
	Id BIGINT PRIMARY KEY IDENTITY(1,1),
	Uuid UNIQUEIDENTIFIER UNIQUE,

	RoleId BIGINT,
	UserId BIGINT,


	CreatedBy VARCHAR(255),
	CreatedAt DATETIME,
	LastUpdatedBy VARCHAR(255),
	LastUpdatedAt DATETIME,
	IsActive BIT,
	IsDeleted BIT,

	CONSTRAINT FK_UXR_RID FOREIGN KEY (RoleId) REFERENCES NDK.[Role](Id),
	CONSTRAINT FK_UXR_UID FOREIGN KEY (UserId) REFERENCES NDK.[User](Id),
);

GO
IF OBJECT_ID('NDK.User_Permission') IS NULL
CREATE TABLE NDK.[User_Permission](
	Id BIGINT PRIMARY KEY IDENTITY(1,1),
	Uuid UNIQUEIDENTIFIER UNIQUE,

	PermissionId BIGINT,
	UserId BIGINT,


	CreatedBy VARCHAR(255),
	CreatedAt DATETIME,
	LastUpdatedBy VARCHAR(255),
	LastUpdatedAt DATETIME,
	IsActive BIT,
	IsDeleted BIT,

	CONSTRAINT FK_UXP_PID FOREIGN KEY (PermissionId) REFERENCES NDK.[Permission](Id),
	CONSTRAINT FK_UXP_UID FOREIGN KEY (UserId) REFERENCES NDK.[User](Id),
);

