using Class06.TryBeingFit.Domain.Db;
using Class06.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class06.TryBeingFit.Services.Services
{
    public class UserService<T> : IUserService<T> where T : User
    {
        Database<T> db;
        public UserService()
        {
            db = new Database<T>();
        }
        public void ChangeInfo(int userId, string firstName, string lastName)
        {
            T user = db.GetById(userId);
            if(user != null)
            {
                user.FirstName = firstName;
                user.LastName = lastName;
                db.Update(user);
            }
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T user = db.GetById(userId);
            if (user != null && user.Password == oldPassword)
            {
               user.Password = newPassword;
            }
        }

        public T LogIn(string username, string password)
        {
            T user = db.GetAll().FirstOrDefault(user => user.Username == username && user.Password == password);
            if(user == null)
            {
                Console.WriteLine("Username and password do not match");
            }
            return user;
        }

        public T Register(T user)
        {
            int id = db.Insert(user);
            return db.GetById(id);
        }
    }
}
