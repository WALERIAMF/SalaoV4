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
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<RequestServicesClient> Post([FromBody] RequestServicesClient tp)
        {
            repo.Incluir(tp);

            return repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<RequestServicesClient> Put([FromBody] RequestServicesClient tp)
        {
            repo.Alterar(tp);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<RequestServicesClient> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
