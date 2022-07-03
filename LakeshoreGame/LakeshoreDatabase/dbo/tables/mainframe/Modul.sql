CREATE TABLE [mainframe].[Modul]
(
	[Id] INT NOT NULL IDENTITY,
	[UserId] int NULL,
	[Type] varchar(200),
	[Name] varchar(300),
	[IsActive] BIT NULL,
	[ActivationDate] DATETIME NULL,
	[InActivationDate] DATETIME NULL
    CONSTRAINT [PK_Modul] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Modul_User] FOREIGN KEY ([UserId]) REFERENCES mainframe.[User]([Id]), 
   
    
)
