using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi.StrumentiMusicali
{
    internal class Chitarra
    {
        public string TipoChitarra { get; set; }

        public Chitarra(string tipo)
        {
            TipoChitarra = tipo;
        }

        public string Suona()
        {
            return $"La chitarra {TipoChitarra} sta suonando.";
        }
    }
}
