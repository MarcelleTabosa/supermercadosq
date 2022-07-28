using Microsoft.AspNetCore.Mvc;
using supermercadosq.Entities;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Request;
using supermercadosq.Routes;

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

app.MapMethods(UserPost.Template, UserPost.Methods, UserPost.Handle);

app.MapPut("/user/{id}", ([FromRoute]int id, UserRequest userDTO, DatabaseConnection context) =>{
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

