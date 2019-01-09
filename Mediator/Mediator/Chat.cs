using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Chat : AMediator
    {
        public Chat(List<AUser> users) : base(users)
        {
        }

        public override void sendMessage(string message, AUser sender)
        {
            foreach (var user in this.Users)
            {
                if (user != sender)
                {
                    user.receiveMessage(message);
                }
            }
        }
    }
}
