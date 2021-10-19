using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment_3
{
    public class Students : Istudent
    {
        public string Name { get; set; }
        public static int NrOfStudents = 30;
        public const int _maxNrOfGroups = 15;
        public int NrStudentsInGroup { get; }
        public int NrStudentsNotInGroup { get; }
        string[] students;

        public override string ToString()//fråga
        {
            string sRet = "";
            for (int i = 0; i < NrOfStudents; i++)
            {
                sRet += $"{students[i],-15}";
                if ((i + 1) % 5 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public static bool StudentException(string userInput, out int nrGroups)
        {
            nrGroups = 0;
            try
            {
                nrGroups = Convert.ToInt32(userInput);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine($"\"{userInput}\" could not be converted to a number");
                return true;
            }
            return false;
        }
    }

}
