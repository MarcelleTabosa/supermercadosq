using supermercadosq.Entities.Enum;

namespace supermercadosq.Entities{
    public class User{
        public int Id { get; set; }
        public string Name { get; set; }
        public string SocialName { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Level Level { get; set; }
        public Boolean Active { get; set; }
        public string PhoneNumber { get; set; }
    }
}