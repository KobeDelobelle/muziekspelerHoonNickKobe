using System;
using WMPLib;
using MusicPlayer.Extra;

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

                LogMusic logMusic = new LogMusic();
                logMusic.InitLog("This is a songname");
            }
        }
    }
}