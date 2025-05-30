-- 1 --
select count(orderNumber) as CountOrders
from orders
where orderDate between '2003-03-01' and '2003-03-31';

-- 2 --
select sum(od.quantityOrdered * od.priceEach) as TotalValue
from orderdetails od
left join orders o on od.orderNumber = o.orderNumber
where status='cancelled' and year(o.orderDate) = 2004;

-- 3 --
select count(paymentDate) as PaymentCount
from payments
where year(paymentDate) = 2003;

-- 4 --
select customerNumber, paymentDate, count(paymentDate) as PaymentCount
from payments
where year(paymentDate) = 2004
group by customerNumber;

-- 5 --
select p.amount, c.country
from payments p
join customers c on p.customerNumber = c.customerNumber
order by p.amount desc;

-- 6 --
select sum(creditLimit) as TotalLimit
from customers c
join payments p on c.customerNumber=p.customerNumber
where c.country='Germany' and year(p.paymentDate)=2004;

-- 7 --
select c.customerName, c.creditLimit, sum(p.amount) as TotalSum
from customers c
left join payments p on c.customerNumber=p.customerNumber
group by c.customerName;

-- 8 --
select c.country, count(orderNumber) as OrderCount
from orders o
left join customers c on o.customerNumber = c.customerNumber
where c.country='USA' or country='Germany'
group by c.country;

-- 9 --
select count(customerNumber) as ClientCount, creditLimit
from customers
where creditLimit>200000;

-- 10 --
select count(distinct c.customerNumber) as ClientCount
from customers c
join orders o on c.customerNumber=o.customerNumber
where orderDate between '2003-03-01' and '2003-03-31';

