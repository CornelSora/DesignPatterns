using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.State
{
    public class StateStart : AState
    {
        public override void Handle(ACar car)
        {
            Console.WriteLine("The engine is started, but the car isn't moving");
            car.State = this;
        }
    }
}
