using ProiectRoboti.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectRoboti.Robots
{
    public interface IObservable
    {
        void Attach(IUser user);

        void Detach(IUser user);

        void Notify();
    }
}
