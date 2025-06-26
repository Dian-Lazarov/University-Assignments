create table Offices (
ID integer,
City varchar(100) not null,
Country varchar(100),
constraint PK_Office primary key(ID)
);

create table Employees (
Empl_ID integer,
Name varchar(100) not null,
Job_Title varchar(100) not null,
Office_Code integer,
constraint PK_Employee primary key(Empl_ID),
constraint FK_Employee foreign key(Office_Code) references Offices(ID)
);

select * from offices;
select * from employees;
drop table offices;
drop table employees;
truncate table offices;
truncate table employees;

insert into Offices
values(1, 'София', 'България');
insert into Offices
values(2, 'Берлин', 'Германия');

insert into employees
values(1,'Иван Петров', 'директор', 1);
insert into employees
values(2,'Анна Смит', 'директор', 2);
insert into employees
values(3,'Никола Николов', 'продажби и маркетинг', 1);
insert into employees
values(4,'Елена Стоянова', 'администратор', 1);

select office_code, city, country, name, job_title
from offices
inner join employees on ID=Office_Code
order by city asc;

update employees
set job_title='координатор'
where office_code=1;

select city, count(employees.Name) as Number_Of_Employees
from offices
inner join employees on offices.ID=employees.Office_Code
group by city
having Number_Of_Employees>2;