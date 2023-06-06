using ECommerceModels;

namespace ECommerceApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        public static List<User> _db = new List<User>();

        public List<User> Get()
        {
            return _db;
        }

        public User Get(int id)
        {
            return _db.Find(x => x.Id == id)!;
        }

        public void Add(User user)
        {
            _db.Add(user);
        }
        public void Update(User user) // Revisar essa função depois , continua tendo o mesmo Id só vai atualizar o nome 
        {
            _db.Remove(Get(user.Id));
            _db.Add(user);
        }

        public void Delete(int id)
        {
            _db.Remove(Get(id));
        }
    }
}



//Posso criar varias implementações da Interface