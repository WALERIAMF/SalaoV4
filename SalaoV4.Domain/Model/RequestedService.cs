using Minha1Conexao.Domain;
using SalaoV4.Domain.Model.GestaoAgendamento;
using System;
using System.Collections.Generic;

namespace SalaoV4.Domain.Model
{
    public class RequestedService : IEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public Services Services { get; set; }
        public Employee Employee { get; set; }
        public StatusServico Status { get; set; }
        public DateTime DtServico { get; set; }
        public List<Client> Client { get; set; }
        public List<Employee> Employees { get; set; }
        public List<RequestServicesClient> RequestServicesClient { get; set; }
        public List<RequestServicesEmployee> RequestServicesEmployee { get; set; }

        public enum StatusServico
        {
            ARealizar,
            Realizado,
            Reagendado,
            CanceladoPeloCliente,
            CanceladoPeloSalao
        }

        public void IncludeRequestedService(int id, Services services, Employee employee)
        {
            Id = id;
            Services = services;
            Employee = employee;
        }

        public void DeleteRequestedService(int id)
        {
            Id = id;
        }
    }
}
