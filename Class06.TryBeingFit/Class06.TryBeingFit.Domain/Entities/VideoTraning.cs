using Class06.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Domain.Entities
{
    public class VideoTraning : Traning, IVideoTraning
    {
        public string Link { get; set; }
        public int Rating { get; set; }

        public string CheckRating()
        {
            throw new NotImplementedException();
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
