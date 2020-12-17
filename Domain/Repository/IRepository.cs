using System.Collections.Generic;
using Domain.Interfaces;

namespace Domain.Repository
{
    public interface IRepository<T> where T : IAggregateRoot
    {
          IEnumerable<T> GetAll();
    }
}