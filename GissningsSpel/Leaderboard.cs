using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GissningsSpel;
public class Leaderboard
{
    Program program;
    Level level;
    public string[] NameToArray = new string[0];
    public int[] GuessesToArray = new int[0];
    public int Attempts = 0;
    public static string Name;

    public void LeaderBoard()
    {
        Console.WriteLine("=== LEADERBOARD ===");
        for (int i = 0; i < NameToArray.Length; i++)
        {
            Console.WriteLine($"Namn: {NameToArray[i]} - Försök: {GuessesToArray[i]}");
        }
    }
    public void AddingToStringArray(string value)
    {
        Array.Resize(ref NameToArray, (NameToArray.Length + 1));

        for (int i = 0; i < NameToArray.Length; i++)
        {
            if (NameToArray[i] == null)
            {
                NameToArray[i] = value;
            }
        }
    }
    public void AddingToIntArray(int value)
    {
        Array.Resize(ref GuessesToArray, (GuessesToArray.Length + 1));

        for (int i = 0; i < GuessesToArray.Length; i++)
        {
            if (GuessesToArray[i] == 0)
            {
                GuessesToArray[i] = value;
                
            }
        }
    }
}
