CREATE TABLE [dbo].[HomePages] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Post]       NVARCHAR (MAX) NULL,
    [HomePageId] INT            NOT NULL,
    CONSTRAINT [PK_HomePages] PRIMARY KEY CLUSTERED ([Id] ASC)
);

