using MVCConsole.Controller.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCConsole.Model
{
    class Message
    {
        public string Msg { get; set; }

        public Message()
        {
            Msg = "Initial msg";
        }

        public Memento CreateMemento()
        {
            return new Memento(Msg);
        }

        public void RestoreMemento(Memento memento)
        {
            Msg = memento.Message;
        }

    }
}