using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class AMediator
    {
        protected List<AUser> Users;

        public AMediator(List<AUser> users)
        {
            this.Users = users;
        }

        public void AddNewUser(AUser user)
        {
            this.Users.Add(user);
        }

        public abstract void sendMessage(string message, AUser sender);

    }
}
