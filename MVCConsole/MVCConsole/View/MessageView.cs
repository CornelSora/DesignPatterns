using MVCConsole.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCConsole.View
{
    class MessageView
    {
        public event EventHandler MessageEntered;

        public void SetActionHandler()
        {
        }

        public void PrintMessage(string message)
        {
            Console.Clear();
            Console.WriteLine("The message is: {0}", message);
            DisplayButton();
        }

        public void DisplayButton()
        {
            Console.WriteLine("Enter a message for a concatenation");
            string message = Console.ReadLine();
            MessageEntered(message, EventArgs.Empty);
        }



    }
}
