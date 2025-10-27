using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi.StrumentiMusicali
{
    public class Pianoforte
    {
        public string TipoPianoforte { get; set; }

        public Pianoforte(string tipo)
        {
            TipoPianoforte = tipo;
        }

        public string Suona()
        {
            return $"Il pianoforte {TipoPianoforte} sta suonando.";
        }
    }
}
