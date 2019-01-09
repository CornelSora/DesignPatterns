using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Users
{
    public class Client : AUser
    {
        public override void printInfo()
        {
            Console.WriteLine("I am a client");
        }
    }
}
