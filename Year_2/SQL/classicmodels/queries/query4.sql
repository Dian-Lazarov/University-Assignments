create table Studenti_233078 (
F_nomer varchar (6) primary key,
Name varchar (120),
R_date date,
Deposit decimal default 100,
check (Deposit > 99),
Kurs int,
check (Kurs between 1 and 4)
);

select * from Studenti_233078;
drop table Studenti_233078;
truncate Studenti_233078;

insert into Studenti_233078(F_nomer, Name, R_date, Deposit, Kurs)
values ('233078', 'Dian', '2025-07-11', 450, 2), 
		('233047', 'Gosho', '2023-03-25', 500, 3),
		('233123', 'Koko', '2025-12-04', 420, 1);

create table Specialnosti_233078 (
Kod_spec int,
Spec_name varchar(200)
);

select * from Specialnosti_233078;

alter table Studenti_233078
add(Kod_spec int);

alter table Specialnosti_233078
add constraint SP_PKEY
primary key(Kod_spec);

alter table Studenti_233078
add constraint SP_FKEY
foreign key (Kod_spec)
references Specialnosti_233078(Kod_spec);

create table Disciplini_233078 (
Kod_disc int primary key,
Disc_Name varchar(200)
);

create table Prepodavateli_233078 (
Kod_prep int primary key,
Prep_Name varchar(200),
Prep_Fam varchar(120)
);

create table Ocenki_233078 (
F_nomer int foreign key,
Kod_disc int foreign key,
Kod_prep int foreign key,
Ocenka decimal default 2,
check(Ocenka between 2 and 6) 
);

insert into Specialnosti_233078(Kod_spec, Spec_name)
values (1, 'KST'), 
		(2, 'IMK');
        
insert into Disciplini_233078(Kod_disc, Disc_Name)
values (1, 'Databases'), 
		(2, 'Web Design');
        
insert into Prepodavateli_233078(Kod_prep, Prep_Name, Prep_Fam )
values (1, 'Emil', 'Peev'), 
		(2, 'Kostadin', 'Ganev');
        
insert into Ocenki_2333078(F_nomer, Kod_disc, Kod_prep, Ocenka)
values (233078, 1, 1, 6);


