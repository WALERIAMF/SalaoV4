using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaoV4.Domain.Model
{
    public class MyClientBase
    {
        public List<Client> Clientes { get; set; }

        public MyClientBase()
        {
            Clientes = new List<Client>();
        }

        public void Include(Client cliente)
        {
            Clientes.Add(cliente);
        }

        public void IncludeList(Client cliente1, Client cliente2)
        {
            List<Client> lst = new List<Client> { cliente1, cliente2 };
            Clientes.AddRange(lst);
        }

        public void ChangeCustomer(int id, string nomeNovo, string telefoneNovo)
        {
            Client cliente = Clientes.FirstOrDefault(cli => cli.Id == id);
            if (cliente != null)
            {
                cliente.Change(nomeNovo, telefoneNovo);
            }
        }

        public void DeleteCustomer(int id)
        {
            Clientes.RemoveAll(cli => cli.Id == id);
        }
    }
}