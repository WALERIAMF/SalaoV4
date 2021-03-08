using Minha1Conexao.Domain;

namespace SalaoV4.Domain.Model
{
    public class SchedulingEmployee : IEntity
    {
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public int IdScheduling { get; set; }
        public Employee Employee { get; set; }
        public Scheduling Scheduling { get; set; }

     }
}
