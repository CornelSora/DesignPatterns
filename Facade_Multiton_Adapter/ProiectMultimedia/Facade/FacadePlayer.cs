using ProiectMultimedia.Multimedia;
using ProiectMultimedia.Multiton;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMultimedia.Facade
{
    class FacadePlayer
    {
        public static void playMusic(string filePath)
        {
            AMedia media = MediaGenerator.getInstanceOf(MediaType.MUSIC);
            media.Play(filePath);
        }

        public static void playVideo(string filePath)
        {
            AMedia media = MediaGenerator.getInstanceOf(MediaType.VIDEO);
            media.Play(filePath);
        }

        public static void openImage(string filePath)
        {
            AMedia media = MediaGenerator.getInstanceOf(MediaType.IMAGE);
            media.Play(filePath);
        }
    }
}
