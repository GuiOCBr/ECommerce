using ECommerceApi.Repositories;
using ECommerceModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // faz validações 
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet] // endereço_site/api/User
        public IActionResult Get()
        {
            var listsUsers = _repository.Get();

            return Ok(listsUsers);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _repository.Get(id);
            if(user == null)
            {
                return NotFound("Não encontrado!");
            }

            return Ok(user);
        }

        [HttpPost]

        public IActionResult Add([FromBody] User user)
        {
            _repository.Add(user);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody]User user, int id )
        {
            _repository.Update(user);

            return Ok(user);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);

            return Ok();
        }
    }
}
