CREATE TABLE [Admin].[Game]
(
    [Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    [Name] VARCHAR(100) NOT NULL,
    [Description] VARCHAR(5000) NOT NULL,
    [ReleaseYear] DATE NOT NULL
)
