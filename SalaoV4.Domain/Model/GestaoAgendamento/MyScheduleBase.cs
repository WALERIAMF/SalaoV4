using System;
using System.Collections.Generic;

namespace SalaoV4.Domain.Model.GestaoAgendamento
{
    public class MyScheduleBase
    {
        public List<Scheduling> Agendamentos { get; set; }

        public bool AgendarServicos(int id, Client cliente, List<RequestedService> servicosSolicitados,
            DateTime dtAgendamento, string anotacao = "")
        {
            Scheduling agenda = new Scheduling();
            //agenda.IncluirAgendamento(id, cliente, servicosSolicitados, dtAgendamento, anotacao);
            return true;
        }
    }
}
