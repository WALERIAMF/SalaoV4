using SalaoV4.Data.Repository.Interface;
using SalaoV4.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class RequestedServiceRepository : BaseRepository<RequestedService>, IEmployeeRepository

    {
        public void Add(Employee entity)
        {
            throw new System.NotImplementedException();
        }

        public void Change(Employee entity)
        {
            throw new System.NotImplementedException();
        }

        Employee IBaseRepository<Employee>.Select(int id)
        {
            throw new System.NotImplementedException();
        }

        List<Employee> IBaseRepository<Employee>.SelectAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
