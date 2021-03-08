using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaoV4.Domain.Model.GestaoAgendamento
{
    public class MyServicesBase
    {
        public List<Services> Services { get; set; }

        public MyServicesBase()
        {
            Services = new List<Services>();
            DadosIniciais();
        }

        public void Incluir(Services services)
        {
            Services.Add(services);
        }

        public void AlterarUmServico(int id, string nomeNovo, int minutosParaExecucaoNovo, decimal precoNovo)
        {
            Services services = Services.FirstOrDefault();
            if (services != null)
            {
                services.Change(nomeNovo, minutosParaExecucaoNovo, precoNovo);
            }
        }

        public void ExcluirUmServico(int id)
        {
            Services.RemoveAll(serv => serv.Id == id);
        }

        private void DadosIniciais()
        {
            Services s1 = new Services();
            s1.Add(1, "Corte de Cabelo", 59, 130);

            Services s5 = new Services();
            s5.Add(1, "Corte de Cabelo", 59, 130);

            Services s2 = new Services();
            s2.Add(2, "Manicure", 59, 20);

            Services s3 = new Services();
            s3.Add(3, "Pedicure", 59, 30);

            Services s4 = new Services();
            s4.Add(4, "Limpeza de pele", 59, 100);


            Incluir(s1);
            Incluir(s2);
            Incluir(s3);
            Incluir(s4);
            Incluir(s5);

            //return bs;
        }
    }
}
