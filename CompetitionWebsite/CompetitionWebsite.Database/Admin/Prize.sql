CREATE TABLE [Admin].[Prize]
(
    [Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    [Title] VARCHAR(100) NOT NULL,
    [Description] VARCHAR(1000) NOT NULL,
    [BadgeId] INT NOT NULL

    CONSTRAINT [FK_Prize_Badge] FOREIGN KEY ([BadgeId]) REFERENCES [Admin].[Badge]([Id])
)
