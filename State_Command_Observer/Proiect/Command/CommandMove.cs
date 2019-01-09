using Proiect.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Command
{
    public class CommandMove : ACommand
    {
        public CommandMove(ACar car) : base(car)
        {
        }

        public override void Execute()
        {
            AState stateMove = new StateMove();
            car.State = stateMove;
            car.Execute();
        }
    }
}
