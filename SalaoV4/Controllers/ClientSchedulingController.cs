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
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<ClientScheduling> Post([FromBody] ClientScheduling tp)
        {
            repo.Incluir(tp);

            return repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<ClientScheduling> Put([FromBody] ClientScheduling tp)
        {
            repo.Alterar(tp);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<ClientScheduling> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
