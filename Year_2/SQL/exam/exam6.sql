create table Product_Lines (
Name varchar(30) not null,
Description varchar(256),
constraint PK_ProductLines primary key(Name)
);

create table Products (
ID integer not null,
Product_Name varchar(100) not null,
Product_Line_Name varchar(30),
Price decimal(5,2),
Quantity integer,
constraint PK_Product primary key(ID),
constraint FK_Product foreign key(Product_Line_Name) references Product_Lines(Name)
);

select * from Product_Lines;
select * from Products;

insert into product_lines
values('Шоколадови вафли', 'В серията са включени вафли с шоколадова глазура');
insert into product_lines
values('Диетични вафли', 'Серия диетични вафли с натурални продукти');

insert into products
values(23, 'Мура лешник', 'Шоколадови вафли', '0.95', 523);
insert into products
values(24, 'Мура шоколад', 'Шоколадови вафли', '0.92', 600);
insert into products
values(46, 'Лимецка', 'Диетични вафли', '1.25', 892);

select p.product_name, pl.name, pl.description
from products p
inner join product_lines pl on p.Product_Line_Name=pl.Name;

select product_name, name, description
from product_lines 
inner join products on product_lines.Name=products.Product_Line_Name;

select product_name, price
from products
where price=(select max(price) from products);

update products
set quantity=(quantity-200)
where id=24;