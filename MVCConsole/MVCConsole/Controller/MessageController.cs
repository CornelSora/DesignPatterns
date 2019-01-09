using MVCConsole.Model;
using MVCConsole.View;
using System;
using System.Collections.Generic;
using System.Text;
using MVCConsole.Controller.Memento;


namespace MVCConsole.Controller
{
    class MessageController
    {
        public MessageView MessageView { get; set; }
        public Message MessageModel { get; set; }
        public Memento.Memento Memento { get; set; }

        public MessageController()
        {
            MessageView = new MessageView();
            MessageView.MessageEntered += new EventHandler(ButtonPressed);
            MessageModel = new Message();
        }

        public void DisplayMessageView()
        {
            MessageView.PrintMessage(MessageModel.Msg);
        }


        private void ButtonPressed(object message, EventArgs e)
        {
            string cmd = (string)message;
            if (!cmd.ToLower().Equals("undo"))
            {
                Memento = MessageModel.CreateMemento();
                MessageModel.Msg += cmd;
            }
            else
            {
                MessageModel.RestoreMemento(Memento);
            }
            DisplayMessageView();
        }


    }
}