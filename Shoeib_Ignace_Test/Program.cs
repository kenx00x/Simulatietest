using System;

namespace Shoeib_Ignace_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat wil je doen? Covidbeslissingshelper (c) of de Covidquiz (q): ");
            string antwoord = Console.ReadLine();
            switch (antwoord)
            {
                case "c":
                    Console.Write("Vertoon je covid symptomen? ");
                    string symptomenAntwoord = Console.ReadLine();
                    string contact="";
                    if (symptomenAntwoord == "nee")
                    {
                        Console.Write("In nauw contact gekomen met iemand die ziek is? ");
                        contact = Console.ReadLine();
                        if (contact == "nee")
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Je mag naar school blijven gaan");
                        }
                    }
                    if (symptomenAntwoord == "ja" || contact=="ja")
                    {
                        Console.WriteLine("Ga in quarantaine en laat je testen");
                        Console.Write("Positieve test? ");
                        string covidtest = Console.ReadLine();
                        if (covidtest == "ja")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("7 dagen quarantaine");
                        }
                        else if (covidtest == "nee")
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("naar school wanneer genezen");
                        }
                    }
                    break;
                case "q":
                    Random willekeurig = new Random();
                    int getal = willekeurig.Next(1, 6);
                    Console.WriteLine($"Je moet nog reeds {getal} in quarantaine blijven.");
                    Console.Write("Hoeveel dagen moet je nog wachten voor je je moet laten testen? ");
                    int dagen = int.Parse(Console.ReadLine());
                    if (getal+dagen==5)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("correct");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fout");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
