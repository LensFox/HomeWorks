--lesson8
use HomeTask

select top (1) tab.Airport, sum(tab.FlightsCount) as [Count] from
(select DepartureAirport as Airport, count(*) as FlightsCount
from Flights
group by DepartureAirport
union all
select ArrivalAirport, count(*)
from Flights
group by ArrivalAirport) tab
group by Airport
order by [Count] desc

insert TicketFlies
(TicketNumber, FlightId, FareConditions, Amount, BoardingNumber, SeatNumber)
values
('PL7665589900', 'PT9087', 'smth', '1', '876613', '44'),
('UA7343289900', 'SQL1517','smth', '1', '986543', '76'),
('PK8766778997', 'PT9087', 'smth', '17', '876547', '54'),
('UK8766789006', 'SQL1517','smth', '17', '876547', '54')

select a.City, sum(d.TotalSum)/sum(d.TotalAmount) as Price from Airports a
left join
Flights b
on a.AirportCode = b.ArrivalAirport
left join TicketFlies c
on b.FlightId = c.FlightId
left join Tickets d
on c.TicketNumber = d.TicketNumber
group by a.City

select t1.PassengerName, t1.TotalSum, t1.TotalSum/t1.TotalAmount as TicketPrice, t2.TotalSum as OtherTicketsTotalSum
from Tickets t1
left join Tickets t2
on t1.PassengerId = t2.PassengerId and t1.TicketNumber != t2.TicketNumber

--lesson9
select * from Flights where ScheduledDeparture != ActualDeparture

select ScheduledDeparture from Flights
except
select ActualDeparture from Flights

create view viewOne
	as
	select a.TicketNumber, c.FlightNumber, c.ArrivalAirport, c.ActualArrival from Tickets a
	left join
	TicketFlies b
	on a.TicketNumber = b.TicketNumber
	left join Flights c
	on b.FlightId = c.FlightId
	with check option
go

create view viewTwo
	as
	select a.FlightNumber, c.AircraftCode, c.SeatsNumber from Flights a
	join
	(select BoardingNumber, FlightId from TicketFlies 
	group by FlightId, BoardingNumber) b
	on a.FlightId = b.FlightId
	join Aircrafts c
	on b.BoardingNumber = c.AircraftCode
	with check option
go

update TicketFlies
set BoardingNumber = 'BC-392' where FlightId = 'PT9087' and Amount=17
update TicketFlies
set BoardingNumber = 'FG-762' where FlightId = 'PT9087'
update TicketFlies
set BoardingNumber = 'TH-402' where FlightId = 'SQL1517'
