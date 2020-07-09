using Class06.TryBeingFit.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Domain.Interfaces
{
    public interface ITraninig
    {
         string  Title { get; set; }
         string Description { get; set; }
         int Time { get; set; }
         Difficulty Dificulty { get; set; }
    }
}
