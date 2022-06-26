CREATE TABLE [mainframe].[User_Options]
(
	[Id] INT NOT NULL IDENTITY, 
	[UserId] int,
	[OptionId] int,
	[IsEnabled] bit,
	[ActivationDate] datetime,
	[InActivationDate] datetime
    CONSTRAINT [PK_Options] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Options_UserId] FOREIGN KEY ([UserId]) REFERENCES mainframe.[User]([Id]), 
    CONSTRAINT [FK_User_Options_Option] FOREIGN KEY ([OptionId]) REFERENCES mainframe.[Option]([Id]) 
)

GO

CREATE INDEX [IX_Options_IsEnabled] ON [mainframe].[User_Options] ([IsEnabled])

GO

CREATE INDEX [IX_Options_UserId] ON [mainframe].[User_Options] ([UserId])

GO

CREATE INDEX [IX_Options_ActivationDate] ON [mainframe].[User_Options] ([ActivationDate])

GO

CREATE INDEX [IX_Options_InActivationDate] ON [mainframe].[User_Options] ([InActivationDate])
