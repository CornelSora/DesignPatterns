using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMultimedia.Multimedia
{
    class MusicPlayer : AMedia
    {
        private static MusicPlayer INSTANCE = new MusicPlayer();

        private MusicPlayer()
        {

        }

        public static MusicPlayer getInstance()
        {
            return INSTANCE;
        }

        public override void Play(string file)
        {
            Console.WriteLine("We play music from: " + file);
        }
    }
}
