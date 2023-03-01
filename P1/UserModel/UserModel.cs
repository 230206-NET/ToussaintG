using System;

namespace UserModel;



//The purpose of this class is to get and set a username,
// password, firstname, lastname and return an employee Id number


public class logUser{
  
    

    public string User{get; set; }
    public string Pass{get; set; }
    
    public string expenseName{get; set; }

    public double Expense;

    public bool isApproved{get; set; }

    public int getId(){

            Random rand = new Random();
            int Id = rand.Next(1000,9999);
            return Id;

        }
    public override string ToString()
    {
        return $"Name:{this.User}\nPass:{this.Pass}";
    }

}

