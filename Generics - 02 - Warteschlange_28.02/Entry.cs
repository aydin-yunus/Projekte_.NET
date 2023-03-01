using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___02___Warteschlange_28._02
{
    internal class Entry
    {
        private string data;
        private Entry next;

        public Entry(string data)
        {
            this.data = data;
        }

        public void SetNext(Entry next)
        {
            this.next = next;
        }

        public string GetData()
        {
            return this.data;
        }

        public Entry GetNext()
        {
            return this.next;
        }
    }   
}
