using SEDC.TimeTrackingApp.Hm.Domain.Database;
using SEDC.TimeTrackingApp.Hm.Domain.Entities;
using SEDC.TimeTrackingApp.Hm.Domain.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SEDC.TimeTrackingApp.Services.Helpers;
using SEDC.TimeTrackingApp.Hm.Domain.Enums;
using System.Threading;

namespace SEDC.TimeTrackingApp.Services.Services
{
    public class UserService<T> : IUserService<T> where T :  User
    {
        private IDatabase<T> db;

        public  UserService()
        {
            db = new Database<T>();
        }
        public void ChangeInfo(int userId, string firstName, string lastName)
        {
            T user = db.GetUserById(userId);

            if (ValidationHelpers.ValidateFirstAndLastName(firstName, lastName) == null)
            {
                Console.WriteLine("You've entered somethig wrong. The first and last name should not be shorter than 2 characters " +
                                   "and they slould not conatin any numbers!");
                return;

            }
            user.FirstName = firstName;
            user.LastName = lastName;
            db.UpdateUser(user);
            Console.WriteLine("You succesfully changed your first and last name!");
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T user = db.GetUserById(userId);
            if (user.Password == oldPassword && oldPassword != newPassword)
            {
                if(ValidationHelpers.ValidatePassword(newPassword) == null)
                {
                    Console.WriteLine("Password should not be shorter than 6 characters, should contain at least one capital letter" +
                                      "and should contain at least one number");
                    Thread.Sleep(3000);
                    return;
                }
            }
            else
            {
                Console.WriteLine("You enyered your old password wrong or you new password cannot be your old password!");
                Thread.Sleep(3000);
                return;
            }
            user.Password = newPassword;
            db.UpdateUser(user);
            Console.WriteLine("You succesfully changed your password!");
        }

        public void DeactivateAccount(int userId)
        {
            db.RemoveUser(userId);
            Console.WriteLine("Your account has been deacivated");
        }

        public T LogIn(string username, string password)
        {
            var users = db.GetAll();
            T user = null;

            if(!ValidationHelpers.DoesUserNameExist(users, username))
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Wrong username you have 3 attepts otherwise the app wil close");
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    if (i == 3 && !ValidationHelpers.DoesUserNameExist(users, username))
                    {
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }
                }
            }
            Console.Clear();
            user = users.FirstOrDefault(u => u.Username == username);

            if (!ValidationHelpers.ThreeAttemptsPass(user, password))
            {
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            Console.Clear();
            return user;
        }

        public T Register(T user)
        {
            if(ValidationHelpers.ValidateFirstAndLastName(user.FirstName, user.LastName) == null
                || ValidationHelpers.ValidateAge(user.Age) == -1
                || ValidationHelpers.ValidateUsername(user.Username) == null 
                || ValidationHelpers.ValidatePassword(user.Password) == null)
            {
                Console.WriteLine("You have entered something wrong!");
                Console.ReadLine();
                return null;
            }
                
            int id = db.Insert(user);
            return db.GetUserById(id);
        }

        public void  SeeStatistics(User user)
        {
            Console.Clear();
            Console.WriteLine($"{user.FirstName} this are yout time tracked activities:");
            foreach (var activity in user.ListOfActivities)
            {
                activity.PrintInfo();
            }
            Console.WriteLine("=====================================");
        }

        public void AccountSettings(int id, int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter your new first and last name!");
                    Console.Write("Fisrt name: ");
                    string fisrtName = Console.ReadLine();
                    Console.Write("Last name: ");
                    string lastName = Console.ReadLine();
                    ChangeInfo(id, fisrtName, lastName);
                    break;
                case 2:
                    Console.WriteLine("Enter your old password");
                    Console.Write("Old password: ");
                    string oldPassword = Console.ReadLine();
                    Console.WriteLine("Enter your new password");
                    Console.Write("New password: ");
                    string newPassword = Console.ReadLine();
                    ChangePassword(id, oldPassword, newPassword);
                    break;
                case 3:
                    DeactivateAccount(id);
                    break;
            }
        }
    }
}
