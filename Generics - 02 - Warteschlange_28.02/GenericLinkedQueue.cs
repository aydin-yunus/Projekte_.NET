using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___02___Warteschlange_28._02
{
    internal class GenericLinkedQueue<T>
    {
        private Entry head;
        private Entry tail;
        public GenericLinkedQueue(Entry head, Entry tail)
        {
            this.head = head;
            this.tail = tail;
        }
        public bool IsEmpty()
        {
            return head != null && tail != null;
        }
        public void Enqueue()
        {
            Entry next=new Entry(head,tail);
        }
        
    }
}
