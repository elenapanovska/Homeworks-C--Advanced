using System;
using SEDC.TimeTrackingApp.Hm.Domain.Enums;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTrackingApp.Hm.Domain.Entities
{
    public class OtherHobbies : BaseActivity
    {
        public string Hobby { get; set; }

        public OtherHobbies()
        {
            ActivityType = ActivityType.OtherHobbies;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{ActivityType.ToString()}: {Hobby},  " +
                $"you enjoyed in your hobbie for {TrackedTime.Minutes} min. from {StartTrackingActivity} to {StopTrackingActivity}");
        }
    }
}
