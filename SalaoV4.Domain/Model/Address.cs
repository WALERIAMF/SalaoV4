using Minha1Conexao.Domain;

namespace SalaoV4.Domain.Model
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public void Add(int id, string logradouro, string cep, string bairro, string cidade,
            string uf, string numero, string compl)
        {
            Id = id;
            Logradouro = logradouro;
            CEP = cep;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Numero = numero;
            Complemento = compl;
        }

        public void Change(string logradouro, string cep, string bairro, string cidade,
            string uf, string numero, string compl)
        {
            Logradouro = logradouro;
            CEP = cep;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Numero = numero;
            Complemento = compl;
        }

    }
}
