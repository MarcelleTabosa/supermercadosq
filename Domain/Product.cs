using Flunt.Validations;
using supermercadosq.Domain.Enum;

namespace supermercadosq.Domain{
    public class Product : Entity{
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public string? Image { get; set; }
        public State? Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public Product(int id, string name, string ingredient, string? image, State? status, int userId)
        {
            var contract = new Contract<Product>()
                .IsNotNull(name, "Name")
                .IsNotNull(ingredient, "Ingredient")
                .IsNotNull(userId, "UserId");

            AddNotifications(contract);

            Id = id;
            Name = name;
            Ingredient = ingredient;
            Image = image;
            Status = status;
            UserId = userId;
            CreationDate = DateTime.UtcNow;
        }
    }
}