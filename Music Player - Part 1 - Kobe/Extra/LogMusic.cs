using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MusicPlayer.Extra
{
    public class LogMusic
    {
        // Properties
        private const string LOGPATH = "C:/Music/MusicLog.txt";

        //public string SongName { get; set; }

        // Methods
        public void InitLog(string SongName)
        {
            LogManager logManager = new LogManager();
            logManager.CreateFile("C:/Music/", LOGPATH);

            LogWriter logWriter = new LogWriter();
            logWriter.WriteMusicLog(SongName, LOGPATH);
        }
    }
}