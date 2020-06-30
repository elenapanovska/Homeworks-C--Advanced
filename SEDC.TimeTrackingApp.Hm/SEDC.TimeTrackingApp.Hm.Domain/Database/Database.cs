using SEDC.TimeTrackingApp.Hm.Domain.Entities;
using SEDC.TimeTrackingApp.Hm.Domain.Enums;
using SEDC.TimeTrackingApp.Hm.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTrackingApp.Hm.Domain.Database
{
    public class Database<T> : IDatabase<T> where T :  User
    {
        private List<T> dataB;
        public int IdCount { get; set; }

        public Database()
        {
            dataB = new List<T>();
            IdCount = 1;
        }
        public List<T> GetAll()
        {
            return dataB;
        }
        public T GetUserById(int id)
        {
            return dataB.FirstOrDefault(u => u.Id == id);
            
        }
        public int Insert(T entity)
        {
            entity.Id = IdCount;
            dataB.Add(entity);
            IdCount++;
            return entity.Id;

        }
        public void  UpdateUser(T entity)
        {
            T item = dataB.FirstOrDefault(x => x.Id == entity.Id);
            item = entity;
        }

        public void RemoveUser(int id)
        {
            T item = dataB.FirstOrDefault(x => x.Id == id);
            if (item != null) dataB.Remove(item);
        }

        public List<BaseActivity> GetAllActivities(int userId)
        {
            T user = dataB.FirstOrDefault(u => u.Id == userId);
            return user.ListOfActivities;
        }


        public BaseActivity GetActivity(ActivityType activity, int userId)
        {
            T user = dataB.FirstOrDefault(u => u.Id == userId);
            var userActicity = user.ListOfActivities.FirstOrDefault(a => a.ActivityType == activity);
            return userActicity;
        }
    }
}
