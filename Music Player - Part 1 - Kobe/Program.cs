using System;
using WMPLib;

namespace MusicPlayer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            MuziekSpeler muziekSpeler = new MuziekSpeler();

            while (true)
            {
                muziekSpeler.ClearConsole();

                muziekSpeler.PrintMenu();
               

                int opties = Convert.ToInt32(Console.ReadLine());

                muziekSpeler.DoeSwitch(opties);

                //test
            }
        }
    }
}