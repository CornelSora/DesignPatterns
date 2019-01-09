using ProiectRoboti.FightRoomN;
using ProiectRoboti.Observers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProiectRoboti.Robots
{
    public abstract class ARobot: IObservable
    {
        public string Password { get; set; }
        public string Id { get; set; }
        private int _energy;

        public int EnergyLevel {
            get
            {
                return _energy;
            }
            set
            {
                this._energy = value;
                if (value < 100)
                {
                    Notify();
                }
            }
        }
        private List<IUser> observers = new List<IUser>();

        public AbstractRoom FightRoom { get; set; }

        public ARobot(string id)
        {
            this.Id = id;
        }

        public virtual void Start()
        {
            EnergyLevel = 100;
            Password = "RobotStarted";
        }

        public virtual void Stop()
        {
            Password = "";
        }

        public abstract void Attack();

        public abstract void Move();

        public abstract void Defend();

        public void Run()
        {
            Start();
            Thread.Sleep(100);
            EnergyLevel -= 10;
            Move();
            Thread.Sleep(100);
            EnergyLevel -= 20;
            Attack();
            Thread.Sleep(100);
            EnergyLevel -= 30;
            Move();
            Thread.Sleep(100);
            EnergyLevel -= 20;
            Defend();
            Thread.Sleep(100);
            EnergyLevel -= 20;
            Stop();
        }

        // send threat message to the other robot
        public void Send(string to, string message)
        {
            FightRoom.Send(Id, to, message);
        }

        // Receives threat messages from a robot
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",from, Id, message);
        }

        public void Attach(IUser user)
        {
            this.observers.Add(user);
        }

        public void Detach(IUser user)
        {
            this.observers.Remove(user);
        }

        public void Notify()
        {
            foreach (IUser user in observers)
            {
                user.Notify(this);
            }
        }
    }
}
