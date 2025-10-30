
using LibreriaClassi.StrumentiMusicali;
using System;

namespace StrumentiMusicali_Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creazione degli oggetti per ogni strumento musicale
            var chitarra = new Chitarra("Duum-duum");
            var pianoforte = new Pianoforte("Plin-plin");
            var tamburo = new Tamburo("Bum-Bum-Bum");
            var tromba = new Tromba("Trum-Trum");

            // Stampa dei suoni prodotti da ogni strumento
            Console.WriteLine("La chitarra fa: " + chitarra.Suono);
            Console.WriteLine("Il pianoforte fa: " + pianoforte.Suono);
            Console.WriteLine("Il tamburo fa: " + tamburo.Suono);
            Console.WriteLine("La tromba fa: " + tromba.Suono);
        }
    }
}