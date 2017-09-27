CREATE TABLE [dbo].[Recipe] (
    [RecipeID]   INT            IDENTITY (1, 1) NOT NULL,
    [RecipeName]      NVARCHAR (MAX) NULL,
    [Source]     NVARCHAR (50)  NULL,
    [Headnote]   NVARCHAR (MAX) NULL,
    [TypeID]     INT            NULL,
    [CategoryID] INT            NULL,
    CONSTRAINT [PK_Recipe] PRIMARY KEY CLUSTERED ([RecipeID] ASC),
    CONSTRAINT [FK_Recipe_RecipeType] FOREIGN KEY ([TypeID]) REFERENCES [dbo].[RecipeType] ([TypeID]),
    CONSTRAINT [FK_Recipe_RecipeCategory] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[RecipeCategory] ([CategoryID])
);

