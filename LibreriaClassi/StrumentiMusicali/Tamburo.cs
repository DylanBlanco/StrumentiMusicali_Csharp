using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi.StrumentiMusicali
{
    public class Tamburo : StrumentoMusicale
    {
        //public string Suono { get; set; }

        public Tamburo() { }

        public Tamburo(string s)
        {
            Suono = s;
        }

        public override string Suona()
        {
            return Suono;
        }
    }
}
