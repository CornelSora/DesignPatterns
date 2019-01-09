using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Users
{
    public class Administrator : AUser
    {
        public override void printInfo()
        {
            Console.WriteLine("I am an administrator");
        }
    }
}
