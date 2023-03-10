using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___06___Schüler_und_Projekte_08._03
{
    class Pupil
    {
        public int ID;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        private List<Project> projects;

        public int ProjectCount
        {
            get { return projects.Count; }
        }

        public Project[] Projects
        {
            get { return projects.ToArray(); }
        }

        public Pupil()
        {
            projects = new List<Project>();
            ID = 0;
            FirstName = "John";
            LastName = "Doe";
        }

        public Pupil(int ID, string FirstName, string LastName)
        {
            projects = new List<Project>();
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void AddProject(Project project)
        {
            if (!projects.Contains(project))
            {
                projects.Add(project);
                project.AddPupil(this);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", LastName, FirstName);
        }

        public static Pupil Parse(string stringdata)
        {
            string[] data = stringdata.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return new Pupil() { ID = int.Parse(data[0]), FirstName = data[1], LastName = data[2] };
        }
    }
}
