
 create table Categories1 (Categoryid int primary key , CategoryName nvarchar(20));

 create table Book_borrow_master1(Borrowid int primary key, userid int, fine int);

 create table Bookses(Categoryid int foreign key references Categories1(Categoryid ) , Title  nvarchar(50), Author nvarchar(20), 
 ISBN nvarchar(10) primary key, Publisher nvarchar(20),
  Edition int, Language nvarchar(30));


 create table Users1( Userid int primary key, FirstName nvarchar(20),LastName nvarchar(20),Email nvarchar(20), 
 Phone varchar(10), Address nvarchar(20), City  nvarchar(10), State_1  nvarchar(20),
 Gender  nvarchar(20), UserType  nvarchar(20));


  create table  Subscriptiondetails1( Userid int foreign key references Users1(Userid), 
  Sub_startdate date, Sub_enddate date, Amount int);

  create table BookBorrows (Borrowid int, ISBN nvarchar(10)foreign key references Bookses(ISBN), 
  BorrowDate Date, ReturnDate Date, DueDate Date);

 
 INSERT INTO Categories1 (Categoryid, CategoryName) VALUES
 
(11, 'Technology Books'),
(12, 'Motivational Books'),
(13, 'Story'),
(15, 'History'),
(14, 'Science');


INSERT INTO Book_borrow_master1 (Borrowid, userid, fine) VALUES
(1, 101, 0);
 
 

INSERT INTO Bookses(Categoryid, Title, Author, ISBN, Publisher, Edition, Language) VALUES

--- Story Books
(13, '  WonderLand', 'Eckhart Tolle', '1572914808', ' New Age Publication', 1, 'English'),
(13, '  Cinderella', 'Stephen Hawking', '050530168', ' Pearson Education', 1, 'English'),
(13, '  The Hike', 'Jane Austen', '0413439513', 'Prentice Hall India ', 2003, 'English'),
----Science books
(14, '   Physical Science', 'Stephen Hawking', '0556318068', ' Pearson Education', 1, 'English'),
(14, '  Biology', 'Jane Austen', '0113399513', 'Prentice Hall India ', 2003, 'English'),
(14, '  Chemistry', 'Stephen Hawking', '0551807168', ' Pearson Education', 1, 'English'),
(14, '  Human Body', 'Jane Austen', '0141239513', 'Prentice Hall India ', 2003, 'English'),
--- History
(15, '  Indian History', 'Stephen Hawking', '0553580168', ' Pearson Education', 1, 'English'),
(15, '  World History', 'Jane Austen', '0141335713', 'Prentice Hall India ', 2003, 'English'),

--Technical books
(11, ' Data structures and Algorithm', 'Harper Lee', '0031120081', 'MIT press ', 50, 'English'),
(11, 'Theory of computation', 'Eckhart Tolle', '3477314808', ' Pearson Education', 1, 'English'),
(11, ' Data Base Management System', 'Stephen Hawking', '0573380108', ' Pearson Education', 1, 'English'),
(11, ' Compiler Design', 'Jane Austen', '0121439533', 'Prentice Hall India ', 2003, 'English'),
(11, ' Machine Learning', 'William L. Shirer', '1151650686', 'Pearson Educationr', 50, 'English'),
(11, ' Pattern Classification', 'Harper Lee', '5006112081', ' New Age Publication', 50, 'English'),
(11, ' Data Structures', 'Eckhart Tolle', '1572311480', ' New Age Publication', 1, 'English'),
(11, ' Python', 'Stephen Hawking', '5531803168', ' Pearson Education', 1, 'English'),
(11, ' JavaScript', 'Jane Austen', '0141396513', 'Prentice Hall India ', 2003, 'English'),
(11, ' Cloud Computing', 'Jane Austen', '024143913', 'Prentice Hall India ', 2003, 'English'),

---Motivational books
(12, '  Believe in Yourself', 'Harper Lee', '501120081', ' New Age Publication', 50, 'English'),
(12, '  One day life will change ', 'Eckhart Tolle', '1532314808', ' New Age Publication', 1, 'English'),
(12, '  Never Giveup', 'Stephen Hawking', '0543180168', ' Pearson Education', 1, 'English'),
(12, '  The power of positive attitude', 'Jane Austen', '0741339513', 'Prentice Hall India ', 2003, 'English'),
(12, '  You Can Do It', 'Harper Lee', '5063112301', ' New Age Publication', 50, 'English');





INSERT INTO Users1 (Userid, FirstName, LastName, Email, Phone, Address, City, State_1, Gender, UserType) VALUES
(111, 'John', 'Doe', 'johndoe@example.com', '1234567890', '123 Main St', 'Anytown', 'CA', 'Male', 'Student'),
(112, 'Jane', 'Doe', 'janedoe@example.com', '0987654321', '456 High St', 'Anytown', 'CA', 'Female', 'Student'),
(113, 'Bob', 'Smith', 'bobsmith@example.com', '5555555555', '789 Oak St', 'Anytown', 'CA', 'Male', 'Faculty'),
(114, 'Alice', 'Johnson', 'alicejohn@exam.com', '1112223333', '321 Pine St', 'Anytown', 'CA', 'Female', 'Staff'),
(115, 'Jack', 'Wilson', 'jackwilson@exa.com', '4444444444', '654 Elm St', 'Anytown', 'CA', 'Male', 'Alumni'),
(116, 'David', 'Smith', 'bobsmith@example.com', '5555555555', '789 Oak St', 'Anytown', 'CA', 'Male', 'Faculty'),
(117, 'Joshua', 'Edition', 'alicejohn@exam.com', '1112223333', '321 Pine St', 'Anytown', 'CA', 'Female', 'Staff'),
(118, 'Jemi', 'Wilson', 'jackwilson@exa.com', '4444444444', '654 Elm St', 'Anytown', 'CA', 'Male', 'Alumni'),
(119, 'Alen', 'Johnson', 'alicejohn@exam.com', '1112223333', '321 Pine St', 'Anytown', 'CA', 'Female', 'Staff'),
(120, 'Thom', 'Wilson', 'jackwilson@exa.com', '4444444444', '654 Elm St', 'Anytown', 'CA', 'Male', 'Alumni');

INSERT INTO Subscriptiondetails1 (Userid, Sub_startdate, Sub_enddate, Amount) VALUES
(111, '2022-01-01', '2022-12-31', 50);
 

INSERT INTO BookBorrows (Borrowid, ISBN, BorrowDate, ReturnDate, DueDate) VALUES
(1, '1572914808', '2022-01-01', '2022-01-15', '2022-01-31');
 

select * from Categories1 
select * from  Book_borrow_master1 

select * from Bookses
select * from Users1 
select * from Subscriptiondetails1 
select * from  BookBorrows 


 



  
 
  

