using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung___02___Classroom_09._03
{
    internal class Teacher:Person
    {
        public string Subject { get; set; }
        public Teacher():base()
        {
            Subject = string.Empty;
        }

    }
}
