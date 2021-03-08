using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaoV4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestedServiceController : ControllerBase
    {
        private readonly RequestedServiceRepository repo;
        public RequestedServiceController()
        {
            repo = new RequestedServiceRepository();
        }


        [HttpGet]
        public IEnumerable<RequestedService> Get()
        {
            return repo.SelecionarTudo();
        }


        [HttpGet("{id}")]
        public RequestedService Get(int id)
        {
            return repo.Selecionar(id);
        }

        // POST api/<ClientController1>
        [HttpPost]
        public IEnumerable<RequestedService> Post([FromBody] RequestedService requestedService)
        {
            repo.Incluir(requestedService);
            return repo.SelecionarTudo();
        }

        // PUT api/<ClientController1>/5
        [HttpPut("{id}")]
        public IEnumerable<RequestedService> Put(int id, [FromBody] RequestedService requestedService)
        {
            repo.Alterar(requestedService);
            return repo.SelecionarTudo();
        }

        // DELETE api/<ClientController1>/5
        [HttpDelete("{id}")]
        public IEnumerable<RequestedService> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}



