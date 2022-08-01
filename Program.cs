using supermercadosq.Endpoint;
using supermercadosq.Model.Connection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddNpgsql<DatabaseConnection>(builder.Configuration["Database:Npgsql"]);
var app = builder.Build();

app.MapMethods(UserGetSingle.Template, UserGetSingle.Methods, UserGetSingle.Handle);
app.MapMethods(UserGet.Template, UserGet.Methods, UserGet.Handle);
app.MapMethods(UserPost.Template, UserPost.Methods, UserPost.Handle);
app.MapMethods(UserPut.Template, UserPut.Methods, UserPut.Handle);
app.MapMethods(UserDelete.Template, UserDelete.Methods, UserDelete.Handle);

app.MapMethods(AddressGetSingle.Template, AddressGetSingle.Methods, AddressGetSingle.Handle);
app.MapMethods(AddressGet.Template, AddressGet.Methods, AddressGet.Handle);
app.MapMethods(AddressPost.Template, AddressPost.Methods, AddressPost.Handle);
app.MapMethods(AddressPut.Template, AddressPut.Methods, AddressPut.Handle);
app.MapMethods(AddressDelete.Template, AddressDelete.Methods, AddressDelete.Handle);

app.Run();

