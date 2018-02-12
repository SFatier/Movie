
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/12/2018 17:44:47
-- Generated from EDMX file: C:\Users\sigt_sf\Documents\GitHub\Movie\DAO\MovieModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DbMovie];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserNotes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NotesSet] DROP CONSTRAINT [FK_UserNotes];
GO
IF OBJECT_ID(N'[dbo].[FK_FilmGenre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GenreSet] DROP CONSTRAINT [FK_FilmGenre];
GO
IF OBJECT_ID(N'[dbo].[FK_RemarkFilm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RemarkSet] DROP CONSTRAINT [FK_RemarkFilm];
GO
IF OBJECT_ID(N'[dbo].[FK_FilmNotes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NotesSet] DROP CONSTRAINT [FK_FilmNotes];
GO
IF OBJECT_ID(N'[dbo].[FK_UserFilm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FilmSet] DROP CONSTRAINT [FK_UserFilm];
GO
IF OBJECT_ID(N'[dbo].[FK_UserRemark]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RemarkSet] DROP CONSTRAINT [FK_UserRemark];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[NotesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NotesSet];
GO
IF OBJECT_ID(N'[dbo].[FilmSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FilmSet];
GO
IF OBJECT_ID(N'[dbo].[GenreSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GenreSet];
GO
IF OBJECT_ID(N'[dbo].[RemarkSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RemarkSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NotesSet'
CREATE TABLE [dbo].[NotesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [User_Id] int  NOT NULL,
    [Film_Id] int  NOT NULL
);
GO

-- Creating table 'FilmSet'
CREATE TABLE [dbo].[FilmSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Resume] nvarchar(max)  NOT NULL,
    [IMG] nvarchar(max)  NOT NULL,
    [Genre_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'GenreSet'
CREATE TABLE [dbo].[GenreSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RemarkSet'
CREATE TABLE [dbo].[RemarkSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Film_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NotesSet'
ALTER TABLE [dbo].[NotesSet]
ADD CONSTRAINT [PK_NotesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FilmSet'
ALTER TABLE [dbo].[FilmSet]
ADD CONSTRAINT [PK_FilmSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GenreSet'
ALTER TABLE [dbo].[GenreSet]
ADD CONSTRAINT [PK_GenreSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RemarkSet'
ALTER TABLE [dbo].[RemarkSet]
ADD CONSTRAINT [PK_RemarkSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_Id] in table 'NotesSet'
ALTER TABLE [dbo].[NotesSet]
ADD CONSTRAINT [FK_UserNotes]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserNotes'
CREATE INDEX [IX_FK_UserNotes]
ON [dbo].[NotesSet]
    ([User_Id]);
GO

-- Creating foreign key on [Genre_Id] in table 'FilmSet'
ALTER TABLE [dbo].[FilmSet]
ADD CONSTRAINT [FK_FilmGenre]
    FOREIGN KEY ([Genre_Id])
    REFERENCES [dbo].[GenreSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilmGenre'
CREATE INDEX [IX_FK_FilmGenre]
ON [dbo].[FilmSet]
    ([Genre_Id]);
GO

-- Creating foreign key on [Film_Id] in table 'RemarkSet'
ALTER TABLE [dbo].[RemarkSet]
ADD CONSTRAINT [FK_RemarkFilm]
    FOREIGN KEY ([Film_Id])
    REFERENCES [dbo].[FilmSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RemarkFilm'
CREATE INDEX [IX_FK_RemarkFilm]
ON [dbo].[RemarkSet]
    ([Film_Id]);
GO

-- Creating foreign key on [Film_Id] in table 'NotesSet'
ALTER TABLE [dbo].[NotesSet]
ADD CONSTRAINT [FK_FilmNotes]
    FOREIGN KEY ([Film_Id])
    REFERENCES [dbo].[FilmSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilmNotes'
CREATE INDEX [IX_FK_FilmNotes]
ON [dbo].[NotesSet]
    ([Film_Id]);
GO

-- Creating foreign key on [User_Id] in table 'FilmSet'
ALTER TABLE [dbo].[FilmSet]
ADD CONSTRAINT [FK_UserFilm]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFilm'
CREATE INDEX [IX_FK_UserFilm]
ON [dbo].[FilmSet]
    ([User_Id]);
GO

-- Creating foreign key on [User_Id] in table 'RemarkSet'
ALTER TABLE [dbo].[RemarkSet]
ADD CONSTRAINT [FK_UserRemark]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserRemark'
CREATE INDEX [IX_FK_UserRemark]
ON [dbo].[RemarkSet]
    ([User_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------