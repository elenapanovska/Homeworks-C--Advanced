using Class06.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class06.TryBeingFit.Domain.Db
{
    public class Database<T> : IDb<T> where T : BaseEntity
    {
        public int IdCount { get; set; }
        private List<T> listDb = new List<T>();

        public Database()
        {
            listDb = new List<T>();
            IdCount = 1;
        }

        public List<T> GetAll()
        {
            return listDb;
        }

        public T GetById(int id)
        {
            return listDb.FirstOrDefault(user => user.Id == id);
        }

        public int Insert(T entity)
        {
            entity.Id = IdCount;
            listDb.Add(entity);
            IdCount++;
            return entity.Id;
        }

        public void Remove(int id)
        {
            T itemFound = listDb.FirstOrDefault(item => item.Id == id);
            if (itemFound != null)
            {
                listDb.Remove(itemFound);
            }
        }

        public void Update(T entity)
        {
            T item = listDb.FirstOrDefault(item => item.Id == entity.Id);
            item = entity;
        }
    }


}
