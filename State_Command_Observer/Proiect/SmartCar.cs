using Proiect.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    public enum CarType
    {
        BERLINE,
        BREAK
    }

    public class SmartCar:ACar
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public CarType Type { get; set; }
        public double MaxSpeed { get; set; }
        public double Distance { get; set; }

        public override void Execute()
        {
            foreach (var user in this.users)
            {
                user.Notify("The current state of the car is: " + State.GetType().Name);
            }
            State.Handle(this);
        }
    }
}
