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
        
        Console.WriteLine("Expense Reimbursement Program");

        Console.WriteLine("");
        while (true)
        {
            Console.WriteLine("What would you like to the do?");

            Console.WriteLine("[1]: Sign Up");
            Console.WriteLine("[2]: Request Reimbursement");
            Console.WriteLine("[3]: Review Requests");
            Console.WriteLine("[e]: Exit");

            string input = Console.ReadLine();

            if (input != null)
            {

                switch (input)
                {

                    case "1":
                        createNewUser();
                        break;

                    case "2":
                        

                        break;

                    case "3":
                        List<signUp> signUps = _service.GetAllUsers(); 
                         foreach(signUp s in signUps){
                            Console.WriteLine(s);
                        }
                        break;

                    case "e":
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
    
    
    
    
    private void createNewUser(){
            
            signUp su = new signUp();
           
            
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

           
            
            new Storage().createNewUser(su);
            Console.WriteLine(su);
            

            


        


        }


     private void createNewAdmin(){
            
            adminSignUp su2 = new adminSignUp();
           
            
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

           
            
            new adminStorage().createNewAdmin(su2);
            Console.WriteLine(su2);
            

            


        


        }


}