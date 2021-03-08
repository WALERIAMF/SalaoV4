using Minha1Conexao.Domain;
using System.Collections.Generic;

namespace SalaoV4.Domain.Model
{
    public class Services : IEntity
    {

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public int MinutesForExecution { get; set; }
        public decimal Price { get; set; }
        public List<ServicesEmployee> ServicesEmployee  { get; set;}

        public void Add(int id, string name, int minutesForExecution, decimal price)
        {
            Scheduling a = new Scheduling();

            Id = id;
            Name = name;
            MinutesForExecution = minutesForExecution;
            Price = price;
        }

        public void Change(string name, int minutesForExecution, decimal price)
        {
            Name = name;
            MinutesForExecution = minutesForExecution;
            Price = price;
        }

    }
}
