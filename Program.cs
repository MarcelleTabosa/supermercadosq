using supermercadosq.Entities;
using supermercadosq.Model.Connection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddNpgsql<DatabaseConnection>(builder.Configuration["Database:Npgsql"]);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/user", (UserRequestDTO user, DatabaseConnection context) => {
  var u = new User{
    Name = user.Name, 
    SocialName = user.SocialName, 
    CpfCnpj = user.CpfCnpj, 
    Email = user.Email, 
    Password = user.Password, 
    Level = user.Level, 
    Active = user.Active, 
    PhoneNumber = user.PhoneNumber
  };
  context.Users.Add(u);
  context.SaveChanges();
  return Results.StatusCode(201);
});

app.Run();

