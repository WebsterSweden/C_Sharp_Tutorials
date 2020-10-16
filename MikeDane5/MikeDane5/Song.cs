using System;
using System.Collections.Generic;
using System.Text;

namespace MikeDane5
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string titleParameter, string artistParameter, int durationParameter)
        {
            title = titleParameter;
            artist = artistParameter;
            duration = durationParameter;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
