 
 create table DRIVER(DCODE int primary key, DNAME nvarchar(30) not null, DOB date, GENDER nvarchar(10));
 insert into  DRIVER values(10, 'Kenry', '06/10/2002', 'Male');
 insert into  DRIVER values(11, 'devi', '04/08/2008', 'Female');
 insert into  DRIVER values(12, 'sumi', '09/04/2012', 'Female');
 insert into  DRIVER values(14, 'siva', '08/02/2002', 'Male');
  
 
 create  table CITY(CCODE int, CNAME nvarchar(30));
 insert into  CITY values(101, 'madurai');
 insert into  CITY values(101, 'chennai');
 insert into  CITY values(101, 'mumbai');
 insert into  CITY values(101, 'delhi');
 
 create table TRAVEL(Tripid int primary key, Dcode int foreign key references DRIVER, DATE date, 
 FROM_CITY nvarchar(30), TO_CITY nvarchar(30));
 insert into TRAVEL values(200, 10, '2023-03-23', 'Madurai', 'Chennai')
insert into TRAVEL values(201, 11, '2023-03-24', 'Chennai', 'mumbai')
insert into TRAVEL values(202, 12, '2023-03-25', 'delhi', 'Chennai')
insert into TRAVEL values(203, 14, '2023-03-27', 'mumbai', 'delhi')

update TRAVEL set DATE='2023-03-20' where  Tripid=201;
--1
select*from driver where GENDER='Female' ;
--2
select*from TRAVEL where from_city='madurai' and TO_CITY='chennai';
--3
select t.Tripid from TRAVEL t inner join DRIVER d on t.Dcode=d.DCODE
where d.DNAME='kenry'
--4
select*from TRAVEL where DATE='2023-03-20';
--5 
select * from udf_driver()
--6
