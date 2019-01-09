using ProiectRoboti.Robots;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectRoboti.FightRoomN
{
    public abstract class AbstractRoom
    {
        public abstract void Register(ARobot robot);
        public abstract void Send(string from, string to, string action);
    }
}
