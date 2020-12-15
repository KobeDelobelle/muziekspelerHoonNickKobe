using System;
using WMPLib;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Muziek test");
            string path = "C:\\Music\\bleeping.mp3";
            PlayMusic(path);

            //we zetten nog een readline erachter zodat applicatie niet
            //direct afsluit

            Console.ReadLine();
            Console.WriteLine();
        }


        static void PlayMusic(string file)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = file;
        }

    }
}
