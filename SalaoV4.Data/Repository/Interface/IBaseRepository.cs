using Minha1Conexao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaoV4.Data.Repository.Interface
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        void Add(T entity);
        void Change(T entity);
        T Select(int id);
        List<T> SelectAll();
        void Delete(int id);
        void Dispose();
    }
}
