using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung___02___Classroom_09._03
{
    internal class ClassRoom
    {
        public string Classname { get; set; }
        public List<Person> Members { get; set; }
        public ClassRoom()
        {
            Classname = string.Empty;
            Members = new List<Person>();
        }
    }
}
