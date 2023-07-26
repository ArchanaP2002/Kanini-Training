CREATE TABLE Products (
    Id INT PRIMARY KEY,
    ProductName NVARCHAR(100),
    Price FLOAT,
    City INT
);

select * from Products

CREATE TABLE Categories (
    Id INT  primary key ,
    CategoryName NVARCHAR(100)
);

 

select * from Categories

CREATE TABLE Orders (
    Id INT PRIMARY KEY,
    ProductId INT,
    Quantity INT,
    OrderDate DATETIME,
    FOREIGN KEY (ProductId) REFERENCES Products (Id)
);

select * from Orders