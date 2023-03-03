// See https://aka.ms/new-console-template for more information
/*

    - As a user, I should be able to log in to the system - DONE
    - As a user, I should be able to create a new account in the system - DONE
    - As an employee, I should be able to submit reimbursement tickets - DONE
    - As a manager, I should be able to approve or reject submitted reimbursement tickets


*/

using UserModel;
using Service;
using DBStorage;
using System.Threading;
using Serilog;

namespace UI;




public class MainMenu
{
    // private readonly UserRepository _service;
    // public logService (UserRepository service){

    //      _service = service;
    // }

    private readonly logService _service;
    private readonly logService _adminService;
    private readonly logService _eService;
    public MainMenu(logService service, logService adminService, logService eService){
        _service = service;
        _adminService = adminService;
        _eService = eService;
    } 
    public void Start()
    {
        
        Console.WriteLine("==================Expense Reimbursement Program==================");
        Console.WriteLine("");
        Console.WriteLine("*****************Main Menu*****************");
        Console.WriteLine("");
        while (true)
        {
            Console.WriteLine("What would you like to the do?");
            //Thread.Sleep(2000);
            Console.WriteLine("[1]: Sign Up");
            //Thread.Sleep(1000);
            Console.WriteLine("[2]: Request Reimbursement");
            //Thread.Sleep(1000);
            Console.WriteLine("[3]: Review Requests");
            //Thread.Sleep(1000);
            Console.WriteLine("[x]: Exit");
           

            string input = Console.ReadLine();

            if (input != null)
            {

                switch (input)
                {

                    case "1":
                        SignUp();
                        break;

                    case "2":
                        requestReimbursement();
                        

                        break;

                    case "3":
                        reviewRequests();
                        
                        // List<signUp> signUps = _service.GetAllUsers(); 
                        //  foreach(signUp s in signUps){
                        //     Console.WriteLine(s);
                        // }
                        break;

                    case "x":
                        Console.WriteLine("Terminating Program.....");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Not a vaild input!");
                        break;


                    }

            }

            else Console.WriteLine("You must enter a valid option!");



            
        }


        


    }
    
    
    
    private void SignUp(){

        Console.WriteLine("");
        Console.WriteLine("***************Sign up***************");
        Console.WriteLine("");
        


        while(true){
            //Thread.Sleep(2000);
            Console.WriteLine("What would you like to do?");
            //Thread.Sleep(1000);
            Console.WriteLine("[1]: Sign Up as Admin");
            Console.WriteLine("-----------------------");
            //Thread.Sleep(1000);
            Console.WriteLine("[2]: Sign up as User");
            Console.WriteLine("-----------------------");
            //Thread.Sleep(1000);
            Console.WriteLine("[x]: Exit");

            
            Console.WriteLine("");
            

            string choice = Console.ReadLine();

            switch(choice){
                case ("1"):
                    createNewAdmin();
                    break;


                case ("2"):
                    createNewUser();
           
                    break;


                case "x":
                    Console.WriteLine("\n\nReturning to Main Menu.......\n\n");
                    Thread.Sleep(1000);
                    Start();
                    break;




                default:
                    Console.WriteLine("Please make a valid choice.....");
                    break;



            }
            





        }





    }
    private void createNewUser(){
            
            signUp su = new signUp();
            Random rand = new Random();
            int num = rand.Next(1000,9999);
           
            
            Console.WriteLine("Intializing Sign Up....");
            Console.WriteLine("");

            while(true){
            Console.WriteLine("Enter your User name:");
           
            
            string uName = Console.ReadLine();

                try{
                    su.User = uName;
                    break;
                }
                catch(ArgumentException ex){
                    Console.WriteLine(ex.Message);
                }
            }
              
          
            while(true){
            Console.WriteLine("Enter your password: ");

                string password = Console.ReadLine();
                try{
                    su.Pass = password;
                    break;
                }
                catch(ArgumentException ae){
                    Console.WriteLine(ae.Message);
                }
                
            }
            su._iD = num;
            

           
            
            new SQLRepository().createNewUser(su);
            Console.WriteLine(su);
            

            


        


        }
    private void createNewAdmin(){
            
            adminSignUp su2 = new adminSignUp();
            Random rand = new Random();
            int num = rand.Next(1000,9999);
           
            
            Console.WriteLine("Intializing Sign Up....");
            Console.WriteLine("");

            while(true){
            Console.WriteLine("Enter your User name:");
           
            
            string adName = Console.ReadLine();

                try{
                    su2.Admin = adName;
                    break;
                }
                catch(ArgumentException aex){
                    Console.WriteLine(aex.Message);
                }
            }
              
          
            while(true){
            Console.WriteLine("Enter your password: ");

                string adPassword = Console.ReadLine();
                try{
                    su2.aPass = adPassword;
                    break;
                }
                catch(ArgumentException aae){
                    Console.WriteLine(aae.Message);
                }
                
            }

            su2._iD = num;

           
            
            new SQLAdminRepository().createNewAdmin(su2);
            Console.WriteLine(su2);


        }
    private void createNewExpense(signUp x){
        Expenses exp = new Expenses();
        signUp signUp = new signUp();
        signUp = x;
        
        string approval;
        Random rand = new Random();
        int num = rand.Next(1000,9999);

        Console.WriteLine("==========Creating New Expense Request==========");
        Console.WriteLine("");
        Console.WriteLine("Would you like to request a reimbursement ticket?[y/n]");
        string choice = Console.ReadLine();
        switch (choice)
        {

            case ("y"):
                Console.WriteLine("Please log the date the expense was made");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Date:");
                DateTime expenseDate = DateTime.Parse(Console.ReadLine());

                DateTime parsed;
                string eName;
                decimal eAmount;
                
                
                
                    exp.expenseDate = expenseDate;
                    
                
                

                while(true){
                    Console.WriteLine("Expense Name: ");
                    eName = Console.ReadLine();
                    
                    try{
                        exp.expenseName = eName;
                        break;
                    }
                    catch(ArgumentException eae){
                        Console.WriteLine(eae.Message);
                        continue;
                    }
                }
                while(true){
                    Console.WriteLine("Expense Amount: ");
                    eAmount = Decimal.Parse(Console.ReadLine());
                    
                    try{
                        exp.expenseAmount = eAmount;
                        break;
                    }
                    catch(ArgumentException eex){
                        Console.WriteLine(eex.Message);
                        continue;
                    }

                    
                }
                exp.uID = x.ID;
                exp.approval = "Pending";
                Console.WriteLine("Expense Name: " + eName);
                Console.WriteLine("Expense Name: " + eAmount);
                Console.WriteLine("You request status is: " + exp.approval);
                
                new SQLExpenseRepository().createNewExpense(exp);

                Console.WriteLine("Request Logged........");
                //Thread.Sleep(1000);
                Console.WriteLine("Preparing to log addational tickets.......");
                //Thread.Sleep(1000);
                break;

            case("n"):

                Console.WriteLine("Returning to Main Menu..........");
                Start();
                break;

            default:
                Console.WriteLine("Please make a valid choice.....");
                break;



                
        }
    
    
    }
        
