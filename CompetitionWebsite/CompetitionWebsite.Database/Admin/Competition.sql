CREATE TABLE [Admin].[Competition]
(
    [Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    [Name] VARCHAR(100) NOT NULL,
    [Description] VARCHAR(5000) NOT NULL,
    [StartDate] DATETIME NOT NULL,
    [EndDate] DATETIME NOT NULL,
    [Status] INT NOT NULL,
    [GameId] INT NOT NULL,
    [PrizeId] INT NOT NULL

    CONSTRAINT [FK_Competition_Game] FOREIGN KEY ([GameId]) REFERENCES [Admin].[Game]([Id]), 
    CONSTRAINT [FK_Competition_Prize] FOREIGN KEY ([PrizeId]) REFERENCES [Admin].[Prize]([Id])
)
