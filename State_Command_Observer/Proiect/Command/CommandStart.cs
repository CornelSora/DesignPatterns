using Proiect.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Command
{
    public class CommandStart : ACommand
    {
        public CommandStart(ACar car) : base(car)
        {
        }

        public override void Execute()
        {
            AState stateMove = new StateStart();
            car.State = stateMove;
            car.Execute();
        }
    }
}
