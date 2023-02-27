--SQL
--Structured Query Language

DROP Table Users;
DROP Table Admin;
DROP Table Expense;

Create Table Users(
    
    id int Primary key Identity,
    [UserName] VARCHAR(100) not NULL,
    [PassKey] varCHAR(100) not null,
);

Create Table Admin(
   
    username VARCHAR,
    passkey VARCHAR,
    adminID INT

);

Create Table Expense(
    ExpenseName NVARCHAR,
    ExpenseAmnt Money,
    IsAppoved CHAR(1),
    userId int FOREIGN key references users (id)
);

INSERT INTO Users (UserName, PassKey) VALUES ('Gtous', 'Onelove');

SELECT UserName, PassKey, EmployeeID from Users


SELECT * From Users

SELECT * From Admin

SELECT * From Expense
Truncate TABLE Users

Create Table Users(
    
    id int Primary key Identity,
    [UserName] VARCHAR(100) not NULL,
    [PassKey] varCHAR(100) not null,
);
Create Table Expense(
    id int PRIMARY KEY identity,
    ExpenseName NVARCHAR,
    ExpenseAmnt Money,
    IsAppoved CHAR(1),
);

Create Table UserExpenses(
id int PRIMARY key IDENTITY,
userID int FOREIGN key REFERENCES Users(id),
expenseID int FOREIGN KEY REFERENCES expense(id)

);

SELECT * From Users

SELECT * From Expense

SELECT * From UserExpenses