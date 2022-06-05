
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2022 01:27:16
-- Generated from EDMX file: D:\abc\Models\Inventorymanagement.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GRNDetail_GRN]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GRNDetails] DROP CONSTRAINT [FK_GRNDetail_GRN];
GO
IF OBJECT_ID(N'[dbo].[FK_RequisitionForm_RefDesignations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequisitionForm] DROP CONSTRAINT [FK_RequisitionForm_RefDesignations];
GO
IF OBJECT_ID(N'[dbo].[FK_RequisitionFormDetails_RequisitionForm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequisitionFormDetails] DROP CONSTRAINT [FK_RequisitionFormDetails_RequisitionForm];
GO
IF OBJECT_ID(N'[dbo].[FK_ReturnVoucher_RefDesignations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReturnVoucher] DROP CONSTRAINT [FK_ReturnVoucher_RefDesignations];
GO
IF OBJECT_ID(N'[dbo].[FK_ReturnVoucher_ReturnVoucherDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReturnVoucher] DROP CONSTRAINT [FK_ReturnVoucher_ReturnVoucherDetails];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GRNDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GRNDetails];
GO
IF OBJECT_ID(N'[dbo].[GRNs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GRNs];
GO
IF OBJECT_ID(N'[dbo].[RefDesignations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefDesignations];
GO
IF OBJECT_ID(N'[dbo].[RefUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefUsers];
GO
IF OBJECT_ID(N'[dbo].[RequisitionForm]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RequisitionForm];
GO
IF OBJECT_ID(N'[dbo].[RequisitionFormDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RequisitionFormDetails];
GO
IF OBJECT_ID(N'[dbo].[ReturnVoucher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReturnVoucher];
GO
IF OBJECT_ID(N'[dbo].[ReturnVoucherDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReturnVoucherDetails];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GRNDetails'
CREATE TABLE [dbo].[GRNDetails] (
    [ID] bigint  NOT NULL,
    [LeadgerPage] nvarchar(50)  NULL,
    [Description] nchar(500)  NULL,
    [AU] nvarchar(50)  NULL,
    [QTYCreated] bigint  NULL,
    [QTYRecived] bigint  NULL,
    [Rate] nvarchar(50)  NULL,
    [TotalValue] nchar(50)  NULL,
    [GRNID] bigint  NULL
);
GO

-- Creating table 'GRNs'
CREATE TABLE [dbo].[GRNs] (
    [Name] nvarchar(50)  NULL,
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [DesignationID] bigint  NULL,
    [Lab] nvarchar(50)  NULL,
    [Project] nvarchar(50)  NULL,
    [GRNNo] nvarchar(50)  NULL,
    [SuplyOrderNo] nvarchar(50)  NULL,
    [SuplyDate] datetime  NULL,
    [GRNDate] datetime  NULL,
    [SupplierName] nvarchar(50)  NULL,
    [SupplierAddress] nvarchar(50)  NULL
);
GO

-- Creating table 'RefDesignations'
CREATE TABLE [dbo].[RefDesignations] (
    [ID] bigint  NOT NULL,
    [Description] nvarchar(50)  NULL,
    [CompanyID] bigint  NULL,
    [ProjectID] bigint  NULL,
    [EntryUserID] nchar(10)  NULL,
    [EntryDate] datetime  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'RefUsers'
CREATE TABLE [dbo].[RefUsers] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(50)  NULL,
    [LastName] varchar(50)  NULL,
    [IdentityNo] varchar(50)  NULL,
    [EmailAddress] varchar(50)  NOT NULL,
    [MobileNumber] nvarchar(50)  NULL,
    [Password] varchar(50)  NULL,
    [UserProfileImage] varchar(100)  NULL,
    [IsAdmin] bit  NULL,
    [IsSuperAdmin] bit  NULL,
    [IsExternal] bit  NULL,
    [CompanyID] bigint  NULL,
    [EntryUserID] bigint  NOT NULL,
    [EntryDate] datetime  NOT NULL,
    [IsActive] bit  NULL,
    [ProjectID] bigint  NULL
);
GO

-- Creating table 'RequisitionForms'
CREATE TABLE [dbo].[RequisitionForms] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [DesignationID] bigint  NULL,
    [Lab] nvarchar(50)  NULL,
    [Project] nvarchar(50)  NULL,
    [SifNo] nvarchar(50)  NULL,
    [IsConsumable] bit  NULL,
    [SignatureOfInditor] nvarchar(50)  NULL,
    [SignatureOfStoreKeeper] nvarchar(50)  NULL
);
GO

-- Creating table 'RequisitionFormDetails'
CREATE TABLE [dbo].[RequisitionFormDetails] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [LeaderPageNo] nvarchar(50)  NULL,
    [Description] nvarchar(50)  NULL,
    [Remarks] nvarchar(50)  NULL,
    [QTYDemand] nvarchar(50)  NULL,
    [QTYIssued] nvarchar(50)  NULL,
    [RequisitionFormID] bigint  NULL
);
GO

-- Creating table 'ReturnVouchers'
CREATE TABLE [dbo].[ReturnVouchers] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [DesignationID] bigint  NULL,
    [Lab] nvarchar(50)  NULL,
    [Project] nvarchar(50)  NULL,
    [ReturnByName] nvarchar(50)  NULL,
    [ReturnByDesignation] nvarchar(50)  NULL,
    [CatByName] nvarchar(50)  NULL,
    [CatByDesignation] nvarchar(50)  NULL,
    [ReturnBySignature] nvarchar(50)  NULL,
    [ReturnVoucherDetailID] bigint  NOT NULL
);
GO

-- Creating table 'ReturnVoucherDetails'
CREATE TABLE [dbo].[ReturnVoucherDetails] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [LeaderPageNo] nvarchar(50)  NULL,
    [Description] nvarchar(50)  NULL,
    [Remarks] nvarchar(50)  NULL,
    [QTYUS] nvarchar(50)  NULL,
    [QTYS] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'GRNDetails'
ALTER TABLE [dbo].[GRNDetails]
ADD CONSTRAINT [PK_GRNDetails]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'GRNs'
ALTER TABLE [dbo].[GRNs]
ADD CONSTRAINT [PK_GRNs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'RefDesignations'
ALTER TABLE [dbo].[RefDesignations]
ADD CONSTRAINT [PK_RefDesignations]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'RefUsers'
ALTER TABLE [dbo].[RefUsers]
ADD CONSTRAINT [PK_RefUsers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'RequisitionForms'
ALTER TABLE [dbo].[RequisitionForms]
ADD CONSTRAINT [PK_RequisitionForms]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'RequisitionFormDetails'
ALTER TABLE [dbo].[RequisitionFormDetails]
ADD CONSTRAINT [PK_RequisitionFormDetails]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ReturnVouchers'
ALTER TABLE [dbo].[ReturnVouchers]
ADD CONSTRAINT [PK_ReturnVouchers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ReturnVoucherDetails'
ALTER TABLE [dbo].[ReturnVoucherDetails]
ADD CONSTRAINT [PK_ReturnVoucherDetails]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [GRNID] in table 'GRNDetails'
ALTER TABLE [dbo].[GRNDetails]
ADD CONSTRAINT [FK_GRNDetail_GRN]
    FOREIGN KEY ([GRNID])
    REFERENCES [dbo].[GRNs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GRNDetail_GRN'
CREATE INDEX [IX_FK_GRNDetail_GRN]
ON [dbo].[GRNDetails]
    ([GRNID]);
GO

-- Creating foreign key on [DesignationID] in table 'RequisitionForms'
ALTER TABLE [dbo].[RequisitionForms]
ADD CONSTRAINT [FK_RequisitionForm_RefDesignations]
    FOREIGN KEY ([DesignationID])
    REFERENCES [dbo].[RefDesignations]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequisitionForm_RefDesignations'
CREATE INDEX [IX_FK_RequisitionForm_RefDesignations]
ON [dbo].[RequisitionForms]
    ([DesignationID]);
GO

-- Creating foreign key on [DesignationID] in table 'ReturnVouchers'
ALTER TABLE [dbo].[ReturnVouchers]
ADD CONSTRAINT [FK_ReturnVoucher_RefDesignations]
    FOREIGN KEY ([DesignationID])
    REFERENCES [dbo].[RefDesignations]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReturnVoucher_RefDesignations'
CREATE INDEX [IX_FK_ReturnVoucher_RefDesignations]
ON [dbo].[ReturnVouchers]
    ([DesignationID]);
GO

-- Creating foreign key on [RequisitionFormID] in table 'RequisitionFormDetails'
ALTER TABLE [dbo].[RequisitionFormDetails]
ADD CONSTRAINT [FK_RequisitionFormDetails_RequisitionForm]
    FOREIGN KEY ([RequisitionFormID])
    REFERENCES [dbo].[RequisitionForms]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequisitionFormDetails_RequisitionForm'
CREATE INDEX [IX_FK_RequisitionFormDetails_RequisitionForm]
ON [dbo].[RequisitionFormDetails]
    ([RequisitionFormID]);
GO

-- Creating foreign key on [ReturnVoucherDetailID] in table 'ReturnVouchers'
ALTER TABLE [dbo].[ReturnVouchers]
ADD CONSTRAINT [FK_ReturnVoucher_ReturnVoucherDetails]
    FOREIGN KEY ([ReturnVoucherDetailID])
    REFERENCES [dbo].[ReturnVoucherDetails]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReturnVoucher_ReturnVoucherDetails'
CREATE INDEX [IX_FK_ReturnVoucher_ReturnVoucherDetails]
ON [dbo].[ReturnVouchers]
    ([ReturnVoucherDetailID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------