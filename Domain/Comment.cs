using supermercadosq.Domain.Enum;

namespace supermercadosq.Domain{
    public class Comment : Entity{
        public string Message { get; set; }
        public State? Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}