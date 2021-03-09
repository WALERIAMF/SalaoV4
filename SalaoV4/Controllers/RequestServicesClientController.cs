using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

namespace SalaoV4.Controllers
{

    public class RequestServicesClientController : ControllerBase
    {
        private readonly RequestServicesClientRepository repo;
        // GET: ClientEmployeeController
        public RequestServicesClientController()
        {
            repo = new RequestServicesClientRepository();
        }
        [HttpGet]
        public IEnumerable<RequestServicesClient> Get()
        {
            return repo.SelectAllComplete();
        }

        [HttpGet("{id}")]
        public RequestServicesClient Get(int id)
        {
            return repo.Select(id);
        }

        [HttpPost]
        public IEnumerable<RequestServicesClient> Post([FromBody] RequestServicesClient tp)
        {
            repo.Add(tp);

            return repo.SelectAll();
        }

        [HttpPut]
        public IEnumerable<RequestServicesClient> Put([FromBody] RequestServicesClient tp)
        {
            repo.Change(tp);
            return repo.SelectAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<RequestServicesClient> Delete(int id)
        {
            repo.Delete(id);
            return repo.SelectAll();
        }
    }
}
