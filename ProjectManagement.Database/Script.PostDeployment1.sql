/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--User 1
INSERT INTO [User] (Id, FirstName, LastName) VALUES (1, 'John', 'Lennon')
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (1, DATEADD(DAY,   4, GETDATE()), DATEADD(YEAR, 2, GETDATE()), 8)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (2, DATEADD(DAY,   1, GETDATE()), DATEADD(YEAR, 1, GETDATE()), 25)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (3, DATEADD(DAY,  21, GETDATE()), DATEADD(YEAR, 4, GETDATE()), 13)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (4, DATEADD(DAY,   5, GETDATE()), DATEADD(YEAR, 1, GETDATE()), 4)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (5, DATEADD(DAY, -30, GETDATE()), DATEADD(YEAR, 0, GETDATE()), 15)

INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 1, 1, DATEADD(DAY, -5, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 2, 1, DATEADD(DAY, -5, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 3, 0, DATEADD(DAY, -6, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 4, 0, DATEADD(DAY, -2, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 5, 1, DATEADD(DAY, -1, GETDATE()))

--User 2
INSERT INTO [User] (Id, FirstName, LastName) VALUES (2, 'Paul', 'McCartney')
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (6,  DATEADD(DAY, -30, GETDATE()), DATEADD(YEAR, 1, GETDATE()), 1)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (7,  DATEADD(DAY,   1, GETDATE()), DATEADD(YEAR, 2, GETDATE()), 2)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (8,  DATEADD(DAY,  21, GETDATE()), DATEADD(YEAR, 1, GETDATE()), 3)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (9,  DATEADD(DAY, -15, GETDATE()), DATEADD(YEAR, 2, GETDATE()), 4)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (10, DATEADD(DAY, -4,  GETDATE()), DATEADD(YEAR, 3, GETDATE()), 5)

INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 6, 0, DATEADD(DAY, -1, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 7, 1, DATEADD(DAY, -2, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 8, 1, DATEADD(DAY, -3, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 9, 0, DATEADD(DAY, -4, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 10, 0, DATEADD(DAY, -5, GETDATE()))

--User 3
INSERT INTO [User] (Id, FirstName, LastName) VALUES (3, 'George', 'Harrison')
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (11, DATEADD(DAY,  20, GETDATE()), DATEADD(YEAR, 1, GETDATE()), 4)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (12, DATEADD(DAY,   3, GETDATE()), DATEADD(YEAR, 2, GETDATE()), 2)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (13, DATEADD(DAY,  21, GETDATE()), DATEADD(YEAR, 1, GETDATE()), 10)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (14, DATEADD(DAY,  -7, GETDATE()), DATEADD(YEAR, 2, GETDATE()), 13)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (15, DATEADD(DAY,  10, GETDATE()), DATEADD(YEAR, 3, GETDATE()), 8)

INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 11, 1, DATEADD(DAY, -1, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 12, 0, DATEADD(DAY, -2, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 13, 0, DATEADD(DAY, -3, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 14, 1, DATEADD(DAY, -4, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 15, 1, DATEADD(DAY, -5, GETDATE()))


