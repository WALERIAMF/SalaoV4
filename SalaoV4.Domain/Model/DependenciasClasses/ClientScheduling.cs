using Minha1Conexao.Domain;

namespace SalaoV4.Domain.Model
{
    public class ClientScheduling : IEntity
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdScheduling { get; set; }
        public Client Client { get; set; }
        public Scheduling Scheduling { get; set; }

     }
}
