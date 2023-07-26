--create table CustomerTable (CustomerId int primary key, Name nvarchar(25),EmailId nvarchar(30), Password bigint);
--create table AddressInformationTable (AddressInformationId int primary key, PresentAddress nvarchar(100) not null,PermanentAddress nvarchar(100) not null, District nvarchar(10), Country nvarchar(20),
--EmailId nvarchar(30) not null, Mobile1 bigint not null, Mobile2 bigint not null , TelephoneNo bigint not null, LoanId int );
create table login (Id int primary key  , Email nvarchar(30), Password bigint );