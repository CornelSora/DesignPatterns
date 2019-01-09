using MVCConsole.Controller;
using System;

namespace MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageController messageController = new MessageController();
            messageController.DisplayMessageView();

            Console.ReadKey();
        }
    }
}
