create table Recipes (
ID integer not null,
Recipe_Title varchar(100) not null,
Author varchar(100),
Time_To_Prepare integer,
constraint PK_Recipe primary key(ID)
);

create table ProductsX (
ID integer not null,
Product_Title varchar(100) not null,
Quantity integer,
constraint FK_ProductX foreign key(ID) references Recipes(ID)
);

select * from recipes;
select * from productsx;
drop table recipes;
drop table productsx;
truncate table recipes;
truncate table productsx;

insert into recipes
values(1, 'Салата с киноа', 'Иван Атанасов', 30);
insert into recipes
values(2, 'Бананов кекс', 'Светлана Стефанова', 60);

insert into productsx
values(2, 'банани', 300);
insert into productsx
values(2, 'брашно', 380);
insert into productsx
values(2, 'масло', 90);
insert into productsx
values(2, 'захар', 125);
insert into productsx
values(1, 'сирене', 200);

select p.product_title, p.quantity, r.recipe_title
from productsx p
inner join recipes r on p.ID=r.ID
where Quantity>125;

select product_title, quantity, recipe_title
from recipes
inner join productsx on recipes.ID=productsx.ID
where Quantity>125;

select product_title, quantity
from productsx
where quantity=(select max(Quantity) from productsx);

select recipe_title, count(product_title) as ProductCount
from recipes
inner join productsx using(id)
group by Recipe_Title;