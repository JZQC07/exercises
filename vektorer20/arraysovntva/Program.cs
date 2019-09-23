using System;

namespace arrays20e
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] namnlista = new string[5];
            bool cont = false;
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
            Console.WriteLine("Namnen du valde var:");
            foreach (var item in namnlista)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            do
            {
                Console.WriteLine("Vill du mata in ett nytt namn?");
                Console.WriteLine("[J] / [Q], J för att mata in nytt namn, annars Q för att avsluta.");
                string val = Console.ReadLine();
                if (val == "J" || val == "j")
                {
                    Console.WriteLine("Vilket index vill du lägga till nytt namn på: ( 0, 1, 2, 3, 4");
                    int indexval = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv in nytt namn.");
                    string nyttnamn = Console.ReadLine();
                
                    switch(indexval)
                    {
                        case 0:
                        namnlista[0] = nyttnamn;
                        break;

                        case 1:
                        namnlista[1] = nyttnamn;
                        break;

                        case 2:
                        namnlista[2] = nyttnamn;
                        break;

                        case 3:
                        namnlista[3] = nyttnamn;
                        break;

                        case 4:
                        namnlista[4] = nyttnamn;
                        break;
                    }
                }
                else if (val == "q" || val == "Q")
                {
                    Console.WriteLine("DU har valt att avsluta programmet.. Programmet avslutas!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Vänligen ange giltligt val..");
                }
                foreach (var item in namnlista)
                {
                    Console.WriteLine("Namnen du har sparat är: ");
                    Console.WriteLine(item);
                }
            
            } 
            while(cont == false);
        }
    }
}
