using Microsoft.AspNetCore.Mvc;
using supermercadosq.Endpoint;
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

app.MapMethods(UserPost.Template, UserPost.Methods, UserPost.Handle);
app.MapMethods(UserPut.Template, UserPut.Methods, UserPut.Handle);
app.MapMethods(UserDelete.Template, UserDelete.Methods, UserDelete.Handle);


app.Run();

