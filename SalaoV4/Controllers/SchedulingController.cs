using Microsoft.AspNetCore.Mvc;
using SalaoV4.Data.Repository;
using SalaoV4.Domain.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaoV4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulingController : ControllerBase
    {
        private readonly SchedulingRepository repo;
        public SchedulingController()
        {
            repo = new SchedulingRepository();
        }


        [HttpGet]
        public IEnumerable<Scheduling> Get()
        {
            return repo.SelecionarTudo();
        }


        [HttpGet("{id}")]
        public Scheduling Get(int id)
        {
            return repo.Selecionar(id);
        }

        // POST api/<ClientController1>
        [HttpPost]
        public IEnumerable<Scheduling> Post([FromBody] Scheduling scheduling)
        {
            repo.Incluir(scheduling);
            return repo.SelecionarTudo();
        }

        // PUT api/<ClientController1>/5
        [HttpPut("{id}")]
        public IEnumerable<Scheduling> Put(int id, [FromBody] Scheduling scheduling)
        {
            repo.Alterar(scheduling);
            return repo.SelecionarTudo();
        }

        // DELETE api/<ClientController1>/5
        [HttpDelete("{id}")]
        public IEnumerable<Scheduling> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}



