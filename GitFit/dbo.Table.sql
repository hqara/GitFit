CREATE TABLE [dbo].[Activity]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[username] NVARCHAR(25) NOT NULL,
	[score] INT NOT NULL,
	[level] NVARCHAR(25) NOT NULL,
	CONSTRAINT[FK_Activity_User] FOREIGN KEY ([username]) REFERENCES [dbo].[User]([username])
)

