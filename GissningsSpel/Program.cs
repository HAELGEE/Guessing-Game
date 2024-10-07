using System;
using System.Xml.Serialization;
using System.Timers;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;

namespace GissningsSpel;

internal class Program
{
    //public string? Choice;
    //public List<string> Name = new List<string>();  // FÅR EJ VARA LISTA
   
    static void Main(string[] args)
    {
        Menu.StartMenu();
    }
}
