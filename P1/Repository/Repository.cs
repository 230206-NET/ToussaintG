
using UserModel;

namespace DBStorage;

//This codeblock will get and persist data onto a json file
public interface UserRepository{


List<signUp> GetAllUsers();


void createNewUser(signUp userToRegister);


}




public interface AdminRepository{
 List<adminSignUp> getallAdmins();


 void createNewAdmin(adminSignUp adminToRegister);

}
/*

public interface ExpenseRepository{



}

*/
