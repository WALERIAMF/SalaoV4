using SalaoV4.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class SchedulingRepository 
    {
        private readonly Context context;

        public SchedulingRepository()
        {
            context = new Context();
        }

        public void Incluir(Scheduling scheduling)
        {
            context.Scheduling.Add(scheduling);
            context.SaveChanges();
        }

        public Scheduling Selecionar(int id)
        {
            return context.Scheduling.FirstOrDefault(x => x.Id == id);
        }

        public List<Scheduling> SelecionarTudo()
        {
            return context.Scheduling.ToList();
        }

        public void Alterar(Scheduling scheduling)
        {
            context.Scheduling.Update(scheduling);
            context.SaveChanges();
        }
        public void Excluir(int id)
        {
            var scheduling = Selecionar(id);
            context.Scheduling.Remove(scheduling);
        }

    }
}
