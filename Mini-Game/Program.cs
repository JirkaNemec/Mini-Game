using System;

namespace Mini_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int nahCislo = random.Next(1, 100);
            Console.WriteLine("hádání čísla");
            Console.WriteLine("--------------------");
            Console.WriteLine("Myslím si číslo od 1 do 100");

            Console.ReadLine();
        }
    }
}
