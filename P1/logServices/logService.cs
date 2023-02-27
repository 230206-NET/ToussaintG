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


    public List<signUp> searcUsersByName(string searchTerm){

        List<signUp> allUsers = GetAllUsers();
        List<signUp> filtered = new();
        foreach(signUp s in allUsers){
            foreach(logUser lg in s.modelUsers){
                if (lg.User.Contains(searchTerm)){
                    filtered.Add(s);
                    break;
                }
            }
        }
        return filtered;

    }

    public void createNewUser(signUp userToCreate){
        _repo.createNewUser(userToCreate);
    }



}
