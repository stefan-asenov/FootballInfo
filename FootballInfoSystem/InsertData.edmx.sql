
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/16/2013 23:00:44
-- Generated from EDMX file: C:\Users\Kiril\Documents\git\FootballInfo\FootballInfoSystem\FootballSystemModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FootballSystemDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

INSERT INTO Leagues ([name], [country])
VALUES ('Premiera Division', 'Spain');

INSERT INTO Users ([userName], [password], [firstName], [lastname], [role])
VALUES ('admin', 'Abcd1234', 'Stefan', 'Stoyanov', 1),
      ('user', '12341234', 'Kiril', 'Dayradzhiev', 2);

INSERT INTO Teams (name, stadium, manager, founded, points, wins, losts, draws, League_Id) 
VALUES ('Barcelona', 'Camp Nou', 'Tito Vilanova', '6.6.1899', 15, 4, 1, 3, (SELECT Id from Leagues WHERE country = 'Spain')),
	   ('Real Madrid', 'Santiago Bernabeu', 'Jose Mourinho', '1.2.1902', 12, 4, 4, 0, (SELECT Id from Leagues WHERE country = 'Spain')),
	   ('Valencia', 'Mestalla', 'Ernesto Valverde', '11.8.1919', 13, 4, 3, 1, (SELECT Id from Leagues WHERE country = 'Spain')),
	   ('Atletico Madrid', 'Vicenete Calderon', 'Diego Simeone', '2.3.1903', 13, 3, 1, 4, (SELECT Id from Leagues WHERE country = 'Spain')),
	   ('Malaga', 'La Rossaleda', 'Manuel Pelegrini', '3.4.1948', 10, 3, 4, 1, (SELECT Id from Leagues WHERE country = 'Spain'));

INSERT INTO Footballers (name, age, nationality, [datеOfBirth], height, [weight], number, position, Team_Id) VALUES ('Lionel Messi', 25, 'Argentina', '6.6.1987', 169, 65, 10, 'Forward', (SELECT Id from Teams WHERE name = 'Barcelona')),('David Villa', 31, 'Spain', '10.5.1982', 175, 72, 7, 'Forward', (SELECT Id from Teams WHERE name = 'Barcelona')),('Andres Iniesta', 28, 'Spain', '12.3.1985', 173, 71, 8, 'Midfield', (SELECT Id from Teams WHERE name = 'Barcelona')),('Carles Puyol', 34, 'Spain', '8.8.1979', 177, 75, 3, 'Defender', (SELECT Id from Teams WHERE name = 'Barcelona')),('Victor Valdes', 31, 'Spain', '11.1.1982', 181, 76, 1, 'Goalkeeper', (SELECT Id from Teams WHERE name = 'Barcelona'));