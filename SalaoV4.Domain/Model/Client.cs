using Minha1Conexao.Domain;
using System.Collections.Generic;

namespace SalaoV4.Domain.Model
{
    public class Client : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public bool Active { get; set; }
        public List<ClientEmployee> ClientEmployee { get; set; }
        public List<ClientScheduling> ClientScheduling { get; set; }
        public List<RequestServicesClient> RequestServicesClient { get; set; }
        public Address Address { get; set; }

        public void Add(int id, string nome, string telefone, string cpf)
        {
            Id = id;
            Name = nome;
            Phone = telefone;
            Cpf = cpf;
        }

        public void Change(string nome, string telefone)
        {
            Name = string.IsNullOrEmpty(nome) ? Name : nome;

            Phone = string.IsNullOrEmpty(telefone) ? Phone : telefone;
        }

    }
}
