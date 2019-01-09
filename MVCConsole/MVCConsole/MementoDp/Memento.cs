using System;
using System.Collections.Generic;
using System.Text;

namespace MVCConsole.Controller.Memento
{
    class Memento
    {
        public string Message { get; set; }

        public Memento(string msg)
        {
            this.Message = msg;
        }

    }
}
