using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissningsSpel;
public class Menu
{
    public string? Choice;

    public static void StartMenu()
    {
        Menu menu = new Menu();
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
            menu.Choice = Console.ReadLine()!;


            if (menu.Choice == "1")
            {
                level.RandomNumber = random.Next(1, 31);
                Console.WriteLine("Du har 30 sekunder på dig att gissa ett tal Från 1 till 30.");
                level.LevelChoice();

            }
            else if (menu.Choice == "2")
            {
                level.RandomNumber = random.Next(1, 61);
                Console.WriteLine("Du har 30 sekunder på dig att gissa ett tal Från 1 till 60.");
                level.LevelChoice();

            }
            else if (menu.Choice == "3")
            {
                level.RandomNumber = random.Next(1, 121);
                Console.WriteLine("Du har 30 sekunder på dig att gissa ett tal Från 1 till 120.");
                level.LevelChoice();
            }
            else if (menu.Choice == "4")
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
