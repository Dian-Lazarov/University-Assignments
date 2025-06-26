create table CoursesX (
ID integer not null AUTO_INCREMENT unique,
Course_Title varchar(100) not null,
Course_Teacher varchar(100),
Hours integer,
Course_Date date,
constraint PK_CourseX primary key(ID)
);

select * from coursesx;
drop table coursesx;
truncate table coursesx;

insert into coursesx(course_title, course_teacher, hours, course_date)
values('Английски език', 'Иван Атанасов', 30, '2022-12-20');
insert into coursesx(course_title, course_teacher, hours, course_date)
values('Английски език', 'Светлана Стефанова', 60, '2022-12-27');
insert into coursesx(course_title, course_teacher, hours, course_date)
values('Програмиране на Java', 'Петър Колев', 60, '2023-01-11');
insert into coursesx(course_title, course_teacher, hours, course_date)
values('Алгоритми', 'Светлин Киров', 30, '2023-01-11');
insert into coursesx(course_title, course_teacher, hours, course_date)
values('Структури от данни', 'Светлин Киров', 60, '2023-01-20');

select course_title, hours, course_teacher
from coursesx
where course_teacher like '%Киров';

select count(id) as Course_Count_2023
from coursesx
where year(Course_Date)=2023;

select course_title, hours
from coursesx
where hours>(select avg(hours) from coursesx);

delete from coursesx
where hours<60;