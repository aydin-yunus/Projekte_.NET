using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___03___Liste_und_Menge
{
    internal class Entry<T> where T : IComparable
    {
        public T Data { get; }
        public Entry<T> Next { get; set; }
        public Entry(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
