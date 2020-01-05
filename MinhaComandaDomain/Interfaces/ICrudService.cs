using MinhaComandaDomain.Entities;
using System;
using System.Linq;

namespace MinhaComandaDomain.Interfaces
{
    public interface ICrudService
    {
        void Create(Entidade entity);

        void Update(Entidade entity);

        IQueryable<Entidade> Read(Guid id);

        void Delete(Guid id);
    }
}