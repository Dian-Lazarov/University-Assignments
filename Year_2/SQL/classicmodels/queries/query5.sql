select count(orderNumber)
from orders
where comments is not null;

select avg(amount)
from payments
where year(paymentDate)=2003;

select count (orderNumber), status, orderDate
from orders
where status='Shipped' and year(orderDate)=2005;

select max(quantityOrdered), min(quantityOrdered)
from orderdetails;

select c.customerName, avg(p. amount)
from customers c
left join payments p on c.customerNumber=p.customerNumber
group by c.customerName;

select c.customerNumber, c.customerName, count(o.orderNumber), sum(p.amount), e.firstName, e.lastName
from customers c
join orders o on c.customerNumber=o.customerNumber
join payments p on c.customerNumber=p.customerNumber
join employees e on c.salesRepEmployeeNumber=e.employeeNumber
group by c.customerNumber;

select o.city, c.customerName, e.employeeNumber, sum(p.amount)
from offices o
join employees e on o.officeCode=e.officeCode
join customers c on o.city=c.city
join payments p on c.customerNumber=p.customerNumber
group by o.city
having o.city is not null;

select avg(p.amount), o.city, p.paymentDate
from payments p
join customers c on p.customerNumber=c.customerNumber
join offices o on c.city=o.city
group by o.city
having year(paymentDate)=2003;
