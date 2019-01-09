using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Labels
{
    public class LabelMac : ALabel
    {
        public override void Paint()
        {
            Console.WriteLine("-This is a label for Mac");
        }
    }
}
