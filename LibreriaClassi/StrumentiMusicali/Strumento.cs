using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi.StrumentiMusicali
{
    public class Strumento
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public Strumento(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        public string Suona()
        {
            return $"{Nome} sta suonando";
        }

        public string TipoStrumento()
        {
            return $"{Nome} è un tipo di strumento: {Tipo}";
        }
    }
}