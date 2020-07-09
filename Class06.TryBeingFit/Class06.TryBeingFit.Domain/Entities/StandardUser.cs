using Class06.TryBeingFit.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Domain.Entities
{
    public class StandardUser : User
    {
        public List<VideoTraning> VideoTranings { get; set; }

        public StandardUser()
        {
            Role = UserRole.Standard;
            VideoTranings = new List<VideoTraning>();
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
