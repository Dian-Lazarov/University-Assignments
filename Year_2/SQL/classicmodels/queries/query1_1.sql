select * from customers;
select customerName, addressLine1, addressLine2
from customers
where country='USA' and state='CA';

select customerName, addressLine1, addressLine2
from customers
where country='USA' and state='CA' and creditLimit>100000;

select customerName, addressLine1, addressLine2
from customers
where country='USA' or country='Canada';

select customerName, addressLine1, addressLine2, creditLimit, country
from customers
where (country='USA' or country='Canada') and creditLimit>100000;

select productName, quantityInStock, buyPrice
from products
where quantityInStock between 7000 and 10000 and buyPrice>50;

select productName, productLine
from products
where productLine like 'Classic%';

select * from orders
where orderDate >= '2004-06-01';

select * from orders
where requiredDate=shippedDate;

select * from orders
where status='Shipped' and comments is null;

select * from orders
where status='Cancelled' and comments is not null;

select textDescription from productlines
where textDescription like '%replica%';

select firstname, lastName
from employees
where lastname like '%on%';

select firstname, lastName
from employees
where lastname not like '%B%';



