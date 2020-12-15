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

        WindowsMediaPlayer player;
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

       

        public string PrintTitle(string title)
        {
            return title;

        }

        public string PlaceMusic(string path)
        {

            return path;
        }

    }
}
