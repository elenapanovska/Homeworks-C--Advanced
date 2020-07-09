using Class06.TryBeingFit.Domain.Enums;
using Class06.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Domain.Entities
{
    public abstract class Traning : BaseEntity, ITraninig
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public Difficulty Dificulty { get; set; }
    }
}
