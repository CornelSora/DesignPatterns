using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Button : View
    {
        public override void Paint()
        {
            Console.WriteLine("This is a simple button");
        }
    }
}
