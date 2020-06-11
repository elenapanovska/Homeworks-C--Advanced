using System;
using System.Collections.Generic;
using System.Text;

namespace Class03.AbstractInterface.Hm.Entities
{
    public interface IStudent
    {
        public List<int> Grades { get; set; }

        void PrintGrades();
    }
}
