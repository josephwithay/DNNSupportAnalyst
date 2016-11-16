CREATE TABLE [dbo].[Users] (
    [userID]    INT           IDENTITY (0, 1) NOT NULL,
    [firstName] VARCHAR (255) NOT NULL,
    [lastName]  VARCHAR (255) NOT NULL,
    [userName]  VARCHAR (255) NOT NULL,
    [email]     VARCHAR (255) NOT NULL,
    [joined]    DATE          NULL,
    PRIMARY KEY CLUSTERED ([userID] ASC)
);

