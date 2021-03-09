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
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository repo;
        public AddressController()
        {
            repo = new AddressRepository();
        }


        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return repo.SelectAll();
        }


        [HttpGet("{id}")]
        public Address Get(int id)
        {
            return repo.Select(id);
        }


        [HttpPost]
        public IEnumerable<Address> Post([FromBody] Address address)
        {
            repo.Add(address);
            return repo.SelectAll();
        }

        // PUT api/<ClientController1>/5
        [HttpPut("{id}")]
        public IEnumerable<Address> Put(int id, [FromBody] Address address)
        {
            repo.Change(address);
            return repo.SelectAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Address> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}



