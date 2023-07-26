use Sample;
CREATE TABLE customertable 
(CustomerId int,
Cust_Name varchar(20),
Address1 varchar(30),
Address2 varchar(30)
);

ALTER TABLE customertable alter column Cust_Name varchar(30);

EXEC sp_RENAME 'customertable.Cust_Name' , 'CustomerName', 'COLUMN'

ALTER TABLE customertable add Gender varchar(1), Age tinyint, PhoneNo int;

INSERT INTO customertable(CustomerId, CustomerName, Address1, Address2, Gender, Age, PhoneNo) VALUES (1000, 'Allen','#115Chicago','#115Chicago', 'M', 25, 7878776 );
INSERT INTO customertable(CustomerId, CustomerName, Address1, Address2, Gender, Age, PhoneNo) VALUES (1001, 'George','#116France','#116France', 'M', 25, 434524 );
INSERT INTO customertable(CustomerId, CustomerName, Address1, Address2, Gender, Age, PhoneNo) VALUES (1002, 'Becker','#114New York','#114New York', 'M', 25, 431525 );

ALTER TABLE customertable ALTER COLUMN CustomerId int not null;

ALTER TABLE customertable
ADD CONSTRAINT PK_CustomerId PRIMARY KEY (CustomerId);

select CustomerId as Custid_Prim, * from customertable;

ALTER TABLE customertable DROP CONSTRAINT PK_CustomerId;

INSERT INTO customertable(CustomerId, CustomerName, Address1, Address2, Gender, Age, PhoneNo) VALUES (1002, 'Becker','#114New York','#114New York', 'M', 45, 431525);
INSERT INTO customertable(CustomerId, CustomerName, Address1, Address2, Gender, Age, PhoneNo) VALUES (1003, 'Nanapatekar','#115India','#115India', 'M', 45, 434524);

CREATE TABLE employeetable (empno int not null,
ename varchar(10), job varchar(50), mgr int, hiredate date, 
sal int, comm int, deptno int);

INSERT INTO employeetable (empno, ename, sal, deptno) VALUES
(7369, 'smith', 800, 20);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7499, 'allen', 1600, 30);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7521, 'ward', 1250, 30);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7566, 'jones', 2975, 20);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7654, 'martin', 1250, 30);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7698, 'blake', 2850, 30);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7782, 'clark', 2450, 10);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7788, 'scott', 3000, 20);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7839, 'king', 5000, 10);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7844, 'turner', 1500, 30);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7876, 'adams', 1100, 20);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7900, 'james', 950, 30);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7902, 'ford', 3000, 20);

INSERT INTO employeetable(empno, ename, sal, deptno) VALUES
(7934, 'miller', 1300, 10);

select * from employeetable;

UPDATE employeetable set deptno=(select deptno from employeetable where empno=7788) where empno=7698;

UPDATE employeetable set deptno=(select deptno from employeetable where empno=7698) where empno=7788;

INSERT INTO employeetable(empno, ename,job,mgr,hiredate, sal,comm, deptno) VALUES
(1000, 'allen','clerk',1001, '2001/01/12', 3000,2, 10);

INSERT INTO employeetable(empno, ename,job,mgr,hiredate, sal,comm, deptno) VALUES
(1001, 'george','analyst',null, '1992/09/08', 5000,0, 10);

INSERT INTO employeetable(empno, ename,job,mgr,hiredate, sal,comm, deptno) VALUES
(1002, 'becker','manager',1000, '1992/11/04', 2800,4, 20);

INSERT INTO employeetable(empno, ename,job,mgr,hiredate, sal,comm, deptno) VALUES
(1003, 'bill','clerk',1002, '1992/11/04', 3000,0, 20);

select * from employeetable;

CREATE TABLE project (projid varchar(10) not null, 
proj_name varchar(25), starting_date date, end_date date);

INSERT INTO project (projid, proj_name, starting_date, end_date) values 
(100, 'iot','2023/01/23','2023/05/23');

INSERT INTO project (projid, proj_name, starting_date, end_date) values 
(101, 'aiml','2023/02/12','2023/06/12');

INSERT INTO project (projid, proj_name, starting_date, end_date) values 
(102, 'cloud','2023/01/20','2023/05/20');

INSERT INTO project (projid, proj_name, starting_date, end_date) values 
(103, 'web','2023/03/09','2023/07/09');

select * from project;
 use kanini;
select * from dept;
insert  into dept values(1, 'cse');
insert  into dept values(2, 'ece');
insert  into dept values(3, 'cce');
create  table emp (eno int, ename nvarchar(20), addr nvarchar(30), sal int);
insert into emp values(1, 'AAA', 123, 123);
insert into emp values(1, 'BBB', 093, 103);
insert into emp values(1, 'CCC', 233, 1350);
insert into emp values(1, 'DDD', 563, 1240);
select * from emp;
select ename from emp e inner join dept d on e.deptno= d.deptno and d.deptname NOT IN ('cse');