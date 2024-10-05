using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GissningsSpel;
public class Continue
{
    public bool Loop = false;
    Program program;
    public void ContinueYesNo()
    {        
        string? choice = "";
        while (choice != "1" || choice != "2")
        {
            Console.WriteLine("Vill du fortsätta? 1. Ja  -  2. Nej");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                break;
            }
            else if (choice == "2")
            {
                Console.WriteLine("Programmet avslutas nu! Ha de g^tt");
                Console.ReadKey();
                Loop = true;
                break;
            }
            else
                Console.WriteLine("Något blev fel, försök igen!");
        }
    }
}
