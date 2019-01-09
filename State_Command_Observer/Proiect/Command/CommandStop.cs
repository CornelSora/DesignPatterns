using Proiect.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Command
{
    public class CommandStop : ACommand
    {
        public CommandStop(ACar car) : base(car)
        {
        }

        public override void Execute()
        {
            AState stateMove = new StateStop();
            car.State = stateMove;
            car.Execute();
        }
    }
}
