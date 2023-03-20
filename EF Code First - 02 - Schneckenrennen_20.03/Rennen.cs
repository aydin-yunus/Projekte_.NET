using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___02___Schneckenrennen_20._03
{
    public class Rennen
    {
        public int ID { get; set; }
        public virtual ICollection<Rennschnecke> AlleSchnecken {  get; set; }
        public string Name { get; set; }
        public int MaxTeilnehmer { get; set; }
        public int StreckenLänge { get; set; }
        public Rennen()
        {
            AlleSchnecken=new List<Rennschnecke>();
        }
        public void AddSchnecken(Rennschnecke newschnecke)
        {
            if (AlleSchnecken.Count<MaxTeilnehmer)
            {
                AlleSchnecken.Add(newschnecke);
            }
        }
    }
}
