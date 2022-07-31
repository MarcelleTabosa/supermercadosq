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
        
        public User UpdateUser(int id, UserRequest userRequest, DatabaseConnection context)
        {
            var user = context.Users.Where(u => u.Id == id).First();

            user.Name = userRequest.Name != null ? userRequest.Name : user.Name;
            user.SocialName = userRequest.SocialName != null ? userRequest.SocialName : user.SocialName;
            user.Email = userRequest.Email != null ? userRequest.Email : user.Email; 
            user.Password = userRequest.Password != null ? userRequest.Password : user.Password;
            user.PhoneNumber = userRequest.PhoneNumber != null ? userRequest.PhoneNumber : user.PhoneNumber;

        context.SaveChanges();

        return user;
        }
    }
}