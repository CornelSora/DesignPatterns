using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class ViewGroup : View
    {
        private List<AComponent> Childs = new List<AComponent>();

        public override void AddView(AComponent view)
        {
            Childs.Add(view);
            view.parent = this;
        }
    }
}
