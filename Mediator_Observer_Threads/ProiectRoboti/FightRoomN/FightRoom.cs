using System;
using System.Collections.Generic;
using System.Text;
using ProiectRoboti.Robots;

namespace ProiectRoboti.FightRoomN
{
    public class FightRoom : AbstractRoom
    {
        private Dictionary<string, ARobot> _robots = new Dictionary<string, ARobot>();
        public override void Register(ARobot robot)
        {
            if (!_robots.ContainsValue(robot))
            {
                _robots[robot.Id] = robot;
            }

            robot.FightRoom = this;
        }

        public override void Send(string from, string to, string threatMessage)
        {
            ARobot robot = _robots[to];

            if (robot != null)
            {
                robot.Receive(from, threatMessage);
            }
        }
    }
}
