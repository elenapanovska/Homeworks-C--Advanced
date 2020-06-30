using SEDC.TimeTrackingApp.Hm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTrackingApp.Hm.Domain.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        List<BaseActivity> ListOfActivities { get; set; } 
        


    }
}
