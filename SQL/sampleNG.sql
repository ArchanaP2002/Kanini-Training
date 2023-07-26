CREATE TABLE Users (
  id INT PRIMARY KEY IDENTITY(1,1),
  email NVARCHAR(255) NOT NULL UNIQUE,
  password NVARCHAR(255) NOT NULL
);

CREATE TABLE Products (
  id INT PRIMARY KEY IDENTITY(1,1),
  name NVARCHAR(255) NOT NULL,
  description NVARCHAR(MAX),
  price DECIMAL(10, 2) NOT NULL,
  created_at DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Roles (
  id INT PRIMARY KEY IDENTITY(1,1),
  name NVARCHAR(255) NOT NULL
);

CREATE TABLE UserRoles (
  user_id INT NOT NULL,
  role_id INT NOT NULL,
  FOREIGN KEY (user_id) REFERENCES Users(id),
  FOREIGN KEY (role_id) REFERENCES Roles(id),
  PRIMARY KEY (user_id, role_id)
);

select * from UserRoles;
select * from Roles;
Select * from Products;

Select * from Users;