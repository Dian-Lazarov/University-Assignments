create table Movies (
ID integer,
Movie_Title varchar(100) not null,
Director varchar(100),
Number_Of_Purchases integer,
Movie_Date date
);

select * from movies;

insert into movies
values(1, 'PUSS IN BOOTS: THE LAST WISH', 'Joel Crawford', 3568, '2022-12-20');
insert into movies
values(2, 'AVATAR: THE WAY OF WATER', 'James Cameron', 6034, '2022-12-27');
insert into movies
values(3, 'M3GAN', 'Gerard Johnstone', 609, '2023-01-11');
insert into movies
values(4, 'AFTERSUN', 'Charolette Wells', 102345, '2023-01-11');
insert into movies
values(5, 'THE MENU', 'Mark Mylod', 105432, '2023-01-20');

select movie_title, number_of_purchases, Movie_Date
from movies
where year(movie_date)=2022;

select count(movie_title) as Movie_Count_2023
from movies
where year(movie_date)=2023;

select movie_title, number_of_purchases
from movies
where number_of_purchases>(select avg(Number_Of_Purchases) from movies);

update movies
set number_of_purchases=(number_of_purchases-10)
where year(movie_date)=2023;