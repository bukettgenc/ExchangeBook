CREATE TABLE [dbo].[Users] (
    [UserId]     INT            IDENTITY (1, 1) NOT NULL,
    [UserName]   NVARCHAR (MAX) NULL,
    [Password]   NVARCHAR (MAX) NULL,
    [Image]      NVARCHAR (MAX) NULL,
    [HomePageId] INT            NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

