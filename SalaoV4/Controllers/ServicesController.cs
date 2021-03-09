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
    public class ServicesController : ControllerBase
    {
        private readonly IServicesRepository repo;
        public ServicesController()
        {
            repo = new ServicesRepository();
        }


        [HttpGet]
        public IEnumerable<Services> Get()
        {
            return repo.SelectAll();
        }


        [HttpGet("{id}")]
        public Services Get(int id)
        {
            return repo.Select(id);
        }

        // POST api/<ClientController1>
        [HttpPost]
        public IEnumerable<Services> Post([FromBody] Services services)
        {
            repo.Add(services);
            return repo.SelectAll();
        }

        // PUT api/<ClientController1>/5
        [HttpPut("{id}")]
        public IEnumerable<Services> Put(int id, [FromBody] Services services)
        {
            repo.Change(services);
            return repo.SelectAll();
        }

        // DELETE api/<ClientController1>/5
        [HttpDelete("{id}")]
        public IEnumerable<Services> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}



