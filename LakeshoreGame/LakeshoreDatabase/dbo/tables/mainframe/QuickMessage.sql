CREATE TABLE [dbo].[QuickMessage]
(
	[Id] INT NOT NULL IDENTITY,
	[SenderId] int,
	[RecieverId] int,
	[Message] varchar(MAX),
	[IsSent] bit,
	[SentDate] datetime,
	[IsDeleted] bit
    CONSTRAINT [PK_QuickMessage] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_QuickMessage_SenderId] FOREIGN KEY ([SenderId]) REFERENCES mainframe.[User]([Id]), 
    CONSTRAINT [FK_QuickMessage_RecieverId] FOREIGN KEY ([RecieverId]) REFERENCES mainframe.[User]([Id]) 
)
