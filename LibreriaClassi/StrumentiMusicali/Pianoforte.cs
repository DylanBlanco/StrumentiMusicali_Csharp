using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi.StrumentiMusicali
{
    public class Pianoforte
    {
        public string Suono { get; set; }

        public Pianoforte() { }

        public Pianoforte(string s)
        {
            Suono = s;
        }
    }
}
