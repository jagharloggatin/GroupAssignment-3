using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment_3
{
    interface Istudent
    {
        public string Name { get; set; }
        public static int NrOfStudents { get; set; }
        public const int _maxNrOfGroups = 15;
        public int NrStudentsInGroup { get; }
        public int NrStudentsNotInGroup { get; }

    }
}
