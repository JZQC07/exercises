using System;

namespace metoderuppg2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Mata in två meningar, avsluta varje mening med ENTER.");
            strängmetod();
            Console.WriteLine("Tryck valfri tangent för att avsluta programmet.");
            Console.ReadKey();
        }
        static void strängmetod()
        {
            string meningett;
            string meningtvå;
            meningett = Console.ReadLine();
            meningtvå = Console.ReadLine(); 
            Console.WriteLine("Dina meningar tillsammans blir ");
            string resultat = meningett + meningtvå;
            Console.WriteLine(resultat);
        }
    }
}
