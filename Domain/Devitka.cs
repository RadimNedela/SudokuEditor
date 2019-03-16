using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Devitka
    {
        public Policko[] Policka { get; private set; }
        internal Devitka(IEnumerable<Policko> policka)
        {
            Policka = policka.ToArray();
        }
    }
}