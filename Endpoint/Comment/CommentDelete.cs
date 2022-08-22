using Microsoft.AspNetCore.Mvc;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Repository;

namespace supermercadosq.Endpoint
{
    public class CommentDelete
    {
        public static string Template => "/comment/{id}";
        public static string[] Methods => new string[] { HttpMethod.Delete.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, DatabaseConnection context)
        {
            var commentRepository = new CommentRepository();
            var comment = commentRepository.DeleteComment(id,  context);

            return Results.StatusCode(200);
        }
    }
}