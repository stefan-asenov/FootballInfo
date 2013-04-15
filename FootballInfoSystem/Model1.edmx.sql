
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/15/2013 23:01:58
-- Generated from EDMX file: C:\Users\Kiril\Documents\git\FootballInfo\FootballInfoSystem\Model1.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [userName] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [firstName] nvarchar(max)  NOT NULL,
    [lastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Teams'
CREATE TABLE [dbo].[Teams] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [stadiumn] nvarchar(max)  NOT NULL,
    [manager] nvarchar(max)  NOT NULL,
    [founded] datetime  NOT NULL,
    [points] smallint  NOT NULL,
    [wins] smallint  NOT NULL,
    [losts] smallint  NOT NULL,
    [draws] smallint  NOT NULL,
    [League_Id] int  NOT NULL,
    [TeamGame_Team_Id] int  NOT NULL,
    [TeamGame1_Team_Id] int  NOT NULL
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
    [Team_Id] int  NOT NULL
);
GO

-- Creating table 'Games'
CREATE TABLE [dbo].[Games] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [result] nvarchar(max)  NOT NULL,
    [matchDate] datetime  NOT NULL
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

-- Creating foreign key on [TeamGame_Team_Id] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [FK_TeamGame]
    FOREIGN KEY ([TeamGame_Team_Id])
    REFERENCES [dbo].[Games]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamGame'
CREATE INDEX [IX_FK_TeamGame]
ON [dbo].[Teams]
    ([TeamGame_Team_Id]);
GO

-- Creating foreign key on [TeamGame1_Team_Id] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [FK_TeamGame1]
    FOREIGN KEY ([TeamGame1_Team_Id])
    REFERENCES [dbo].[Games]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamGame1'
CREATE INDEX [IX_FK_TeamGame1]
ON [dbo].[Teams]
    ([TeamGame1_Team_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------