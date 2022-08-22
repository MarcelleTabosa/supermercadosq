using supermercadosq.Domain.Enum;

namespace supermercadosq.Domain{
    public class Comment : Entity{
        public string Message { get; set; }
        public State? Status { get; set; }
        public int User { get; set; }
        public int Product { get; set; }
    }
}