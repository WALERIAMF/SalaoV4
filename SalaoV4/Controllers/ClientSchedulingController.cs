using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

namespace SalaoV4.Controllers
{

    public class ClientSchedulingController : ControllerBase
    {
        private readonly ClientSchedulingRepository repo;
        // GET: ClientEmployeeController
        public ClientSchedulingController()
        {
            repo = new ClientSchedulingRepository();
        }
        [HttpGet]
        public IEnumerable<ClientScheduling> Get()
        {
            return repo.SelectAllComplete();
        }

        [HttpGet("{id}")]
        public ClientScheduling Get(int id)
        {
            return repo.Select(id);
        }

        [HttpPost]
        public IEnumerable<ClientScheduling> Post([FromBody] ClientScheduling tp)
        {
            repo.Add(tp);

            return repo.SelectAll();
        }

        [HttpPut]
        public IEnumerable<ClientScheduling> Put([FromBody] ClientScheduling tp)
        {
            repo.Change(tp);
            return repo.SelectAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<ClientScheduling> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}
