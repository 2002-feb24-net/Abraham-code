CREATE TABLE Customer (
	Id int PRIMARY KEY,
	Firstname nvarchar(35) NOT NULL,
	Lastname nvarchar(40),
	CardNumber nvarchar(16) NOT NULL
)

CREATE TABLE Products (
	Id int PRIMARY KEY,
	Name nvarchar(45) NOT NULL,
	Price money NOT NULL
)

CREATE TABLE Orders (
	Id int NOT NULL,
	ProductId int FOREIGN KEY REFERENCES Products(Id) NOT NULL,
	CustomerId int FOREIGN KEY REFERENCES Customer(Id) NOT NULL
)

INSERT INTO Customer (Id, Firstname, Lastname, CardNumber)
VALUES (1, 'Abraham', 'Bergerson', 1111222233334444),
		(2, 'Shawn', 'Bergerson', 2222333344445555),
		(3, 'Jeremiah', 'Bergerson', 3333444455556666)

INSERT INTO Products (Id, Name, Price)
VALUES (1, 'iPhone', 200),
		(2, 'Galaxy S10', 177),
		(3, 'Nokia', 15)

INSERT INTO Orders (Id, ProductId, CustomerId)
VALUES (1, 1, 1),
		(2, 2, 3),
		(3, 3, 1)

INSERT INTO Customer (Id, Firstname, Lastname, CardNumber)
VALUES (4, 'Tina', 'Smith', 4444555566667777)

INSERT INTO Orders (Id, ProductId, CustomerId)
VALUES (4, 1, 4)

SELECT *
FROM Orders o LEFT JOIN Customer c
	ON o.CustomerId = c.Id
WHERE c.Id = 4

SELECT Sum(Price) AS 'Total'
FROM Products p INNER JOIN Orders o
	ON p.Id = o.ProductId
WHERE o.ProductId = 1

UPDATE Products
SET Price = 250
WHERE Name = 'iPhone'

SELECT *
FROM Orders