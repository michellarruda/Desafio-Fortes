using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DesafioFortes.Domain.Interfaces.Repositories;
using DesafioFortes.Infra.Data.Context;

namespace DesafioFortes.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T:class 
    {
        protected DesafioFortesContext Db = new DesafioFortesContext();

        public void Add(T obj)
        {
            Db.Set<T>().Add(obj);
            Db.SaveChanges();
        }

        public T GetById(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public void Update(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(T obj)
        {
            Db.Set<T>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
