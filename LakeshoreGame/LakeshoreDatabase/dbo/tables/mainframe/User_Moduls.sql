CREATE TABLE [mainframe].[User_Moduls]
(
	[Id] INT NOT NULL IDENTITY, 
	[UserId] int,
	[ModulId] int,
	[IsEnabled] bit,
	[ActivationDate] datetime,
	[InActivationDate] datetime
    CONSTRAINT [PK_Moduls] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Moduls_User] FOREIGN KEY ([UserId]) REFERENCES mainframe.[User]([Id]), 
    CONSTRAINT [FK_User_Moduls_Modul] FOREIGN KEY ([ModulId]) REFERENCES mainframe.[Modul]([Id]) 
)

GO

CREATE INDEX [IX_Moduls_IsEnabled] ON [mainframe].[User_Moduls] ([IsEnabled])

GO

CREATE INDEX [IX_Moduls_UserId] ON [mainframe].[User_Moduls] ([UserId])

GO

CREATE INDEX [IX_Moduls_ActivationDate] ON [mainframe].[User_Moduls] ([ActivationDate])

GO

CREATE INDEX [IX_Moduls_InActivationDate] ON [mainframe].[User_Moduls] ([InActivationDate])