 using System;

namespace Uppdrag_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är din favorit bok");
            string book = Console.ReadLine();
            Console.WriteLine("Programmeing 1");
            string Favorit = Console.ReadLine();

            Console.WriteLine("Det är en bra bok" + book + Favorit + ".");
        }
    }
}
