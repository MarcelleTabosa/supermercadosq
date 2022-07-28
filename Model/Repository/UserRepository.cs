using supermercadosq.Entities;

namespace supermercadosq.Model.Repository{
    public class UserRepository{
        public List<User> User { get; set; }

        public void CreateUser(User user){
            if(User == null)
                User = new List<User>();

            User.Add(user);
        }
    }
}