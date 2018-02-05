
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/01/2018 14:33:59
-- Generated from EDMX file: C:\Users\sigt_sf\source\repos\movie.net\MovieNet\DataBase\ModelAPP.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
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

-- Creating table 'FilmSet'
CREATE TABLE [dbo].[FilmSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titre] nvarchar(max)  NOT NULL,
    [Resume] nvarchar(max)  NOT NULL,
    [Genre_Id] int  NOT NULL,
    [Utilisateur_Id] int  NOT NULL
);
GO

-- Creating table 'GenreSet'
CREATE TABLE [dbo].[GenreSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CommentaireSet'
CREATE TABLE [dbo].[CommentaireSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Film_Id] int  NOT NULL,
    [Utilisateur_Id] int  NOT NULL
);
GO

-- Creating table 'NotesSet'
CREATE TABLE [dbo].[NotesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Film_Id] int  NOT NULL,
    [Utilisateur_Id] int  NOT NULL
);
GO

-- Creating table 'UtilisateurSet'
CREATE TABLE [dbo].[UtilisateurSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

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

-- Creating primary key on [Id] in table 'CommentaireSet'
ALTER TABLE [dbo].[CommentaireSet]
ADD CONSTRAINT [PK_CommentaireSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NotesSet'
ALTER TABLE [dbo].[NotesSet]
ADD CONSTRAINT [PK_NotesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtilisateurSet'
ALTER TABLE [dbo].[UtilisateurSet]
ADD CONSTRAINT [PK_UtilisateurSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [Film_Id] in table 'CommentaireSet'
ALTER TABLE [dbo].[CommentaireSet]
ADD CONSTRAINT [FK_FilmCommentaire]
    FOREIGN KEY ([Film_Id])
    REFERENCES [dbo].[FilmSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilmCommentaire'
CREATE INDEX [IX_FK_FilmCommentaire]
ON [dbo].[CommentaireSet]
    ([Film_Id]);
GO

-- Creating foreign key on [Utilisateur_Id] in table 'FilmSet'
ALTER TABLE [dbo].[FilmSet]
ADD CONSTRAINT [FK_UtilisateurFilm]
    FOREIGN KEY ([Utilisateur_Id])
    REFERENCES [dbo].[UtilisateurSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UtilisateurFilm'
CREATE INDEX [IX_FK_UtilisateurFilm]
ON [dbo].[FilmSet]
    ([Utilisateur_Id]);
GO

-- Creating foreign key on [Utilisateur_Id] in table 'CommentaireSet'
ALTER TABLE [dbo].[CommentaireSet]
ADD CONSTRAINT [FK_UtilisateurCommentaire]
    FOREIGN KEY ([Utilisateur_Id])
    REFERENCES [dbo].[UtilisateurSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UtilisateurCommentaire'
CREATE INDEX [IX_FK_UtilisateurCommentaire]
ON [dbo].[CommentaireSet]
    ([Utilisateur_Id]);
GO

-- Creating foreign key on [Film_Id] in table 'NotesSet'
ALTER TABLE [dbo].[NotesSet]
ADD CONSTRAINT [FK_NotesFilm]
    FOREIGN KEY ([Film_Id])
    REFERENCES [dbo].[FilmSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NotesFilm'
CREATE INDEX [IX_FK_NotesFilm]
ON [dbo].[NotesSet]
    ([Film_Id]);
GO

-- Creating foreign key on [Utilisateur_Id] in table 'NotesSet'
ALTER TABLE [dbo].[NotesSet]
ADD CONSTRAINT [FK_UtilisateurNotes]
    FOREIGN KEY ([Utilisateur_Id])
    REFERENCES [dbo].[UtilisateurSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UtilisateurNotes'
CREATE INDEX [IX_FK_UtilisateurNotes]
ON [dbo].[NotesSet]
    ([Utilisateur_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------