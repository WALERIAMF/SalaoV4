using SalaoV4.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class RequestedServiceRepository
    {
        private readonly Context context;

        public RequestedServiceRepository()
        {
            context = new Context();
        }

        public void Incluir(RequestedService requestedService)
        {
            context.RequestedService.Add(requestedService);
            context.SaveChanges();
        }

        public RequestedService Selecionar(int id)
        {
            return context.RequestedService.FirstOrDefault(x => x.Id == id);
        }

        public List<RequestedService> SelecionarTudo()
        {
            return context.RequestedService.ToList();
        }

        public void Alterar(RequestedService requestedService)
        {
            context.RequestedService.Update(requestedService);
            context.SaveChanges();
        }
        public void Excluir(int id)
        {
            var requestedService = Selecionar(id);
            context.RequestedService.Remove(requestedService);
        }

    }
}
