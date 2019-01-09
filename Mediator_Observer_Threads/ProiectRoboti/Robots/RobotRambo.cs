using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectRoboti.Robots
{
    public class RobotRambo : ARobot
    {
        public RobotRambo(string id) : base(id)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("The rambo robot is attacking, sending to the system the password: " + this.Password);
        }

        public override void Defend()
        {
            Console.WriteLine("The rambo robot is defending, sending to the system the password: " + this.Password);
        }

        public override void Move()
        {
            Console.WriteLine("The rambo robot is moving, sending to the system the password: " + this.Password);
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To Rambo: ");
            base.Receive(from, message);
        }
    }
}
