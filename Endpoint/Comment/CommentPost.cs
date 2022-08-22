using supermercadosq.Model.Request;
using supermercadosq.Model.Connection;
using supermercadosq.Domain;
using supermercadosq.Model.Repository;

namespace supermercadosq.Endpoint
{
    public class CommentPost
    {
        public static string Template => "/comment";
        public static string[] Methods => new string[] {HttpMethod.Post.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(CommentRequest commentRequest, DatabaseConnection context)
        {
            var commentRepository = new CommentRepository();
            var comment = new Comment();
            comment = commentRepository.CreateComment(commentRequest, context);
            
            return Results.Created($"/Comment/{comment.Id}", comment.Id);
        }
    }
}