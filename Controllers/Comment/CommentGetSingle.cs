using Microsoft.AspNetCore.Mvc;
using supermercadosq.Data;
using supermercadosq.Model.Response;

namespace supermercadosq.Endpoint
{
    public class CommentGetSingle
    {
        public static string Template => "/comment/{id}";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute] int id, DatabaseConnection context)
        {
            //var commentRepository = new CommentRepository();
            //CommentResponse commentResponse = commentRepository.GetCommentSingle(id, context);
            return Results.Ok();
        }
    }
}