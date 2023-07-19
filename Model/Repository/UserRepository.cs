/*using supermercadosq.Domain;
using supermercadosq.Model.Request;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Response;

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
            PhoneNumber = userRequest.PhoneNumber,
            CreationDate = DateTime.UtcNow,
            UpdateDate = DateTime.UtcNow,
            DeletionDate = null
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
            user.UpdateDate = DateTime.UtcNow;

        context.SaveChanges();

        return user;
        }

        public User DeleteUser(int id, DatabaseConnection context)
        {
            var user = context.Users.Where(u => u.Id == id).First();

        context.Users.Remove(user);
        context.SaveChanges();

        return user;
        }

        public List<UserResponse> GetAllUser(DatabaseConnection context)
        {
            List<User> users = context.Users.ToList();
            List<UserResponse> responses = new List<UserResponse>();
            foreach(User user in users)
            {
                var response = new UserResponse
                (
                    user.Name,
                    user.SocialName,
                    user.CpfCnpj,
                    user.Email,
                    user.PhoneNumber
                );
                responses.Add(response);
            }
            return responses;
        }

        public UserResponse GetUserSingle(int id, DatabaseConnection context)
        {
            var user = context.Users.Where(u => u.Id == id).First();
            
                var response = new UserResponse
                (
                    user.Name,
                    user.SocialName,
                    user.CpfCnpj,
                    user.Email,
                    user.PhoneNumber
                );
            
            return response;
        }
    }
}*/