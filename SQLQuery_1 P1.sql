--SQL
--Structured Query Language

DROP Table Users;
DROP Table Admin;
DROP Table Expense;

Create Table Users(
    
    Username NVARCHAR,
    Password NVARCHAR,
    FirstName NVARCHAR,
    LastName NVARCHAR,
    employeeID INT
);

Create Table Admin(
   
    Username NVARCHAR,
    Password NVARCHAR,
    FirstName NVARCHAR,
    LastName NVARCHAR,
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