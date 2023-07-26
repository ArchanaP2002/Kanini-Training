
CREATE TABLE Author 
  ( 
     Id   BIGINT IDENTITY(1, 1) NOT NULL, 
     ProductName NVARCHAR(50) NOT NULL,
	 Price float not null,
	 City Int not null,
     PRIMARY KEY (Id) 
  ) 
  CREATE TABLE Product
  ( 
     Id   BIGINT IDENTITY(1, 1) NOT NULL, 
     ProductName NVARCHAR(50) NOT NULL,
	 Price float not null,
	 City Int not null,
     PRIMARY KEY (Id) 
  ) 

  select * from Product