--SQL
--Structured Query Language

DROP Table Users;
TRUNCATE TABLE Users;
TRUNCATE TABLE Expense;
DROP Table UserExpenses;
DROP Table Expense;
DROP Table Admin;
Truncate TABLE Users
Truncate TABLE Expense

Create Table Users(
    
    inID int Primary key Identity,
    userID int,
    [UserName] VARCHAR(100) not NULL,
    [PassKey] varCHAR(100) not null,
);
Create Table Expense(
    inID int PRIMARY KEY identity,
    ExpenseDate VARCHAR(100),
    ExpenseName VARCHAR(100),
    ExpenseAmnt Money,
    userID int,
    IsApproved VARCHAR(100),
);

Create Table UserExpenses(
id int PRIMARY key IDENTITY,
userID int FOREIGN key REFERENCES Users(inID),
expenseID int FOREIGN KEY REFERENCES Expense(id)
);
Create Table Admin(
    inID int PRIMARY KEY identity,
    UserName VARCHAR(100),
    PassKey VARCHAR(100),
    adminID INT

);

--SELECT Users.inID, UserName, PassKey, Users.userID, ExpenseName, ExpenseAmnt FROM Users Left JOIN Expense on Users.userID = Expense.userID;

SELECT * From Users

SELECT * From Expense

SELECT * From UserExpenses

SELECT * FROM Admin




INSERT INTO Users (userID, UserName, PassKey) VALUES (2255, 'Saul', 'Goodman');
INSERT INTO Expense ( userID, ExpenseName, ExpenseAmnt,IsAppoved) VALUES (4444, 'Hotel', 1250.37, 'Pending');
INSERT INTO Admin (username, passkey, adminID) VALUES ('sampAdmin', 'BigMan', 7750);


