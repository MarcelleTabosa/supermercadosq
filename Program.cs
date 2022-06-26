using Microsoft.AspNetCore.Mvc;
using supermercadosq.Entities;
using supermercadosq.Model.Connection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddNpgsql<DatabaseConnection>(builder.Configuration["Database:Npgsql"]);
var app = builder.Build();

app.MapGet("/user", (DatabaseConnection context) => {
  List<User> user = context.Users.ToList();
  return Results.Ok(user);;
});

app.MapGet("/user/single/{id}", ([FromRoute] int id, DatabaseConnection context) => {
  var user = context.Users.Where(u => u.Id == id).First();
  return Results.Ok(user);
});

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

app.MapPut("/user/{id}", ([FromRoute]int id, UserRequestDTO userDTO, DatabaseConnection context) =>{
  var user = context.Users.Where(u => u.Id == id).First();
  if(user != null){
    user.Name = userDTO.Name != null ? userDTO.Name : user.Name;
    user.SocialName = userDTO.SocialName != null ? userDTO.SocialName : user.SocialName;
    user.Email = userDTO.Email != null ? userDTO.Email : user.Email; 
    user.Password = userDTO.Password != null ? userDTO.Password : user.Password;
    user.PhoneNumber = userDTO.PhoneNumber != null ? userDTO.PhoneNumber : user.PhoneNumber;
  }
  context.SaveChanges();
  return Results.StatusCode(204);
});

app.MapDelete("/user/{id}", ([FromRoute] int id, DatabaseConnection context) => {
  var user = context.Users.Where(u => u.Id == id).First();
  context.Users.Remove(user);
  context.SaveChanges();  

  return Results.StatusCode(204);
});


app.Run();

