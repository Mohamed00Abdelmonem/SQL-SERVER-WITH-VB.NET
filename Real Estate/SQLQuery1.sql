CREATE TABLE Properties (
    PropertyID INT PRIMARY KEY,
    PropertyName NVARCHAR(100),
    PropertyType NVARCHAR(50),
    PurchasePrice DECIMAL(18, 2),
   
);

CREATE TABLE Investors (
    InvestorID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    InvestmentAmount DECIMAL(18, 2)
);

CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY,
    PropertyID INT FOREIGN KEY REFERENCES Properties(PropertyID),
    InvestorID INT FOREIGN KEY REFERENCES Investors(InvestorID),
 
);



-- Insert sample data with Arabic names
INSERT INTO Properties VALUES (1, N'عقار سكني أ', N'سكني', 200000);
INSERT INTO Properties VALUES (2, N'عقار تجاري ب', N'تجاري', 300000);

INSERT INTO Investors VALUES (1, N'احمد', N'محمد', 'amed@gamil.com', '123-456-7890', 100000);
INSERT INTO Investors VALUES (2, N'امير', N'حسن', 'amer@gamil.com', '987-654-3210', 150000);

INSERT INTO Transactions VALUES (1, 1, 1);
INSERT INTO Transactions VALUES (2, 2, 2);
