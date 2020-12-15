using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MusicPlayer.Extra

{
    public class LogWriter
    {
        public void WriteMusicLog(string songName, string path)
        {
            using StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine($"OP {DateTime.Now} werd '{songName}' afgespeeld.");
        }
    }
}