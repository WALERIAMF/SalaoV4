using Minha1Conexao.Domain;

namespace SalaoV4.Domain.Model
{
    public class ServicesEmployee : IEntity
    {

        public int Id { get; set; }
        public int IdServices { get; set; }
        public Services Services { get; set; }
        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }
    }
}
