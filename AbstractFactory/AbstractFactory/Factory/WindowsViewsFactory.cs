using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Labels;
using AbstractFactory.Buttons;

namespace AbstractFactory.Factory
{
    public class WindowsViewsFactory : AViewsFactory
    {
        public override AButton createButton()
        {
            return new ButtonWindows();
        }

        public override ALabel createLabel()
        {
            return new LabelWindows();
        }
    }
}
