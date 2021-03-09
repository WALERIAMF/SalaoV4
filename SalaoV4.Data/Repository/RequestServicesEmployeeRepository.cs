using Microsoft.EntityFrameworkCore;
using SalaoV4.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaoV4.Data.Repository
{
    public class RequestServicesEmployeeRepository : BaseRepository<RequestServicesEmployee>
    {
        public List<RequestServicesEmployee> SelectAllComplete()
        {
            return contexto.RequestServicesEmployee
                .Include(x => x.RequestedService)
                .Include(x => x.Employee)
                .ToList();
        }

        public override void Add(RequestServicesEmployee entity)
        {
            base.Add(entity);
        }

        public static implicit operator RequestServicesEmployeeRepository(RequestServicesEmployee v)
        {
            throw new NotImplementedException();
        }
    }
}
