create table Exams(
ID integer not null unique,
Exam_Title varchar(256) not null,
Student_ID varchar(30),
Result decimal(3,2),
Exam_Date date,
constraint PK_Exam primary key(ID)
);

select * from exams;
drop table exams;
truncate table exams;

insert into exams
values(1, 'Английски език', '12а-10', 4.50, '2022-12-20');
insert into exams
values(2, 'Английски език', '12б-12', 6.00, '2022-12-27');
insert into exams
values(3, 'Програмиране на Java', '12б-10', 5.25, '2023-01-11');
insert into exams
values(4, 'Алгоритми', '12б-12', 5.00, '2023-01-11');
insert into exams
values(5, 'Структури от данни', '12б-12', 4.75, '2023-01-20');
insert into exams
values(6, 'Програмиране на Java', '12б-12', 5.75, '2023-01-11');

select exam_title, count(student_id) as StudentCount
from exams
group by exam_title;

select student_id, avg(result)
from exams
group by student_id;

select exam_title, student_id, result, exam_date
from exams
where year(exam_date)<2023;

update exams
set result=6.00
where student_id='12б-12' and id=6;