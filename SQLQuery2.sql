CREATE TABLE Users(
	Id		    VARCHAR(255) NOT NULL UNIQUE,
	[Name]		VARCHAR(255) NOT NULL,
	Email		VARCHAR(255) NOT NULL,
	[Password]	VARCHAR(255) NOT NULL
);
GO

INSERT INTO Users(Id, [Name], Email, [Password])
VALUES				 ('123456789', 'Saulo', 'admin@email.com', 'admin123');
GO

SELECT * FROM Users;
GO