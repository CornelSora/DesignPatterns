using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class View : AComponent
    {
        public override void AddView(AComponent view)
        {
            throw new NotImplementedException();
        }

        public override void DisplayInfo()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                if (parent != null)
                {
                    parent.DisplayInfo();
                }
                else
                {
                    Console.WriteLine("No support");
                }
            }
            else
            {
                Console.WriteLine("Message from child " + this.Text + " in " + this.TypeOfInfo);
            }
        }
    }
}
