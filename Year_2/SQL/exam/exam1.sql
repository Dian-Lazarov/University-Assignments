create database ExamPrep;

create table Courses (
Cid integer (3) primary key not null auto_increment unique,
CTitle varchar (50),
StartDate date,
EndDate date,
Instructor varchar (50),
NumberParticipants integer(30)
-- primary key (Cid),
-- constraint PK_Course primary key (Cid, CTitle)
-- foreign key(priceID) references Prices(priceID)
-- constraint FK_CoursePrice foreign key(priceID) references Prices(priceID)
);

select * from Courses;
drop table Courses; -- delete entire table
truncate table Courses; -- delete data only

insert into Courses(CTitle, StartDate, EndDate, Instructor, NumberParticipants)
values('Роботика', '2022-10-01', '2022-12-22', 'Петров', 10);
insert into Courses(CTitle, StartDate, EndDate, Instructor, NumberParticipants)
values('Математика', '2023-11-15', '2024-03-31', 'Колева', 22);
insert into Courses(CTitle, StartDate, EndDate, Instructor, NumberParticipants)
values('Изкуства', '2022-09-20', '2023-01-01', 'Анастасов', 8);
insert into Courses(CTitle, StartDate, EndDate, Instructor, NumberParticipants)
values('Музика', '2023-10-01', '2023-11-30', 'Николова', 15);
insert into Courses(CTitle, StartDate, EndDate, Instructor, NumberParticipants)
values('Танци', '2023-10-15', '2023-12-22', 'Иванова', 20);

update Courses
set NumberParticipants=13
where Cid=3;

-- alter table courses
-- add column email varchar(40) => add a column
-- drop column email => delete a column
-- rename column [old_name] to [new_name] => rename a column
-- modify column startdate year => change data type of a column
-- add constraint PK_Course primary key (cid, ctitle) => add a primary key
-- add constraint FK_PriceCourse foreign key (priceID) references Prices(priceID) => add a foreign key
-- drop primary/foreign key [constraint_name] => remove a primary/foreign key
-- add check (numberparticipants <=100) => add a check constraint
-- alter ctitle set default 'test' => add a default value
-- alter ctitle drop default => remove the default value

-- delete from Courses
-- where numberparticipants between 0 and 20

select ctitle, startdate, enddate, instructor, numberparticipants
from courses
where numberparticipants>15;

select count(*) as Ending_2023
from courses
where year(enddate)=2023;

select count(cid) as Ending_2023
from courses
where enddate like '2023%';

select ctitle, numberparticipants
from courses
where enddate<now()
order by ctitle asc;