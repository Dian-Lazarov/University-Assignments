select c.customerName, p.paymentDate
from customers c
join payments p on p.customerNumber=c.customerName
where p.paymentDate=(select min(p.paymentDate)
from payments p
);

select count(*) as payment_count, c.customerName
from customers c
inner join payments p using(customerNumber)
group by p.customerNumber
having payment_count=(
select max(payment_count)
from (
select count(*) as payment_count
from customers c
inner join payments p using(customerNumber)
group by p.customerNumber) as t
);

select e.firstName, e.lastName, p.amount
from employees e
inner join customers c on e.employeeNumber=c.salesRepEmployeeNumber
inner join payments p using(customerNumber)
having p.amount=(select max(p.amount)
from payments p
);

select c.customerName, sum(od.priceEach*od.quantityOrdered) as total_orders, sum(p.amount) as total_payments
from customers c
inner join payments p using(customerNumber)
inner join orders o using(customerNumber)
inner join orderdetails od using(orderNumber)
group by c.customerNumber
having total_orders>(select sum(p.amount)
from payments p
);
