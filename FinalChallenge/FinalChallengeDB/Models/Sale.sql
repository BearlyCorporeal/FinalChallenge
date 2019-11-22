CREATE TABLE [dbo].[Sale0136]
(
	[CustNo] INT NOT NULL,
	[RecordID] NVARCHAR(5) NOT NULL, 
	[DateOrdered] NVARCHAR(20) NOT NULL,
	[Price] money NOT NULL,
	Foreign Key(CustNo)References Customer0136,
	Foreign Key(RecordID)References Record0136,
	Primary Key(CustNo,RecordID,DateOrdered,Price)
)
