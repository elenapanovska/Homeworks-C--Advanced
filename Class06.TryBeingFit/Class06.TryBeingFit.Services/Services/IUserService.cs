using Class06.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Services.Services
{
    public interface IUserService<T> where T: User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeInfo(int userId, string firstName, string lastName);
        T LogIn(string username, string password);
        T Register(T user);
    }
}
