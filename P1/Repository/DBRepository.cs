using UserModel;
using System.Data;
using System.Data.SqlClient;
using Serilog;


namespace DBStorage;


public class SQLRepository : UserRepository
{

List<signUp> allUsers = new();
public List<signUp> GetAllUsers(){


    
    Secrets sec = new Secrets();
    SqlConnection connection = new SqlConnection(sec.getconnestionString());

    connection.Open();

    using SqlCommand cmd = new SqlCommand("SELECT * FROM Users", connection);
    using SqlDataReader reader = cmd.ExecuteReader();

    
        while(reader.Read()){
            allUsers.Add(
            new signUp{
            ID = (int)reader["id"],
            User = (string)reader["UserName"],
            Pass = (string)reader["PassKey"]
            });


        }
    


    return allUsers;

}


public void createNewUser(signUp userToRegister){


}


}




public class SQLAdminRepository: AdminRepository{
 public List<adminSignUp> getallAdmins(){

    Secrets sec = new Secrets();
    SqlConnection connection = new SqlConnection(sec.getconnestionString());

    connection.Open();

    return new List<adminSignUp>();


 }


 public void createNewAdmin(adminSignUp adminToRegister){


 }

}
