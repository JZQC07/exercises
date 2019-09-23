using System;

namespace arrays20e
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] namnlista = new string[5];

            Console.WriteLine("Vilka 5 namn vill du mata in??");
            for (int i = 0; i < namnlista.Length; i++)
            {
                try 
                {
                    namnlista[i] = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Ange dina namn korrekt. Använd bara bokstäver.");
                }
                
            }
            foreach (var item in namnlista)
            {
                Console.WriteLine("Namnen du valde var:");
                Console.WriteLine(item);
            }
            
        }
    }
}
