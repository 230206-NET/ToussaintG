--SQL
--Structured Query Language

DROP Table Users;
DROP Table Admin;
DROP Table Expense;

Create Table Users(
    FirstName NVARCHAR,
    LastName NVARCHAR,
    Username NVARCHAR,
    Password NVARCHAR,
    employeeID INT
);

Create Table Admin(
    FirstName NVARCHAR,
    LastName NVARCHAR,
    Username NVARCHAR,
    Password NVARCHAR,
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