using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace Music_Player___Part_1___Kobe
{
    public class MuziekSpeler
    {
        WindowsMediaPlayer player;

        public void DoeSwitch(int opties)
        {
            switch (opties)
            {
                case 1:
                    player.controls.pause();
                    player.controls.play();

                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    AskUserForSong();
                    break;

                case 5:
                    player.controls.stop();
                    break;

                case 6:
                    Environment.Exit(-1);
                    break;

                default:
                    Console.WriteLine("foutmelding");
                    break;
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("Opties:");
            Console.WriteLine("1:Pause/Play");
            Console.WriteLine("2:Volume wijzigen");
            Console.WriteLine("3:Volume dempen/dempen opheffen");
            Console.WriteLine("4:Liedje afspelen");
            Console.WriteLine("5:Stoppen");
            Console.WriteLine("6:Afsluiten");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Mijn eenvoudige muziekspeler");
            Console.WriteLine("*******************************");
            Console.WriteLine("Welke optie wenst u te gebruiken?");
        }

        public void AskUserForSong()
        {
            Console.WriteLine("Geef de locatie van uw gewenst liedje in:");
            //string locatie = Console.ReadLine();
            string locatie = "C:\\Music\\Waterloo.mp3";

            PlayMusic(locatie);
            Console.ReadLine();
            Console.WriteLine();
        }

        public void ClearConsole()
        {
            Console.Clear();
        }

        public void PlayMusic(string file)
        {
            player.URL = file;
        }
    }
}
