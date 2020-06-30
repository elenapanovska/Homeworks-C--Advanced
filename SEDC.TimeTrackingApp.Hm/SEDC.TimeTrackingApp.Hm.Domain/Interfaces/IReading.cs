using SEDC.TimeTrackingApp.Hm.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTrackingApp.Hm.Domain.Interfaces
{
    public interface IReading : IBaseActivity
    {
        string Pages { get; set; }
        BookType BookType { get; set; }

      

    }
}
