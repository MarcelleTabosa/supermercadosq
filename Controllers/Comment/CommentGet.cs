using supermercadosq.Data;
using supermercadosq.Model.Response;

namespace supermercadosq.Endpoint
{
    public class CommentGet
    {
        public static string Template => "/comment";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(DatabaseConnection context)
        {
            //var commentRepository = new CommentRepository();
            //List<CommentResponse> comments = commentRepository.GetAllComment(context);
            return Results.Ok();
        }
    }
}