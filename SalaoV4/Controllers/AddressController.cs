using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaoV4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly AddressRepository repo;
        public AddressController()
        {
            repo = new AddressRepository();
        }


        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return repo.SelecionarTudo();
        }


        [HttpGet("{id}")]
        public Address Get(int id)
        {
            return repo.Selecionar(id);
        }


        [HttpPost]
        public IEnumerable<Address> Post([FromBody] Address address)
        {
            repo.Incluir(address);
            return repo.SelecionarTudo();
        }

        // PUT api/<ClientController1>/5
        [HttpPut("{id}")]
        public IEnumerable<Address> Put(int id, [FromBody] Address address)
        {
            repo.Alterar(address);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Address> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}



