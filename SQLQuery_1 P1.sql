--SQL
--Structured Query Language

DROP Table Users;
DROP Table Admin;
DROP Table Expense;

Create Table Users(
    
    Username VARCHAR(50),
    Password VARCHAR(50),
    FirstName VARCHAR,
    LastName VARCHAR,
    employeeID INT
);

Create Table Admin(
   
    username VARCHAR,
    password VARCHAR,
    FirstName VARCHAR,
    LastName VARCHAR,
    adminID INT

);

Create Table Expense(
    ExpenseName NVARCHAR,
    ExpenseAmnt Money,
    IsAppoved CHAR(1)



);
SELECT * From Users

SELECT * From Admin

SELECT * From Expense