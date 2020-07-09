using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Domain.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
