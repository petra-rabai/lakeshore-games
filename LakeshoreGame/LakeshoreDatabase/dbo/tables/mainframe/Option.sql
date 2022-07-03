CREATE TABLE [mainframe].[Option]
(
	[Id] INT NOT NULL IDENTITY, 
	[UserId] int NULL,
	[Type] varchar(200),
	[Name] varchar(300),
	[IsActive] BIT NULL,
	[ActivationDate] DATETIME NULL,
	[InActivationDate] DATETIME NULL
    CONSTRAINT [PK_Option] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Option_User] FOREIGN KEY ([UserId]) REFERENCES mainframe.[User]([Id]) 
)
