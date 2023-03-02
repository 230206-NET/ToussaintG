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

    using SqlCommand cmd = new SqlCommand("SELECT Users.userID AS uID, UserName, PassKey From Users", connection);
    using SqlDataReader reader = cmd.ExecuteReader();

    
        while(reader.Read()){
            allUsers.Add(
            new signUp{
           
            User = (string)reader["UserName"],
            Pass = (string)reader["PassKey"],
            ID = (int)reader["uID"]
            });


        }
    


    return allUsers;

}


public signUp createNewUser(signUp userToRegister){

      
    Secrets sec = new Secrets();
    SqlConnection conn = new SqlConnection(sec.getconnestionString());

    conn.Open();

    using SqlTransaction tran = conn.BeginTransaction();
    try{
        using SqlCommand command = new SqlCommand("INSERT INTO Users(userID, UserName, PassKey) OUTPUT INSERTED.inID VALUES (@uID, @uName, @uPass)", conn);
        command.Transaction = tran;
        command.Parameters.AddWithValue("@uID", userToRegister.ID);
        command.Parameters.AddWithValue("@uName", userToRegister.User);
        command.Parameters.AddWithValue("@uPass", userToRegister.Pass);

        int uID = (int)command.ExecuteScalar();

        userToRegister.uID = uID;

        //VVVVVV=====Might need to move this section in to its own function====VVVVVVV
        command.CommandText = ("INSERT INTO Expenses(ExpenseDate, ExpenseName, ExpenseAmnt, userID, IsApproved) VALUES(@expenseDate, @expenseName, @expenseAmount, @uID, @approval)");
        for(int i =0; i < userToRegister.userExpense.Count; i++){
            if(i==0){
                command.Parameters.AddWithValue("@expenseDate", userToRegister.userExpense[i].expenseDate);
                command.Parameters.AddWithValue("@expenseName", userToRegister.userExpense[i].expenseName);
                command.Parameters.AddWithValue("@expenseAmount", userToRegister.userExpense[i].expenseAmount);
                command.Parameters.AddWithValue("@uID", userToRegister.userExpense[i].uID);
                command.Parameters.AddWithValue("@approval", userToRegister.userExpense[i].approval);
            }
            else{
                command.Parameters["@expenseDate"] = new SqlParameter("@expenseDate", userToRegister.userExpense[i].expenseDate);
                command.Parameters["@expenseName"] = new SqlParameter("@expenseName", userToRegister.userExpense[i].expenseName);
                command.Parameters["@expenseAmount"] = new SqlParameter("@expenseAmount", userToRegister.userExpense[i].expenseAmount);
                command.Parameters["@approval"] = new SqlParameter("@approval", userToRegister.userExpense[i].approval);

            }
            command.ExecuteNonQuery();

        }
        //AAAAAAA======Might need to move this section in to its own function=====AAAAAAAAA
       
        tran.Commit();
        return userToRegister;
    }

    catch (SqlException) {
            tran.Rollback();
            throw;

}


}
}



public class SQLAdminRepository: AdminRepository{
 public List<adminSignUp> getallAdmins(){


    List<adminSignUp> allAdmins = new();
    Secrets sec = new Secrets();
    SqlConnection conn = new SqlConnection(sec.getconnestionString());

    conn.Open();

     using SqlCommand cmd = new SqlCommand("SELECT Admin.adminID AS aID, UserName, PassKey From Admin", conn);
    using SqlDataReader reader = cmd.ExecuteReader();

    
        while(reader.Read()){
            allAdmins.Add(
            new adminSignUp{
            Admin = (string)reader["UserName"],
            aPass = (string)reader["PassKey"],
            aID = (int)reader["aID"]
            });


        }
    


    return allAdmins;



 }


 public adminSignUp createNewAdmin(adminSignUp adminToRegister){
    
    Secrets sec = new Secrets();
    SqlConnection conn = new SqlConnection(sec.getconnestionString());
    conn.Open();
    using SqlTransaction tran = conn.BeginTransaction();

    try{
        using SqlCommand command = new SqlCommand("INSERT INTO Admin(adminID, UserName, PassKey) OUTPUT INSERTED.inID VALUES (@aID, @aName, @aPass)", conn);
        command.Transaction = tran;
        command.Parameters.AddWithValue("@aID", adminToRegister.aID);
        command.Parameters.AddWithValue("@aName", adminToRegister.Admin);
        command.Parameters.AddWithValue("@aPass", adminToRegister.aPass);

        int aID = (int)command.ExecuteScalar();
        //adminToRegister.aID = aID;

        tran.Commit();
        return adminToRegister;
 }

 catch(SqlException){
    tran.Rollback();
    throw;
 }

}


}

public class SQLExpenseRepository: ExpenseRepository{

    public Expenses createNewExpense(Expenses expenseToRegister){

    Secrets sec = new Secrets();
    SqlConnection conn = new SqlConnection(sec.getconnestionString());

    conn.Open();

    using SqlTransaction tran = conn.BeginTransaction();
    try{
        using SqlCommand command = new SqlCommand("INSERT INTO Expense(userID, ExpenseName, ExpenseAmnt, IsApproved) OUTPUT INSERTED.inID VALUES (@uID, @eName, @eAmount, @eIsApproved)", conn);
        command.Transaction = tran;

        command.Parameters.AddWithValue("@uID", expenseToRegister.uID);
        command.Parameters.AddWithValue("@eName", expenseToRegister.expenseName);
        command.Parameters.AddWithValue("@eAmount", expenseToRegister.expenseAmount);
        command.Parameters.AddWithValue("@eIsApproved", expenseToRegister.approval);

        int expID = (int)command.ExecuteScalar();

        tran.Commit();
        return expenseToRegister;
    }
    catch(SqlException){
    tran.Rollback();
    throw;
 }

}
}