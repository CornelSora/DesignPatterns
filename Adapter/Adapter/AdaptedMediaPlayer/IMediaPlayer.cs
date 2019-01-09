using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IMediaPlayer
    {
        void play(string audioType, string fileName);
    }
}
