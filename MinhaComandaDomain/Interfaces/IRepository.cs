using System;
using System.Linq;

namespace MinhaComandaDomain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);

        void Update(T entity);

        IQueryable<T> Find(Func<T, bool> expression = null);

        void Delete(T entity);
    }
}