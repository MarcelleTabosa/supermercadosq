using supermercadosq.Model.Request;
using supermercadosq.Model.Connection;
using supermercadosq.Entities;

namespace supermercadosq.Routes
{
    public class UserPost
    {
        public static string Template => "/user";
        public static string[] Methods => new string[] {HttpMethod.Post.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(UserRequest userRequest, DatabaseConnection context)
        {
            var user = new User
            {
                Name = userRequest.Name,
                SocialName = userRequest.SocialName,
                CpfCnpj = userRequest.CpfCnpj,
                Email = userRequest.Email,
                Password = userRequest.Password,
                Level = userRequest.Level,
                Active = userRequest.Active,
                PhoneNumber = userRequest.PhoneNumber
            };
            context.Users.Add(user);
            context.SaveChanges();
            return Results.Created($"/user/{user.Id}", user.Id);
        }
    }
}