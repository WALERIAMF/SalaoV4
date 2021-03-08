using SalaoV4.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class AddressRepository
    {
        private readonly Context context;

        public AddressRepository()
        {
            context = new Context();
        }

        public void Incluir(Address address)
        {
            context.Address.Add(address);
            context.SaveChanges();
        }

        public Address Selecionar(int id)
        {
            return context.Address.FirstOrDefault(x => x.Id == id);
        }

        public List<Address> SelecionarTudo()
        {
            return context.Address.ToList();
        }

        public void Alterar(Address address)
        {
            context.Address.Update(address);
            context.SaveChanges();
        }
        public void Excluir(int id)
        {
            var address = Selecionar(id);
            context.Address.Remove(address);
        }

    }
}

