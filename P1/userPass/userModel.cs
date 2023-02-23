//The purpose of this class is to get and set a username,
// password, firstname, lastname and return an employee Id number
using System;
namespace userModel;

public class logUser{
  
Random rand = new Random();

    private string user;
    private string pass;
    private string FirstName;
    private string LastName;

   
    public int employeeId(){


        int iD = rand.Next(1000,9999);
        return iD;


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



}

