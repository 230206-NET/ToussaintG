using Microsoft.AspNetCore.Mvc;
using DBStorage;
using Service;
using UserModel;
//TODO: Figure out why I can view localhost on my browser and why VSCodde doesn't recognize definition of "Service"
var builder = WebApplication.CreateBuilder(args);
builder.service.AddScoped<UserRepository, SQLRepository>();
builder.service.AddScoped<AdminRepository, SQLAdminRepository>();
builder.service.AddScoped<ExpenseRepository, SQLExpenseRepository>();
builder.service.AddScoped<logService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

//Review "Pending" Reimbursement Requests  

app.MapGet("/Retrieve Pending Expenses",([FromQuery] string? search, logService service)=>{
    if(search != null){
        service.searchExpensesByApproval(search);
    }
    return service.GetAllExpenses();
});


//Add New Users, Admins, and Expenses to the Registry - Sign up and Request Reimbursement

app.MapPost("/New User",([FromBody] signUp user,  logService service) =>{
    return service.createNewUser(user);
    });

app.MapGet("/Log Expense", ([FromBody] Expenses Expense, logService service) => {
    return service.createNewExpense(Expense);
});

app.MapGet("/Log Expense", ([FromBody] adminSignUp admin, logService service) => {
    return service.createNewAdmin(admin);
});


//Access Users and Admins accounts - Log in

app.MapGet("/Log In User", ([FromQuery] string? user, string? pass, logService service) => {
    return service.logInByCredentials(user, pass);
});

app.MapGet("/Log In Admin", ([FromQuery] string? admin, string? pass, int ID,logService service) => {
    return service.adminLogInByCredentials(admin, pass, ID);
});




app.Run();
