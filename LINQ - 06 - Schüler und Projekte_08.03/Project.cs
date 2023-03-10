using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___06___Schüler_und_Projekte_08._03
{
    class Project
    {
        public string ID { get; set; }

        public string Name { get; set; }

        private List<Pupil> pupils;

        public Pupil[] Pupils
        {
            get { return pupils.ToArray(); }
        }

        public int PupilCount
        {
            get { return pupils.Count; }
        }

        public Project()
        {
            pupils = new List<Pupil>();
            ID = "None";
            Name = "No Project Name yet!";
        }

        public override string ToString()
        {
            return string.Format("Projekt : {0}", Name);
        }

        public void AddPupil(Pupil pupil)
        {
            if (pupils.Contains(pupil) == false)
            {
                pupils.Add(pupil);

                pupil.AddProject(this);
            }
        }

        public static Project Parse(string line)
        {
            string[] lineElements = line.Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            return new Project() { ID = lineElements[0], Name = lineElements[1] };
        }
    }
}
