CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL
);


CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    CategoryID INT,
    TransactionDate DATETIME,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);


CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(15)
);






INSERT INTO Categories (CategoryID, CategoryName)
VALUES
    (1, 'إلكترونيات'),
    (2, 'أدوات منزلية'),
    (3, 'ملابس');




INSERT INTO Products (ProductID, ProductName, Price, CategoryID, TransactionDate)
VALUES
    (1, 'لابتوب', 3500.00, 1, '2023-01-15 09:30:00'),
    (2, 'مكواة كهربائية', 120.50, 2, '2023-01-16 14:45:00'),
    (3, 'قميص رجالي', 75.99, 3, '2023-01-17 11:20:00');




INSERT INTO Customers (CustomerID, CustomerName, PhoneNumber)
VALUES
    (1, 'محمد', '12457890'),
    (2, 'احمد', '98743210'),
    (3, 'سمير', '555124567');



