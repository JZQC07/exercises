using System;

namespace Uppgift_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till programmet!");
            Console.WriteLine("Tryck valfri tangent för att starta programmet");
            Console.ReadKey();
            Myndig();
        }

        static void Myndig()
        {
            bool exit = false;
            int age = 0;
            while (exit == false)
            {
                Console.Write("Hur gammal är du?::: ");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Skriv din ålder i siffror!");
            }
            if (age > 17)
            {
                Console.WriteLine("Trevligt! Du är myndig.");
                Console.WriteLine("Tryck valfri tangent för att avsluta programmet.");
                Console.ReadLine();
                exit = true;
            }
            else
            {
                int arkvar = 18 - age;
                Console.WriteLine("Du får vänta {0} år innan du är myndig :)", arkvar);
            }
            }
            
        }
    }
}
