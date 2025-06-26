select customername, orderdate
from customers
inner join orders using(customernumber)
where orderdate=(select max(orderDate) from orders);

SELECT o.city, COUNT(e.employeeNumber) AS employeeCount
FROM offices o
JOIN employees e ON o.officeCode = e.officeCode
GROUP BY o.city
ORDER BY employeeCount DESC
LIMIT 1;

select country, count(customernumber) as Client_Count
from customers
group by country
order by Client_Count desc
LIMIT 1;

select productname, sum(quantityordered) as Total_Quantity
from products
inner join orderdetails on products.productCode=orderdetails.productCode
group by productName
order by Total_Quantity desc
limit 1;

SELECT firstName, lastName
FROM employees
WHERE officeCode = (
    SELECT officeCode
    FROM employees
    GROUP BY officeCode
    ORDER BY COUNT(*) DESC
    LIMIT 1
);

select productname, quantityordered, orderdate
from products
inner join orderdetails on products.productCode=orderdetails.productCode
inner join orders on orderdetails.orderNumber=orders.orderNumber
where orderdate=(select min(orderdate) from orders);

select customername, amount
from customers
inner join payments using(customernumber)
where amount=(select min(amount) from payments);

select productname, quantityinstock
from products
where quantityInStock = (
select max(quantityInStock) from products
);

select productname, textdescription, sum(quantityordered) as Most_Frequent
from products
inner join orderdetails using(productcode)
inner join productlines on products.productLine=productlines.productLine
group by productname, textDescription
order by Most_Frequent desc
limit 5;

select city, count(customerNumber) as Client_Count
from customers
group by city
order by Client_Count desc
limit 2;

select city, count(ordernumber) as Orders_Count
from customers
join orders on customers.customerNumber=orders.customerNumber
group by city
order by Orders_Count desc
limit 1;

select productvendor, productname, buyprice
from products
where buyprice = (
select min(buyprice)
from products
);

SELECT c.customerName, o.orderNumber, SUM(od.quantityOrdered * od.priceEach) AS orderTotal
FROM orders o
JOIN orderdetails od ON o.orderNumber = od.orderNumber
JOIN customers c ON o.customerNumber = c.customerNumber
GROUP BY o.orderNumber, c.customerName
HAVING orderTotal > (
    SELECT AVG(order_total)
    FROM (
        SELECT SUM(quantityOrdered * priceEach) AS order_total
        FROM orderdetails
        GROUP BY orderNumber
    ) AS all_orders
)
ORDER BY orderTotal DESC;

select customername, paymentdate, amount
from customers
inner join payments using(customerNumber)
where paymentDate = (
select min(paymentDate)
from payments
);

select customername, count(paymentDate) as Payment_Count
from customers
inner join payments using(customernumber)
group by customerName
order by Payment_Count desc
limit 1;

select firstname, lastname, amount
from customers
inner join employees on customers.salesRepEmployeeNumber=employees.employeeNumber
inner join payments on customers.customerNumber=payments.customerNumber
where amount = (
select max(amount)
from payments
);

SELECT 
    c.customerName,
    order_totals.totalOrderValue,
    IFNULL(payment_totals.totalPayment, 0) AS totalPayment
FROM customers c
JOIN (
    SELECT o.customerNumber, SUM(od.quantityOrdered * od.priceEach) AS totalOrderValue
    FROM orders o
    JOIN orderdetails od ON o.orderNumber = od.orderNumber
    GROUP BY o.customerNumber
) AS order_totals ON c.customerNumber = order_totals.customerNumber
LEFT JOIN (
    SELECT p.customerNumber, SUM(p.amount) AS totalPayment
    FROM payments p
    GROUP BY p.customerNumber
) AS payment_totals ON c.customerNumber = payment_totals.customerNumber
WHERE order_totals.totalOrderValue > IFNULL(payment_totals.totalPayment, 0);

SELECT e.employeeNumber, e.firstName, e.lastName, COUNT(sub.employeeNumber) AS numberOfSubordinates
FROM employees e
JOIN employees sub ON sub.reportsTo = e.employeeNumber
GROUP BY e.employeeNumber, e.firstName, e.lastName
ORDER BY numberOfSubordinates DESC
LIMIT 1;