CREATE TABLE [mainframe].[User]
(
	[Id] INT NOT NULL IDENTITY, 
	[FirstName] varchar(250),
	[LastName] varchar(250),
	[Email] varchar(256),
	[LoginName] varchar(150),
	[LoginPassword] varchar(150),
	[CreatedDate] datetime,
	[ModifiedDate] datetime,
	[DeletedDate] datetime,
	[IsDeleted] bit
    CONSTRAINT [PK_User] PRIMARY KEY ([Id]) 
)

GO

CREATE INDEX [IX_User_LoginName] ON [mainframe].[User] ([LoginName])

GO

CREATE INDEX [IX_User_IsDeleted] ON [mainframe].[User] ([IsDeleted])

GO

CREATE INDEX [IX_User_CreatedDate] ON [mainframe].[User] ([CreatedDate])

GO

CREATE INDEX [IX_User_DeletedDate] ON [mainframe].[User] ([DeletedDate])
