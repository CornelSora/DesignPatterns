using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMultimedia.Multimedia
{
    class ImagePlayer : AMedia
    {
        private static ImagePlayer INSTANCE = new ImagePlayer();
        private OldSystem.ImagePlayer oldSystem;

        private ImagePlayer()
        {
            oldSystem = new OldSystem.ImagePlayer();
        }

        public static ImagePlayer getInstance()
        {
            return INSTANCE;
        }

        public override void Play(string file)
        {
            base.Play(file);
            oldSystem.Play(new OldSystem.Image(file));
            //  Console.WriteLine("We open image from: " + file);
        }
    }
}
