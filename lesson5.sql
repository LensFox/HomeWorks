/*
Подключившись к базе HomeTask, при помощи агрегатных функций и системных таблиц, подсчитать
количество таблиц в данной базе.
*/

select count(*) from sys.tables

/*
Задание 1
Получить среднее значение дальности полета самолетов и среднее значение для уникальных значений
дальности.
*/

select avg (DistanceRange) from Aircrafts
select avg(distinct DistanceRange) from Aircrafts

/*
Задание 2
Получить количество броней и их среднюю стоимость
*/

alter table Tickets
add TotalSum int

update Tickets
set TotalSum = 4567
where TotalAmount = 4
update Tickets
set TotalSum = 780
where TotalAmount = 1
update Tickets
set TotalSum = 1890
where TotalAmount = 2
update Tickets
set TotalSum = 2741
where TotalAmount = 5

select count (BookDate) from Tickets

select sum(TotalSum) / sum (TotalAmount)
from Tickets