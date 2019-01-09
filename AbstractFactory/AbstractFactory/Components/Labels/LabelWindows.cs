using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Labels
{
    public class LabelWindows : ALabel
    {
        public override void Paint()
        {
            Console.WriteLine("-This is a label for windows");
        }
    }
}
