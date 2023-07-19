using Microsoft.AspNetCore.Mvc;
using supermercadosq.Data;
using supermercadosq.Model.Response;

namespace supermercadosq.Endpoint
{
    public class UserGetSingle
    {
        public static string Template => "/user/{id}";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute] int id, DatabaseConnection context)
        {
            //var userRepository = new UserRepository();
            //UserResponse user = userRepository.GetUserSingle(id, context);
            return Results.Ok();
        }
    }
}