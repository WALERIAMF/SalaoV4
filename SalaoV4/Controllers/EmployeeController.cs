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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository repo;
        public EmployeeController()
        {
            repo = new EmployeeRepository();
        }


        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return repo.SelectAll();
        }


        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return repo.Select(id);
        }

        // POST api/<ClientController1>
        [HttpPost]
        public IEnumerable<Employee> Post([FromBody] Employee employee)
        {
            repo.Add(employee);
            return repo.SelectAll();
        }

        // PUT api/<ClientController1>/5
        [HttpPut("{id}")]
        public IEnumerable<Employee> Put(int id, [FromBody] Employee employee)
        {
            repo.Change(employee);
            return repo.SelectAll();
        }

        // DELETE api/<ClientController1>/5
        [HttpDelete("{id}")]
        public IEnumerable<Employee> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}



