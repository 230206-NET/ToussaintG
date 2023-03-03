
using UserModel;

namespace DBStorage;

//This codeblock will get and persist data onto a json file
public interface UserRepository{


List<signUp> GetAllUsers();


signUp createNewUser(signUp userToRegister);


}




public interface AdminRepository{
 List<adminSignUp> getallAdmins();


 adminSignUp createNewAdmin(adminSignUp adminToRegister);

}


public interface ExpenseRepository{

    List<Expenses> getallExpenses();

    Expenses createNewExpense(Expenses expenseToRegister);
    
}