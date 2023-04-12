CREATE TABLE [dbo].[Contacts]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Company] NVARCHAR(50) NULL, 
    [Telephone] NVARCHAR(50) NULL
)
