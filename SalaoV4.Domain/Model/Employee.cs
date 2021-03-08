using Minha1Conexao.Domain;
using SalaoV4.Domain.Model.GestaoAgendamento;
using System;
using System.Collections.Generic;

namespace SalaoV4.Domain.Model
{
    public class Employee : IEntity
    {

        public Employee()
        {
            Services = new List<Services>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public Address Address { get; set; }
        public DateTime HorarioEntrada { get { return Convert.ToDateTime("10:00"); } }
        public DateTime HorarioSaida { get { return Convert.ToDateTime("19:00"); } }
        public PositionEmployer Position { get; set; }
        public List<ClientEmployee> ClientEmployees { get; set; }
        public List<ServicesEmployee> ServicesEmployee { get; set; }
        public List<RequestServicesEmployee> RequestServicesEmployee { get; set; }
        public List<SchedulingEmployee> SchedulingEmployee { get; set; }
        public List<Services> Services { get; set; }


        public enum PositionEmployer
        {
            Cabelereira,
            Manicure,
            Esteticista
        }
      
        public void Add(string name, string phone, Address address, PositionEmployer position)
        {
            //Matricula = matricula;
            Name = name;
            Phone = phone;
            Address = address;
            Position = position;
        }

        public void Change(string name, string phone, Address address, PositionEmployer position)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Position = position;
        }

        public void ServicesInclude(Services service)
        {
            Services.Add(service);
        }

        public void ServiceExclude(int id)
        {
            //Services.RemoveAll(s => s.Id == id);

            List<Services> remover = Services.FindAll(f => f.Id == id);
            foreach (var remove in remover)
            {
                Services.Remove(remove);
            }
        }
    }


}