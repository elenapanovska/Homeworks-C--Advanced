using Class02.QuizApp.Data.Data;
using Class02.QuizApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class02.QuizApp.Business.Services
{
    public class ValidationService 
    {

        public bool DoesUserNameExist(List<User> users, string userName)
        {
            foreach (var userN in users)
            {
                if (userN.UserName == userName)
                {
                    return true;
                }
            }
            return false;
            
        }

        public bool UsernamePasswordMatch(User user, string username, string password)
        {
            if(user.UserName == username && user.Password == password)
            {
                return true;
            }
            return false;
        }

        public bool ThreeAttemptsPass(User user, string password)
        {
            for (int i = 1; i <= 3; i++)
            {
                if(user.Password != password)
                {
                    Console.WriteLine($"Wrong password you have 3 attepts otherwise the app wil close");
                    Console.Write("Password: ");
                    password = Console.ReadLine();

                    if(i == 3 && user.Password != password)
                    {
                        return false;
                    };
                }
                
            }
            return true;
            
                    
        }
    }
}
