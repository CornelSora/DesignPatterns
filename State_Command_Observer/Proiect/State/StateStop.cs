using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.State
{
    public class StateStop : AState
    {
        public override void Handle(ACar car)
        {
            Console.WriteLine("The car is  stopped");
            car.State = this;
        }
    }
}
