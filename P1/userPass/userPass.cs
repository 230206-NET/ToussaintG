//The purpose of this class is to get and set a username
// and password and return an employee Id number

using System;
using System.Collections.Generic;
namespace userPass;

public class logIn{
  
Random rand = new Random();

    private string user;
    private string pass;

    public void employeeId(){


        int num = rand.Next(1000,9999);
        Console.WriteLine("Employee ID: " + num);


    } 


 
public string User{
        get{
            return this.user;
        }
        set{
            this.user = value;
        }
}



    public string Pass{

        get{
            return this.pass;
        }
        set{
            this.pass = value;
        }


    }

}

