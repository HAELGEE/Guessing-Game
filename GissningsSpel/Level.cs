using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GissningsSpel;

using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

public class Level
{
    Program program;
    Leaderboard leaderboard = new Leaderboard();

    public int RandomNumber = 0;

    public int Guess = 0;

    public Stopwatch stopwatch = new Stopwatch();


    public void LevelChoice()
    {
        Timer_Elapsed();

        while (leaderboard.Attempts < 10)
        {

            while (true)
            {                
                Console.WriteLine($"\nGör din gissning (försök kvar: {10 - leaderboard.Attempts})");
                string input = Console.ReadLine();
                try
                {
                    Guess = Convert.ToInt32(input);
                    break;
                }
                catch(Exception) 
                {
                    Console.WriteLine("Något blev fel, försök igen");
                }
            }


            if (stopwatch.ElapsedMilliseconds > 30000)
            {
                Console.WriteLine("Tiden tog slut");
                stopwatch.Stop();
                leaderboard.Attempts = 0;
                break;
            }
            else if (Guess == RandomNumber)
            {
                
                leaderboard.Attempts++;
                leaderboard.AddingToStringArray(Leaderboard.Name);
                leaderboard.AddingToIntArray(leaderboard.Attempts);
                Console.ForegroundColor = ConsoleColor.Magenta;
                stopwatch.Stop();
                Console.Clear();
                Console.WriteLine($"Grattis du gissade rätt på Nummer: {Guess} med {leaderboard.Attempts} försök och {stopwatch.Elapsed} sekunder ");
                Console.ResetColor();
                leaderboard.Attempts = 0;

                leaderboard.LeaderBoard();
                Console.ReadKey();
                break;
            }
            else if (Guess > RandomNumber)
            {
                Console.WriteLine("För högt! Försök igen.");
                leaderboard.Attempts++;
            }
            else if (Guess < RandomNumber)
            {
                Console.WriteLine("För lågt! Försök igen.");
                leaderboard.Attempts++;
            }
            else
            {
                Console.WriteLine($"Något blev fel, försök igen och använd siffor");
            }
        }
    }

    private void Timer_Elapsed()
    {
        stopwatch.Start();
    }
}




