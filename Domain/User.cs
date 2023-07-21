using Flunt.Validations;
using supermercadosq.Domain.Enum;

namespace supermercadosq.Domain{
    public class User : Entity
    {
        public string Name { get; set; }
        public string? SocialName { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Level Level { get; set; }
        public Boolean Active { get; set; }
        public string? PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }

        public User (int id, string name, string? socialName, string cpfCnpj, string email, string password, Level level, bool active, string? phoneNumber)
        {
            var contracts = new Contract<User>()
                .IsNotNullOrEmpty(name, "Name")
                .IsNotNullOrEmpty(cpfCnpj, "CpfCnpj")
                .IsNotNullOrEmpty(email, "Email")
                .IsEmail(email, "Email")
                .IsNotNullOrEmpty(password, "Password")
                .IsNotNull(level, "Level")
                .IsNotNull(active, "Active");

            AddNotifications(contracts);

            Id = id;
            Name = name;
            SocialName = socialName;
            CpfCnpj = cpfCnpj;
            Email = email;
            Password = password;
            Level = level;
            Active = active;
            PhoneNumber = phoneNumber;
            CreationDate = DateTime.UtcNow;
        }
    }
}