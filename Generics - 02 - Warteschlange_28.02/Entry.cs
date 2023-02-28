using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___02___Warteschlange_28._02
{
    internal class Entry:GenericLinkedQueue<Entry>
    {
        private Entry head;
        private Entry tail;
        
        public Entry(Entry head, Entry tail):base (head, tail) 
        {
            
        }
    }
}
