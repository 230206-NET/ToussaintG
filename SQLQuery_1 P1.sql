--SQL
--Structured Query Language

Truncate TABLE Users
Truncate TABLE Expense

Create Table Users(
    
    id int Primary key Identity,
    [UserName] VARCHAR(100) not NULL,
    [PassKey] varCHAR(100) not null,
);
Create Table Expense(
    id int PRIMARY KEY identity,
    ExpenseName VARCHAR(100),
    ExpenseAmnt Money,
    IsAppoved CHAR(1),
);

Create Table UserExpenses(
id int PRIMARY key IDENTITY,
userID int FOREIGN key REFERENCES Users(id),
expenseID int FOREIGN KEY REFERENCES Expense(id)
);
Create Table Admin(
   
    username VARCHAR(100),
    passkey VARCHAR(100),
    adminID INT

);

SELECT * From Users

SELECT * From Expense

SELECT * From UserExpenses

SELECT * FROM Admin




INSERT INTO Users (UserName, PassKey) VALUES ('Black', 'Blue');
INSERT INTO Expense (ExpenseName, ExpenseAmnt) VALUES ('Hotel', 1250.37);
INSERT INTO Admin (username, passkey, adminID) VALUES ('sampAdmin', 'BigMan', 7750);


DROP Table Users;
DROP Table UserExpenses;
DROP Table Expense;
DROP Table Admin;