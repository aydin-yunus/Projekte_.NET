using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung___02___Classroom_09._03
{
    internal class Pupil:Person
    {
        public string Classname { get; set; }
        public Pupil():base()
        {
            Classname = string.Empty;
        }
    }
}
