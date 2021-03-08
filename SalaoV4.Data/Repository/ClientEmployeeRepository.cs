using Microsoft.EntityFrameworkCore;
using SalaoV4.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class ClientEmployeeRepository : BaseRepository<ClientEmployee>
    {
        public List<ClientEmployee> SelectAllComplete()
        {
            return contexto.ClientEmployee
                .Include(x => x.Client)
                .Include(x => x.Employee)
                .ToList();
        }

        public override void Incluir(ClientEmployee entity)
        {
            base.Incluir(entity);
        }
    }
}

