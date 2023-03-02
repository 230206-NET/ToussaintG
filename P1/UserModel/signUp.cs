using System;
using System.Text;
using UserModel;

namespace UserModel;







//This codeblock will allow the user to create new user data and add it to the database
//The employee sign up will be a standard sign up process
//The manager sign up process will need the credentials of an existing manager to sign up



public class signUp{

 
    public signUp(){
        
        userExpense = new List<Expenses>();

    }


    logUser lu = new logUser();
    
    private string _userName = DateTime.Now.ToString();
    private string _passWord = DateTime.Now.ToString();
    public int _iD = 0;

    public int uID;

    
    public List<logUser> newUser{ get; set;  }


    



    //Registering a new Username
    public string User{
        
    
        get{

            return _userName;
        }
        set{
            if (value == null){
                //Log.Warning("Models: assigning username: can't be null");
                throw new ArgumentException("Name must be registered");
            }
            if(!string.IsNullOrWhiteSpace(value)){
                _userName = value;
            }


        }
    }


    //Registering a new Password
    public string Pass{
        
    
        get{

            return _passWord;
        }
        set{
            if (value == null){
                //Log.Warning("Models: assigning password: can't be null");
                throw new ArgumentException("A password must be registered");
            }
            if(!string.IsNullOrWhiteSpace(value)){
                _passWord = value;
            }


        }

    }

    public int ID{

        get{

            return _iD;

        }
        set{

            if (value == null){
                //Log.Warning("Models: assigning password: can't be null");
                throw new ArgumentException("Something went wrong");
            }
            else{
                _iD = value;
            }
        }


    }
    
    public List<Expenses> userExpense {get; set; }

     public override string ToString()
    {
        StringBuilder sb = new();

        sb.Append($"User: {this.User}\nPass: {this.Pass}\nUserID: {this.ID}\n\n");
        foreach(Expenses ex in userExpense){
            sb.Append("\n");
            sb.Append(ex.ToString());
        }
        return sb.ToString();
    }



}




public class adminSignUp{
    //Admins need to be placed in a separate list
    //The goal is to give admins control over approving Expenses from the Expense List
    public adminSignUp(){

        newAdmin = new List<logUser>();

    }



    private string _aUserName = DateTime.Now.ToString();
    private string _aPassWord = DateTime.Now.ToString();
    public int _iD = 0;

    public List<logUser> newAdmin{ get; set;  }


    //Registering a new Admin username
    public string Admin{
        
    
        get{

            return _aUserName;
        }
        set{
            if (value == null){
                //Log.Warning("Models: assigning username: can't be null");
                throw new ArgumentException("Name must be registered");
            }
            if(!string.IsNullOrWhiteSpace(value)){
                _aUserName = value;
            }


        }
    }


    //Registering a new Password
    public string aPass{
        
    
        get{

            return _aPassWord;
        }
        set{
            if (value == null){
                //Log.Warning("Models: assigning password: can't be null");
                throw new ArgumentException("A password must be registered");
            }
            if(!string.IsNullOrWhiteSpace(value)){
                _aPassWord = value;
            }


        }

    }

    public int aID{

        get{

            return _iD;

        }
        set{

            if (value == null){
                //Log.Warning("Models: assigning password: can't be null");
                throw new ArgumentException("Something went wrong");
            }
            else{
                _iD = value;
            }
        }


    }
    
    public List<logUser> Admins {get; set; }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.Append($"User: {this.Admin}\nPass: {this.aPass}\nAdminID: {this.aID}\n\n");
        foreach(logUser lu in newAdmin){
            sb.Append("\n");
            sb.Append(lu.ToString());
        }
        return sb.ToString();
    }



}


