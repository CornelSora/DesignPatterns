using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class AUser
    {
        protected AMediator mediator;
        
        public AUser(AMediator mediator)
        {
            this.mediator = mediator;
            this.mediator.AddNewUser(this);
        }

        public abstract void receiveMessage(string message);

        public abstract void sendMessage(string message);
    }
}
