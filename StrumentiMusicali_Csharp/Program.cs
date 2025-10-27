
using System;

namespace StrumentiMusicali_Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Istanza della classe Strumento
            var strumento = new LibreriaClassi.StrumentiMusicali.Strumento("Chitarra", "Corda");
        }
    }
}