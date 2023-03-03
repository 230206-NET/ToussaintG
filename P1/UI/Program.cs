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
        AdminRepository Repo = new SQLAdminRepository();
        ExpenseRepository eRepo = new SQLExpenseRepository();
        logService service = new logService(repo);
        logService adminService = new logService(Repo);
        logService eService = new logService(eRepo);

        MainMenu menu = new MainMenu(service, adminService, eService);
        menu.Start();

    }
    catch(Exception ex){

        Log.Error("Something went wrong 8(, {0}", ex);
    }
    finally{
        Log.CloseAndFlush();
    }


