using Serilog;
using System.Text.Json;
using UserModel;


namespace DBStorage;



public class Storage:UserRepository

{

    private const string _filePath = "../Repository/Repository.json";

    

    public  Storage(){

        //Data will be written on a JSON format

        //Log.Information("Instantiating Storage Class");
        bool fileExists = File.Exists(_filePath);

        if(!fileExists){
            var fs = File.Create(_filePath);
            fs.Close();
        }


    }

   



    public List<signUp> GetAllUsers(){

        Log.Information("File Storage: Retrieving user Registry");
        string fileContent = File.ReadAllText(_filePath);

        return JsonSerializer.Deserialize<List<signUp>>(fileContent);

    }


   

    public void createNewUser(signUp userToCreate){
        
        Log.Information("File Storage: creating a new user");

        List<signUp> users = GetAllUsers();

        users.Add(userToCreate);
        
        string content = JsonSerializer.Serialize(users);
        File.WriteAllText(_filePath,content);
    }

   

    

    
}

public class adminStorage:AdminRepository{

private const string _aFilePath = "../Repository/aRepository.json";

 public adminStorage(){

        //Data will be written on a JSON format

        //Log.Information("Instantiating Admin Storage Class");
        bool afileExists = File.Exists(_aFilePath);

        if(!afileExists){
            var fs = File.Create(_aFilePath);
            fs.Close();
        }
    }

 public List<adminSignUp> getallAdmins(){

        Log.Information("File Storage: Retrieving admin Registry");
        string aFileContent = File.ReadAllText(_aFilePath);

        return JsonSerializer.Deserialize<List<adminSignUp>>(aFileContent);

    }
 public void createNewAdmin(adminSignUp adminToCreate){
        
        Log.Information("File Storage: creating a new Admin");

        List<adminSignUp> admins = getallAdmins();

        admins.Add(adminToCreate);
        
        string aContent = JsonSerializer.Serialize(admins);
        File.WriteAllText(_aFilePath,aContent);
    }



}