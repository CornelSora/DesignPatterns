using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IAdvancedMediaPlayer
    {
        void playVlc(string fileName);
        void playMp4(string fileName);
    }
}
