using System;
using System.Collections.Generic;

namespace Vaderkvanen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static List<int> myVader = new List<int>();
        static void lägg_till()
        {
            bool ext = true;
            do
            {
                Console.WriteLine("Mata in temperatur som skall sparas. Annars mata in [0] för att gå tillbaka.");
                int val = Convert.ToInt32(Console.ReadLine());
                if (val == 0)
                {
                    Menu();
                }
                else
                {   
                    myVader.Add(val);
                }
            }
            while(ext); 
        }
        static void ta_bort()
        {
            Console.WriteLine("Välj vilken position du vill ta bort värdet för.");
            int delete = Convert.ToInt32(Console.ReadLine());
            myVader.RemoveAt(delete);
            Console.WriteLine("Värdet på angiven position har blivit borttaget.");

        }
        static void skriv_ut()
        {
            Console.WriteLine("Listan med värden skrivs ut:");
           for (int i = 0; i < myVader.Count; i++)
            {
                Console.WriteLine("[{0}] {1}", i, myVader[i]);
            }
            Console.WriteLine("Tryck valfri tangent för att gå tillbaka till menyn.");
            Console.ReadKey();
            Menu();

        }
        static void Menu()
        {
            int svar = 0;
            while(svar != 1 && svar != 2 && svar != 3 && svar != 4)
            { 
                Console.WriteLine("Välkommen till väderstationen!");
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1: Lägg till ny mätning.");
                Console.WriteLine("2: Ta bort mätning.");
                Console.WriteLine("3: Skriv ut alla mätningar.");
                Console.WriteLine("4: Avsluta programmet");
                try
                {
                    svar = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ange giltlig siffra för ditt val.");   
                }
            }
            switch(svar)
            {
                case 1:
                    lägg_till();
                    //Lägg till ny mätning i lista
                break;

                case 2:
                    ta_bort();
                    //Ta bort vald mätning ur lista
                break;

                case 3:
                    skriv_ut();
                    //Skriv ut alla mätningar
                break;

                case 4:
                    Console.WriteLine("Programmet avslutas.");
                    Environment.Exit(0);
                break;

                default:
                    Console.WriteLine("Mata endast in siffrorna 1-4 för att välja.");
                    Menu();
                break;
            }
        }
    }
}
