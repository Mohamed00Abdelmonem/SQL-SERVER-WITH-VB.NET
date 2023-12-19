
CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY,
    RoomNumber INT,
    RoomType VARCHAR(50),
    Price DECIMAL(10, 2),
    IsAvailable BIT
);



CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    Phone VARCHAR(20)
);

CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY,
    RoomID INT,
    CustomerID INT,
    CheckInDate DATE,
    CheckOutDate DATE,
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);




INSERT INTO Rooms (RoomID, RoomNumber, RoomType, Price, IsAvailable)
VALUES
    (1, 101, 'Single', 80.00, 1),
    (2, 201, 'Double', 120.00, 1),
    (3, 301, 'Suite', 200.00, 1),
    (4, 102, 'Single', 80.00, 1),
    (5, 202, 'Double', 120.00, 1);





INSERT INTO Customers (CustomerID, FirstName, LastName, Email, Phone)
VALUES
    (1, 'John', 'Doe', 'john.doe@example.com', '123-456-7890'),
    (2, 'Jane', 'Smith', 'jane.smith@example.com', '987-654-3210'),
    (3, 'Bob', 'Johnson', 'bob.johnson@example.com', '555-123-4567');





INSERT INTO Bookings (BookingID, RoomID, CustomerID, CheckInDate, CheckOutDate)
VALUES
    (101, 1, 1, '2023-01-15', '2023-01-20'),
    (102, 2, 2, '2023-02-10', '2023-02-15'),
    (103, 3, 3, '2023-03-05', '2023-03-10'),
    (104, 4, 1, '2023-04-01', '2023-04-05'),
    (105, 5, 2, '2023-05-20', '2023-05-25');
