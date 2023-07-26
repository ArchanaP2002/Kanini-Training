--insert into student (rno, sname, addr,phn,dob) values( 100, 'ap', 123456 , 1234567890, '1.2.3');
drop table student;
 
 create Table student(rno smallint primary key, sname varchar(20), addr varchar(100),
 ph int, dob date);
insert into student (rno, sname, addr,ph,dob) values( 102, 'ap', 087090 , 1000005678, '2000/03/23');
insert into student (rno, sname, addr,ph,dob) values( 160, 'sdfgh', 00000 , 00045678, '2012/03/26');
insert into student values( 10, 'sdfgh', 06000 , 111118, '2004/02/16');
  
 
--select  rno, sname from student;
select rno as 'Roll No',sname as 'Student Name', dob as 'DOB' from student where dob between '2007/1/1' and '2023/1/23';
 select * from student;
 select rno as 'Roll No',sname as 'Student Name', dob as 'DOB' from student where sname like 'a-p';
  
