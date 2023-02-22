using System;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

           System.Console.WriteLine($"The result of your mathematical operation is {result3}.");
            

        }

        public static string GetName()
        {
            //throw new NotImplementedException();
            
            Console.WriteLine("Please enter your name: ");
            String Name = Console.ReadLine();
            return Name;
        }

        public static void GreetFriend(string name)
        {
            //Greeting should be: Hello, nameVar. You are my friend
            //Ex: Hello, Jim. You are my friend
            //throw new NotImplementedException();
            Console.WriteLine("Hello, " + name + ". You are my friend");
        }
        

        public static double GetNumber()
        {
            //Should throw FormatException if the user did not input a number
            //throw new NotImplementedException();
            double num;
            while(true){
            Console.WriteLine("Please enter a number: ");
            
            bool ParseSuccess = double.TryParse(Console.ReadLine(), out num);
            if(ParseSuccess){
            break;
            }
            
            }

            return num;

        }

        public static int GetAction()
        {
            //throw new NotImplementedException();
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            int choice;

            while(true){
                
                Console.WriteLine("Please enter a valid choice: ");
                bool choiceSuccess = int.TryParse(Console.ReadLine(), out choice);
                if((choiceSuccess) && (choice < 5) && (choice > 0)){
                    break;
                }

                

            }
            return choice;
        }


        

        public static double DoAction(double x, double y, int z)
        {   
            double result = 0;
            //throw new NotImplementedException();
            if (z == 1){
                result = x+y;
                
            }
            else if (z == 2){
                result = x-y;
            }
            else if (z == 3){
                result = x*y;
            }
            else if (z == 4){
                result = x/y;
            }
            return result;
        }
    }
}
