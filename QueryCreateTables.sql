-- Create Tables
CREATE TABLE [Role](
	Id INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(50) NOT NULL,

	PRIMARY KEY([Id])
)

CREATE TABLE [User](
	Id INT NOT NULL IDENTITY(1,1),
	RoleId INT NOT NULL,
	Username VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Gender VARCHAR(50) NOT NULL,
	[Password] VARCHAR(50) NOT NULL,

	PRIMARY KEY([Id]),
	FOREIGN KEY(RoleId) REFERENCES [Role](Id)
)

CREATE TABLE [Header](
	Id INT NOT NULL IDENTITY(1,1),
	CustomerId INT NOT NULL,
	StaffId INT NOT NULL,
	[Date] DATE,

	PRIMARY KEY([ID]),
	FOREIGN KEY(CustomerId) REFERENCES [User](Id)
)

CREATE TABLE [Meat](
	Id INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(50),

	PRIMARY KEY([Id])
)

CREATE TABLE [Ramen](
	Id INT NOT NULL IDENTITY(1,1),
	MeatId INT NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	Broth VARCHAR(50) NOT NULL,
	Price VARCHAR(50) NOT NULL,

	PRIMARY KEY([ID]),
	FOREIGN KEY(MeatId) REFERENCES [Meat](Id)
)

CREATE TABLE [Detail](
	HeaderId INT NOT NULL,
	RamenId INT NOT NULL,
	Quantity INT NOT NULL,

	PRIMARY KEY([HeaderId], [RamenId]),
	FOREIGN KEY(HeaderId) REFERENCES Header(Id),
	FOREIGN KEY(RamenId) REFERENCES Ramen(Id),
)

-- Seeding Role Table (1 => Admin, 2 => Staff, 3 => Customer)
INSERT INTO [Role] ([Name]) VALUES
('Admin'),
('Staff'),
('Customer')

-- Seeding Meat Table
INSERT INTO [Meat] ([Name]) VALUES
('Chicken'),
('Pork'),
('Beef')

-- Seeding User Table for Admin Account (username: 'admin', password: 'admin123')
INSERT INTO [User] ([RoleId], [Username], [Email], [Gender], [Password]) VALUES
(1, 'admin', 'admin.com', 'Male', 'admin123')