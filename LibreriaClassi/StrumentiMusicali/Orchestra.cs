using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi.StrumentiMusicali
{
    public class Orchestra
    {
        public string Suona()
        {
            foreach(var item in this)
            {
                suono = item.Suono() + "r\n";
            }
            return suono;
        }
    }
}
