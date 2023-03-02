// See https://aka.ms/new-console-template for more information
/*

    - As a user, I should be able to log in to the system
    - As a user, I should be able to create a new account in the system
    - As an employee, I should be able to submit reimbursement tickets
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
    private readonly logService _service;
    public MainMenu(logService service){
        _service = service;
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
                        createNewExpense();

                        break;

                    case "3":
                        List<signUp> signUps = _service.GetAllUsers(); 
                         foreach(signUp s in signUps){
                            Console.WriteLine(s);
                        }
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
        // signUp SU = new signUp;
        // adminSignUp ASU = new adminSignUp;

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
                    Console.WriteLine("Returning to Main Menu.......");
                    Console.WriteLine("");
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

    private void createNewExpense(){
        Expenses exp = new Expenses();
        string approval;
        Random rand = new Random();
        int num = rand.Next(1000,9999);

        Console.WriteLine("==========Creating New Expense Request==========");
        Console.WriteLine("");
        Console.WriteLine("Please Log the date the expense was made");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Date:");
        DateTime expenseDate = DateTime.Parse(Console.ReadLine());

        DateTime parsed;
        string eName;
        double eAmount;
        //bool parseSuccess = DateTime.TryParse(expenseDate, out parsed);

        //if(parseSuccess){
            exp.expenseDate = expenseDate;
            
        //}

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
            eAmount = Double.Parse(Console.ReadLine());
            
            try{
                exp.expenseAmount = eAmount;
                break;
            }
            catch(ArgumentException eex){
                Console.WriteLine(eex.Message);
                continue;
            }

            
        }
        exp.approval = "Pending";
        Console.WriteLine("Expense Name: " + eName);
        Console.WriteLine("Expense Name: " + eAmount);
        Console.WriteLine("You request status is: " + exp.approval);
           
        new SQLExpenseRepository().createNewExpense(exp);




    }


}