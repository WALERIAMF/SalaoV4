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
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<SchedulingEmployee> Post([FromBody] SchedulingEmployee tp)
        {
            repo.Incluir(tp);

            return repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<SchedulingEmployee> Put([FromBody] SchedulingEmployee tp)
        {
            repo.Alterar(tp);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<SchedulingEmployee> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
