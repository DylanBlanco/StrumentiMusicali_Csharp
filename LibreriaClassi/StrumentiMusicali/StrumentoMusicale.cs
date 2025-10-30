using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi.StrumentiMusicali
{
    // CALSSE ASTRATTA, NON ISTANZIABILE
    public abstract class StrumentoMusicale : IStrumentoMusicale
    {
        public abstract string Suona();  // METODO ASTRATTO, OBBLIGA LE CLASSI DERIVATE A IMPLEMENTARLO

        public string Suono { get; set; }  // PROPRIETA' COMUNE A TUTTI GLI STRUMENTI

        public StrumentoMusicale() { }  // COSTRUTTORE DI DEFAULT

        public StrumentoMusicale(string s)
        {
            Suono = s;  // COSTRUTTORE CON PARAMETRO
        }
    }
}
