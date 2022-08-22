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

app.MapMethods(ProductGetSingle.Template, ProductGetSingle.Methods, ProductGetSingle.Handle);
app.MapMethods(ProductGet.Template, ProductGet.Methods, ProductGet.Handle);
app.MapMethods(ProductPost.Template, ProductPost.Methods, ProductPost.Handle);
app.MapMethods(ProductPut.Template, ProductPut.Methods, ProductPut.Handle);
app.MapMethods(ProductDelete.Template, ProductDelete.Methods, ProductDelete.Handle);

app.MapMethods(CommentGetSingle.Template, CommentGetSingle.Methods, CommentGetSingle.Handle);
app.MapMethods(CommentGet.Template, CommentGet.Methods, CommentGet.Handle);
app.MapMethods(CommentPost.Template, CommentPost.Methods, CommentPost.Handle);
app.MapMethods(CommentPut.Template, CommentPut.Methods, CommentPut.Handle);
app.MapMethods(CommentDelete.Template, CommentDelete.Methods, CommentDelete.Handle);

app.Run();

