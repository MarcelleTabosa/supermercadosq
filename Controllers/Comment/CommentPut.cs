using Microsoft.AspNetCore.Mvc;
using supermercadosq.Data;
using supermercadosq.Domain;
using supermercadosq.Model.Request;

namespace supermercadosq.Endpoint
{
    public class CommentPut
    {
        public static string Template => "/comment/{id}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, CommentRequest commentRequest, DatabaseConnection context)
        {
            //var commentRepository = new CommentRepository();
            //var comment = commentRepository.UpdateComment(id, commentRequest, context);

            return Results.StatusCode(204);
        }
    }
}