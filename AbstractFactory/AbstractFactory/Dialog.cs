using AbstractFactory.Factory;
using AbstractFactory.Labels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Dialog
    {
        public AButton button { get; set; }
        public ALabel label { get; set; }

        public Dialog(AViewsFactory factory)
        {
            button = factory.createButton();
            button.Paint();
            label = factory.createLabel();
            label.Paint();
        }
    }
}
