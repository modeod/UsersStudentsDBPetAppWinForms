CREATE TABLE [dbo].[UserStudent]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Patronymic] NVARCHAR(50) NULL, 
    [DOB] DATE NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Phone] NCHAR(20) NULL, 
    [Telegram] NVARCHAR(50) NULL, 
    [University] NCHAR(10) NULL, 
    [Country] NVARCHAR(50) NULL, 
    [Region] NVARCHAR(50) NULL, 
    [Town] NVARCHAR(50) NULL, 
    [Street] NVARCHAR(50) NULL, 
    [House] NVARCHAR(50) NULL, 
    [Flat] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(200) NULL
)
