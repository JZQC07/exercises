using System;

namespace Vektoreruppg1
{
  class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int [5];
            int summa = 0;
            
            Console.WriteLine("Ange fem stycken tal att summera ");

            for (int i = 0; i < tal.Length; i++)
            {
                try
                {
                    tal[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Använd endast siffror.");
                    Console.WriteLine("Programmet avslutas!");
                    break;
                }
                 
            }
            summa = (tal[0] + tal[1] + tal[2] + tal[3] + tal[4]);

            Console.WriteLine("Summan av talen du matade in är {0}", summa);
        }
    }
}
