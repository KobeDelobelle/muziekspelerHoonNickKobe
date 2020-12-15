using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace MusicPlayer
{
    public class MuziekSpeler
    {
        public int IsPlaying { get; set; }
        public int isPlaying = 0;

        public int IsMuted { get; set; }
        public int isMuted = 0;

        private WindowsMediaPlayer player;

        //opm: ctor hieronder
        public MuziekSpeler()
        {
            player = new WindowsMediaPlayer();
            player.settings.volume = 10;
        }

        public void DoeSwitch(int opties)
        {
            IsPlaying = isPlaying++;
            IsMuted = isMuted++;
            switch (opties)
            {
                case 1:

                    if ((IsPlaying % 2) == 0)
                    {
                        player.controls.play();
                    }
                    else if ((IsPlaying % 2) != 0)
                    {
                        player.controls.pause();
                    }

                    break;

                case 2:

                    int huidigVolume = player.settings.volume;
                    Console.WriteLine($"Huidig volume: { huidigVolume}");
                    Console.WriteLine("Stel het volume opnieuw in");
                    int nieuwVolume = Convert.ToInt32(Console.ReadLine());
                    while (nieuwVolume < 0 || nieuwVolume > 100)
                    {
                        Console.WriteLine("Geef een geldige waarde in voor volume.");
                        nieuwVolume = Convert.ToInt32(Console.ReadLine());
                    }
                    player.settings.volume = nieuwVolume;
                    break;

                case 3:
                    if ((IsMuted % 2) == 0)
                    {
                        player.settings.mute = false;
                    }
                    else if ((IsMuted % 2) != 0)
                    {
                        player.settings.mute = true;
                    }
                    break;

                case 4:
                    AskUserForSong();
                    break;

                case 5:
                    player.controls.stop();
                    break;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("foutmelding");
                    break;
            }
        }

        public void PlayMusic(string file)
        {
            player.URL = file;
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

            ShowVolume();
        }

        public void AskUserForSong()
        {
            Console.WriteLine("Welk liedje wil je afspelen:");
            //string locatie = Console.ReadLine();
            string locatie = "C:/Music/";

            string songName = Console.ReadLine();
            PlayMusic($"{locatie}{songName}.mp3");
            Console.WriteLine();
        }

        public void ClearConsole()
        {
            Console.Clear();
        }

        public void ShowVolume()
        {
            int currentVolume = player.settings.volume;

            for (int i = 1; i <= 100; i += 5)
            {
                Console.Write("#");
            }

            switch (currentVolume)
            {
                case 5:
                    break;

                case 10:
                    break;

                case 15:
                    break;

                case 20:
                    break;

                case 25:
                    break;

                case 30:
                    break;

                case 35:
                    break;

                case 40:
                    break;

                case 45:
                    break;

                case 50:
                    break;

                case 55:
                    break;

                case 60:
                    break;

                case 65:
                    break;

                case 70:
                    break;
            }
        }
    }
}