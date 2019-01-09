using ProiectRoboti.Robots;
using System;
using ProiectRoboti.FightRoomN;
using ProiectRoboti.Observers;
using System.Threading.Tasks;
using System.Threading;

namespace ProiectRoboti
{
    class Program
    {
        static void Main(string[] args)
        {
            User spectator1 = new User("spectator1");
            User spectator2 = new User("spectator2");

            ARobot robotBox = new RobotBox("rb1");
            robotBox.Attach(spectator1);
            robotBox.Attach(spectator2);
            ARobot robotKarate = new RobotKarate("rk1");
            robotKarate.Attach(spectator1);
            ARobot robotRambo = new RobotRambo("rr1");
            robotRambo.Attach(spectator2);


            FightRoom fightRoom = new FightRoom();
            fightRoom.Register(robotBox);
            fightRoom.Register(robotKarate);
            fightRoom.Register(robotRambo);

            robotBox.Send("rk1", "I'm comming for you");
            robotKarate.Send("rr1", "I'm comming for you");
            robotRambo.Send("rb1", "I'm comming for you");

            Console.WriteLine("-------------------");

            var rbThread = new Thread(() =>
            {
                robotBox.Run();
            });
            var rrThread = new Thread(() =>
            {
                robotRambo.Run();
            });
            var rkThread = new Thread(() =>
            {
                robotKarate.Run();
            });

            rbThread.Start();
            rrThread.Start();
            rkThread.Start();

            Console.ReadKey();
        }
    }
}
