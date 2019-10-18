CREATE TABLE [dbo].[UserProject]
(
	[UserId] INT NOT NULL, 
    [ProjectId] INT NOT NULL, 
    [IsActive] BIT NOT NULL, 
    [AssignedDate] DATETIME NOT NULL
	PRIMARY KEY ([UserId], [ProjectId]),

	CONSTRAINT FK_UserProject_User FOREIGN KEY ([UserId]) REFERENCES [User] ([Id]),
	CONSTRAINT FK_UserProject_Project FOREIGN KEY ([ProjectId]) REFERENCES [Project] ([Id])
);