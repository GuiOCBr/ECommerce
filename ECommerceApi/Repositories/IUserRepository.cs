using ECommerceModels;

namespace ECommerceApi.Repositories
{
    public interface IUserRepository
    {
        // Usando o padrão Repository

        // Realizando o CRUD


        public List<User> Get();

        public User Get(int id);

        public void Add(User user);

        public void Update(User user);

        public void Delete(int id);


    }
}
