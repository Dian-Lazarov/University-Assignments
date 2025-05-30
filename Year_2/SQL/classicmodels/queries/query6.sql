select customerName, orderDate, orderNumber
from customers
join orders using(customerNumber)
where orderDate=(select min(orderDate) from orders
);

select max(employeeNumber), city
from offices
join employees using(officeCode)
where (select count(employeeNumber) from employees
);

select count(*) as counted_emp1, city
from employees e
inner join offices o using(officeCode)
group by o.officeCode
having counted_emp1=(
select max(counted_emp1)
from (
select count(*) as counted_emp1
from employees
inner join offices o using(officeCode)
group by o.officeCode) as t
);

select count(*) as counted_clients, country
from customers c
group by c.country
having counted_clients=(
select max(counted_clients)
from (
select count(*) as counted_clients
from customers c
group by c.country) as t2
);

select count(*) as quantity_bought, p.productName
from products p
inner join orderdetails o using(productCode)
group by productCode
having quantity_bought=(
select max(quantity_bought)
from (
select count(*) as quantity_bought
from products p
inner join orderdetails o using(productCode)
group by p.productName) as t3
);

select e.officeCode, firstName, lastName
from employees e
inner join (
select max(counted_emp2), officeCode
                    from (
                    select count(*) as counted_emp2, officeCode
                    from offices o
                    inner join employees e using(officeCode)
                    group by o.officeCode) as t4
) as t4 on t4.officeCode=e.officeCode;

select distinct productName, quantityInStock, orderDate
from products p
inner join orders o using(orderNumber)
inner join orderdetails od using(productCode)
where orderDate=(select min(orderDate) from orders
);