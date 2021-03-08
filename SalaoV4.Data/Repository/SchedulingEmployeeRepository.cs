using Microsoft.EntityFrameworkCore;
using SalaoV4.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class SchedulingEmployeeRepository : BaseRepository<SchedulingEmployee>
    {
        public List<SchedulingEmployee> SelectAllComplete()
        {
            return contexto.SchedulingEmployee
                .Include(x => x.Scheduling)
                .Include(x => x.Employee)
                .ToList();
        }
        public override void Incluir(SchedulingEmployee entity)
        {
            base.Incluir(entity);
        }

    }
}

