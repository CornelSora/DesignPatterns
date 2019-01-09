using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.State
{
    public abstract class AState
    {
        public abstract void Handle(ACar car);
    }
}
