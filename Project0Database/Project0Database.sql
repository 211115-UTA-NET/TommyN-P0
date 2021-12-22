-- Create My Item Storage Database

CREATE TABLE Account
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(25) NOT NULL,
    "Password" VARCHAR(20) NOT NULL,
)

CREATE TABLE Customer
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FName VARCHAR(25) NOT NULL,
    LName VARCHAR(25) NOT NULL,
    AccountId INT FOREIGN KEY REFERENCES Account(Id),
)

CREATE TABLE StoreList
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    "Name" VARCHAR(50) NOT NULL,
    "Location" VARCHAR(150) NOT NULL,
)

CREATE TABLE ProductList
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    "Name" VARCHAR(100) NOT NULL,
    Price MONEY NOT NULL,
    Stock INT NOT NULL DEFAULT(0),
    "Limit" INT NOT NULL DEFAULT(0),
    StoreId INT FOREIGN KEY REFERENCES StoreList(Id),
)

CREATE TABLE Invoice
(
    Id INT IDENTITY(1,1),
    ProductListId INT FOREIGN KEY REFERENCES ProductList(Id),
    "Date" DATETIME2(3) NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Amount INT NOT NULL,
    Destination VARCHAR(250) NOT NULL,
    CustomerId INT FOREIGN KEY REFERENCES Customer(Id),
    CONSTRAINT PK_Receipt PRIMARY KEY (Id, ProductListId),
)

--Create inventory in stores
INSERT StoreList
    ("Name", "Location")
VALUES
    ('Walmart', 'Sydney, NY'),
    ('Target', 'Albany, NY');

INSERT ProductList
    ("Name", Price, Stock, "Limit", StoreId)
VALUES
    --Walmart
    ('Orange Juice', 1.99, 1000, 10, 1),
    ('Turkey Slices', 1.99, 1000, 10, 1),
    ('Water Jug', 0.99, 500, 4, 1),

    --Target
    ('IPhone Charger', 24.99, 100, 2, 2),
    ('XBox X', 299.99, 50, 1, 2);

--JohnDoe Account
INSERT Account
    (Username, "Password")
VALUES
    ('JohnDoe','password123');

INSERT Customer
    (FName, LName, AccountId)
VALUES
    ('John', 'Doe', 1);

--Walmart purchases
INSERT Invoice
    (ProductListId, Amount, Destination, CustomerId)
VALUES
    (2, 4, 'Home', 1),
    (3, 2, 'Home', 1);

--Target purchases
INSERT Invoice
    (ProductListId, Amount, Destination, CustomerId)
VALUES
    (5, 1, 'Home', 1);

--John Doe's Invoice
SELECT c.FName, c.LName, i.Date, p.Name AS Item, i.Amount
FROM Customer AS c
LEFT JOIN Invoice AS i
ON c.Id = i.CustomerId
LEFT JOIN ProductList AS p
ON i.ProductListId = p.Id
WHERE c.Id = 1;

--Walmart stock
SELECT s.Name, p.Name AS Item, p.Stock
FROM StoreList AS s
INNER JOIN ProductList AS p
ON s.Id = p.StoreId
WHERE s.Name = 'Walmart'

SELECT s.Name, p.Name AS Item, p.Stock
FROM StoreList AS s
INNER JOIN ProductList AS p
ON s.Id = p.StoreId
WHERE s.Name = 'Target'