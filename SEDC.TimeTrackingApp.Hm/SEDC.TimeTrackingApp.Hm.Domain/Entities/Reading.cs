using SEDC.TimeTrackingApp.Hm.Domain.Enums;
using SEDC.TimeTrackingApp.Hm.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTrackingApp.Hm.Domain.Entities
{
    public class Reading : BaseActivity
    {
        public string Pages { get; set; }
        public BookType BookType { get; set; }

        public Reading()
        {
            ActivityType = ActivityType.Reading;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{ActivityType.ToString()}: {BookType.ToString()}, pages read: {Pages}, " +
                $"you read for {TrackedTime.Minutes} min from {StartTrackingActivity} to {StopTrackingActivity}");
        }

    }
}