using SEDC.TimeTrackingApp.Hm.Domain.Entities;
using SEDC.TimeTrackingApp.Hm.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTrackingApp.Hm.Domain.Interfaces
{
    public interface IDatabase<T> where T : User// IBaseActivity, IUser 
    {
        List<T> GetAll();
        T GetUserById(int id);
        int Insert(T entity);
        void UpdateUser(T user);
        void RemoveUser(int id);
        List<BaseActivity> GetAllActivities(int id);
        BaseActivity GetActivity(ActivityType activity, int userId);



    }
}
