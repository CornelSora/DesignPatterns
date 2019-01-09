using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Prototype
{
    public class WhiteClone : ACloneWar
    {
        public WhiteClone(string id) : base(id)
        {
        }

        public override ACloneWar Clone()
        {
            return (ACloneWar)this.MemberwiseClone();
        }
    }
}
