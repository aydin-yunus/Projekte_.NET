using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___06___Schüler_und_Projekte_08._03
{
    internal static class Repository
    {
        public static Dictionary<int, Pupil> LoadPupilData(string path)
        {
            Dictionary<int, Pupil> pupils = new Dictionary<int, Pupil>();

            try
            {
                foreach (string line in File.ReadAllLines(path, Encoding.Default))
                {
                    try
                    {
                        Pupil pupil = Pupil.Parse(line);

                        pupils.Add(pupil.ID, pupil);
                    }
                    catch
                    {
                        Console.WriteLine("Fehlerhafte Zeile in Datei '{0}'", path);
                        Console.WriteLine("Daten : {0}", line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return pupils;
        }

        public static Dictionary<string, Project> LoadProjectData(string path, Dictionary<int, Pupil> allPupils)
        {
            Dictionary<string, Project> projects = new Dictionary<string, Project>();

            try
            {
                foreach (string line in File.ReadAllLines(path, Encoding.Default))
                {
                    try
                    {
                        Project project = Project.Parse(line);

                        projects.Add(project.ID, project);

                        foreach (string pupilId in line.Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries).Skip(2))
                        {
                            int id = int.Parse(pupilId);

                            project.AddPupil(allPupils[id]);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Fehlerhafte Zeile in Datei '{0}'", path);
                        Console.WriteLine("Daten : {0}", line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return projects;
        }

        public static void GetTopProject(Dictionary<string, Project> allProjects)
        {
            // Größte Anzahl von Schülern in einem Projekt ermitteln
            //int maxPupilCount = (from p in allProjects.Values
            //                     select p.PupilCount).Max();

            //
            //var topProjects = from project in allProjects.Values
            //                  where project.PupilCount == maxPupilCount
            //                  select project;

            // Im Where die größte Anzahl von Schülern in einem Projekt ermitteln
            // Projekte suchen, welche der ermittelten Maximalanzahl entsprechen
            var topProjects = allProjects.Values.Where(p => p.PupilCount == allProjects.Values.Max(s => s.PupilCount));

            Console.WriteLine("\nTop Projekt(e):");

            foreach (Project project in topProjects)
            {
                Console.WriteLine("\n" + project);
                Console.WriteLine("Teilnehmer:");
                foreach (Pupil pupil in project.Pupils)
                {
                    Console.WriteLine(pupil);
                }
            }
        }

        public static void GetMostActiveStudent(Dictionary<int, Pupil> allPupils)
        {
            // Schüler suchen, welche der ermittelten Maximalanzahl entsprechen
            var busiestPupil = from pupil in allPupils.Values
                                   // Größte Anzahl von Schülern in einem Projekt ermitteln
                               where pupil.ProjectCount == allPupils.Values.Max(v => v.ProjectCount)
                               select pupil;

            Console.WriteLine("\nDie aktivsten Schüler :");

            foreach (Pupil pupil in busiestPupil)
            {
                Console.WriteLine("\n" + pupil);
                Console.WriteLine("Projekte");
                foreach (Project project in pupil.Projects)
                {
                    Console.WriteLine(project);
                }
            }
        }
    }
}
