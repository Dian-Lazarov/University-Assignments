select firstName, lastName, country
from employees
join offices using (officeCode);

select firstName, lastName, country
from employees, offices
where country='Australia';

select orderNumber, customerName, orderDate
from orders
join customers using (customerNumber);

select orderNumber, productCode,
quantityOrdered * priceEach
from orders
join orderdetails using (orderNumber);

select
concat(m.lastName, ',', m.firstName) as Manager,
concat(e.lastName, ',', e.firstName) as 'Direct Report'
from employees e
inner join employees m on
m.employeeNumber=e.reportsTo
order by Manager;

select firstName, lastName, customerName
from employees
join customers on employeeNumber=salesRepEmployeeNumber
order by firstName, lastName;

select customerName, contactFirstName, contactLastName, checkNumber, paymentDate
from customers
join payments using(customerNumber)
order by customerName, paymentDate;

select customerName, contactFirstName, contactLastName, checkNumber, amount
from customers
join payments using(customerNumber)
order by customerName, amount;

select checkNumber, amount, country
from payments
join customers using(customerNumber)
where country='France' or 'USA' or 'Poland';

