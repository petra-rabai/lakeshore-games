CREATE TABLE [dbo].[Modul]
(
	[Id] INT NOT NULL IDENTITY, 
	[Type] varchar(200),
	[Name] varchar(300)
    CONSTRAINT [PK_Modul] PRIMARY KEY ([Id]) 
)
