using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi.StrumentiMusicali
{
    public class Orchestra : List<IStrumentoMusicale>
    {
        public string Suona()
        {
            var suono = "";
            foreach(var item in this)
            {
                suono = item.Suona() + "r\n";
            }
            return suono;
        }
    }
}
