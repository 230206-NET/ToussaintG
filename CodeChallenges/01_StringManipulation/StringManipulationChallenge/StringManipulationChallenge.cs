using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            
            //
            //
            //implement the required code here and within the methods below.
            //
            //
            
            //Program p = new Program();

            Console.WriteLine("Please enter a message: ");
            userInputString = Console.ReadLine();

            Console.WriteLine("Please enter a number less than the length of yor string: ");
            elementNum = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please a letter to search for: ");
            char1 = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your first name: ");
            fName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            lName = Console.ReadLine();

 
            Console.WriteLine(StringToUpper(userInputString));
            Console.WriteLine(StringToLower(userInputString));
            Console.WriteLine(StringSubstring(userInputString, elementNum));
            Console.WriteLine(SearchChar(userInputString, char1));
            //Console.WriteLine(StringTrim(userInputString));
            StringTrim(userInputString);
            userFullName = ConcatNames(fName, lName);
            Console.WriteLine(userFullName);

        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x){
            //throw new NotImplementedException("StringToUpper method not implemented.");
           
            
            string tempString = x.ToUpper();
            
            //Console.WriteLine(tempString);
            
            return tempString;

        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            //throw new NotImplementedException("StringToUpper method not implemented.");
            string tempString = x.ToLower();
            
            //Console.WriteLine(tempString);

            return tempString;

        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x){
            //throw new NotImplementedException("StringTrim method not implemented.");
            
           
            string tempString = x.Trim();
            Console.WriteLine(tempString);

            return tempString;

        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            //throw new NotImplementedException("StringSubstring method not implemented.");
            string tempString = x.Substring(elementNum);
            
            //Console.WriteLine(tempString);

            return tempString;


        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            //throw new NotImplementedException("SearchChar method not implemented.");
            
            int num =  userInputString.IndexOf(x);
            return num;

        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
           //throw new NotImplementedException("ConcatNames method not implemented.");

            return fName + " " + lName;

        }



    }//end of program
}
