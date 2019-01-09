using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Buttons
{
    public class ButtonMac : AButton
    {
        public override void Paint()
        {
            Console.WriteLine("-This is a button for Mac");
        }
    }
}
