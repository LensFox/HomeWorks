/*
ѕроанализировав таблицы базы HomeTask обеспечить целостность сущностей/ссылочную с
использованием изученных подходов
*/

alter table Tickets
add constraint UQ_Tickets_TicketNumber unique (TicketNumber)
go

alter table TicketFlies
add constraint FK_TicketFlies_Tickets foreign key (TicketNumber) references Tickets(TicketNumber)
go

alter table TicketFlies
add constraint FK_TicketFlies_Tickets foreign key (Amount) references Tickets(TotalAmount)
go

alter table Aircrafts
add constraint UQ_Aircrafts_Aitcraftcode unique (Aircraftcode)
go

alter table Flights with nocheck
add constraint FK_Flights_Aircrafts foreign key (AircraftCode) references Aircrafts(AircraftCode)
go

/*
«адание 1
ƒобавить несколько пользовательских ограничений на вводимые данные дл€ обработки возможных
некорректных значений.
*/

alter table Tickets 
add constraint CK_Flights_TicketNumber check (TicketNumber like 
'[A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
go

/*
«адание 2
ѕроанализировав таблицы и варианты возможных запросов к ним, наложить ограничени€ на
уникальность значений дл€ возможных целевых полей таблиц.
*/

use HomeTask
alter table Aircrafts 
add constraint PK_Aircrafts_AircraftCode primary key (AircraftCode)

alter table Airports 
add constraint PK_Airports_AirportCode primary key (AirportCode)

alter table Airports 
add constraint UQ_Airports_AirportName unique (AirportName)