using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ButtonFaraColturi : DecoratorButton
    {
        public override void Paint()
        {
            base.BaseView.Paint();
            Console.WriteLine("Button fara colturi");
        }

        public ButtonFaraColturi (View View) : base(View)
        {
        }

    }
}
