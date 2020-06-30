using SEDC.TimeTrackingApp.Hm.Domain.Entities;
using SEDC.TimeTrackingApp.Hm.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTrackingApp.Services.Services
{
    public interface IUserService<T> where T : User 
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeInfo(int userId, string firstName, string lastName);
        void DeactivateAccount(int userId);
        T LogIn(string username, string password);
        T Register(T user);
        void SeeStatistics(User user);
        void AccountSettings(int id, int choice);
    }
}
