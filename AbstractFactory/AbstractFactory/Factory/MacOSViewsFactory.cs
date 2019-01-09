using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Buttons;
using AbstractFactory.Labels;

namespace AbstractFactory.Factory
{
    public class MacOSViewsFactory : AViewsFactory
    {
        public override AButton createButton()
        {
            return new ButtonMac();
        }

        public override ALabel createLabel()
        {
            return new LabelMac();
        }
    }
}
