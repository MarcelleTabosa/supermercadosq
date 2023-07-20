using supermercadosq.Domain.Enum;

namespace supermercadosq.Domain{
    public class Product : Entity{
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public string? Image { get; set; }
        public State? Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}