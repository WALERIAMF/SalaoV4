using Microsoft.EntityFrameworkCore;
using SalaoV4.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class ClientSchedulingRepository : BaseRepository<ClientScheduling>
    {
        public List<ClientScheduling> SelectAllComplete()
        {
            return contexto.ClientScheduling
                .Include(x => x.Client)
                .Include(x => x.Scheduling)
                .ToList();
        }
        public override void Incluir(ClientScheduling entity)
        {
            base.Incluir(entity);
        }
    }

}


