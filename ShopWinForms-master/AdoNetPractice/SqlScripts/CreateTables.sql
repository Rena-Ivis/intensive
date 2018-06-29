CREATE TABLE dbo.Clients
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(150) NOT NULL, 
    [Email] NVARCHAR(150) NOT NULL, 
    [Phone] NVARCHAR(150) NOT NULL
);

CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(150) NOT NULL, 
    [Price] DECIMAL(18,2) NOT NULL
);

CREATE TABLE [dbo].[Orders] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [ProductId] INT NOT NULL,
    [ClientId]  INT NOT NULL,
    [Count]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [FK_Orders_ToClients] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Clients] ([Id])
);