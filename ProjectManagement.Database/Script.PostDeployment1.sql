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
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (1, '2019-01-01', '2019-02-01', 3)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (2, '2019-01-02', '2019-02-02', 4)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (3, '2019-01-03', '2019-02-03', 5)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (4, '2019-01-04', '2019-02-04', 6)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (5, '2019-01-05', '2019-02-05', 7)

INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 1, 1, DATEADD(DAY, -1, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 2, 1, DATEADD(DAY, -2, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 3, 1, DATEADD(DAY, -3, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 4, 1, DATEADD(DAY, -4, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (1, 5, 1, DATEADD(DAY, -5, GETDATE()))

--User 2
INSERT INTO [User] (Id, FirstName, LastName) VALUES (2, 'Paul', 'McCartney')
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (6, '2019-03-01', '2019-04-01', 1)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (7, '2019-03-02', '2019-04-02', 2)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (8, '2019-03-03', '2019-04-03', 3)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (9, '2019-03-04', '2019-04-04', 4)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (10, '2019-03-05', '2019-04-05', 5)

INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 6, 1, DATEADD(DAY, -1, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 7, 1, DATEADD(DAY, -2, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 8, 1, DATEADD(DAY, -3, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 9, 1, DATEADD(DAY, -4, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (2, 10, 1, DATEADD(DAY, -5, GETDATE()))

--User 3
INSERT INTO [User] (Id, FirstName, LastName) VALUES (3, 'George', 'Harrison')
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (11, '2019-05-01', '2019-06-01', 9)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (12, '2019-05-02', '2019-06-02', 8)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (13, '2019-05-03', '2019-06-03', 7)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (14, '2019-05-04', '2019-06-04', 6)
INSERT INTO [Project] (Id, StartDate, EndDate, Credits) VALUES (15, '2019-05-05', '2019-06-05', 5)

INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 11, 1, DATEADD(DAY, -1, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 12, 1, DATEADD(DAY, -2, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 13, 1, DATEADD(DAY, -3, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 14, 1, DATEADD(DAY, -4, GETDATE()))
INSERT INTO [UserProject] (UserId, ProjectId, IsActive, AssignedDate) VALUES (3, 15, 1, DATEADD(DAY, -5, GETDATE()))


