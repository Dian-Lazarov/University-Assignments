create table Departments (
ID_D varchar(3) not null,
Department_Name varchar(100),
constraint PK_Department primary key(ID_D)
);

create table Students (
ID_S varchar(6) not null,
Student_Name varchar(100),
Department_ID varchar(3),
Results decimal(4,2),
Birth_Date date,
constraint PK_Student primary key(ID_S),
constraint FK_Student foreign key(Department_ID) references Departments(ID_D)
);

select * from Departments;
drop table Departments;
select * from Students;
drop table Students;
truncate table departments;
truncate table students;

insert into departments
values('001', 'Компютърни системи и технологии');
insert into departments
values('002', 'Информационни и комуникационни технологии');

insert into students
values('233023','Иван Петров Иванова', '001', 33.50, '2005-12-23');
insert into students
values('233043','Алекс Драгомиров Колев', '001', 36, '2005-03-02');
insert into students
values('233046','Ивайла Стоименова Николова', '002', 30.25, '2005-06-24');

select student_name, department_name, results
from students
inner join departments on students.Department_ID=departments.ID_D
order by Results DESC;

select student_name, results
from students
where results=(select max(results) from students);

select department_name, count(ID_S) as Number_Of_Candidates
from departments
inner join students on departments.ID_D=students.Department_ID
group by Department_Name;