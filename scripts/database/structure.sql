CREATE DATABASE [CleanCodePOC];
GO

USE [CleanCodePOC];
GO

CREATE TABLE [dbo].[User]
(
    [Id] INT IDENTITY,
    [Username] NVARCHAR(200) NOT NULL,
    [SecurePassword] NVARCHAR(500) NOT NULL,
    [EmailAddress] NVARCHAR(200),
    [MobileNumber] NVARCHAR(200),
    [IsActive] BIT NOT NULL,
    [IsPasswordChangeRequired] BIT NOT NULL,
    [IsEmailAddresVerified] BIT NOT NULL,
    [IsMobileNumberVerified] BIT NOT NULL,
    [IsDeleted] BIT NOT NULL,
    [InsertedById] INT,
    [InsertedOn] DATETIMEOFFSET,
    [UpdatedById] INT,
    [UpdatedOn] DATETIMEOFFSET,
    [DeletedById] INT,
    [DeletedOn] DATETIMEOFFSET,
    CONSTRAINT [PK_User] PRIMARY KEY([Id])
);
ALTER TABLE [dbo].[User] ADD
    CONSTRAINT [DF_User_IsActive] DEFAULT 0 FOR [IsActive],
    CONSTRAINT [DF_User_IsPasswordChangeRequired] DEFAULT 0 FOR [IsPasswordChangeRequired],
    CONSTRAINT [DF_User_IsEmaulAddressVerified] DEFAULT 0 FOR [IsEmailAddresVerified],
    CONSTRAINT [DF_User_IsMobileNumberVerified] DEFAULT 0 FOR [IsMobileNumberVerified],
    CONSTRAINT [DF_User_IsDeleted] DEFAULT 0 FOR [IsDeleted];
GO