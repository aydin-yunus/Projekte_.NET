using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___02___Warteschlange_28._02
{
    internal class GenericLinkedQueue
    {
        private Entry tail;
        private Entry head;

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Enqueue(string data)
        {
            // 1. Neuen Eintrag anlegen
            Entry newEntry = new Entry(data);

            if (IsEmpty() == true)
            {
                // 2.
                // Bei leerer Warteschlange ist der
                // neue Eintrag der Kopf
                this.head = newEntry;
            }
            else
            {
                // 2.
                // Befinden sich bereits Elemente in der
                // Warteschlange, wird das neue Element
                // Nachfolger des letzten Elementes
                this.tail.SetNext(newEntry);
            }

            // 3.
            // Das neue Element ist jetzt das letzte Element
            this.tail = newEntry;
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Warteschlange ist leer");
            }
            else
            {
                // Ein Entry auf den Kopf verweisen
                Entry anEntry = head;

                // Ist der Entry nicht leer
                while (anEntry != null)
                {
                    // Daten im Entry ausgeben
                    Console.WriteLine(anEntry.GetData());

                    // Für die nächste Ausgabe ist der Entry
                    // der Nachfolger des aktuellen Entry
                    anEntry = anEntry.GetNext();
                }
                Console.WriteLine();
            }
        }

        public string Dequeue()
        {
            if (IsEmpty() == false)
            {
                // Daten des Entry-Objektes zwischenspeichern
                string data = head.GetData();

                // Neues erstes Entry ist der Nachfolger vom
                // aktuellen Kopf
                head = head.GetNext();

                // Ist der Kopf leer?
                if (head == null)
                {
                    // Dann auch das Ende "löschen"
                    tail = null;
                }
                return data;
            }

            return null;
        }

    }
}
