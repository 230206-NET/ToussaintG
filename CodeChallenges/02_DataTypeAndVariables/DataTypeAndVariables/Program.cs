using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          
          Console.WriteLine("Hello World!");

          byte myByte = 20;
          sbyte mySbyte = -20;
          int myInt = 300;
          uint myUint = 301;
          short myShort = 3201;
          ushort myUShort = 2000;
          float myFloat = 32.64f;
          double myDouble = 1.0;
          char myCharacter = 'G';
          bool myBool = true;
          string myText = "Golden";
          string numText = "100";
          string str2txt = "123923";
          

         
        try{
          Console.WriteLine(Program.Text2Num(numText));
        }
          catch(NotImplementedException){

            Console.WriteLine("Not Implemented");
          }

          Console.WriteLine(myByte);
          Console.WriteLine(mySbyte);
          Console.WriteLine(myInt);
          Console.WriteLine(myUint);
          Console.WriteLine(myShort);
          Console.WriteLine(myUShort);
          Console.WriteLine(myFloat);
          Console.WriteLine(myDouble);
          Console.WriteLine(myCharacter);
          Console.WriteLine(myBool);
          Console.WriteLine(myText);
          Console.WriteLine(numText);
          Console.WriteLine(Program.Text2Num(str2txt));
      }

      public static int Text2Num(string Text)
      {
        //throw new NotImplementedException();
        
        

        int number;
        
        bool Ratio = int.TryParse(Text, out number);
          
        if(Ratio == true){

          return number;
        }
        else
        return 0;

        
      }

    }
}
