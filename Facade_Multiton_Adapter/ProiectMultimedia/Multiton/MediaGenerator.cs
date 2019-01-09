using ProiectMultimedia.Multimedia;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMultimedia.Multiton
{
    class MediaGenerator
    {
        private static Dictionary<MediaType, AMedia> Objects = new Dictionary<MediaType, AMedia>();

        public static AMedia getInstanceOf(MediaType mediaType)
        {
            if (!Objects.ContainsKey(mediaType))
            {
                if (mediaType == MediaType.IMAGE)
                {
                    Objects[mediaType] = ImagePlayer.getInstance();
                }
                else if (mediaType == MediaType.MUSIC)
                {
                    Objects[mediaType] = MusicPlayer.getInstance();
                }
                else if (mediaType == MediaType.VIDEO)
                {
                    Objects[mediaType] = VideoPlayer.getInstance();
                }
            }

            return Objects[mediaType];
        }
    }
}
