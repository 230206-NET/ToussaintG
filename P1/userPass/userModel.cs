//The purpose of this class is to get and set a username
// and password and return an employee Id number

using System;
using System.Collections.Generic;
using System.Text;
namespace userPass;

public class logIn{
  
Random rand = new Random();

    private string user;
    private string pass;

   
    public void employeeId(){


        int iD = rand.Next(1000,9999);
        Console.WriteLine("Employee ID: " + iD);


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
 private string FirstName{
        
    get{
        return this.FirstName;
    }
    
    
     set{
        this.FirstName = value;
     }
    
    
}
private string LastName{
        
    get{
        return this.LastName;
    }
    
    
     set{
        this.LastName = value;
     }
    
}

public List<UsersPass> Employees { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new();
        
        sb.Append($"User: {this.User}\nPassword: {this.Pass}");
        sb.Append("\n$FirstName: {this.FirstName}/nLastName: {this.LastName}");
       


}

