using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Labels;

namespace AbstractFactory.Factory
{
    public abstract class AViewsFactory
    {
        public abstract AButton createButton();
        public abstract ALabel createLabel();
    }
}
