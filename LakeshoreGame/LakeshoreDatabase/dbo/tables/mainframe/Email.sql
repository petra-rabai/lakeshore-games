CREATE TABLE [mainframe].[Email]
(
	[Id] INT NOT NULL IDENTITY,
	[SenderId] int,
	[RecieverId] int,
	[Subject] varchar(300),
	[Body] varchar(MAX),
	[IsSent] bit,
	[SentDate] datetime,
	[IsDeleted] bit
    CONSTRAINT [PK_Email] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Email_SenderId] FOREIGN KEY ([SenderId]) REFERENCES mainframe.[User]([Id]), 
    CONSTRAINT [FK_Email_RecieverId] FOREIGN KEY ([RecieverId]) REFERENCES mainframe.[User]([Id]) 
)
