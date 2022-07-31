using supermercadosq.Domain.Enum;

namespace supermercadosq.Domain{
    public class Adress : Entity{
        public string Road { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public User User { get; set; }
    }
}