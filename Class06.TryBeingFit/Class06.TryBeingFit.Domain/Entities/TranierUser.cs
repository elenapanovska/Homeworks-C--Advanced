using Class06.TryBeingFit.Domain.Enums;
using Class06.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Domain.Entities
{
    public class TranierUser : User, ITrainerUser
    {
        public int YearsExpirience { get; set; }
       
        public TranierUser()
        {
            Role = UserRole.Trainer;
        }

        public bool ChangeSchedule(ILiveTraning livetraning)
        {
            throw new NotImplementedException();
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
