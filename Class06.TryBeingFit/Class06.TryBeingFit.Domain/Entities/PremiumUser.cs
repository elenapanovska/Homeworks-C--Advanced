using Class06.TryBeingFit.Domain.Enums;
using Class06.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Domain.Entities
{
    public class PremiumUser : User, IPremiumUser
    {
        public List<VideoTraning> VideoTranings { get; set; }
        public LiveTraning LiveTraning { get; set; }

        public PremiumUser()
        {
            Role = UserRole.Premium;
            VideoTranings = new List<VideoTraning>();

        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
