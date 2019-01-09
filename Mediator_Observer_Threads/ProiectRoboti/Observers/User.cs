using System;
using System.Collections.Generic;
using System.Text;
using ProiectRoboti.Robots;

namespace ProiectRoboti.Observers
{
    public class User : IUser
    {
        private string v;

        public User(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Notify(ARobot robot)
        {
            Console.WriteLine("I, " + Name + ", received notification from: " + robot.Id + " that has the energy level: " + robot.EnergyLevel);
        }
    }
}