    private void requestReimbursement(){
        signUp check = new signUp();
        bool checker;// = false;
        //Remember to use this for Admin Request review
        Console.WriteLine("+++++++++++++ LOG IN +++++++++++++\n\n");
        Console.WriteLine("Please enter your username: ");

        string user = Console.ReadLine();
        
        Console.WriteLine("\n\nPlease enter your password: ");

        string password = Console.ReadLine();

        //check = lS.logInByCredentials(user, password);
        List<signUp> logIn = _service.logInByCredentials(user,password);
            foreach(signUp s in logIn){
                if(s.Pass.Contains(password)){
                    checker = true;
                //Sanity Check - Gotta be triple sure.....(;-)) 
                //    Console.WriteLine(s);
                //    Console.WriteLine("True");
                //     break;
                    if(checker = true){
                        createNewExpense(s);
                    }
                    
                }
           
            }
        Console.WriteLine("\nXXXXXXXXXXXXXXXXXXXXX----Access Denied----XXXXXXXXXXXXXXXXXXXXX\n\n");
        Thread.Sleep(1000);
        Console.WriteLine("Returning to Main Menu.....\n\n");
                
    }
          
    private void reviewRequests(){
        Expenses Exp = new Expenses();        
        adminSignUp check = new adminSignUp();
        bool checker;// = false;
        string pending ="Pending";
        //Remember to use this for Admin Request review
        Console.WriteLine("+++++++++++++ LOG IN +++++++++++++\n\n");
        Console.WriteLine("Please enter your username: ");

        string user = Console.ReadLine();
        
        Console.WriteLine("\n\nPlease enter your password: ");

        string password = Console.ReadLine();

        Console.WriteLine("\n\nPlease enter your Admin Identification Number: ");

        int ID = int.Parse(Console.ReadLine());

        //check = lS.logInByCredentials(user, password);
        List<adminSignUp> adminLogIn = _adminService.adminLogInByCredentials(user,password,ID);
            foreach(adminSignUp aS in adminLogIn){
                if(aS.aPass.Contains(password)){
                    if((aS.aID.Equals(ID))){
                         checker = true;
            //    // Sanity Check - Gotta be triple sure.....(;-)) 
            //        Console.WriteLine(aS);
            //        Console.WriteLine("True");
            //         break;
                    // if(checker = true){
                    //     createNewExpense(s);
                    // }
                        if(checker = true){
                            List<Expenses> search = _eService.searchExpensesByApproval(pending);
                            foreach(Expenses exp in search){
                                Console.WriteLine(exp);
                                Console.WriteLine("Approve this expense?[y/n]");
                                string choice = Console.ReadLine();
                                switch(choice){
                                    case ("y"):
                                    Exp.approval = "APPROVED";
                                    
                                    break;
                                    case ("n"):
                                    Exp.approval = "DENIED";
                                    break;
                                    default:
                                    Console.WriteLine("Please make a valid choice.....");
                                    break;

                                }
                                
                            }
                           break; 
                        }

                }
           
            }
        Console.WriteLine("\nXXXXXXXXXXXXXXXXXXXXX----Access Denied----XXXXXXXXXXXXXXXXXXXXX\n\n");
        Thread.Sleep(1000);
        Console.WriteLine("Returning to Main Menu.....\n\n");

    }      
                    
                
           

    }


     
}




