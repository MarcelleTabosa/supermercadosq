using supermercadosq.Entities;
using supermercadosq.Model.Request;
using supermercadosq.Model.Connection;

namespace supermercadosq.Model.Repository{
    public class UserRepository
    {
        public User CreateUser(UserRequest userRequest, DatabaseConnection context)
        {
        var user = new User
        {
            Name = userRequest.Name,
            SocialName = userRequest.SocialName,
            CpfCnpj = userRequest.CpfCnpj,
            Email = userRequest.Email,
            Password = userRequest.Password,
            Level = userRequest.Level,
            Active = userRequest.Active,
            PhoneNumber = userRequest.PhoneNumber
        };
        context.Users.Add(user);
        context.SaveChanges();

        return user;
        }
    }
}