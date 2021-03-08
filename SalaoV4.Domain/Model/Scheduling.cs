using System;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Domain.Model
{
    public class Scheduling
    {

        public int Id { get; set; }
        public Client Client { get; set; }
        public DateTime? DtAgendamento { get; set; }
        public DateTime DataChegada { get; set; }
        public string Anotacao { get; set; }
        public StatusAgenda Status { get; set; }
        public Employee Employee { get; set; }
        public List<SchedulingEmployee> SchedulingEmployee { get; set; }
        public List<ClientScheduling> ClientScheduling { get; set; }
        public RequestedService RequestedService { get; set; }

        public enum StatusAgenda
        {
            ARealizar,
            Realizado,
            Reagendado,
            CanceladoPeloCliente,
            NaoCompareceu,
            CanceladoPeloSalao,
            Pendente
        }

        public string IncludeSchedule(int id, Client cliente,
            //List<ServicoSolicitado> servicosSolicitados, 
            RequestedService servicoParaAgendar,
            DateTime dtAgendamento, List<Scheduling> agenda, string anotacao = "")
        {
            if (AllowsSchedule(agenda, servicoParaAgendar, dtAgendamento))
            {
                return "Esse horário não está livre.";
            }
            else
            {
                Id = id;
                Client = cliente;
                //ServicosSolicitados = servicosSolicitados;
                RequestedService = servicoParaAgendar;
                DtAgendamento = dtAgendamento;
                Anotacao = anotacao;

                return "Agendamento feito com sucesso.";
            }
        }

        public string ChangeSchedule(Client cliente, RequestedService servicoParaAgendar,
            DateTime dtAgendamento, List<Scheduling> agenda, string anotacao = "")
        {
            if (AllowsSchedule(agenda, servicoParaAgendar, dtAgendamento))
            {
                return "Esse horário não está livre.";
            }
            else
            {
                servicoParaAgendar.Status = RequestedService.StatusServico.Reagendado;
                Client = cliente;
                //ServicosSolicitados = servicosSolicitados;
                RequestedService = servicoParaAgendar;
                DtAgendamento = dtAgendamento;
                Anotacao = anotacao;

                return "Agendamento feito com sucesso.";
            }
        }

        private bool AllowsSchedule(List<Scheduling> agenda, RequestedService servicoParaAgendar, DateTime dtAgendamento)
        {
            DateTime dataTerminoParaAgendar = dtAgendamento.AddMinutes(servicoParaAgendar.Services.MinutesForExecution);
            return (agenda.Any(a => a.DtAgendamento >= dtAgendamento &&
                    (a.Status != StatusAgenda.CanceladoPeloSalao || a.Status != StatusAgenda.CanceladoPeloCliente)) &&
                agenda.Any(a => a.DtAgendamento <= dataTerminoParaAgendar &&
                    (a.Status != StatusAgenda.CanceladoPeloSalao || a.Status != StatusAgenda.CanceladoPeloCliente)));
        }

        public void IncludeRequestedService(int id, Services servico, Employee func)
        {
            RequestedService ss = new RequestedService();
            ss.IncludeRequestedService(id, servico, func);
            //ServicosSolicitados.Add(ss);
        }

        public void ExcludeRequestedService(int id)
        {
            //ServicosSolicitados.RemoveAll(x => x.Id == id);
        }
    }
}

