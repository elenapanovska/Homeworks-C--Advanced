using System;
using System.Collections.Generic;
using System.Text;

namespace Class03.AbstractInterface.Hm.Entities
{
    public interface ITeacher
    {
        public List<string> Subjects { get; set; }
        void PrintSubjects();

       
    }
}
