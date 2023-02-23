
using System;
using System.Data;

using System.Data.SqlClient;
using Serilog;
namespace DBRepository;


public class UserPassCheck
{
    
    bool isAdmin();
    
    public List<Users> GetAllUsers(){
        List<Users> allUsers = new();
        using SqlConnection connection = new SqlConnection(Secrets.getConnectionString());

        connection.Open();

        using SqlCommand cmd = new SqlCommand("SELECT Users.Username, Password, FirstName, LastName, employeeID;", connection);
        using SqlDataReader reader = cmd.ExecuteReader();

    }

    public List<Admin> GetAllAdmins();



}



public class ReimbursementDB
{







}