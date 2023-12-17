-- database name = school

CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Birthdate DATE
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50)
);

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    EnrollmentDate DATE,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);






INSERT INTO Students (StudentID, FirstName, LastName, Birthdate)
VALUES 
    (1, 'Ahmed', 'Mohamed', '2015-01-15'),
    (2, 'Ali', 'Ahmed', '2002-05-20'),
    (3, 'Hassan', 'Ali', '2000-09-10');



INSERT INTO Courses (CourseID, CourseName)
VALUES 
    (101, 'Mathematics'),
    (102, 'History'),
    (103, 'Science');



INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID, EnrollmentDate)
VALUES 
    (1, 1, 101, '2023-01-01'),
    (2, 1, 102, '2023-01-02'),
    (3, 2, 101, '2023-01-03'),
    (4, 3, 103, '2023-01-04');
