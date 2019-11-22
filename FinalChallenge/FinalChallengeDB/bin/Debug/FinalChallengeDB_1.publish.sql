﻿/*
Deployment script for DAD

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DAD"
:setvar DefaultFilePrefix "DAD"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
PRINT N'Creating [dbo].[Customer0136]...';


GO
CREATE TABLE [dbo].[Customer0136] (
    [CustNo]       INT           NOT NULL,
    [CustName]     NVARCHAR (50) NOT NULL,
    [CustAddress]  NVARCHAR (50) NOT NULL,
    [CustPCode]    INT           NOT NULL,
    [InterestCode] NVARCHAR (2)  NOT NULL,
    PRIMARY KEY CLUSTERED ([CustNo] ASC)
);


GO
PRINT N'Creating [dbo].[Interest0136]...';


GO
CREATE TABLE [dbo].[Interest0136] (
    [InterestCode] NVARCHAR (2)  NOT NULL,
    [InterestDesc] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([InterestCode] ASC)
);


GO
PRINT N'Creating [dbo].[Record0136]...';


GO
CREATE TABLE [dbo].[Record0136] (
    [RecordID]  NVARCHAR (5)  NOT NULL,
    [Title]     NVARCHAR (50) NOT NULL,
    [Preformer] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([RecordID] ASC)
);


GO
PRINT N'Creating [dbo].[Sale0136]...';


GO
CREATE TABLE [dbo].[Sale0136] (
    [CustNo]      INT           NOT NULL,
    [RecordID]    NVARCHAR (5)  NOT NULL,
    [DateOrdered] NVARCHAR (20) NOT NULL,
    [Price]       MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([CustNo] ASC, [RecordID] ASC, [DateOrdered] ASC, [Price] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[Customer0136]...';


GO
ALTER TABLE [dbo].[Customer0136] WITH NOCHECK
    ADD FOREIGN KEY ([InterestCode]) REFERENCES [dbo].[Interest0136] ([InterestCode]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Sale0136]...';


GO
ALTER TABLE [dbo].[Sale0136] WITH NOCHECK
    ADD FOREIGN KEY ([CustNo]) REFERENCES [dbo].[Customer0136] ([CustNo]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Sale0136]...';


GO
ALTER TABLE [dbo].[Sale0136] WITH NOCHECK
    ADD FOREIGN KEY ([RecordID]) REFERENCES [dbo].[Record0136] ([RecordID]);


GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
insert into Interest0136(InterestCode,InterestDesc)Values('RR','Rock and Roll');
insert into Interest0136(InterestCode,InterestDesc)Values('JA','Jazz');
insert into Interest0136(InterestCode,InterestDesc)Values('RB','Rhythm and Blues');

insert into Record0136(RecordID,Title,Preformer)Values('PF003','The Wall','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('IX002','Kick','INXS');
insert into Record0136(RecordID,Title,Preformer)Values('SP069','Never Mind the Bollocks','Sex Pistols');
insert into Record0136(RecordID,Title,Preformer)Values('PF007','The Division Bell','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('PF002','The Dark Side of the Moon','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('IX005','Shabooh Shoobah','INXS');
insert into Record0136(RecordID,Title,Preformer)Values('SP072','Floggin a Dead Horse','INXS');
insert into Record0136(RecordID,Title,Preformer)Values('PF004','The Endless River','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('PF006','Wish You Were Here','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('SP075','Agents of Anarchy','Sex Pistols');
insert into Record0136(RecordID,Title,Preformer)Values('PF007','The Division Bell','Pink Floyd');

insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(123,'Jimmy Barnes','1 Sesame Street',3000,'RR');
insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(456,'Ian Moss','10 Downing Street',4000,'JA');
insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(789,'Don Walker','221B Baker Street',5000,'RB');
insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(234,'Steve Prestwich','LG1 College Cres, Parkville',6000,'RR');
insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(567,'Phil Small','1 Adelaide Avenue',7000,'RB');

insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(123,'PF003','01-Dec-15','$30.00');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(123,'IX002','01-Dec-15','$29.95');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(123,'SP069','02-Dec-15','$12.45');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(123,'IX002','05-Dec-18','$30.03');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(456,'PF007','03-Dec-15','$9.95');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(456,'PF002','01-Dec-15','$31.00');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(456,'IX005','03-Dec-15','$28.95');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(456,'SP072','03-Dec-15','$28.95');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(789,'PF004','02-Dec-15','$29.00');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(789,'IX002','05-Dec-16','$29.96');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(234,'PF006','01-Dec-15','$45.00');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(234,'SP075','04-Dec-16','$5.68');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(567,'PF007','03-Dec-15','$9.95');

GO

GO