using System;
using WMPLib;

namespace Music_Player___Part_1___Kobe
{
    internal class Program
    {
        

        private static void Main(string[] args)
        {
            //Class MuziekSpeler aanroepen op een of andere manier of? herkent de opgeroepte methods nu niet uiteraard

            MuziekSpeler muziekSpeler = new MuziekSpeler();  
            muziekSpeler.

            while (true)
            {
                ClearConsole();

                PrintMenu();
                player = new WindowsMediaPlayer();
                player.settings.volume = 1;

                int opties = Convert.ToInt32(Console.ReadLine());

                DoeSwitch(opties);
            }

        }

    }
}