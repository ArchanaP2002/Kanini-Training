select*from Hotels
select*from Reservations
select*from Users
select*from Rooms
SET IDENTITY_INSERT Rooms On
SET IDENTITY_INSERT Hotels Off

insert into Hotels (HotelId, Name, Location, Rating) values ( '5', 'EEE', 'ccc', '4');

insert into Hotels (HotelId, Name, Location, Rating) values ( '2', 'BBB', 'bbb', '3');
insert into Hotels (HotelId, Name, Location, Rating) values ( '3', 'CCC', 'ccc', '5');
insert into Hotels (HotelId, Name, Location, Rating) values ( '4', 'DDD', 'ddd', '6');

insert into Rooms (RoomId, Number, Type, Price, Availability, HotelId) values('2', '6', 'Ac',1000,'True','4');
insert into Rooms (RoomId, Number, Type, Price, Availability, HotelId) values('3', '3', 'nonAc',500,'False','3');
insert into Rooms (RoomId, Number, Type, Price, Availability, HotelId) values('4', '2', 'Ac',1000,'True','2');
insert into Rooms (RoomId, Number, Type, Price, Availability, HotelId) values('5', '5', 'nonAc',500,'True','5');
insert into Rooms (RoomId, Number, Type, Price, Availability, HotelId) values('6', '9', 'nonAc',500,'True','1');
