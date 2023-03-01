using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___03___Liste_und_Menge
{
    class Set<T>:SimpleList<T> where T : IComparable
    {
        protected override void Einfügen(T data, Entry<T> enter)
        {
            base.Einfügen(data, enter);
        }
        public Set<T> Union(Set<T> otherSet)
        {
            // Neue Menge für die Vereinigung
            Set<T> union = new Set<T>();

            T[] firstSet = this.ToArray();

            // Alle Elemente der ersten Menge in die Vereinigungsmenge einfügen
            for (int i = 0; i < firstSet.Length; i++)
            {
                union.Einfügen(firstSet[i]);
            }

            T[] secondSet = otherSet.ToArray();

            // Alle Elemente der zweite Menge in die Vereinigungsmenge einfügen
            // Doppelte werden nicht eingefügt
            for (int i = 0; i < secondSet.Length; i++)
            {
                union.Einfügen(secondSet[i]);
            }

            return union;
        }
        public Set<T> Intersection(Set<T> otherSet)
        {
            Set<T> intersection = new Set<T>();

            T[] set = this.ToArray();

            for (int i = 0; i < set.Length; i++)
            {
                // Ist das aktuelle Element aus dieser Menge auch in der zweiten Menge vorhanden?
                if (otherSet.Suche(set[i]) != null)
                {
                    // Dann einfügen
                    intersection.Einfügen(set[i]);
                }
            }

            return intersection;
        }
    }
   
}
