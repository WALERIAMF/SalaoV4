using Minha1Conexao.Domain;
using SalaoV4.Data.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SalaoV4.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity
    {
        protected readonly Context contexto;
        public BaseRepository()
        {
            contexto = new Context();
        }

        public virtual void Add(T entity)
        {
            contexto.Set<T>().Add(entity);
            contexto.SaveChanges();
        }

        public void Change(T entity)
        {
            contexto.Set<T>().Update(entity);
            contexto.SaveChanges();
        }

        public T Select(int id)
        {
            return contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> SelectAll()
        {
            return contexto.Set<T>().ToList();
        }

        public void Delete(int id)
        {
            var entity = Select(id);
            contexto.Set<T>().Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}