using Class06.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Domain.Db
{
    public interface IDb<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Remove(int id);
        void Update(T entity);
    }
    
}
