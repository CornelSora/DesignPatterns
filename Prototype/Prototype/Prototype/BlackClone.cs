using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Prototype
{
    public class BlackClone : ACloneWar
    {
        public BlackClone(string id) : base(id)
        {
        }

        public override ACloneWar Clone()
        {
            return (ACloneWar)this.MemberwiseClone();
        }
    }
}
