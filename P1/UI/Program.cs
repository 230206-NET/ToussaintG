using UI;
using Service;
using DBStorage;
using Serilog;




Log.Logger = new LoggerConfiguration()
.WriteTo.Console()
    .WriteTo.File("../logs/logs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

    try{

        Log.Information("Please Standby......");

        UserRepository repo = new SQLRepository();
        //new SQLRepository().createNewUser(2);
        logService service = new logService(repo);
        MainMenu menu = new MainMenu(service);
        menu.Start();

    }
    catch(Exception ex){

        Log.Error("Something went wrong 8(, {0}", ex);
    }
    finally{
        Log.CloseAndFlush();
    }


