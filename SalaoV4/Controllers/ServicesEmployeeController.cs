using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

namespace SalaoV4.Controllers
{

    public class ServicesEmployeeController : ControllerBase
    {
        private readonly ServicesEmployeeRepository repo;
        // GET: ClientEmployeeController
        public ServicesEmployeeController()
        {
            repo = new ServicesEmployeeRepository();
        }
        [HttpGet]
        public IEnumerable<ServicesEmployee> Get()
        {
            return repo.SelectAllComplete();
        }

        [HttpGet("{id}")]
        public ServicesEmployee Get(int id)
        {
            return repo.Select(id);
        }

        [HttpPost]
        public IEnumerable<ServicesEmployee> Post([FromBody] ServicesEmployee tp)
        {
            repo.Add(tp);

            return repo.SelectAll();
        }

        [HttpPut]
        public IEnumerable<ServicesEmployee> Put([FromBody] ServicesEmployee tp)
        {
            repo.Change(tp);
            return repo.SelectAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<ServicesEmployee> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}
