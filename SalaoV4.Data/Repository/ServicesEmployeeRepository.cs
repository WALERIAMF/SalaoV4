using Microsoft.EntityFrameworkCore;
using SalaoV4.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class ServicesEmployeeRepository : BaseRepository<ServicesEmployee>
    {
        public List<ServicesEmployee> SelectAllComplete()
        {
            return contexto.ServicesEmployee
                .Include(x => x.Services)
                .Include(x => x.Employee)
                .ToList();
        }
        public override void Add(ServicesEmployee entity)
        {
            base.Add(entity);
        }
    }
}


