using Proiect.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    public abstract class ACar
    {
        public List<User> users = new List<User>();

        private AState _state;

        public AState State
        {
            get { return _state; }
            set

            {
                _state = value;
            }
        }

        public abstract void Execute();
    }
}
