using System;
namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken är din favorit bok?");
            string bok=(Console.ReadLine());
            Console.WriteLine("Vad roligt " + bok + " är min favorit bok också");
            Console.ReadKey();
        }
    }
}