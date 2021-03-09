using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

namespace SalaoV4.Controllers
{
    public class RequestServicesEmployeeController : ControllerBase
    {
        private readonly RequestServicesEmployeeRepository repo;
        // GET: ClientEmployeeController
        public RequestServicesEmployeeController()
        {
            repo = new RequestServicesEmployee();
        }
        [HttpGet]
        public IEnumerable<RequestServicesEmployee> Get()
        {
            return repo.SelectAllComplete();
        }

        [HttpGet("{id}")]
        public RequestServicesEmployee Get(int id)
        {
            return repo.Select(id);
        }

        [HttpPost]
        public IEnumerable<RequestServicesEmployee> Post([FromBody] RequestServicesEmployee tp)
        {
            repo.Add(tp);

            return repo.SelectAll();
        }

        [HttpPut]
        public IEnumerable<RequestServicesEmployee> Put([FromBody] RequestServicesEmployee tp)
        {
            repo.Change(tp);
            return repo.SelectAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<RequestServicesEmployee> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}
