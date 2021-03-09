using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Data.Repository.Interface;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaoV4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository repo;
        public ClientController()
        {
            repo = new ClientRepository();
        }


        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return repo.SelectAll();
        }


        [HttpGet("{id}")]
        public Client Get(int id)
        {
            return repo.Select(id);
        }

        // POST api/<ClientController1>
        [HttpPost]
        public IEnumerable<Client> Post([FromBody] Client client)
        {
            repo.Add(client);
            return repo.SelectAll();
        }

        // PUT api/<ClientController1>/5
        [HttpPut("{id}")]
        public IEnumerable<Client> Put(int id, [FromBody] Client client)
        {
            repo.Change(client);
            return repo.SelectAll();
        }

        // DELETE api/<ClientController1>/5
        [HttpDelete("{id}")]
        public IEnumerable<Client> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}



