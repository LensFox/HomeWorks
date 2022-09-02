/*
Дополнительное задание
Задание
Создать пользовательскую базу данных с именем HomeTask и необходимыми параметрами сортировки
для кириллицы.

Задание 1
Подключитесь к созданной ранее базе, создать таблицы для следующей схемы.

Задание 2
Добавить ряд записей в каждую созданную таблицу (количество произвольное). Произвести
обновление, удаление некоторых записей с использованием изученных синтаксических конструкций.


*/
CREATE DATABASE MyDatabase
COLLATE Cyrillic_General_CI_AS

ALTER DATABASE MyDatabase
MODIFY NAME = HomeTask

USE HomeTask

create table Flights
(FlightId varchar(50) not null,
FlightNumber varchar(50) not null,
ScheduledDeparture datetime not null,
DepartureAirport varchar(50) not null,
ArrivalAirport varchar(50) not null,
FlightStatus varchar(40) not null,
AitcraftCode varchar(60) not null,
ActualDeparture datetime,
ActualArrival datetime);

CREATE table Tickets
(FTicketNumber varchar(50) not null,
BookDate datetime not null,
TotalAmount smallint not null,
PassengerId varchar(50) not null,
PassengerName varchar(80) not null,
ContactData varchar(120) not null);

create table Aircrafts
(AitcraftCode varchar(60) not null,
Model varchar(60) not null,
DistanceRange int not null,
SeatsNumber smallint not null,
FareConditions varchar(100) not null);

create table TicketFlies
(TicketNumber varchar(50) not null,
FlightId varchar(50) not null,
FareConditions varchar(100) not null,
Amount smallint not null,
BoardingNumber varchar(50) not null,
SeatNumber smallint);

create table Airports
(AirportCode varchar(50) not null,
AirportName varchar(50) not null,
City varchar(50) not null,
Longtitude geography not null,
Latitude geography not null,
TimeZone smallint not null);

EXEC sp_rename 'Tickets.FTicketNumber', 'TicketNumber', 'COLUMN'

alter table Flights
alter column ScheduledDeparture datetimeoffset not null
alter table Flights
alter column ActualDeparture datetimeoffset null
alter table Flights
alter column ActualArrival datetimeoffset null

Insert Flights
(FlightId, FlightNumber, ScheduledDeparture, DepartureAirport,ArrivalAirport,FlightStatus,
AitcraftCode, ActualDeparture, ActualArrival)
Values
('PT9087', 'LA8780BZ','2022-08-29 22:08:00 -09:00', 'LAX', 'LHR', 'On time', 'BG-847', null, null),
('SQL1517', 'FK-9876-GB','2022-08-25 08:57:00 +00:00', 'LHR', 'MAN', 'Delayed', 'PT-765', '2022-08-25 09:15:00 +00:00', '2022-08-25 11:47:00 +00:00')

select * from Flights

insert Tickets
(TicketNumber, BookDate,TotalAmount,PassengerId,PassengerName,ContactData)
Values
('PL7665589900', '2022-08-22T18:43:01', '4', '9394949494', 'Robert Stephenson', 'Nashville, Tennessee'),
('UA7343289900', '2022-08-18T05:02:16', '2', '3739494331', 'Tatiana Sirko', 'Kyiv, Ukraine')

select * from Airports

Update Flights
set ActualDeparture = '2022-08-29 22:08:00 -09:00', ActualArrival = '2022-08-30 03:31:00 -00:00'
where FlightId = 'PT9087'

delete Tickets
WHERE BookDate < '2022-08-20T00:00:00'

insert Aircrafts
(AitcraftCode, Model,DistanceRange,SeatsNumber,FareConditions)
Values
('TU-646', 'Boing', '3000', '265', 'send via post'),
('TH-402', 'Mriya', '2800', '157', 'no return'),
('BC-392', 'Kukuruznik', '200', '3', 'return in 14 days'),
('FG-762', 'Plane', '1500', '150', 'courier delivery')

alter table Airports
alter column Longtitude geography null
alter table Airports
alter column Latitude geography null

insert Airports
(AirportCode, AirportName, City, Longtitude, Latitude, TimeZone)
Values
('LAX', 'LAairport', 'Los Angeles', null, null, '-7'),
('BHC', 'Heathrow', 'London', null, null, '+0'),
('MAN', 'Manch', 'Manchester', null, null,'+0'),
('PAZ', 'CharlesdeGolle', 'Paris', null, null, '+1')

/*
Задание
Из созданной в предыдущем занятии БД получить следующие выборки:
- Номера самолетов, дистанция полета которых превышает 1000 или неопределенна.
- Названия всех аэропортов, первый символ названия городов которых буквы A, B или C, так же,
часовая зона имеет положительную составляющую времени.
*/
select AitcraftCode from Aircrafts
where DistanceRange > 1000 or DistanceRange is null
 
 select AirportName from Airports
 where TimeZone >=0 and AirportName like '[A-C]%'

delete Airports from
(select top 4 * from Airports) as Selected
where Airports.AirportName = Selected.AirportName
