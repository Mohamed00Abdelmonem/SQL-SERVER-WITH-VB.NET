-- name server = HospitalDB

CREATE TABLE Patients (
    PatientID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DateOfBirth DATE,
    Gender CHAR(1),
    PhoneNumber VARCHAR(15),
    Email VARCHAR(100)
);




CREATE TABLE Doctors (
    DoctorID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Specialty VARCHAR(100),
    PhoneNumber VARCHAR(15),
    Email VARCHAR(100)
);




CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY,
    PatientID INT,
    DoctorID INT,
    AppointmentDate DATETIME,
    CONSTRAINT FK_PatientID FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    CONSTRAINT FK_DoctorID FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);



-- Insert data into Patients table
INSERT INTO Patients (PatientID, FirstName, LastName, DateOfBirth, Gender, PhoneNumber, Email)
VALUES
    (1, 'Ahmed', 'abdo', '1980-05-15', 'M', '555-1234', 'mm.doe@email.com'),
    (2, 'Eman', 'ahmed', '1990-08-22', 'F', '555-5678', 'nn.smith@email.com');

-- Insert data into Doctors table
INSERT INTO Doctors (DoctorID, FirstName, LastName, Specialty, PhoneNumber, Email)
VALUES
    (1, 'Dr. Entsar', 'Ahmed', 'Cardiology', '555-4321', 'ahmed.johnson@email.com'),
    (2, 'Dr. Mohamed', 'Ahmed', 'Orthopedics', '555-8765', 'mo.williams@email.com');

INSERT INTO Appointments (AppointmentID, PatientID, DoctorID, AppointmentDate)
VALUES
    (1, 1, 1, '2023-01-10 10:00:00'),
    (2, 2, 2, '2023-01-15 14:30:00');

