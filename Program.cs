using Microsoft.EntityFrameworkCore;
using supermercadosq.Model.Connection;
using supermercadosq.Model.UserRepository;
using supermercadosq.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEntityFrameworkNpgsql()
.AddDbContext<DatabaseConnection>(options => options
.UseNpgsql("Server=localhost;Port=5432;Database=servertest;User Id=postgres;Password=029847Gu@;"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/users", (User user) => {
    CreateUserRepository createUser = new CreateUserRepository();
    createUser.CreateUser(user);
    
});

app.Run();
