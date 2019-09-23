using System;

namespace ToPercentage
{
    class Program
    {
        static void Main(string[] args)
        {
            ToPercentage();
        }
        static void ToPercentage()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Ange ett decimaltal (,)");
                    decimal yourdec = Convert.ToDecimal(Console.ReadLine());
                    int nummer = Convert.ToInt32(Math.Round(yourdec));
                    Console.WriteLine("Ditt decimaltal avrundat till heltal är: {0}", nummer);
                }
                catch
                {
                    Console.WriteLine("Ange decimaltal med (,)");
                }
                Console.WriteLine("För att skriva in nytt tal, mata in [1]. För att avsluta, mata in [0]");
                int svar = Convert.ToInt32(Console.ReadLine());
                if (svar == 1)
                {
                    Console.WriteLine("Tryck valfri tangent för att fortsätta.");
                    Console.ReadKey();
                }
                else if (svar == 0)
                {
                    Console.WriteLine("Programmet avslutas..");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning... Programmet avslutas!");
                    Environment.Exit(0);
                } 
            }
            
        }
    }
}
