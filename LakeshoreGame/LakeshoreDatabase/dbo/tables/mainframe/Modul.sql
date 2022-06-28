CREATE TABLE [dbo].[Modul]
(
	[Id] INT NOT NULL IDENTITY, 
	[Type] varchar(200),
	[Name] varchar(300),
	[IsActive] BIT NULL,
	[ActivationDate] DATETIME NULL,
	[InActivationDate] DATETIME NULL
    CONSTRAINT [PK_Modul] PRIMARY KEY ([Id]), 
   
    
)
