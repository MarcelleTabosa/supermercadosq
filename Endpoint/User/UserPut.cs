using Microsoft.AspNetCore.Mvc;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Repository;
using supermercadosq.Model.Request;

namespace supermercadosq.Endpoint
{
    public class UserPut
    {
        public static string Template => "/user/{id}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, UserRequest userRequest, DatabaseConnection context)
        {
            var userRepository = new UserRepository();
            var user = userRepository.UpdateUser(id, userRequest, context);

            return Results.StatusCode(200);
        }
    }
}