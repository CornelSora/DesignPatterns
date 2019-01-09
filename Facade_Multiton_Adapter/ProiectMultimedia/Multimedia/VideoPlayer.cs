using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMultimedia.Multimedia
{
    class VideoPlayer : AMedia
    {
        private static VideoPlayer INSTANCE = new VideoPlayer();

        private VideoPlayer()
        {

        }

        public static VideoPlayer getInstance()
        {
            return INSTANCE;
        }

        public override void Play(string file)
        {
            Console.WriteLine("We play video from: " + file);
        }
    }
}
