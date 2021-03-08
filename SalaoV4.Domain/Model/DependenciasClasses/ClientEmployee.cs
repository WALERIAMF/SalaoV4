using Minha1Conexao.Domain;

namespace SalaoV4.Domain.Model
{
    public class ClientEmployee : IEntity
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }
        public Client Client { get; set; }

     }
}
