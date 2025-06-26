create table Countries (
Country varchar(25),
Continent varchar(25),
Population integer,
Area integer,
constraint PK_Country primary key(country)
);

select * from countries;
drop table countries;
truncate table countries;

insert into countries
values('България', 'Европа', 7700000, 111000);
insert into countries
values('Индия', 'Азия', 1080300000, 3300000);
insert into countries
values('Китай', 'Азия', 1306300000, 9600000);
insert into countries
values('Дания', 'Европа', 540000, 43100);
insert into countries
values('Австрия', 'Европа', 8500000, 82500);

select country, continent
from countries
where (population>130000 and area<300000);

select continent, count(country)
from countries
group by continent;

select country
from countries
where area=(select max(area) from countries);

delete from countries
where Continent='Европа';