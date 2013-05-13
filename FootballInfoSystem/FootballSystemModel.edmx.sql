
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/10/2013 00:45:51
-- Generated from EDMX file: D:\изпити и материали\програмиране\C++\Projects\vs\FootballInfoSystem\FootballInfoSystem\FootballSystemModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FootballSystemDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GameTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_GameTeam];
GO
IF OBJECT_ID(N'[dbo].[FK_GameTeam1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_GameTeam1];
GO
IF OBJECT_ID(N'[dbo].[FK_LeagueTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teams] DROP CONSTRAINT [FK_LeagueTeam];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamFootballer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Footballers] DROP CONSTRAINT [FK_TeamFootballer];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTeam_Team]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserTeam] DROP CONSTRAINT [FK_UserTeam_Team];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTeam_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserTeam] DROP CONSTRAINT [FK_UserTeam_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Footballers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Footballers];
GO
IF OBJECT_ID(N'[dbo].[Games]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Games];
GO
IF OBJECT_ID(N'[dbo].[Leagues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Leagues];
GO
IF OBJECT_ID(N'[dbo].[Teams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teams];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[UserTeam]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserTeam];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [userName] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [firstName] nvarchar(max)  NOT NULL,
    [lastName] nvarchar(max)  NOT NULL,
    [role] int  NOT NULL,
    [email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Teams'
CREATE TABLE [dbo].[Teams] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [stadium] nvarchar(max)  NOT NULL,
    [manager] nvarchar(max)  NOT NULL,
    [founded] datetime  NOT NULL,
    [points] smallint  NOT NULL,
    [wins] smallint  NOT NULL,
    [losts] smallint  NOT NULL,
    [draws] smallint  NOT NULL,
    [League_Id] int  NOT NULL
);
GO

-- Creating table 'Leagues'
CREATE TABLE [dbo].[Leagues] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [country] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Footballers'
CREATE TABLE [dbo].[Footballers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [age] nvarchar(max)  NOT NULL,
    [nationality] nvarchar(max)  NOT NULL,
    [datеOfBirth] datetime  NOT NULL,
    [height] smallint  NOT NULL,
    [weight] smallint  NOT NULL,
    [number] smallint  NOT NULL,
    [position] nvarchar(max)  NOT NULL,
    [Team_Id] int  NOT NULL
);
GO

-- Creating table 'Games'
CREATE TABLE [dbo].[Games] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [result] nvarchar(max) NULL,
    [matchDate] datetime  NOT NULL,
    [homeTeam_Id] int  NOT NULL,
    [awayTeam_Id] int  NOT NULL
);
GO

-- Creating table 'UserTeam'
CREATE TABLE [dbo].[UserTeam] (
    [Users_Id] int  NOT NULL,
    [Teams_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [PK_Teams]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Leagues'
ALTER TABLE [dbo].[Leagues]
ADD CONSTRAINT [PK_Leagues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Footballers'
ALTER TABLE [dbo].[Footballers]
ADD CONSTRAINT [PK_Footballers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [PK_Games]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Users_Id], [Teams_Id] in table 'UserTeam'
ALTER TABLE [dbo].[UserTeam]
ADD CONSTRAINT [PK_UserTeam]
    PRIMARY KEY NONCLUSTERED ([Users_Id], [Teams_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Users_Id] in table 'UserTeam'
ALTER TABLE [dbo].[UserTeam]
ADD CONSTRAINT [FK_UserTeam_User]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Teams_Id] in table 'UserTeam'
ALTER TABLE [dbo].[UserTeam]
ADD CONSTRAINT [FK_UserTeam_Team]
    FOREIGN KEY ([Teams_Id])
    REFERENCES [dbo].[Teams]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTeam_Team'
CREATE INDEX [IX_FK_UserTeam_Team]
ON [dbo].[UserTeam]
    ([Teams_Id]);
GO

-- Creating foreign key on [League_Id] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [FK_LeagueTeam]
    FOREIGN KEY ([League_Id])
    REFERENCES [dbo].[Leagues]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LeagueTeam'
CREATE INDEX [IX_FK_LeagueTeam]
ON [dbo].[Teams]
    ([League_Id]);
GO

-- Creating foreign key on [Team_Id] in table 'Footballers'
ALTER TABLE [dbo].[Footballers]
ADD CONSTRAINT [FK_TeamFootballer]
    FOREIGN KEY ([Team_Id])
    REFERENCES [dbo].[Teams]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamFootballer'
CREATE INDEX [IX_FK_TeamFootballer]
ON [dbo].[Footballers]
    ([Team_Id]);
GO

-- Creating foreign key on [homeTeam_Id] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_GameTeam]
    FOREIGN KEY ([homeTeam_Id])
    REFERENCES [dbo].[Teams]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GameTeam'
CREATE INDEX [IX_FK_GameTeam]
ON [dbo].[Games]
    ([homeTeam_Id]);
GO

-- Creating foreign key on [awayTeam_Id] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_GameTeam1]
    FOREIGN KEY ([awayTeam_Id])
    REFERENCES [dbo].[Teams]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GameTeam1'
CREATE INDEX [IX_FK_GameTeam1]
ON [dbo].[Games]
    ([awayTeam_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------