using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ButtonImagine : DecoratorButton
    {
        public ButtonImagine(View view) : base(view)
        {
            base.BaseView.Paint();
            Console.WriteLine("Buton imgaine");
        }

        public override void Paint()
        {
            throw new NotImplementedException();
        }
    }
}
