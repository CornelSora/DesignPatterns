using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Frame : ViewGroup
    {

        public override void DisplayInfo()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                base.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Message from parent " + this.Text + " in " + this.TypeOfInfo);
            }
        }
    }
}
