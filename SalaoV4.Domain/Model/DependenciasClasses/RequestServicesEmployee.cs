using Minha1Conexao.Domain;

namespace SalaoV4.Domain.Model
{
    public class RequestServicesEmployee : IEntity
    {

        public int Id { get; set; }
        public int IdRequestServices { get; set; }
        public RequestedService RequestedService { get; set; }
        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }
    }
}
