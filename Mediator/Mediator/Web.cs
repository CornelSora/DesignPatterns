using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Web : AUser
    {
        public Web(AMediator mediator) : base(mediator)
        {
        }

        public override void receiveMessage(string message)
        {
            Console.WriteLine(string.Format("Web received: {0}", message));
        }

        public override void sendMessage(string message)
        {
            this.mediator.sendMessage(message, this);
        }
    }
}
