using ECommerceModels;

namespace ECommerceApi.Repositories
{
    public interface IUserRepository
    {
        // Usando o padrão Repository

        // Realizando o CRUD

        // Intermediar para evitar o acoplamento

        public List<User> Get(); // Pode usar uma lista para trazer todos os usuarios 

        public User Get(int id);

        public void Add(User user); // passar o objeto por referencia , pois se houver alteração ela se reflete para fora 

        public void Update(User user); // passar o objeto por referencia , pois se houver alteração ela se reflete para fora

        public void Delete(int id); // da para melhorar o tipo de dado referente ao retorno 


    }
}
