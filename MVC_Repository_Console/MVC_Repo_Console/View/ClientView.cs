using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PregatireExamen.View
{
    class ClientView
    {
        public event EventHandler CommandSelected;
        public event EventHandler IdSelected;
        public event EventHandler IdRemoved;

        public void OpenFirstMessage()
        {
            Console.WriteLine("Welcome to client view");

            Console.WriteLine("1. Display the list with clients");
            Console.WriteLine("2. Select a specific client");
            Console.WriteLine("3. Remove a specific client");
            Console.WriteLine("4. Save");
            Console.WriteLine("X to exit");

            string command = Console.ReadLine();
            CommandSelected(command, EventArgs.Empty);

        }

        public void DisplayListOfClients(string clientsString)
        {
            Console.WriteLine("The list of clients is:");
            Console.WriteLine(clientsString);
            OpenFirstMessage();
        }

        public void DisplayDeleteDoneWithSuccess()
        {
            Console.WriteLine("Delete was done with success!");
            Thread.Sleep(100);
            OpenFirstMessage();
        }

        public void DisplayClientDetails(string client)
        {
            Console.WriteLine("The details of the client are: " + client);
            OpenFirstMessage();
        }

        public void DisplayMessageForSelect()
        {
            Console.WriteLine("Enter the id of the client");
            string id = Console.ReadLine();
            IdSelected(id, EventArgs.Empty);
            OpenFirstMessage();
        }

        public void DisplayMessageForRemove()
        {
            Console.WriteLine("Enter the id of the client");
            string id = Console.ReadLine();
            IdRemoved(id, EventArgs.Empty);
            OpenFirstMessage();
        }

        public void DisplaySuccessSave()
        {
            Console.WriteLine("Save was done with success!");
            Thread.Sleep(100);
            OpenFirstMessage();
        }

        public void Close()
        {
            Console.Clear();
        }
    }
}
