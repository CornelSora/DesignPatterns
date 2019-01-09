using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapter
{
    class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void play(string audioType, string fileName)
        {
            if (audioType.ToLowerInvariant().Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }
            else if (audioType.ToLowerInvariant().Equals("vlc") || audioType.ToLowerInvariant().Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
