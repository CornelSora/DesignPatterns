using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public abstract class AComponent
    {
        public string Text { get; set; }
        public string TypeOfInfo { get; set; }
        public AComponent parent { get; set; }
        public abstract void DisplayInfo();
        public abstract void AddView(AComponent view);
    }
}
