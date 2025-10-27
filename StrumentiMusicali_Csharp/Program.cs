
using System;

namespace StrumentiMusicali_Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Istanza della classe Chitarra e utilizzo del metodo
            string[] tipoChitarra = { "Acustica", "Elettrica", "Classica" };
            for (int i = 0; i < tipoChitarra.Length; i++)
            {
                var strumento = new LibreriaClassi.StrumentiMusicali.Chitarra(tipoChitarra[i]);
                Console.WriteLine(strumento.Suona());
            }

            // Istanza della classe Pianoforte e utilizzo del metodo
            string[] tipoPianoforte = { "Digitale", "Acustico", "Ibrido" };
            for (int i=0; i<tipoPianoforte.Length; i++)
            {
                var pianoforte = new LibreriaClassi.StrumentiMusicali.Pianoforte(tipoPianoforte[i]);
                var suonoPianoforte = pianoforte.Suona();
                Console.WriteLine(suonoPianoforte);
            }
        }
    }
}