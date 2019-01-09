using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMultimedia.Multimedia
{
    abstract class AMedia
    {
        public virtual void Play(string file)
        {
            if (file == null)
            {
                throw new Exception("The file path cannot be null");
            }
        }
    }
}
