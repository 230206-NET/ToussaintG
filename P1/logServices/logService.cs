using UserModel;
using DBStorage;

namespace Service;
public class logService
{


    private readonly UserRepository _repo;
    public logService (UserRepository repo){

        _repo = repo;
    }
   

    public List<signUp> GetAllUsers(){
        return _repo.GetAllUsers();
    }
 /*   
     public List<signUp> logInByCredentials(string username, string password){
        bool isMatch;

        List<signUp> allUsers = GetAllUsers();
        List<signUp> filtered = new();
        foreach(signUp s in allUsers){
            foreach(signUp SU in s.User){
                if (SU.User.Contains(username)){
                    if(SU.Pass.Contains(password)){
                        isMatch = true;
                        break;
                    } 
                }
                else{
                    isMatch = false;
                    break;
                }
            }
        }
        return filtered;

    }

    public List<signUp> adminLogInByCredentials(string username, string password, int adminID){

        List<signUp> allUsers = GetAllUsers();
        List<signUp> filtered = new();
        foreach(signUp s in allUsers){
            foreach(Expenses ex in s.userExpense){
                if (ex.approval.Contains(searchTerm)){
                    filtered.Add(s);
                    break;
                }
            }
        }
        return filtered;

    }

    public List<signUp> searchExpensesByApproval(string searchTerm){

        List<signUp> allUsers = GetAllUsers();
        List<signUp> filtered = new();
        foreach(signUp s in allUsers){
            foreach(Expenses ex in s.userExpense){
                if (ex.approval.Contains(searchTerm)){
                    filtered.Add(s);
                    break;
                }
            }
        }
        return filtered;

    }
*/
    public void createNewUser(signUp userToCreate){
        _repo.createNewUser(userToCreate);
    }



}
