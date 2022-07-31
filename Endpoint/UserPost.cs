using supermercadosq.Model.Request;
using supermercadosq.Model.Connection;
using supermercadosq.Domain;
using supermercadosq.Model.Repository;

namespace supermercadosq.Endpoint
{
    public class UserPost
    {
        public static string Template => "/user";
        public static string[] Methods => new string[] {HttpMethod.Post.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(UserRequest userRequest, DatabaseConnection context)
        {
            var userRepository = new UserRepository();
            var user = new User();
            user = userRepository.CreateUser(userRequest, context);
            
            return Results.Created($"/user/{user.Id}", user.Id);
        }
    }
}