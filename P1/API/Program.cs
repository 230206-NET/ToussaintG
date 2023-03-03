using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DBStorage;
using Service;
using UserModel;

var builder = WebApplication.CreateBuilder(args);
builder.Service.AddScoped<UserRepository, SQLRepository>();
builder.Service.AddScoped<AdminRepository, SQLAdminRepository>();
builder.Service.AddScoped<ExpenseRepository, SQLExpenseRepository>();
builder.Service.AddScoped<logService>();

var app = builder.Build();



app.MapGet("/", () => "Hello World!");
app.MapGet("/Pending Expenses",([FromQuery] string? search, logService service)=>{
    if(search != null){
        service.searchExpensesByApproval(search);
    }
    return service.GetAllUsers();
});
app.MapPost("/Admin Registry",([FromBody] signUp user, logService service ) =>{
    service.createNewUser(user);
    });
app.Run();
