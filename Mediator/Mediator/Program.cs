using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            AMediator chat = new Chat(new List<AUser>());
            AUser webUser1 = new Web(chat);
            AUser webUser2 = new Web(chat);
            AUser mobileUser1 = new Mobile(chat);

            webUser2.sendMessage("Hello world!");

            Console.ReadLine();
        }
    }
}
