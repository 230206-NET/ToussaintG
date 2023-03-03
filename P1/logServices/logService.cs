using UserModel;
using DBStorage;

namespace Service;
public class logService
{


    private readonly UserRepository _repo;
    private readonly AdminRepository _Repo;
    private readonly ExpenseRepository _eRepo;


    public logService (UserRepository repo){

        _repo = repo;
     }
    public logService(AdminRepository Repo){
        _Repo = Repo;
    }
    public logService(ExpenseRepository eRepo){
        _eRepo = eRepo;
    }
   

    public List<signUp> GetAllUsers(){
        return _repo.GetAllUsers();
    }
    public List<adminSignUp> GetAllAdmins(){
        return _Repo.getallAdmins();
    }
    public List<Expenses> GetAllExpenses(){
        return _eRepo.getallExpenses();
    }
     public List<signUp> logInByCredentials(string username, string password){
        

        List<signUp> allUsers = GetAllUsers();
        List<signUp> filtered = new();
        foreach(signUp s in allUsers){
            foreach(signUp S in allUsers){
                if (S.User.Contains(username)){
                    if(S.Pass.Contains(password)){
                        filtered.Add(S);
                        break;
                    } 
                }
               
            }
        }
        return filtered;

    }
     public List<adminSignUp> adminLogInByCredentials(string username, string password, int adminID){
        

        List<adminSignUp> allAdmins = GetAllAdmins();
        List<adminSignUp> filtered = new();
        foreach(adminSignUp a in allAdmins){
            foreach(adminSignUp A in allAdmins){
                if (A.Admin.Contains(username)){
                    if(A.aPass.Contains(password)){
                        if(A.aID.Equals(adminID)){
                            filtered.Add(A);
                            break;
                        } 
                    }
               
                }
            }
        
        }
        return filtered;
    }

    public List<Expenses> searchExpensesByApproval(string searchTerm){

        List<Expenses> allUsers = GetAllExpenses();
        List<Expenses> filtered = new();
        foreach(Expenses ex in allUsers){            
                if (ex.approval.Contains(searchTerm)){
                    filtered.Add(ex);
                    break;
                }            
        }
        return filtered;

    }

    public void createNewUser(signUp userToCreate){
        _repo.createNewUser(userToCreate);
    }
    public void createNewAdmin(adminSignUp adminToCreate){
        _Repo.createNewAdmin(adminToCreate);
    }
    public void createNewExpense(Expenses expenseToCreate){
        _eRepo.createNewExpense (expenseToCreate);
    }



}
