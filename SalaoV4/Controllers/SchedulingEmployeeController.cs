using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

namespace SalaoV4.Controllers
{

    public class SchedulingEmployeeController : ControllerBase
    {
        private readonly SchedulingEmployeeRepository repo;
        // GET: ClientEmployeeController
        public SchedulingEmployeeController()
        {
            repo = new SchedulingEmployeeRepository();
        }
        [HttpGet]
        public IEnumerable<SchedulingEmployee> Get()
        {
            return repo.SelectAllComplete();
        }

        [HttpGet("{id}")]
        public SchedulingEmployee Get(int id)
        {
            return repo.Select(id);
        }

        [HttpPost]
        public IEnumerable<SchedulingEmployee> Post([FromBody] SchedulingEmployee tp)
        {
            repo.Add(tp);

            return repo.SelectAll();
        }

        [HttpPut]
        public IEnumerable<SchedulingEmployee> Put([FromBody] SchedulingEmployee tp)
        {
            repo.Change(tp);
            return repo.SelectAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<SchedulingEmployee> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}
