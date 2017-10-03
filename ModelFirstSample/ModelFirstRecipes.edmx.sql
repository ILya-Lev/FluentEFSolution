
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/03/2017 20:19:13
-- Generated from EDMX file: D:\Projects\LIS\studying\pet_projects\EntityFramework\ModelFirstSample\ModelFirstRecipes.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirstRecipesDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Recipes'
CREATE TABLE [dbo].[Recipes] (
    [RecipeId] int IDENTITY(1,1) NOT NULL,
    [RecipeName] nvarchar(max)  NOT NULL,
    [Headnote] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RecipeIngredients'
CREATE TABLE [dbo].[RecipeIngredients] (
    [IngredientId] int IDENTITY(1,1) NOT NULL,
    [Preparation] nvarchar(max)  NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [Unit] nvarchar(max)  NOT NULL,
    [RecipeRecipeId] int  NOT NULL,
    [RecipeID] int  NOT NULL
);
GO

-- Creating table 'RecipeSteps'
CREATE TABLE [dbo].[RecipeSteps] (
    [StepNumber] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [RecipeID] int  NOT NULL,
    [RecipeRecipeId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [RecipeId] in table 'Recipes'
ALTER TABLE [dbo].[Recipes]
ADD CONSTRAINT [PK_Recipes]
    PRIMARY KEY CLUSTERED ([RecipeId] ASC);
GO

-- Creating primary key on [IngredientId] in table 'RecipeIngredients'
ALTER TABLE [dbo].[RecipeIngredients]
ADD CONSTRAINT [PK_RecipeIngredients]
    PRIMARY KEY CLUSTERED ([IngredientId] ASC);
GO

-- Creating primary key on [StepNumber] in table 'RecipeSteps'
ALTER TABLE [dbo].[RecipeSteps]
ADD CONSTRAINT [PK_RecipeSteps]
    PRIMARY KEY CLUSTERED ([StepNumber] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RecipeRecipeId] in table 'RecipeIngredients'
ALTER TABLE [dbo].[RecipeIngredients]
ADD CONSTRAINT [FK_RecipeRecipeIngredient]
    FOREIGN KEY ([RecipeRecipeId])
    REFERENCES [dbo].[Recipes]
        ([RecipeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecipeRecipeIngredient'
CREATE INDEX [IX_FK_RecipeRecipeIngredient]
ON [dbo].[RecipeIngredients]
    ([RecipeRecipeId]);
GO

-- Creating foreign key on [RecipeRecipeId] in table 'RecipeSteps'
ALTER TABLE [dbo].[RecipeSteps]
ADD CONSTRAINT [FK_RecipeRecipeStep]
    FOREIGN KEY ([RecipeRecipeId])
    REFERENCES [dbo].[Recipes]
        ([RecipeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecipeRecipeStep'
CREATE INDEX [IX_FK_RecipeRecipeStep]
ON [dbo].[RecipeSteps]
    ([RecipeRecipeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------