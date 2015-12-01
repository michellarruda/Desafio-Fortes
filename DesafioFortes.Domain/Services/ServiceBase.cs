using System;
using System.Collections.Generic;
using DesafioFortes.Domain.Interfaces.Repositories;
using DesafioFortes.Domain.Interfaces.Services;

namespace DesafioFortes.Domain.Services
{
    public class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public void Add(T obj)
        {
            _repository.Add(obj);
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(T obj)
        {
            _repository.Update(obj);
        }

        public void Remove(T obj)
        {
           _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
