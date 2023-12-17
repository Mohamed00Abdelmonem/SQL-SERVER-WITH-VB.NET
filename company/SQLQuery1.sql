

--datbase name = company

CREATE TABLE Managers (
    ManagerID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Department NVARCHAR(50)
);

-- Create Employees Table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Department NVARCHAR(50),
    Salary DECIMAL(10, 2),
    ManagerID INT,
    FOREIGN KEY (ManagerID) REFERENCES Managers(ManagerID)
);

-- Create Customers Table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    Phone NVARCHAR(20),
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);


select * from Customers;



INSERT INTO Managers (ManagerID, FirstName, LastName, Department)
VALUES
    (5, N'أحمد', N'محمد', N'الموارد البشرية'),
    (6, N'فاطمة', N'علي', N'التسويق');



INSERT INTO Employees (EmployeeID, FirstName, LastName, Department, Salary, ManagerID)
VALUES
    (4, N'محمد', N'أحمد', N'التقنية', 6000.00, 5),
    (5, N'سارة', N'خالد', N'المبيعات', 5500.00, 6);



INSERT INTO Customers (CustomerID, FirstName, LastName, Email, Phone, EmployeeID)
VALUES
    (3, N'علي', N'محمود', N'ali@example.com', N'0123456789', 4),
    (4, N'نور', N'عبد الله', N'nour@example.com', N'9876543210', 5);
