using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CubRubik : ACubRubik
    {
        public override void ColorIt()
        {
            Console.WriteLine("This is a basic cub");
        }
    }
}
