using System;

namespace metoderuppg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Moms();
        }
        static void Moms()
        {
            double summa = 0;
            double moms;
            bool cancel = false;
            double dinmoms;
            do
            {
                Console.WriteLine("Ange Summa.");
                try
                {
                    summa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange moms i %");
                    moms = Convert.ToDouble(Console.ReadLine());
                    dinmoms = summa * (moms / 100.0 +1); 
                    Console.WriteLine("Summan + moms är: {0}", dinmoms);
                }
                catch
                {
                    Console.WriteLine("Mata endast in nummer.");
                }
                Console.WriteLine("Vill du mata in en ny summa?");
                Console.WriteLine("[J] / [N]");
                string fortsatta = Console.ReadLine();

                if(fortsatta == "J" || fortsatta == "j")
                {
                    Console.WriteLine("Tryck valfri tangent för att mata in en ny summa.");
                    Console.ReadKey();
                }
                else if(fortsatta == "N" || fortsatta == "n")
                {
                    Console.WriteLine("Tryck valfri tangent för att avsluta programmet!");
                    Console.ReadKey();
                    cancel = true;
                }
                else
                {
                    Console.WriteLine("Du gjorde en felaktig inmatning.");
                }
            } while(cancel == false);
        }
    }
}
