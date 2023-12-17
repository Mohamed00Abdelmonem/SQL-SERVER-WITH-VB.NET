
--database name = restaurant 

CREATE TABLE Menus (
    MenuID INT PRIMARY KEY,
    ItemName VARCHAR(255),
    Price DECIMAL(10, 2)
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100)
);

-- Create Orders table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    MenuID INT,
    Quantity INT,
    OrderDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (MenuID) REFERENCES Menus(MenuID)
);



INSERT INTO Menus (MenuID, ItemName, Price) VALUES
    (1, 'sulat', 10.99),
    (2, 'rice', 12.99),
    (3, 'rab', 8.99);

INSERT INTO Customers (CustomerID, FirstName, LastName, Email) VALUES
    (1, 'ahmed', 'ali', 'ahmed@gamil.com'),
    (2, 'mohamed', 'ali', 'moahmed@gamil.com');

INSERT INTO Orders (OrderID, CustomerID, MenuID, Quantity, OrderDate) VALUES
    (1, 1, 1, 2, '2023-01-01'),
    (2, 2, 2, 1, '2023-01-02'),
    (3, 1, 3, 3, '2023-01-03');



