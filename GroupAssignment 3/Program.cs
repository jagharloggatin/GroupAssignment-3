using System;
using System.Collections.Generic;

namespace GroupAssignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> StudentNames = PopulateList();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Original List");
            Console.WriteLine("--------------");
            string sRet = PrintOut(StudentNames);
            Console.WriteLine(sRet);
            Console.WriteLine("Press any key to see the sorted List!\n");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sorted List");
            Console.WriteLine("--------------");
            Sorting(StudentNames);
            sRet = PrintOut(StudentNames);
            Console.WriteLine(sRet);
            Console.WriteLine("Press any key to see the Shuffled List!\n");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Shuffled List");
            Console.WriteLine("--------------");
            StudentNames = Shuffle(StudentNames);
            sRet = PrintOut(StudentNames);
            Console.WriteLine(sRet);

            Console.WriteLine();
            Console.WriteLine("Press any key choose how many groups you want!\n");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            bool GroupOptionsLegal = GroupOption(out int nrGroups);

            switch (nrGroups)
            {
                case 1:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet,  nrGroups);
                    break;
                case 2:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 3:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 4:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 5:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 6:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 7:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 8:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 9:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 10:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 11:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 12:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 13:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 14:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
                case 15:
                    sRet = PrintList(StudentNames, nrGroups);
                    PrintingsRet(sRet, nrGroups);
                    break;
            };
        }
        private static string PrintList(List<Students> StudentNames, int nrGroups)
        {
            string sRet = "";
            for (int i = 0; i < StudentNames.Count; i++)
            {
                sRet += $"{StudentNames[i].Name,-15}";
                if ((i + 1) % nrGroups == 0)
                    sRet += "\n";
            }
            return sRet;
        }
        private static void PrintingsRet(string sRet, int nrGroups)
        {
            int students = Students.NrOfStudents % nrGroups;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"There are {nrGroups} number of groups with a rest of {students} at the very bottom");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine(sRet);
        }
        private static List<Students> PopulateList() 
        {
            List<Students> StudentNames = new List<Students>();

            StudentNames.Add(new Students() { Name = "Sahar" });
            StudentNames.Add(new Students() { Name = "Jenny" });
            StudentNames.Add(new Students() { Name = "Kamran" });
            StudentNames.Add(new Students() { Name = "Sophie" });
            StudentNames.Add(new Students() { Name = "Sam" });
            StudentNames.Add(new Students() { Name = "Hanna" });
            StudentNames.Add(new Students() { Name = "Jennifer" });
            StudentNames.Add(new Students() { Name = "Mohammed" });
            StudentNames.Add(new Students() { Name = "Pontus" });
            StudentNames.Add(new Students() { Name = "Louise" });
            StudentNames.Add(new Students() { Name = "Finan" });
            StudentNames.Add(new Students() { Name = "Shohruh" });
            StudentNames.Add(new Students() { Name = "Ferri" });
            StudentNames.Add(new Students() { Name = "Kaoveh" });
            StudentNames.Add(new Students() { Name = "Fredric" });
            StudentNames.Add(new Students() { Name = "Alperen" });
            StudentNames.Add(new Students() { Name = "Niklas" });
            StudentNames.Add(new Students() { Name = "Jonathan" });
            StudentNames.Add(new Students() { Name = "Alexandra F" });
            StudentNames.Add(new Students() { Name = "Maria" });
            StudentNames.Add(new Students() { Name = "Carl-Henrik" });
            StudentNames.Add(new Students() { Name = "Josefine" });
            StudentNames.Add(new Students() { Name = "Hector" });
            StudentNames.Add(new Students() { Name = "Leo" });
            StudentNames.Add(new Students() { Name = "Vidar" });
            StudentNames.Add(new Students() { Name = "Adam" });
            StudentNames.Add(new Students() { Name = "Frans" });
            StudentNames.Add(new Students() { Name = "Ghåsem" });
            StudentNames.Add(new Students() { Name = "Fredrik" });
            StudentNames.Add(new Students() { Name = "Adrian" });

            return StudentNames;
        }
        private static string PrintOut(List<Students> StudentNames)
        {
            string sRet = "";
            for (int i = 0; i < StudentNames.Count; i++)
            {
                sRet = sRet + $" {StudentNames[i].Name, -15} ";
                if ((i + 1) % 5 == 0)
                {
                    sRet = sRet + "\n";
                }
            }
            return sRet;
        }
        private static bool GroupOption(out int nrGroups)
        {
            bool nrStudentsLegal = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("How many groups do you want? (1-15 or Q to quit)");
                string userInput = Console.ReadLine();

                nrStudentsLegal = Students.StudentException(userInput, out nrGroups);
                if (nrGroups > Students._maxNrOfGroups || nrGroups < 1 && !nrStudentsLegal)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine($"\"{nrGroups}\" is a not a valid input");
                    nrStudentsLegal = true;
                    continue;
                }
                if (userInput.ToLower() == "q")
                {
                    return false;
                }
            } while (nrStudentsLegal);
            return true;
        }

        private static List<Students>Shuffle(List<Students> StudentNames)
        {
            Random rnd = new Random();
            for (int i = 0; i < StudentNames.Count; i++)
            {
                int k = rnd.Next(0, i);
                Students value = StudentNames[k];
                StudentNames[k] = StudentNames[i];
                StudentNames[i] = value;
            }
            return StudentNames;
        }
        private static List<Students> Sorting(List<Students> StudentNames) 
        {
            StudentNames.Sort((x, y) => x.Name.CompareTo(y.Name));

            return StudentNames;
        }
    }
}

/* string sRet = "";
for (int i = 0; i < _NrOfStudents; i++)
{
    sRet += $"{students[i],-15}";
    if ((i + 1) % 5 == 0)
        sRet += "\n";
} */

/* List<Students>[] mygroups = new List<Students>[nrGroups];

 for (int i = 0; i < nrGroups; i++)
 {
     mygroups[i] = new List<Students>();
     for (int k = 0; k < StudentNames.Count; k++)
     {
         Console.WriteLine(StudentNames[i].Name);
     }
     Console.WriteLine();
 } */

/* 
List<Students>[] mygroups = new List<Students>[10];
for (int i = 0; i < nrGroups; i++)
{
    mygroups[i] = new List<Students>();
    foreach (var name in StudentNames)
    {
        mygroups[i].Add(name);
        Console.WriteLine(name.Name);
    }
} */