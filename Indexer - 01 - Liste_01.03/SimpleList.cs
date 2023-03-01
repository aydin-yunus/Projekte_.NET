using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___03___Liste_und_Menge
{
    class SimpleList<T> where T : IComparable
    {
        Entry<T> head;
        Entry<T> tail;

        public void Einfügen(T data)
        {
            Entry<T> newEntry = new Entry<T>(data);
            if (head == null)
            {
                head = newEntry;
            }
            else
            {
                Einfügen(data, head);
            }
        }
        protected virtual void Einfügen(T data, Entry<T> enter)
        {
            Entry<T> newEntry = new Entry<T>(data);
            if (enter.Next == null)
            {
                enter.Next = newEntry;
            }
            else
            {
                Einfügen(data, enter.Next);
            }
        }
        public void Löschen(T value)
        {
            Entry<T> wirdGelöscht = Suche(value, head);
            if (wirdGelöscht != null)
            {
                if (wirdGelöscht == head)
                {
                    head = wirdGelöscht.Next;
                }
                else
                {
                    tail.Next = wirdGelöscht.Next;
                }
            }

        }
        public Entry<T> Suche(T value)
        {
            return Suche(value, head);
        }
        private Entry<T> Suche(T value, Entry<T> entry)
        {
            if (entry != null)
            {
                if (entry.Data.CompareTo(value) == 0)
                {
                    return entry;
                }
                else
                {
                    tail = entry;

                    return Suche(value, entry.Next);
                }
            }
            else
            {
                return null;
            }
        }
        public int Count()
        {
            Entry<T> zähler = head;
            int counter = 0;
            while (zähler != null)
            {
                zähler = zähler.Next;
                counter++;
            }
            return counter;
        }
        public T[] ToArray()
        {
            T[] alledatein = new T[Count()];
            if (head != null)
            {
                alledatein[0] = head.Data;
                Entry<T> temp = head.Next;

                for (int i = 1; temp != null; i++)
                {
                    alledatein[i] = temp.Data;
                    temp = temp.Next;
                }
            }
            return alledatein;
        }
        public T this[int index]
        {
            get
            {
                if (index<0||index>Count()-1)
                {
                    throw new IndexOutOfRangeException();
                }
                Entry<T> einEntry=head;
                for (int i = 0; i < index; i++)
                {
                    einEntry = einEntry.Next;
                }
                return einEntry.Data;
            }
        }
    }
}
