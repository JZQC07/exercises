using System;

namespace metoderuppg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Addera();
        }
        static void Addera()
        {
            bool enter = true;
            while(enter == true)
            {
                try 
                {
                    Console.WriteLine("Mata in de två heltal som du vill addera:");
                    Console.Write("Tal 1: ");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Mata in tal 2: ");
                    int tal2 = int.Parse(Console.ReadLine());
                    int summa = tal1 + tal2;
                    Console.WriteLine("Summan av de två tal du angav är:");
                    Console.WriteLine(summa);
                
                }
                catch
                {
                    Console.WriteLine("Mata endast in heltal..");
                }
            }
            
        } 
    }
}
