using Proiect.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    public class User
    {
        private ACommand _command;

        public void SetCommand(ACommand command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }

        public void Notify(string message)
        {
            Console.WriteLine("I received the alert: " + message);
        }
    }
}
