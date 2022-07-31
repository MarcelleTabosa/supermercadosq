using Microsoft.AspNetCore.Mvc;
using supermercadosq.Endpoint;
using supermercadosq.Entities;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Request;

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

app.MapPut("/user/{id}", ([FromRoute]int id, UserRequest userRequest, DatabaseConnection context) =>{
  var user = context.Users.Where(u => u.Id == id).First();
  if(user != null){
    user.Name = userRequest.Name != null ? userRequest.Name : user.Name;
    user.SocialName = userRequest.SocialName != null ? userRequest.SocialName : user.SocialName;
    user.Email = userRequest.Email != null ? userRequest.Email : user.Email; 
    user.Password = userRequest.Password != null ? userRequest.Password : user.Password;
    user.PhoneNumber = userRequest.PhoneNumber != null ? userRequest.PhoneNumber : user.PhoneNumber;
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

