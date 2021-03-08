using Minha1Conexao.Domain;

namespace SalaoV4.Domain.Model
{
    public class RequestServicesClient : IEntity
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdRequestServices { get; set; }
        public Client Client { get; set; }
        public RequestedService RequestedService { get; set; }
    }
}
