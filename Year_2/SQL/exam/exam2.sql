create table Homeworks (
H_id integer AUTO_INCREMENT not null,
H_Title varchar(50) not null default 'None',
Points decimal(4,2) not null,
check(Points<=60.00),
H_Date date,
constraint PK_Homework primary key(H_id)
);

create table Tasks (
H_id integer not null,
Tasks_text varchar(250) not null,
Answer varchar(100) not null,
T_Points decimal(4,2),
check(T_Points<=10),
constraint FK_Task foreign key(H_id) references Homeworks(H_id)
);

select * from homeworks;
select * from tasks;
drop table homeworks;
drop table tasks;
truncate table homeworks;
truncate table tasks;

insert into homeworks(h_title, points, h_date)
values('Обикновени дроби', 30.00, '2023-01-12');
insert into homeworks(h_title, points, h_date)
values('Десетични дроби', 30.00, '2023-02-06');

insert into tasks(h_id, tasks_text, answer, t_points)
values(1, '1/2+1/4', '3/4', 10.00);
insert into tasks(h_id, tasks_text, answer, t_points)
values(1, '1/2-1/4', '1/4', 10.00);
insert into tasks(h_id, tasks_text, answer, t_points)
values(1, '1/2+1/2', '1', 10.00);
insert into tasks(h_id, tasks_text, answer, t_points)
values(2, '0.5+0.5', '1', 10.00);

select h.h_title, t.tasks_text
from homeworks h
inner join tasks t on h.h_id=t.h_id;

select h_title, count(tasks_text) as TaskCount
from homeworks
inner join tasks using (h_id)
group by h_title;

delete from homeworks
where month(h_date)=2;

update homeworks
set points=50
where h_id=2;

delete from tasks
where h_id=2;

select * from homeworks
inner join(select sum(t_points) as total_points, h_id
from tasks
group by h_id) as temp
using(h_id)
where total_points<points;