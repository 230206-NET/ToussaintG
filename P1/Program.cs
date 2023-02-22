// See https://aka.ms/new-console-template for more information
/*

    - As a user, I should be able to log in to the system
    - As a user, I should be able to create a new account in the system
    - As an employee, I should be able to submit reimbursement tickets
    - As a manager, I should be able to approve or reject submitted reimbursement tickets


*/
using System;
using System.Collections.Generic;
using userPass;


logIn lI = new logIn();




Console.WriteLine("Expense Reimbursement Program");


//Sanity Check --Repurpose later for Sign up class--
Console.WriteLine("Enter your username:");

string name = Console.ReadLine();

Console.WriteLine("Enter your password:");

string password = Console.ReadLine();


lI.User = name;
lI.Pass = password;


Console.WriteLine("Username: " + lI.User);
Console.WriteLine("Password: " + lI.Pass);
lI.employeeId();

//Dictionary<int, string> animalID = new Dictionary<int, string>();

        Console.WriteLine("Expense Reimbursement Program");

        Console.WriteLine("");
        while(true){
            Console.WriteLine("What would you like to the do?");

            Console.WriteLine("[1]: Sign Up");
            Console.WriteLine("[2]: Request Reimbursement");
            Console.WriteLine("[3]: Review Requests");
            Console.WriteLine("[E]: Exit");

            string? input = console.ReadLine();

            if(input != null){

                switch (input){

                    case "1":
                    break;

                    case "2":
                    break;

                    case "3":
                    break;

                    case "e":
                    Console.WriteLine("Terminating Program.....");
                    Environment.Exit(0);
                    break;

                    default:
                    Console.WriteLine("Not a vaild input!");
                    Console.WriteLine("What would you like to the do?");
                    break;










                 }



            }

        }


