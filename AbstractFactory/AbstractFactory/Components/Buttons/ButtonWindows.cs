using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Buttons
{
    public class ButtonWindows : AButton
    {
        public override void Paint()
        {
            Console.WriteLine("-This is a button for windows");
        }
    }
}
