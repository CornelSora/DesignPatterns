using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Prototype
{
    public abstract class ACloneWar
    {
        private string _id;

        public ACloneWar(string id)
        {
            _id = id;
        }

        public string Id
        {
            get { return _id; }
        }

        public abstract ACloneWar Clone();
    }
}
