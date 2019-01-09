using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapter
{
    class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.ToLowerInvariant().Equals("vlc"))
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else
            {
                advancedMediaPlayer = new Mp4Player();
            }
        }

        public void play(string audioType, string fileName)
        {
            if (audioType.ToLowerInvariant().Equals("vlc"))
            {
                advancedMediaPlayer.playVlc(fileName);
            }
            else
            {
                advancedMediaPlayer.playMp4(fileName);
            }
        }
    }
}
