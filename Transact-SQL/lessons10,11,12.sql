--lesson10
use HomeTask

update Flights
set AircraftCode = 'TU-646' where FlightNumber = 'LA8780BZ'
update Flights
set AircraftCode = 'FG-762' where FlightNumber = 'FK-9876-GB'
insert Flights
values
('TV8765', 'TC-8752-IR', '2022-10-06 13:24:00 +01:00', 'CDG','LHR', 'on time','TH-402', null, null),
('IQ9105', 'UB-8057-OM', '2022-10-03 19:12:00 +04:00', 'ESB','POZ', 'on time','FG-762', null, null)

select FlightNumber from Flights
where AircraftCode = (select AircraftCode from Aircrafts
where Aircrafts.DistanceRange = (select Max(Aircrafts.DistanceRange) from Aircrafts))

select FlightNumber, Airports.City, Aircrafts.Model from Flights
left join Airports on Flights.ArrivalAirport = Airports.AirportCode
left join Aircrafts on Flights.AircraftCode = Aircrafts.AircraftCode

select distinct PassengerName, BookDate, TotalSum from Tickets where exists
(select distinct PassengerName, max(BookDate) from Tickets
group by PassengerName)

--lesson11

create clustered index IX_CL_Tickets_PassengerName on Tickets(PassengerName)
go

create index IX_Tickets_FlightNumber_ArrivalAirport_FlightStatus
	on Flights(FlightNumber, ArrivalAirport, FlightStatus)

create index IX_Airports_City on Airports(City)

create index IX_TicketFlies_TicketNumber_FlightId_BoardingNumber
	on TicketFlies(TicketNumber,FlightId, BoardingNumber)

--lesson12

declare @counter int = 0
while @counter <30
	begin
	set @counter = @counter + 1
	if @counter%3 = 0
		begin
		continue
		end
		else if @counter%4 = 0
		begin
		continue
		end
		else if @counter%5 = 0
		begin
		continue
		end
		else 
		begin
		print @counter
		end
	end


	--another task
	declare @number int = 9, @denominator int = 2
	declare @result bit = 0

	while @denominator <= sqrt(@number)
		begin
		if @number%@denominator = 0
			begin
			set @denominator = @denominator +1
			set @result = 0
			break
			end
		else 
			begin
			set @denominator = @denominator +1
			set @result = 1
			end
		end

	if @result = 1
		begin
		print Cast(@number as varchar) + ' is a prime number'
		end
	else
		begin
		print Cast(@number as varchar) + ' is NOT a prime number'
		end
go

--another task ???

declare @number int = 9
declare @denominator int = @number, @denominator2 int,  @finalResult int
declare @result bit = 0

	while @denominator > 1
	begin
		if @number%@denominator = 0
		begin
		set @denominator2 = 2
			while @denominator2 <= sqrt(@denominator)
			begin
				if @denominator%@denominator2 = 0
				begin
					set @result = 0
					break
				end
				else 
				begin
					set @denominator2 = @denominator2 +1
					set @result = 1
				end
			end
			
			if @result = 1
			begin
				set @finalResult = @denominator
				break
			end
			else 
			begin
				set @denominator = @denominator - 1
			end
		end
	end

	print Cast(@finalResult as varchar)
	
