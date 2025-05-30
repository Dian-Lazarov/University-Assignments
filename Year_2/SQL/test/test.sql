CREATE DATABASE TestDB;
SHOW DATABASES;
 -- single-line comment --
 /* multi-
	line
    comment
 */

CREATE TABLE Persons (
    PersonID INT NOT NULL AUTO_INCREMENT,
    Age INT,
    FirstName VARCHAR(255),
    LastName VARCHAR(255) NOT NULL,
    Address VARCHAR(255),
    City VARCHAR(255),
    GPA DOUBLE, -- FLOAT --
    PRIMARY KEY (PersonID)
    -- CONSTRAINT PK_Person PRIMARY KEY (PersonID, LastName) --
    -- CONSTRAINT CHK_Person CHECK (Age>=18 AND City='Sadness') --
);

CREATE TABLE Orders (
    OrderID int NOT NULL AUTO_INCREMENT,
    OrderNumber int NOT NULL,
    Quantity int,
    OrderDate date DEFAULT '2004-08-16',
    PersonID int,
    PRIMARY KEY (OrderID),
    FOREIGN KEY (PersonID) REFERENCES Persons(PersonID)
);
SELECT * FROM Persons;
SELECT * FROM Orders;
SELECT * FROM Orders WHERE (OrderDate = '2004-08-16' AND OrderNumber != 4836);
SELECT DISTINCT City FROM Persons; -- no duplicate values! --
SELECT * FROM Orders WHERE NOT OrderID = 1;
SELECT * FROM Persons WHERE City IN ('Plovdiv', 'Sofia', 'Varna');
-- SELECT * FROM Persons WHERE City = 'Plovdiv' OR 'Sofia' OR 'Varna'; --
SELECT * FROM Persons WHERE City = 'Burgas' AND (Age <=18 OR GPA >= 25.50) ORDER BY LastName; -- ASC (default) / DESC --
SELECT MIN(GPA) AS LowestGPA FROM Persons;
SELECT MAX(GPA) AS HighestGPA FROM Persons;
SELECT COUNT(PersonID) AS TotalPersonsRuse FROM Persons WHERE City = 'Ruse';
SELECT AVG(GPA) AS AverageGPARuse FROM Persons WHERE City = 'Ruse';
SELECT SUM(Quantity) AS TotalQuantityGlobal FROM Persons WHERE NOT PersonID = 1 AND NOT City = 'Ruse';
SELECT * FROM Persons WHERE Age BETWEEN 18 AND 35;

SELECT COUNT(PersonID), City
FROM Persons
GROUP BY City
ORDER BY COUNT(PersonID) DESC;

SELECT OrderID, Quantity,
CASE
    WHEN Quantity > 30 THEN 'The quantity is greater than 30'
    WHEN Quantity = 30 THEN 'The quantity is 30'
    ELSE 'The quantity is under 30'
END AS QuantityText
FROM Orders;

DROP TABLE Persons;
DROP TABLE Orders;

ALTER TABLE Personss
ADD ZipCode INT,
ADD Email VARCHAR(255);
-- ADD PRIMARY KEY (PersonID) --
-- ADD CONSTRAINT PK_Person PRIMARY KEY (PersonID, LastName) --
-- AUTO_INCREMENT=100 --

ALTER TABLE Persons
DROP COLUMN Email;
-- DROP PRIMARY KEY --

ALTER TABLE Persons
MODIFY COLUMN GPA FLOAT,
MODIFY Age INT NOT NULL;

INSERT INTO Persons (PersonID, Age, FirstName, LastName, Address, City, GPA, ZipCode) VALUES (3, 18, 'Yana', 'Georgieva', 'st. \"Test\" №3', 'Varna', 69.69, 6981);
UPDATE Persons SET Age = 20, FirstName='Dian' WHERE PersonID = 1;
DELETE FROM Persons WHERE PersonID = 2;