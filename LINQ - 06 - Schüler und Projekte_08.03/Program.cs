using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___06___Schüler_und_Projekte_08._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Pupil> allPupils = Repository.LoadPupilData("Schüler.txt");

            Console.WriteLine("Alle Schüler:");

            foreach (var item in allPupils)
            {
                Console.WriteLine(item.Value);
            }

            Dictionary<string, Project> allProjects = Repository.LoadProjectData("Projekte.txt", allPupils);

            Console.WriteLine();
            Console.WriteLine("Alle Projekte:");

            foreach (var item in allProjects)
            {
                Console.WriteLine(item.Value);
            }

            // -----------------------------------------------

            Repository.GetTopProject(allProjects);

            // -----------------------------------------------

            Repository.GetMostActiveStudent(allPupils);

            Console.Read();
        }
    }
}
