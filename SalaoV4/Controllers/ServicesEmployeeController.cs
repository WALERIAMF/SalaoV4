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
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<ServicesEmployee> Post([FromBody] ServicesEmployee tp)
        {
            repo.Incluir(tp);

            return repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<ServicesEmployee> Put([FromBody] ServicesEmployee tp)
        {
            repo.Alterar(tp);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<ServicesEmployee> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
