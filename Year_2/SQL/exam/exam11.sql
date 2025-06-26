create table Studenti (
F_nomer varchar(6) not null,
Name varchar(120),
R_date date,
Deposit decimal (5,2) default 100,
check(Deposit>99),
Kurs integer,
check(Kurs between 1 and 4),
constraint PK_Stud primary key(F_nomer)
);

select * from studenti;
drop table studenti;
truncate table studenti;

insert into studenti
values('233078', 'Диан Лазаров', '2004-08-16', 450, 2, '001');
insert into studenti
values('233126', 'Владимир Стилиянов', '2005-11-05', 420, 1, '002');
insert into studenti
values('233069', 'Виктория Костадинова', '2004-06-15', 450, 2, '001');
insert into studenti
values('233077', 'Велислава Момчилова', '2002-02-09', 500, 4, '002');
insert into studenti
values('233166', 'Георги Михайлов', '2003-04-01', 470, 3, '001');

create table Specialnosti (
Kod_spec varchar(3) not null,
Spec_name varchar(200),
constraint PK_Spec primary key(Kod_spec)
);

select * from specialnosti;
drop table specialnosti;
truncate table specialnosti;

insert into specialnosti
values('001', 'Компютърни системи и технологии');
insert into specialnosti
values('002', 'Информационни и комуникационни технологии');

alter table studenti
add column Kod_spec varchar(3);
alter table studenti
add constraint FK_Stud foreign key(Kod_spec) references specialnosti(Kod_spec);

create table Disciplini (
Kod_disc varchar(7) not null,
Disc_name varchar(150),
constraint PK_Disc primary key(Kod_disc)
);

create table Prepodavateli (
Kod_prep integer not null,
Prep_name varchar(60),
Prep_fam varchar(60),
constraint PK_Prep primary key(Kod_prep)
);

create table Ocenki (
F_nomer varchar(6) not null,
Kod_disc varchar(7) not null,
Kod_prep integer not null,
Ocenka decimal(3,2) default 2,
check(Ocenka BETWEEN 2 AND 6),
constraint FK_Oc_Stud foreign key(F_nomer) references Studenti(F_nomer),
constraint FK_Oc_Disc foreign key(Kod_disc) references Disciplini(Kod_disc),
constraint FK_Oc_Prep foreign key(Kod_prep) references Prepodavateli(Kod_prep)
);

insert into disciplini
values('AE2128P', 'Бази от данни');
insert into disciplini
values('BE6034K', 'Уеб дизайн');

insert into prepodavateli
values(1, 'Ирена', 'Вълова');
insert into prepodavateli
values(2, 'Георги', 'Георгиев');

insert into ocenki
values('233078', 'AE2128P', 1, 6.00);
insert into ocenki
values('233126', 'BE6034K', 2, 5.25);
insert into ocenki
values('233069', 'BE6034K', 2, 4.50);
insert into ocenki
values('233077', 'AE2128P', 1, 5.75);
insert into ocenki
values('233166', 'AE2128P', 1, 3.80);

select * from disciplini;
select * from prepodavateli;
select * from ocenki;

update studenti
set deposit=(deposit*1.10); -- increase deposit by 10% => *1.10 || decrease deposit by 10% => *0.90

update studenti
set deposit=default
where kurs=4;

delete from specialnosti
where Kod_spec='002';

delete from studenti
where kurs=4;