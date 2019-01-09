using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public abstract class AIterator
    {
        public abstract Client First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract Client CurrentItem();
        public abstract Client Last();
        public abstract void Prev();

    }
}
