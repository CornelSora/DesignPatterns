using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class DecoratorButton : View
    {
        public View BaseView { get; set; }

        public DecoratorButton(View View)
        {
            BaseView = View;
        }
    }
}
