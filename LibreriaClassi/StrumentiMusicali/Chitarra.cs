using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi.StrumentiMusicali
{
    public class Chitarra : StrumentoMusicale
    {
        //public string Suono { get; set; }

        public Chitarra() { }

        public Chitarra(string s)
        {
            Suono = s;
        }

        public override string Suona()
        {
            return Suono;
        }
    }
}
