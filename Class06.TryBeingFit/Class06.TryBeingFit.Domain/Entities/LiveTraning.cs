using Class06.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Domain.Entities
{
    public class LiveTraning : Traning, ILiveTraning
    {
        public DateTime NextSession { get; set; }
        public TranierUser Trainer { get; set; }

        public int HoursToNextSession()
        {
            throw new NotImplementedException();
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
