using Flunt.Validations;
using supermercadosq.Domain.Enum;

namespace supermercadosq.Domain{
    public class Comment : Entity{
        public string Message { get; set; }
        public State? Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public Comment(int id, string message, State? status, int userId, int productId)
        {
            var contract = new Contract<Comment>()
                .IsNotNull(message, "Messagr")
                .IsNotNull(status, "Status")
                .IsNotNull(userId, "UserId")
                .IsNotNull(productId, "ProductId");

            AddNotifications(contract);

            Id = id;
            Message = message;
            Status = status;
            UserId = userId;
            ProductId = productId;
            CreationDate = DateTime.UtcNow;
        }
    }
}