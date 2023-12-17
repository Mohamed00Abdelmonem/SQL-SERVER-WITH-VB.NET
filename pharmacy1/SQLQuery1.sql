-- Create the Drugs table
CREATE TABLE Drugs (
    DrugID INT PRIMARY KEY,
    DrugName NVARCHAR(100) NOT NULL,
    Manufacturer NVARCHAR(100),
    UnitPrice DECIMAL(10, 2) NOT NULL
);

-- Create the Customers table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Address NVARCHAR(255),
    PhoneNumber NVARCHAR(15)
);

-- Create the Sales table
CREATE TABLE Sales (
    SaleID INT PRIMARY KEY,
    DrugID INT FOREIGN KEY REFERENCES Drugs(DrugID),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    SaleDate DATETIME NOT NULL,
    Quantity INT NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL
);



INSERT INTO Drugs (DrugID, DrugName, Manufacturer, UnitPrice)
VALUES
    (1, 'باراسيتامول', 'شركة الأدوية المثلى', 5.50),
    (2, 'إيبوبروفين', 'شركة الأدوية الصيدلانية', 8.75),
    (3, 'أموكسيسيلين', 'شركة الأدوية المضادة', 12.25);



INSERT INTO Drugs (DrugID, DrugName, Manufacturer, UnitPrice)
VALUES
    (4, N'سيتريزين', N'شركة الأدوية المثلى', 15.80),
    (5, N'لوراتادين', N'شركة الأدوية الصيدلانية', 9.25),
    (6, N'أوميغا 3', N'شركة الأدوية الغذائية', 25.00)



INSERT INTO Customers (CustomerID, FirstName, LastName, Address, PhoneNumber)
VALUES
    (1, N'أحمد', N'المصري', N'شارع النيل، القاهرة', N'0123456789'),
    (2, N'فاطمة', N'السعودية', N'شارع الملك فهد، الرياض', N'0551234567'),
    (3, N'محمد', N'الجزائري', N'شارع الجمهورية، الجزائر', N'0556789012');



INSERT INTO Sales (SaleID, DrugID, CustomerID, SaleDate, Quantity, TotalAmount)
VALUES
    (1, 1, 1, GETDATE(), 3, 16.50),
    (2, 2, 2, GETDATE(), 2, 17.50),
    (3, 3, 3, GETDATE(), 1, 12.25);


