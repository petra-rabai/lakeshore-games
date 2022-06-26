CREATE TABLE [mainframe].[Option]
(
	[Id] INT NOT NULL IDENTITY, 
	[Type] varchar(200),
	[Name] varchar(300)
    CONSTRAINT [PK_Option] PRIMARY KEY ([Id]) 
)
