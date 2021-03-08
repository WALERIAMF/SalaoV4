using SalaoV4.Domain.Model.GestaoAgendamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaoV4.Domain.Model.Financeiro
{
    public class Financial : RequestedService
    {
        public List<RequestedService> ServicosSolicitados { get; }
        public List<Services> Servico { get; }
        public List<Employee> Funcionario { get; }
        

        public Financial(List<RequestedService> servicosSolicitados, List<Services> price)
        {
            ServicosSolicitados = servicosSolicitados;
            Servico = price;
        }

        public Financial()
        {
        }
        public List<Services> CloseCashierByPeriod(DateTime dataInicial, DateTime dataFinal)
        {
            List<Services> servicoSolicitadosPorData = new List<Services>();
            foreach (RequestedService servicoSolicitado in ServicosSolicitados)
            {
                //filtrar uma data inicial e uma final
                //se a data do serviço >= dataInicial e se data do serviço <= dataFinal
                //considerar apenas os serviços realizados
                if (dataInicial >= servicoSolicitado.DtServico && dataFinal <= servicoSolicitado.DtServico && servicoSolicitado.Status == RequestedService.StatusServico.Realizado)
                {
                    servicoSolicitadosPorData.Add(servicoSolicitado.Services);
                }
            }
            //soma o valor dos serviços
            return servicoSolicitadosPorData;
        }
        public List<Services> CloseCashierByPeriodByEmployee(DateTime dataInicial, DateTime dataFinal, int id, double price)
        {
            List<Services> servicoSolicitadosPorDataPorFuncionario = new List<Services>();
            foreach (RequestedService servicoSolicitado in ServicosSolicitados)
            {

                if (dataInicial >= servicoSolicitado.DtServico && dataFinal <= servicoSolicitado.DtServico && servicoSolicitado.Status == RequestedService.StatusServico.Realizado && servicoSolicitado.Id == Employee.Id);
                {

                    //servicoSolicitadosPorDataPorFuncionario.Add(Servico.price);

                    // price = price*0.3;
                }
            }

           
            //soma o valor dos serviços
            return servicoSolicitadosPorDataPorFuncionario;
        }
    }
}
