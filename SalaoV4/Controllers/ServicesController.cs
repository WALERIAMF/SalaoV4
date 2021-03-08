using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaoV4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ServicesRepository repo;
        public ServicesController()
        {
            repo = new ServicesRepository();
        }


        [HttpGet]
        public IEnumerable<Services> Get()
        {
            return repo.SelecionarTudo();
        }


        [HttpGet("{id}")]
        public Services Get(int id)
        {
            return repo.Selecionar(id);
        }

        // POST api/<ClientController1>
        [HttpPost]
        public IEnumerable<Services> Post([FromBody] Services services)
        {
            repo.Incluir(services);
            return repo.SelecionarTudo();
        }

        // PUT api/<ClientController1>/5
        [HttpPut("{id}")]
        public IEnumerable<Services> Put(int id, [FromBody] Services services)
        {
            repo.Alterar(services);
            return repo.SelecionarTudo();
        }

        // DELETE api/<ClientController1>/5
        [HttpDelete("{id}")]
        public IEnumerable<Services> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}



