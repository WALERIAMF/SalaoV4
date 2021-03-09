using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

namespace SalaoV4.Controllers
{
    public class ClientEmployeeController : ControllerBase
    {
        private readonly ClientEmployeeRepository repo;
        // GET: ClientEmployeeController
        public ClientEmployeeController()
        {
            repo = new ClientEmployeeRepository();
        }
        [HttpGet]
        public IEnumerable<ClientEmployee> Get()
        {
            return repo.SelectAllComplete();
        }

        [HttpGet("{id}")]
        public ClientEmployee Get(int id)
        {
            return repo.Select(id);
        }

        [HttpPost]
        public IEnumerable<ClientEmployee> Post([FromBody] ClientEmployee tp)
        {
            repo.Add(tp);

            return repo.SelectAll();
        }

        [HttpPut]
        public IEnumerable<ClientEmployee> Put([FromBody] ClientEmployee tp)
        {
            repo.Change(tp);
            return repo.SelectAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<ClientEmployee> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}
