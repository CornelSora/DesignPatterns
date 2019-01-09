using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Mp4Player : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("I am playing the the mp4 file: " + fileName);
        }

        public void playVlc(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
