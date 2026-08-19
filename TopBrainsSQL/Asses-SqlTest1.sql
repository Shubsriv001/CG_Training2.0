-- Question 1 - Normalized Database Design

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100) NOT NULL,
    CustomerPhone VARCHAR(20),
    CustomerCity VARCHAR(50)
);

CREATE TABLE SalesPersons
(
    SalesPersonID INT PRIMARY KEY,
    SalesPersonName VARCHAR(100) NOT NULL
);

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL
);

CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    OrderDate DATE NOT NULL,
    CustomerID INT NOT NULL,
    SalesPersonID INT NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (SalesPersonID) REFERENCES SalesPersons(SalesPersonID)
);

CREATE TABLE OrderDetails
(
    OrderID INT,
    ProductID INT,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (OrderID, ProductID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);


-- Question 2 - Third Highest Total Sales

WITH OrderTotals AS
(
    SELECT 
        OrderID,
        SUM(Quantity * UnitPrice) AS TotalSales
    FROM OrderDetails
    GROUP BY OrderID
),
RankedOrders AS
(
    SELECT 
        OrderID,
        TotalSales,
        DENSE_RANK() OVER (ORDER BY TotalSales DESC) AS SalesRank
    FROM OrderTotals
)
SELECT OrderID, TotalSales
FROM RankedOrders
WHERE SalesRank = 3;


-- Question 3 - Salespersons With Revenue Greater Than 60000

SELECT 
    sp.SalesPersonName,
    SUM(od.Quantity * od.UnitPrice) AS TotalSales
FROM SalesPersons sp
JOIN Orders o
    ON sp.SalesPersonID = o.SalesPersonID
JOIN OrderDetails od
    ON o.OrderID = od.OrderID
GROUP BY sp.SalesPersonName
HAVING SUM(od.Quantity * od.UnitPrice) > 60000;


-- Question 4 - Customers Spending More Than Average

WITH CustomerTotals AS
(
    SELECT 
        c.CustomerName,
        SUM(od.Quantity * od.UnitPrice) AS TotalSpent
    FROM Customers c
    JOIN Orders o
        ON c.CustomerID = o.CustomerID
    JOIN OrderDetails od
        ON o.OrderID = od.OrderID
    GROUP BY c.CustomerName
)
SELECT CustomerName, TotalSpent
FROM CustomerTotals
WHERE TotalSpent >
(
    SELECT AVG(TotalSpent)
    FROM CustomerTotals
);


-- Question 5 - String and Date Functions

SELECT
    UPPER(CustomerName) AS CustomerName,
    MONTH(OrderDate) AS OrderMonth,
    OrderDate
FROM Sales_Raw
WHERE MONTH(CONVERT(DATE, OrderDate)) = 1
  AND YEAR(CONVERT(DATE, OrderDate)) = 2026;
