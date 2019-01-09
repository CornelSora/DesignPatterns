using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Command
{
    public abstract class ACommand
    {
        protected ACar car;

        // Constructor

        public ACommand(ACar car)
        {
            this.car = car;
        }

        public abstract void Execute();
    }
}
