using System;
using System.Collections.Generic;
using System.Text;

namespace Class03.AbstractInterface.Hm.Entities
{
    public interface IUser
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        void PrintUser();
     
    }
}
