using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.State
{
    public class StateMove : AState
    {
        public override void Handle(ACar car)
        {
            Console.WriteLine("The car is on move");
            car.State = this;
        }
    }
}
