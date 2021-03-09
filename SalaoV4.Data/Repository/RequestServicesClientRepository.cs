using Microsoft.EntityFrameworkCore;
using SalaoV4.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class RequestServicesClientRepository : BaseRepository<RequestServicesClient>
    {
        public List<RequestServicesClient> SelectAllComplete()
        {
            return contexto.RequestServicesClient
                .Include(x => x.RequestedService)
                .Include(x => x.Client)
                .ToList();
        }

        public override void Add(RequestServicesClient entity)
        {
            base.Add(entity);
        }

    }
}

