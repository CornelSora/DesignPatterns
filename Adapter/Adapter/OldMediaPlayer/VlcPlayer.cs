using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class VlcPlayer : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            throw new NotImplementedException();
        }

        public void playVlc(string fileName)
        {
            Console.WriteLine("I am playing the the vlc file: " + fileName);
        }
    }
}
