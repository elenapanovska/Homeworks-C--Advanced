using SEDC.TimeTrackingApp.Hm.Domain.Entities;
using SEDC.TimeTrackingApp.Hm.Domain.Enums;
using SEDC.TimeTrackingApp.Hm.Domain.Interfaces;
using SEDC.TimeTrackingApp.Services.Helpers;
using SEDC.TimeTrackingApp.Services.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTrackingApp.Services.Services
{
    public class AppServices<T> where T : BaseActivity
    {
        public static Menu menus = new Menu();
        public void TrackingTime(ActivityType activity, User user)
        {
            Console.Clear();
            switch (activity)
            {
                case ActivityType.Reading:
                    var reading  = new Reading();
                    reading.TrackTime();
                    Console.WriteLine("Please enter how many pages you've read and what kind Of book you were reading:");
                    Console.Write("Pages: ");
                    reading.Pages = Console.ReadLine();
                    reading.BookType = (BookType)menus.ShowBookTypes();
                    user.ListOfActivities.Add(reading);
                    break;
                case ActivityType.Exercising:
                    var exercising = new Exercising();
                    exercising.TrackTime();
                    Console.WriteLine("Please enter what kind of workout did you do");
                    exercising.ExercisingType = (ExercisingType)menus.ShowExercisingTypes();
                    user.ListOfActivities.Add(exercising);
                    break;
                case ActivityType.Working:
                    var working = new Working();
                    working.TrackTime();
                    Console.WriteLine("Where were you working from?");
                    working.WorkingFrom = (WorkingFrom)menus.ShowWorkingOptions();
                    user.ListOfActivities.Add(working);
                    break;
                case ActivityType.OtherHobbies:
                    var otherHobbies = new OtherHobbies();
                    otherHobbies.TrackTime();
                    Console.WriteLine("Please enter the name of the hobby");
                    otherHobbies.Hobby = Console.ReadLine();
                    user.ListOfActivities.Add(otherHobbies);
                    break;
                default:
                    break;
            }
        }

       
    }
}


