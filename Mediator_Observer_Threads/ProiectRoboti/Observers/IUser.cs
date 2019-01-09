using ProiectRoboti.Robots;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectRoboti.Observers
{
    public interface IUser
    {
        void Notify(ARobot robot);
    }
}
