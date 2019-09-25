using System;

namespace Ryggsäcken_vidare
{
    class Program
    {

        public static string[] ryggsack = new string[5];
        public static int antal = 0;
        static void Main(string[] args)
        {

            Menu();

        }
        static void Menu()
        {
            int val = 0;
            bool exit = true;
            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("-----DIN RYGGSÄCK-----");
                Console.WriteLine("----------------------");
                Console.WriteLine("");
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1: Lägg till något i ryggsäcken");
                Console.WriteLine("2: Ta ut något ur ryggsäcken");
                Console.WriteLine("3: Rensa hela ryggsäcken");
                Console.WriteLine("4: Skriv ut innehållet i ryggsäcken");
                Console.WriteLine("5: Avsluta programmet");

                try        //Try catch för att vara säker på att användaren skriver in ett giltligt nummer
                {
                    val = int.Parse(Console.ReadLine());
                }
                catch      //Slippa att programmet crashar. Felmeddelande skrivs ut
                {
                    Console.WriteLine("Error: Ange nummer enligt menyn. Tryck valfri knapp för att försöka igen.");
                    Console.ReadKey();
                    Menu();
                }
                switch (val)
                {
                    case 1:
                        add();
                        break;

                    case 2:
                        remove();
                        break;

                    case 3:
                        removeall();
                        break;

                    case 4:
                        print();
                        break;
                    case 5:
                        Console.WriteLine("Tryck valfri tangent för att avsluta programmet.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Jag förstod inte vad du menade..");
                        Console.WriteLine("Gör ditt val med siffrorna enligt menyn");
                        break;
                }
            } while (exit == true);
        }
        static void add()
        {
            bool cancel = true;
            while (cancel)
                if (antal > 4)
                {
                    Console.WriteLine("Din ryggsäck är nu full...");
                    Console.WriteLine("Ta bort något innan du lägger till något nytt.");
                    Console.WriteLine("Tryck valfri tangent för att återgå till menyn");
                    Console.ReadKey();
                    Menu();
                }
                else
                {
                    Console.WriteLine("Mata in [E] för att gå tillbaka till menyn.");
                    Console.WriteLine("Eller annan valfri tangent för att lägga till saker i ryggsäcken.");
                    string valsak = Console.ReadLine();
                    if (valsak == "E" || valsak == "e")
                    {
                        Console.WriteLine("Tryck valfri tangent för att återgå till menyn...");
                        Console.ReadKey();
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Skriv vad du vill lägga till i din ryggsäck!");

                        for (int i = 0; i < ryggsack.Length; i++)
                        {
                            if (ryggsack[i] == null)
                            {
                                ryggsack[i] = Console.ReadLine();
                                antal++;
                                break;
                            }
                        }
                    }
                }
        }
        static void remove()
        {
            Console.WriteLine("Välj vad du vill ta ut ur ryggsäcken:");
            int indexnumber = 0;
            int index = 0;

            foreach (var temp in ryggsack)
            {
                Console.WriteLine(indexnumber + " || " + temp);
                indexnumber++;
            }
            try
            {
                index = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Mata endast in siffrorna 0-4!");
                Console.WriteLine("Tryck valfri tangent för att försöka igen.");
                Console.ReadKey();
                remove();
            }
            if (index <= ryggsack.Length)
            {
                ryggsack[index] = null;
                antal--;
                Console.WriteLine("Vald sak på index {0} har blivit borttagen!", index);
                Console.WriteLine("Tryck valfri tangent för att återgå till menyn.");
                Console.ReadKey();
                Menu();
            }
            else
            {
                Console.WriteLine("Ange korrekt index..");
                Console.WriteLine("Tryck valfri tangent för att försöka igen..");
                Console.ReadKey();
                remove();
            }
        }
        static void removeall()
        {
            for (int i = 0; i < ryggsack.Length; i++)
            {
                if (ryggsack[i] != null)
                {
                    ryggsack[i] = null;         // Alla objekten ersätts med tom plats
                }

            }
            antal = 0;
            Console.WriteLine("Din ryggsäck har tömts!");
            Console.WriteLine("Tryck valfri tangent för att återgå till menyn.");
            Console.ReadKey();
            Menu();
        }
        static void print()
        {
            Console.WriteLine("Din ryggsäck innehåller:");
            Console.WriteLine("------------------------");

            foreach (var temp in ryggsack)
            {
                if (ryggsack != null)
                {
                    Console.WriteLine(temp);
                }
                else
                {
                    Console.WriteLine("Din ryggsäck är tom..");
                    Console.WriteLine("Tryck valfri tangent för att återgå till menyn..");
                    Console.ReadKey();
                    Menu();
                }
            }
            Console.WriteLine("Tryck valfri tangent för att återgå till menyn..");
            Console.ReadKey();
            Menu();
        }

    }
}
