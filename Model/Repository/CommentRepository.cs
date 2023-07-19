/*using supermercadosq.Domain;
using supermercadosq.Model.Request;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Response;

namespace supermercadosq.Model.Repository{
    public class CommentRepository
    {
        public Comment CreateComment(CommentRequest commentRequest, DatabaseConnection context)
        {
        var comment = new Comment
        {
            Message = commentRequest.Message,
            Status = commentRequest.Status,
            User = commentRequest.User,
            Product = commentRequest.Product,
            CreationDate = DateTime.UtcNow,
            UpdateDate = DateTime.UtcNow
        };
        context.Comments.Add(comment);
        context.SaveChanges();

        return comment;
        }
        
        public Comment UpdateComment(int id, CommentRequest commentRequest, DatabaseConnection context)
        {
            var comment = context.Comments.Where(c => c.Id == id).First();

            comment.Message = commentRequest.Message != null ? commentRequest.Message : comment.Message;
            comment.Status = commentRequest.Status != null ? commentRequest.Status : comment.Status;
            comment.User = commentRequest.User != null ? commentRequest.User : comment.User; 
            comment.Product = commentRequest.Product != null ? commentRequest.Product : comment.Product;
            comment.UpdateDate = DateTime.UtcNow;

        context.SaveChanges();

        return comment;
        }

        public Comment DeleteComment(int id, DatabaseConnection context)
        {
            var comment = context.Comments.Where(c => c.Id == id).First();

        context.Comments.Remove(comment);
        context.SaveChanges();

        return comment;
        }

        public List<CommentResponse> GetAllComment(DatabaseConnection context)
        {
            List<Comment> comments = context.Comments.ToList();
            List<CommentResponse> responses = new List<CommentResponse>();
            foreach(Comment comment in comments)
            {
                var response = new CommentResponse
                (
                    comment.Message,
                    comment.Product
                );
                responses.Add(response);
            }
            return responses;
        }

        public CommentResponse GetCommentSingle(int id, DatabaseConnection context)
        {
            var comment = context.Comments.Where(c => c.Id == id).First();
            
                var response = new CommentResponse
                (
                    comment.Message,
                    comment.Product
                );
            
            return response;
        }
    }
}*/