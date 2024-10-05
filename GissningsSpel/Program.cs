using System;
using System.Xml.Serialization;
using System.Timers;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;

namespace GissningsSpel;

internal class Program
{
    public string? Choice;
    //public List<string> Name = new List<string>();  // FÅR EJ VARA LISTA
   
    

    static void Main(string[] args)
    {
        //Leaderboard leaderboard = new Leaderboard();
        Program program = new Program();
        Random random = new Random();
        Level level = new Level();
        int tries = 0;
        Stopwatch stopwatch = new Stopwatch();
        Continue fortsätt = new Continue();
      

        while (fortsätt.Loop == false)
        {
            if (tries > 0)
                fortsätt.ContinueYesNo();

            if (fortsätt.Loop)
            {
                fortsätt.Loop = true;
                break;
            }
            if (tries < 6)
            {
                Console.Write("Var god skriv ditt namn: ");
                Leaderboard.Name = Console.ReadLine();
                tries++;                
            }
            else
            {
                Console.WriteLine("Du har redan kört 5 gånger.");
                break;
            }
            level.stopwatch.Reset();
            Console.Clear();
            Console.WriteLine("Var god välj ett utav följande");
            Console.WriteLine("1. Lätt(30)");
            Console.WriteLine("2. Medium(60)");
            Console.WriteLine("3. Svår(120)");
            Console.WriteLine("4. Avsluta");
            program.Choice = Console.ReadLine()!;


            if (program.Choice == "1")
            {
                level.RandomNumber = random.Next(1, 31);
                Console.WriteLine("Du har 30 sekunder på dig att gissa ett tal Från 1 till 30.");
                level.LevelChoice();

            }
            else if (program.Choice == "2")
            {
                level.RandomNumber = random.Next(1, 61);
                Console.WriteLine("Du har 30 sekunder på dig att gissa ett tal Från 1 till 60.");
                level.LevelChoice();

            }
            else if (program.Choice == "3")
            {
                level.RandomNumber = random.Next(1, 121);
                Console.WriteLine("Du har 30 sekunder på dig att gissa ett tal Från 1 till 120.");
                level.LevelChoice();
            }
            else if (program.Choice == "4")
            {
                Console.WriteLine("Programmet avslutas nu! Ha de g^tt");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("Var god välj någon utav siffrorna från 1 till 4.");
                Console.ReadKey();
                tries--;
            }
        }
    }
}
