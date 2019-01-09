using Proiect.Command;
using Proiect.State;
using System;

namespace Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            ACar smartCar = new SmartCar()
            {
                Id = 1,
                Brand = "SmartBrand",
                Distance = 0,
                MaxSpeed = 200,
                Type = CarType.BERLINE
            };
            //smartCar.State = new StateStart();

            //smartCar.Execute();
            //smartCar.Execute();
            //smartCar.Execute();

            User user = new User();
            smartCar.users.Add(user);
            ACommand commandStart = new CommandStart(smartCar);
            ACommand commandMove = new CommandMove(smartCar);
            ACommand commandStop = new CommandStop(smartCar);

            user.SetCommand(commandStart);
            user.ExecuteCommand();
            user.SetCommand(commandMove);
            user.ExecuteCommand();
            user.SetCommand(commandStop);
            user.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
